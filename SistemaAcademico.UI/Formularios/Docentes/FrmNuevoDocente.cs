using System;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;
using SistemaAcademico.UI.Helpers;

namespace SistemaAcademico.UI.Formularios.Docentes
{
    public partial class FrmNuevoDocente : Form
    {
        private readonly DocenteBll _docenteBll = new();
        private readonly DocenteEntity? _docenteEdicion;

        public FrmNuevoDocente()
        {
            InitializeComponent();
            _docenteEdicion = null;
        }

        public FrmNuevoDocente(DocenteEntity docente) : this()
        {
            _docenteEdicion = docente;
            CargarDatosEdicion();
        }

        private void CargarDatosEdicion()
        {
            if (_docenteEdicion == null) return;

            lblTitulo.Text = "Editar Docente";
            lblSubtitulo.Text = $"Modificando la información del docente (ID: {_docenteEdicion.IdDocente})";
            Text = "Editar Maestro";

            txtNombres.Text = _docenteEdicion.Nombres;
            txtApellidos.Text = _docenteEdicion.Apellidos;
            txtCedula.Text = _docenteEdicion.Cedula;
            txtEspecialidad.Text = _docenteEdicion.Especialidad ?? string.Empty;
            txtTelefono.Text = _docenteEdicion.Telefono ?? string.Empty;
            txtCorreo.Text = _docenteEdicion.Correo ?? string.Empty;
        }

        private bool ValidarCampos()
        {
            errorProvider.Clear();
            bool valido = true;

            if (!Validacion.Requerido(txtNombres, errorProvider, "Los nombres del docente son obligatorios."))
                valido = false;

            if (!Validacion.Requerido(txtApellidos, errorProvider, "Los apellidos del docente son obligatorios."))
                valido = false;

            if (!Validacion.Requerido(txtCedula, errorProvider, "El número de cédula es obligatorio."))
                valido = false;

            return valido;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            btnGuardar.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                DocenteEntity docente = new();
                docente.CambiarNombres(txtNombres.Text);
                docente.CambiarApellidos(txtApellidos.Text);
                docente.CambiarCedula(txtCedula.Text);
                docente.CambiarEspecialidad(txtEspecialidad.Text);
                docente.CambiarTelefono(txtTelefono.Text);
                docente.CambiarCorreo(txtCorreo.Text);

                if (_docenteEdicion != null)
                {
                    docente.AsignarId(_docenteEdicion.IdDocente);
                    docente.CambiarEstado(_docenteEdicion.Estado);
                }

                await _docenteBll.GuardarAsync(docente);

                MessageBox.Show(
                    _docenteEdicion == null 
                        ? "¡Docente registrado exitosamente!" 
                        : "¡Datos del docente actualizados exitosamente!",
                    "Éxito",
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
