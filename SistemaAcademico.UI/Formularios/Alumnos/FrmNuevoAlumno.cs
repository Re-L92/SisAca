using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;
using SistemaAcademico.UI.Helpers;

namespace SistemaAcademico.UI.Formularios.Alumnos
{
    public partial class FrmNuevoAlumno : Form
    {
        private readonly AlumnoBll _alumnoBll = new();
        private int _proximoNumeroMatricula = 1;
        private bool _cargandoCatalogos = true;

        public FrmNuevoAlumno()
        {
            InitializeComponent();
        }

        private async void FrmNuevoAlumno_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                _cargandoCatalogos = true;

                // 1. Estado inicial del alumno (Activo por defecto)
                cboEstadoEstudiante.SelectedIndex = 0;

                // 2. Obtener el próximo número de matrícula para el código único
                _proximoNumeroMatricula = await _alumnoBll.ObtenerSiguienteNumeroMatriculaAsync();

                // 3. Cargar Años Académicos desde la base de datos
                var listaAnios = await _alumnoBll.ListarAniosAcademicosAsync();

                cboAnioAcademico.DisplayMember = "NombreAnio";
                cboAnioAcademico.ValueMember = "IdAnio";
                cboAnioAcademico.DataSource = listaAnios;

                _cargandoCatalogos = false;

                // 4. Si hay años cargados, cargar asignaturas y secciones para el primer año
                if (listaAnios.Count > 0)
                {
                    cboAnioAcademico.SelectedIndex = 0;
                    await CargarDetallesPorAnioAsync(listaAnios[0].IdAnio);
                }

                ActualizarCodigoPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogos desde la base de datos:\n{ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private int ObtenerIdAnioSeleccionado()
        {
            if (cboAnioAcademico.SelectedItem is AnioAcademicoEntity anio)
                return anio.IdAnio;

            if (cboAnioAcademico.SelectedValue != null && int.TryParse(cboAnioAcademico.SelectedValue.ToString(), out int id))
                return id;

            return 0;
        }

        private int ObtenerIdSeccionSeleccionada()
        {
            if (cboSeccion.SelectedItem is SeccionEntity seccion)
                return seccion.IdSeccion;

            if (cboSeccion.SelectedValue != null && int.TryParse(cboSeccion.SelectedValue.ToString(), out int id))
                return id;

            return 0;
        }

        private async void cboAnioAcademico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoCatalogos) return;

            int idAnio = ObtenerIdAnioSeleccionado();
            if (idAnio > 0)
            {
                await CargarDetallesPorAnioAsync(idAnio);
            }
        }

        private async Task CargarDetallesPorAnioAsync(int idAnio)
        {
            try
            {
                // 1. Cargar clases / asignaturas del año lectivo correspondiente
                var asignaturas = await _alumnoBll.ListarAsignaturasPorAnioAsync(idAnio);
                dgvAsignaturas.AutoGenerateColumns = false;
                dgvAsignaturas.DataSource = null;
                dgvAsignaturas.DataSource = asignaturas;
                lblTotalAsignaturas.Text = $"Total de asignaturas: {asignaturas.Count}";

                // 2. Cargar Secciones (A, B, C) desde la base de datos evaluando cupos
                // La consulta SQL ordena para que la sección más vacía aparezca de primera
                var secciones = await _alumnoBll.ListarSeccionesConDisponibilidadAsync(idAnio);

                cboSeccion.DataSource = null;
                cboSeccion.DisplayMember = "DescripcionCompleta";
                cboSeccion.ValueMember = "IdSeccion";
                cboSeccion.DataSource = secciones;

                if (secciones.Count > 0)
                {
                    // Seleccionar automáticamente la primera opción (la sección más vacía)
                    cboSeccion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar asignaturas y secciones del año seleccionado:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombresApellidos_TextChanged(object sender, EventArgs e)
        {
            ActualizarCodigoPreview();
        }

        private void ActualizarCodigoPreview()
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) && string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                txtCodigoEstudiante.Text = $"[Iniciales]{_proximoNumeroMatricula}";
                return;
            }

            // Generar código con las primeras letras de los 2 nombres y apellidos + número de matrícula
            txtCodigoEstudiante.Text = _alumnoBll.GenerarCodigoEstudiante(txtNombres.Text, txtApellidos.Text, _proximoNumeroMatricula);
        }

