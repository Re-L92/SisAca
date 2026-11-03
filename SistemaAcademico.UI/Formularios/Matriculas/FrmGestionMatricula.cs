using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.UI.Formularios.Matriculas
{
    public partial class FrmGestionMatricula : Form
    {
        private readonly MatriculaBll _matriculaBll = new();
        private List<MatriculaEntity> _listaMatriculas = new();
        private MatriculaEntity? _matriculaSeleccionada;
        private EvaluacionPromocionModel? _evaluacionActual;
        private bool _cargandoCatalogos = false;

        public FrmGestionMatricula()
        {
            InitializeComponent();
        }

        #region Eventos de Inicialización y Filtros

        private async void FrmGestionMatricula_Load(object sender, EventArgs e)
        {
            await InicializarFiltrosAsync();
            await CargarMatriculasAsync();
        }

        private async Task InicializarFiltrosAsync()
        {
            _cargandoCatalogos = true;
            try
            {
                // Cargar Años Académicos
                var anios = await _matriculaBll.ListarAniosAcademicosAsync();
                var itemTodosAnios = new AnioAcademicoEntity("Todos los Años", "Todos");
                itemTodosAnios.AsignarId(0);

                var listaAnios = new List<AnioAcademicoEntity> { itemTodosAnios };
                listaAnios.AddRange(anios);

                cboFiltroAnio.DataSource = listaAnios;
                cboFiltroAnio.DisplayMember = "NombreAnio";
                cboFiltroAnio.ValueMember = "IdAnio";

                // Cargar Secciones (A, B, C)
                var secciones = await _matriculaBll.ListarSeccionesConDisponibilidadAsync(1);
                var itemTodasSecciones = new SeccionEntity("Todas", 999);
                itemTodasSecciones.AsignarId(0);

                var listaSecciones = new List<SeccionEntity> { itemTodasSecciones };
                listaSecciones.AddRange(secciones);

                cboFiltroSeccion.DataSource = listaSecciones;
                cboFiltroSeccion.DisplayMember = "NombreSeccion";
                cboFiltroSeccion.ValueMember = "IdSeccion";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogos de filtro:\n{ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargandoCatalogos = false;
            }
        }

        public async Task CargarMatriculasAsync()
        {
            if (_cargandoCatalogos) return;

            int idAnio = (cboFiltroAnio.SelectedValue is int anioVal) ? anioVal : 0;
            int idSeccion = (cboFiltroSeccion.SelectedValue is int secVal) ? secVal : 0;
            string filtro = txtBuscar.Text.Trim();

            Cursor = Cursors.WaitCursor;
            try
            {
                _listaMatriculas = await _matriculaBll.ListarMatriculasAsync(idAnio, idSeccion, filtro);

                dgvMatriculas.AutoGenerateColumns = false;
                dgvMatriculas.DataSource = null;
                dgvMatriculas.DataSource = _listaMatriculas;

                lblTotalRegistros.Text = $"Total de matrículas: {_listaMatriculas.Count}";

                if (_listaMatriculas.Count > 0)
                {
                    dgvMatriculas.ClearSelection();
                    dgvMatriculas.Rows[0].Selected = true;
                    await SeleccionarMatriculaAsync(_listaMatriculas[0]);
                }
                else
                {
                    LimpiarExpediente();
                }
            }
            catch (Exception ex)
            {
                lblEstadoOperacion.Text = $"Error al consultar matrículas: {ex.Message}";
                lblEstadoOperacion.ForeColor = Color.FromArgb(185, 28, 28);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            await CargarMatriculasAsync();
        }

        private async void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_cargandoCatalogos)
            {
                await CargarMatriculasAsync();
            }
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            if (cboFiltroAnio.Items.Count > 0) cboFiltroAnio.SelectedIndex = 0;
            if (cboFiltroSeccion.Items.Count > 0) cboFiltroSeccion.SelectedIndex = 0;
            await CargarMatriculasAsync();
        }

        #endregion

        #region Selección de Estudiante y Evaluación de Promoción

        private async void dgvMatriculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMatriculas.CurrentRow?.DataBoundItem is MatriculaEntity matricula)
            {
                await SeleccionarMatriculaAsync(matricula);
            }
        }

        private async Task SeleccionarMatriculaAsync(MatriculaEntity matricula)
        {
            _matriculaSeleccionada = matricula;

            // 1. Mostrar información en la tarjeta de expediente
            lblEstudianteNombre.Text = matricula.NombreEstudiante;
            lblCodigoEstudiante.Text = $"Carnet: {matricula.CodigoEstudiante}";
            lblGradoSeccionActual.Text = $"Grado: {matricula.NombreAnio} | Sec: '{matricula.NombreSeccion}' ({matricula.Ciclo})";

            // 2. Colorear badge de estado del estudiante
            ActualizarBadgeEstadoEstudiante(matricula.EstadoEstudiante);

            Cursor = Cursors.WaitCursor;
            try
            {
                // 3. Consultar las calificaciones del estudiante para esta matrícula
                var calificaciones = await _matriculaBll.ObtenerCalificacionesPorMatriculaAsync(matricula.IdMatricula);

                dgvCalificaciones.AutoGenerateColumns = false;
                dgvCalificaciones.DataSource = null;
                dgvCalificaciones.DataSource = calificaciones;

                // 4. Evaluar promoción según las reglas de negocio
                _evaluacionActual = _matriculaBll.EvaluarPromocionEstudiante(matricula, calificaciones);

                // 5. Presentar el dictamen y activar botones correspondientes
                ActualizarPanelDictamen(_evaluacionActual);
            }
            catch (Exception ex)
            {
                lblDictamen.Text = $"Ocurrió un error al evaluar el historial curricular: {ex.Message}";
                lblDictamen.BackColor = Color.FromArgb(254, 226, 226);
                lblDictamen.ForeColor = Color.FromArgb(153, 27, 27);
                DeshabilitarBotonesAccion();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ActualizarBadgeEstadoEstudiante(string estado)
        {
            lblBadgeEstadoEstudiante.Text = estado.ToUpper();

            switch (estado.Trim().ToLower())
            {
                case "activo":
                    lblBadgeEstadoEstudiante.BackColor = Color.FromArgb(220, 252, 231);
                    lblBadgeEstadoEstudiante.ForeColor = Color.FromArgb(22, 101, 52);
                    break;
                case "inactivo":
                    lblBadgeEstadoEstudiante.BackColor = Color.FromArgb(254, 226, 226);
                    lblBadgeEstadoEstudiante.ForeColor = Color.FromArgb(153, 27, 27);
                    break;
                case "promovido":
                    lblBadgeEstadoEstudiante.BackColor = Color.FromArgb(219, 234, 254);
                    lblBadgeEstadoEstudiante.ForeColor = Color.FromArgb(30, 64, 175);
                    break;
                case "estudiante graduado":
                    lblBadgeEstadoEstudiante.BackColor = Color.FromArgb(254, 243, 199);
                    lblBadgeEstadoEstudiante.ForeColor = Color.FromArgb(146, 64, 14);
                    break;
                case "repite año":
                case "repite ano":
                    lblBadgeEstadoEstudiante.BackColor = Color.FromArgb(255, 237, 213);
                    lblBadgeEstadoEstudiante.ForeColor = Color.FromArgb(194, 65, 12);
                    break;
                default:
                    lblBadgeEstadoEstudiante.BackColor = Color.FromArgb(241, 245, 249);
                    lblBadgeEstadoEstudiante.ForeColor = Color.FromArgb(71, 85, 105);
                    break;
            }
        }

        private void ActualizarPanelDictamen(EvaluacionPromocionModel evaluacion)
        {
            lblDictamen.Text = evaluacion.Dictamen;

            // Ajustar estilos y habilitar botones según el resultado
            if (evaluacion.EsGraduado)
            {
                lblDictamen.BackColor = Color.FromArgb(254, 243, 199);
                lblDictamen.ForeColor = Color.FromArgb(146, 64, 14);

                btnMatricularSiguiente.Text = "Graduación (5to Año)";
                btnMatricularSiguiente.Enabled = true;
                btnMatricularSiguiente.BackColor = Color.FromArgb(217, 119, 6);

                btnRepetirAnio.Enabled = false;
                btnRepetirAnio.BackColor = Color.FromArgb(203, 213, 225);

                lblEstadoOperacion.Text = "Estudiante completó satisfactoriamente la secundaria. Puede asentar su graduación.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(146, 64, 14);
            }
            else if (evaluacion.PuedeAvanzar)
            {
                lblDictamen.BackColor = Color.FromArgb(220, 252, 231);
                lblDictamen.ForeColor = Color.FromArgb(22, 101, 52);

                btnMatricularSiguiente.Text = $"Matricular en {evaluacion.SiguienteAnioNombre}";
                btnMatricularSiguiente.Enabled = true;
                btnMatricularSiguiente.BackColor = Color.FromArgb(37, 99, 235);

                btnRepetirAnio.Enabled = false;
                btnRepetirAnio.BackColor = Color.FromArgb(203, 213, 225);

                lblEstadoOperacion.Text = $"Estudiante promovido. Presione 'Matricular en {evaluacion.SiguienteAnioNombre}' para inscribirlo.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(22, 101, 52);
            }
            else if (evaluacion.DebeRepetir)
            {
                lblDictamen.BackColor = Color.FromArgb(254, 226, 226);
                lblDictamen.ForeColor = Color.FromArgb(153, 27, 27);

                btnMatricularSiguiente.Text = "No Promovido";
                btnMatricularSiguiente.Enabled = false;
                btnMatricularSiguiente.BackColor = Color.FromArgb(203, 213, 225);

                btnRepetirAnio.Text = $"Matricular en Mismo Año ({evaluacion.NombreAnioActual})";
                btnRepetirAnio.Enabled = true;
                btnRepetirAnio.BackColor = Color.FromArgb(217, 119, 6);

                lblEstadoOperacion.Text = "El estudiante no aprobó el año escolar. Se habilita la opción de matricular en el mismo año.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(185, 28, 28);
            }
            else if (evaluacion.EnReparacion)
            {
                lblDictamen.BackColor = Color.FromArgb(255, 237, 213);
                lblDictamen.ForeColor = Color.FromArgb(194, 65, 12);

                btnMatricularSiguiente.Text = "Pendiente de Reparación";
                btnMatricularSiguiente.Enabled = false;
                btnMatricularSiguiente.BackColor = Color.FromArgb(203, 213, 225);

                btnRepetirAnio.Enabled = false;
                btnRepetirAnio.BackColor = Color.FromArgb(203, 213, 225);

                lblEstadoOperacion.Text = "El estudiante debe rendir sus exámenes de reparación antes de determinar su matrícula.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(194, 65, 12);
            }
            else
            {
                lblDictamen.BackColor = Color.FromArgb(241, 245, 249);
                lblDictamen.ForeColor = Color.FromArgb(71, 85, 105);

                DeshabilitarBotonesAccion();
                lblEstadoOperacion.Text = "Calificaciones incompletas. Ingrese todas las notas en el módulo de Calificaciones.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(71, 85, 105);
            }
        }

        private void DeshabilitarBotonesAccion()
        {
            btnMatricularSiguiente.Text = "Matricular al Siguiente Año";
            btnMatricularSiguiente.Enabled = false;
            btnMatricularSiguiente.BackColor = Color.FromArgb(203, 213, 225);

            btnRepetirAnio.Text = "Matricular en Mismo Año";
            btnRepetirAnio.Enabled = false;
            btnRepetirAnio.BackColor = Color.FromArgb(203, 213, 225);
        }

        private void LimpiarExpediente()
        {
            _matriculaSeleccionada = null;
            _evaluacionActual = null;

            lblEstudianteNombre.Text = "Ningún estudiante coincide con la búsqueda";
            lblCodigoEstudiante.Text = "Carnet: ---";
            lblGradoSeccionActual.Text = "Grado Actual: -- | Sec: --";
            lblBadgeEstadoEstudiante.Text = "---";
            lblBadgeEstadoEstudiante.BackColor = Color.FromArgb(241, 245, 249);
            lblBadgeEstadoEstudiante.ForeColor = Color.FromArgb(100, 116, 139);

            lblDictamen.Text = "No se encontraron estudiantes para los filtros ingresados.";
            lblDictamen.BackColor = Color.FromArgb(241, 245, 249);
            lblDictamen.ForeColor = Color.FromArgb(100, 116, 139);

            dgvCalificaciones.DataSource = null;
            DeshabilitarBotonesAccion();
        }

        #endregion

        #region Acciones de Matrícula (Siguiente Año / Mismo Año)

        private async void btnMatricularSiguiente_Click(object sender, EventArgs e)
        {
            if (_matriculaSeleccionada == null || _evaluacionActual == null) return;

            // Caso A: Estudiante Graduado de 5to Año
            if (_evaluacionActual.EsGraduado)
            {
                var confirmacion = MessageBox.Show(
                    $"¡Felicidades, estudiante graduado!\n\n" +
                    $"El estudiante '{_matriculaSeleccionada.NombreEstudiante}' ha culminado satisfactoriamente el 5to año de bachillerato.\n\n" +
                    $"¿Desea asentar formalmente su graduación en el sistema académico?",
                    "Estudiante Graduado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        var (nuevoId, mensaje) = await _matriculaBll.MatricularSiguienteAnioAsync(_matriculaSeleccionada.IdMatricula, _matriculaSeleccionada.IdSeccion);

                        MessageBox.Show(mensaje, "Graduación Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarMatriculasAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar la graduación:\n{ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
                return;
            }

            // Caso B: Promover al siguiente año consecutivo
            if (!_evaluacionActual.PuedeAvanzar)
            {
                MessageBox.Show("El estudiante no cumple con los requisitos académicos para avanzar al siguiente año.", "No Apto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                // Consultar secciones disponibles para el año siguiente evaluando cupos (<40)
                var secciones = await _matriculaBll.ListarSeccionesConDisponibilidadAsync(_evaluacionActual.SiguienteIdAnio);
                Cursor = Cursors.Default;

                if (secciones.Count == 0)
                {
                    MessageBox.Show($"No hay secciones registradas para el año {_evaluacionActual.SiguienteAnioNombre}.", "Sin Secciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var frmConfirmar = new FrmConfirmarMatricula(
                    $"{_matriculaSeleccionada.CodigoEstudiante} - {_matriculaSeleccionada.NombreEstudiante}",
                    _evaluacionActual.SiguienteAnioNombre,
                    secciones
                );

                if (frmConfirmar.ShowDialog(this) == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    var (nuevoId, mensaje) = await _matriculaBll.MatricularSiguienteAnioAsync(_matriculaSeleccionada.IdMatricula, frmConfirmar.IdSeccionSeleccionada);

                    MessageBox.Show(
                        $"{mensaje}\n\n" +
                        $"• Estudiante: {_matriculaSeleccionada.NombreEstudiante}\n" +
                        $"• Nuevo Año: {_evaluacionActual.SiguienteAnioNombre}\n" +
                        $"• N° de Matrícula: {nuevoId}\n" +
                        $"• Las nuevas materias del grado fueron incorporadas automáticamente a su expediente.",
                        "Matrícula Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await CargarMatriculasAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al matricular estudiante al siguiente año:\n{ex.Message}", "Error de Matrícula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnRepetirAnio_Click(object sender, EventArgs e)
        {
            if (_matriculaSeleccionada == null || _evaluacionActual == null) return;

            if (!_evaluacionActual.DebeRepetir)
            {
                MessageBox.Show("Esta opción solo está habilitada para alumnos que deban repetir el año lectivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                // Consultar secciones disponibles para el mismo año evaluando cupos (<40)
                var secciones = await _matriculaBll.ListarSeccionesConDisponibilidadAsync(_matriculaSeleccionada.IdAnio);
                Cursor = Cursors.Default;

                if (secciones.Count == 0)
                {
                    MessageBox.Show($"No hay secciones disponibles para {_matriculaSeleccionada.NombreAnio}.", "Sin Secciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var frmConfirmar = new FrmConfirmarMatricula(
                    $"{_matriculaSeleccionada.CodigoEstudiante} - {_matriculaSeleccionada.NombreEstudiante} (Repite Año)",
                    $"{_matriculaSeleccionada.NombreAnio} (Mismo Año)",
                    secciones
                );

                if (frmConfirmar.ShowDialog(this) == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    var (nuevoId, mensaje) = await _matriculaBll.MatricularMismoAnioAsync(_matriculaSeleccionada.IdMatricula, frmConfirmar.IdSeccionSeleccionada);

                    MessageBox.Show(
                        $"{mensaje}\n\n" +
                        $"• Estudiante: {_matriculaSeleccionada.NombreEstudiante}\n" +
                        $"• Año Escolar: {_matriculaSeleccionada.NombreAnio} (Repetición)\n" +
                        $"• N° de Matrícula: {nuevoId}\n" +
                        $"• Se inicializó un nuevo ciclo de asignaturas en limpio para el ciclo lectivo.",
                        "Matrícula de Repetición Registrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await CargarMatriculasAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la matrícula de repetición:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Formato Visual de Grids

        private void dgvMatriculas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _listaMatriculas.Count) return;

            var matricula = _listaMatriculas[e.RowIndex];
            var col = dgvMatriculas.Columns[e.ColumnIndex];

            if (col == colEstadoAlumno)
            {
                e.CellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
                if (matricula.EstadoEstudiante.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                }
            }
            else if (col == colEstadoMatricula)
            {
                e.CellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
                switch (matricula.EstadoMatricula.Trim().ToLower())
                {
                    case "activo":
                        e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                        break;
                    case "promovido":
                        e.CellStyle.ForeColor = Color.FromArgb(30, 64, 175);
                        break;
                    case "estudiante graduado":
                        e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
                        break;
                    case "repite año":
                    case "repite ano":
                        e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                        break;
                }
            }
        }

        private void dgvCalificaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCalificaciones.DataSource is not List<CalificacionEntity> lista || e.RowIndex < 0 || e.RowIndex >= lista.Count)
                return;

            var cal = lista[e.RowIndex];
            var col = dgvCalificaciones.Columns[e.ColumnIndex];

            // Formato decimal con 2 dígitos
            if (col == colSemestre1 || col == colSemestre2 || col == colNotaFinal || col == colReparacion)
            {
                if (e.Value is decimal decVal)
                {
                    e.Value = decVal.ToString("N2", CultureInfo.CurrentCulture);
                    e.FormattingApplied = true;
                }
            }

            // Destacar Nota Final
            if (col == colNotaFinal && cal.NotaFinal.HasValue)
            {
                e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                if (cal.NotaFinal.Value >= 60)
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                }
            }

            // Destacar Estado de Asignatura
            if (col == colEstadoAsig)
            {
                e.CellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
                switch (cal.EstadoAsignatura.Trim().ToLower())
                {
                    case "aprobada":
                        e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                        e.CellStyle.BackColor = Color.FromArgb(240, 253, 244);
                        break;
                    case "reparación":
                    case "reparacion":
                        e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
                        e.CellStyle.BackColor = Color.FromArgb(254, 252, 232);
                        break;
                    case "reprobada":
                        e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                        e.CellStyle.BackColor = Color.FromArgb(254, 242, 242);
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.FromArgb(30, 64, 175);
                        e.CellStyle.BackColor = Color.FromArgb(239, 246, 255);
                        break;
                }
            }

            // Observaciones
            if (col == colObservaciones)
            {
                e.CellStyle.ForeColor = Color.FromArgb(71, 85, 105);
            }
        }

        #endregion
    }
}
