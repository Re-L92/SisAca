using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.UI.Formularios.Calificaciones
{
    public partial class FrmGestionCalificaciones : Form
    {
        private readonly CalificacionBll _calificacionBll = new();
        private List<MatriculaEntity> _todasMatriculas = new();
        private List<CalificacionEntity> _calificacionesActuales = new();
        private MatriculaEntity? _matriculaSeleccionada;
        private bool _cargandoFiltros = false;
        private bool _hayCambiosSinGuardar = false;

        public FrmGestionCalificaciones()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario y Carga

        private async void FrmGestionCalificaciones_Load(object? sender, EventArgs e)
        {
            await InicializarFiltrosAsync();
            await CargarMatriculasAsync();
        }

        private async Task InicializarFiltrosAsync()
        {
            _cargandoFiltros = true;
            try
            {
                // Cargar Años Académicos
                var anios = await _calificacionBll.ListarAniosAcademicosAsync();
                var itemTodosAnios = new AnioAcademicoEntity("Todos los Años", "Todos");
                itemTodosAnios.AsignarId(0);

                var listaAnios = new List<AnioAcademicoEntity> { itemTodosAnios };
                listaAnios.AddRange(anios);
                cboAnio.DataSource = listaAnios;
                cboAnio.DisplayMember = "NombreAnio";
                cboAnio.ValueMember = "IdAnio";

                // Cargar Secciones
                var secciones = await _calificacionBll.ListarSeccionesAsync();
                var itemTodasSecciones = new SeccionEntity("Todas", 999);
                itemTodasSecciones.AsignarId(0);

                var listaSecciones = new List<SeccionEntity> { itemTodasSecciones };
                listaSecciones.AddRange(secciones);
                cboSeccion.DataSource = listaSecciones;
                cboSeccion.DisplayMember = "NombreSeccion";
                cboSeccion.ValueMember = "IdSeccion";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los catálogos de filtro:\n{ex.Message}", "Error de Catálogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargandoFiltros = false;
            }
        }

        public async Task CargarMatriculasAsync()
        {
            if (_cargandoFiltros) return;

            int idAnio = (cboAnio.SelectedValue is int anioVal) ? anioVal : 0;
            int idSeccion = (cboSeccion.SelectedValue is int secVal) ? secVal : 0;
            string filtro = txtBuscar.Text.Trim();

            Cursor = Cursors.WaitCursor;
            try
            {
                _todasMatriculas = await _calificacionBll.ListarMatriculasAsync(idAnio, idSeccion, filtro);

                cboEstudiante.SelectedIndexChanged -= cboEstudiante_SelectedIndexChanged;
                cboEstudiante.DataSource = null;
                cboEstudiante.DisplayMember = "DescripcionCompleta";
                cboEstudiante.ValueMember = "IdMatricula";
                cboEstudiante.DataSource = _todasMatriculas;
                cboEstudiante.SelectedIndexChanged += cboEstudiante_SelectedIndexChanged;

                if (_todasMatriculas.Count > 0)
                {
                    cboEstudiante.SelectedIndex = 0;
                    await CargarCalificacionesEstudianteAsync(_todasMatriculas[0]);
                }
                else
                {
                    LimpiarDatosEstudiante();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar estudiantes matriculados:\n{ex.Message}", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void FiltroCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (!_cargandoFiltros)
            {
                await CargarMatriculasAsync();
            }
        }

        private async void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            await CargarMatriculasAsync();
        }

        private async void btnRefrescar_Click(object? sender, EventArgs e)
        {
            txtBuscar.Clear();
            if (cboAnio.Items.Count > 0) cboAnio.SelectedIndex = 0;
            if (cboSeccion.Items.Count > 0) cboSeccion.SelectedIndex = 0;
            await CargarMatriculasAsync();
        }

        #endregion

        #region Selección de Estudiante y Carga de Calificaciones

        private async void cboEstudiante_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_hayCambiosSinGuardar)
            {
                var confirmacion = MessageBox.Show(
                    "Tiene calificaciones modificadas sin guardar.\n¿Desea descartar los cambios y cambiar de estudiante?",
                    "Cambios sin Guardar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes)
                {
                    // Volver a seleccionar el estudiante actual en el combo sin disparar eventos
                    return;
                }
            }

            if (cboEstudiante.SelectedItem is MatriculaEntity matricula)
            {
                await CargarCalificacionesEstudianteAsync(matricula);
            }
            else
            {
                LimpiarDatosEstudiante();
            }
        }

        private async Task CargarCalificacionesEstudianteAsync(MatriculaEntity matricula)
        {
            _matriculaSeleccionada = matricula;

            // 1. Mostrar información en la tarjeta de expediente
            lblDetalleCarnet.Text = $"EXPEDIENTE ACADÉMICO: {matricula.CodigoEstudiante}";
            lblDetalleNombreEstudiante.Text = matricula.NombreEstudiante;
            lblDetalleGradoSeccion.Text = $"Grado / Sección: {matricula.NombreAnio} '{matricula.NombreSeccion}' ({matricula.Ciclo})";
            lblDetalleDocente.Text = $"Docente Guía: {matricula.DocenteGuia} | Aula: {matricula.Aula}";

            Cursor = Cursors.WaitCursor;
            try
            {
                // 2. Cargar asignaturas y calificaciones de la matrícula
                _calificacionesActuales = await _calificacionBll.ObtenerCalificacionesPorMatriculaAsync(matricula.IdMatricula, matricula.IdAnio);

                dgvCalificaciones.AutoGenerateColumns = false;
                dgvCalificaciones.DataSource = null;
                dgvCalificaciones.DataSource = _calificacionesActuales;

                // 3. Recalcular y presentar métricas
                ActualizarResumen();

                _hayCambiosSinGuardar = false;
                lblEstadoOperacion.Text = $"Calificaciones cargadas correctamente ({_calificacionesActuales.Count} asignaturas).";
                lblEstadoOperacion.ForeColor = Color.FromArgb(51, 65, 85);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las calificaciones del estudiante:\n{ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LimpiarDatosEstudiante()
        {
            _matriculaSeleccionada = null;
            _calificacionesActuales.Clear();
            dgvCalificaciones.DataSource = null;

            lblDetalleCarnet.Text = "EXPEDIENTE ACADÉMICO";
            lblDetalleNombreEstudiante.Text = "No se encontraron estudiantes para los filtros seleccionados";
            lblDetalleGradoSeccion.Text = "Grado / Sección: --";
            lblDetalleDocente.Text = "Docente Guía: -- | Aula: --";

            ActualizarResumen();
            lblEstadoOperacion.Text = "Sin estudiantes que mostrar";
            lblEstadoOperacion.ForeColor = Color.FromArgb(100, 116, 139);
        }

        #endregion

        #region Cálculo y Actualización de Métricas Curriculares

        private void ActualizarResumen()
        {
            var resumen = _calificacionBll.CalcularResumen(_calificacionesActuales);

            lblPromedioGeneral.Text = resumen.TotalAsignaturas > 0 && resumen.PromedioGeneral > 0
                ? resumen.PromedioGeneral.ToString("N2", CultureInfo.CurrentCulture)
                : "--.--";

            lblKpiAprobadas.Text = $"Aprobadas: {resumen.AsignaturasAprobadas}";
            lblKpiReparacion.Text = $"Reparación: {resumen.AsignaturasEnReparacion}";
            lblKpiReprobadas.Text = $"Reprobadas: {resumen.AsignaturasReprobadas}";
            lblKpiEnProceso.Text = $"En Proceso: {resumen.AsignaturasEnProceso}";

            lblBadgeRendimiento.Text = resumen.EstadoRendimiento.ToUpper();

            // Colorear badge de rendimiento
            switch (resumen.EstadoRendimiento)
            {
                case "Excelente":
                    lblBadgeRendimiento.BackColor = Color.FromArgb(220, 252, 231);
                    lblBadgeRendimiento.ForeColor = Color.FromArgb(22, 101, 52);
                    break;
                case "Muy Bueno":
                case "Aprobado":
                    lblBadgeRendimiento.BackColor = Color.FromArgb(219, 234, 254);
                    lblBadgeRendimiento.ForeColor = Color.FromArgb(30, 64, 175);
                    break;
                case "Pendiente de Reparación":
                    lblBadgeRendimiento.BackColor = Color.FromArgb(254, 243, 199);
                    lblBadgeRendimiento.ForeColor = Color.FromArgb(146, 64, 14);
                    break;
                case "Riesgo de Repetición":
                case "Reprobado":
                    lblBadgeRendimiento.BackColor = Color.FromArgb(254, 226, 226);
                    lblBadgeRendimiento.ForeColor = Color.FromArgb(153, 27, 27);
                    break;
                default:
                    lblBadgeRendimiento.BackColor = Color.FromArgb(241, 245, 249);
                    lblBadgeRendimiento.ForeColor = Color.FromArgb(71, 85, 105);
                    break;
            }
        }

        #endregion

        #region Manejo de la Cuadrícula (Edición Interactiva y Formato)

        private void dgvCalificaciones_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _calificacionesActuales.Count) return;

            var cal = _calificacionesActuales[e.RowIndex];
            var col = dgvCalificaciones.Columns[e.ColumnIndex];
            var cell = dgvCalificaciones.Rows[e.RowIndex].Cells[e.ColumnIndex];

            try
            {
                decimal? nuevoValor = ParsearValorCelda(cell.Value);

                if (col == colNota1)
                {
                    cal.CambiarNotaISemestre(nuevoValor);
                }
                else if (col == colNota2)
                {
                    cal.CambiarNotaIISemestre(nuevoValor);
                }
                else if (col == colNotaReparacion)
                {
                    cal.CambiarNotaReparacion(nuevoValor);
                }

                // Refrescar celdas calculadas
                dgvCalificaciones.InvalidateRow(e.RowIndex);

                // Actualizar métricas del alumno
                ActualizarResumen();

                _hayCambiosSinGuardar = true;
                lblEstadoOperacion.Text = "Hay cambios pendientes de guardar. Presione 'Guardar Calificaciones' para persistir.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(217, 119, 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvCalificaciones.CancelEdit();
            }
        }

        private decimal? ParsearValorCelda(object? rawValue)
        {
            if (rawValue == null || rawValue == DBNull.Value) return null;
            string str = rawValue.ToString()?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(str)) return null;

            str = str.Replace(',', '.');

            if (!decimal.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal val))
            {
                throw new Exception("El valor ingresado no corresponde a un número decimal válido.");
            }

            if (val < 0 || val > 100)
            {
                throw new Exception("La calificación debe estar comprendida estrictamente entre 0 y 100 puntos.");
            }

            return Math.Round(val, 2);
        }

        private void dgvCalificaciones_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Por favor ingrese un valor numérico válido entre 0 y 100.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvCalificaciones_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _calificacionesActuales.Count) return;

            var cal = _calificacionesActuales[e.RowIndex];
            var col = dgvCalificaciones.Columns[e.ColumnIndex];

            // Formato numérico de dos decimales
            if (col == colNota1 || col == colNota2 || col == colNotaFinal || col == colNotaReparacion)
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
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52); // Verde
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28); // Rojo
                }
            }

            // Destacar Estado con color tipo etiqueta
            if (col == colEstado)
            {
                e.CellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
                switch (cal.EstadoAsignatura)
                {
                    case "Aprobada":
                        e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                        e.CellStyle.BackColor = Color.FromArgb(240, 253, 244);
                        break;
                    case "Reparación":
                        e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
                        e.CellStyle.BackColor = Color.FromArgb(254, 252, 232);
                        break;
                    case "Reprobada":
                        e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                        e.CellStyle.BackColor = Color.FromArgb(254, 242, 242);
                        break;
                    default:
                        e.CellStyle.ForeColor = Color.FromArgb(30, 64, 175);
                        e.CellStyle.BackColor = Color.FromArgb(239, 246, 255);
                        break;
                }
            }
        }

        private void dgvCalificaciones_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AbrirCapturaModal();
            }
        }

        #endregion

        #region Acciones y Botones

        private void btnCapturaIndividual_Click(object? sender, EventArgs e)
        {
            AbrirCapturaModal();
        }

        private void AbrirCapturaModal()
        {
            if (dgvCalificaciones.CurrentRow?.DataBoundItem is not CalificacionEntity cal)
            {
                MessageBox.Show("Seleccione una asignatura para capturar la calificación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var frm = new FrmCapturaNota(cal, _matriculaSeleccionada?.NombreEstudiante ?? "");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                dgvCalificaciones.Refresh();
                ActualizarResumen();
                _hayCambiosSinGuardar = false;
                lblEstadoOperacion.Text = $"Calificación de '{cal.NombreAsignatura}' guardada correctamente.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(16, 185, 129);
            }
        }

        private void btnRecalcular_Click(object? sender, EventArgs e)
        {
            if (_calificacionesActuales.Count == 0) return;

            foreach (var cal in _calificacionesActuales)
            {
                cal.CalcularResultado();
            }

            dgvCalificaciones.Refresh();
            ActualizarResumen();

            MessageBox.Show("Se han recalculado automáticamente las notas finales y estados curriculares.", "Cálculo Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnGuardarLote_Click(object? sender, EventArgs e)
        {
            if (_calificacionesActuales.Count == 0)
            {
                MessageBox.Show("No hay calificaciones cargadas para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnGuardarLote.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                await _calificacionBll.GuardarCalificacionesLoteAsync(_calificacionesActuales);

                _hayCambiosSinGuardar = false;
                lblEstadoOperacion.Text = "Todas las calificaciones han sido guardadas y sincronizadas exitosamente.";
                lblEstadoOperacion.ForeColor = Color.FromArgb(16, 185, 129);

                MessageBox.Show("Las calificaciones fueron guardadas exitosamente en la base de datos.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el lote de calificaciones:\n{ex.Message}", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardarLote.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        #endregion
    }
}