        private bool ValidarCampos()
        {
            errorProvider.Clear();
            bool valido = true;

            if (!Validacion.Requerido(txtNombres, errorProvider, "Los nombres del alumno son obligatorios."))
                valido = false;

            if (!Validacion.Requerido(txtApellidos, errorProvider, "Los apellidos del alumno son obligatorios."))
                valido = false;

            int idAnio = ObtenerIdAnioSeleccionado();
            if (idAnio <= 0)
            {
                errorProvider.SetError(cboAnioAcademico, "Debe seleccionar el año académico a matricular.");
                valido = false;
            }

            int idSeccion = ObtenerIdSeccionSeleccionada();
            if (idSeccion <= 0)
            {
                errorProvider.SetError(cboSeccion, "Debe seleccionar la sección.");
                valido = false;
            }
            else if (cboSeccion.SelectedItem is SeccionEntity seccion && seccion.EstaLlena)
            {
                errorProvider.SetError(cboSeccion, "La sección seleccionada ha alcanzado su capacidad máxima (40 alumnos). Por favor elija una sección disponible.");
                valido = false;
            }

            if (!Validacion.Requerido(txtTutorNombres, errorProvider, "Los nombres del tutor son obligatorios."))
                valido = false;

            if (!Validacion.Requerido(txtTutorApellidos, errorProvider, "Los apellidos del tutor son obligatorios."))
                valido = false;

            if (!Validacion.Requerido(txtTutorCedula, errorProvider, "El número de cédula del tutor es obligatorio."))
                valido = false;

            if (!Validacion.Requerido(txtTutorTelefono, errorProvider, "El teléfono de contacto del tutor es obligatorio."))
                valido = false;

            return valido;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                var model = new AlumnoRegistroModel
                {
                    EstudianteNombres = txtNombres.Text.Trim(),
                    EstudianteApellidos = txtApellidos.Text.Trim(),
                    EstudianteFechaNac = dtpFechaNacimiento.Value.Date,
                    Estado = cboEstadoEstudiante.SelectedItem?.ToString() ?? "Activo",
                    IdAnio = ObtenerIdAnioSeleccionado(),
                    IdSeccion = ObtenerIdSeccionSeleccionada(),
                    TutorNombres = txtTutorNombres.Text.Trim(),
                    TutorApellidos = txtTutorApellidos.Text.Trim(),
                    TutorCedula = txtTutorCedula.Text.Trim(),
                    TutorTelefono = txtTutorTelefono.Text.Trim(),
                    TutorDireccion = txtTutorDireccion.Text.Trim()
                };

                // Asignar el código generado
                model.EstudianteCodigo = _alumnoBll.GenerarCodigoEstudiante(
                    model.EstudianteNombres,
                    model.EstudianteApellidos,
                    _proximoNumeroMatricula
                );

                var (idEstudiante, idMatricula, codigoFinal) = await _alumnoBll.RegistrarEstudianteYMatriculaAsync(model);

                MessageBox.Show(
                    $"¡Matrícula y Estudiante registrados exitosamente!\n\n" +
                    $"• Código de Estudiante: {codigoFinal}\n" +
                    $"• Estudiante: {model.EstudianteNombres} {model.EstudianteApellidos}\n" +
                    $"• Estado: {model.Estado}\n" +
                    $"• N° de Matrícula: {idMatricula}\n" +
                    $"• Asignaturas vinculadas al registro académico.",
                    "Registro Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
