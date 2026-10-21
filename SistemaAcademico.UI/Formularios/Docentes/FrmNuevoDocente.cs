using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;
using SistemaAcademico.UI.Helpers;

namespace SistemaAcademico.UI.Formularios.Docentes
{
    public partial class FrmNuevoDocente : Form
    {
        private readonly DocenteBll _docenteBll = new();
        private readonly EspecialidadBll _especialidadBll = new();
        private readonly DocenteEntity? _docenteEdicion;

        public FrmNuevoDocente()
        {
            InitializeComponent();
            _docenteEdicion = null;
            Load += FrmNuevoDocente_Load;
        }

        public FrmNuevoDocente(DocenteEntity docente) : this()
        {
            _docenteEdicion = docente;
        }

        private async void FrmNuevoDocente_Load(object? sender, EventArgs e)
        {
            // Permitir que el usuario seleccione de la lista o escriba una nueva especialidad
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDown;
            cmbEspecialidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEspecialidad.AutoCompleteSource = AutoCompleteSource.ListItems;

            await CargarEspecialidadesAsync();

            if (_docenteEdicion != null)
            {
                CargarDatosEdicion();
            }
        }

        private async Task CargarEspecialidadesAsync()
        {
            try
            {
                var lista = await _especialidadBll.ListarAsync();
                cmbEspecialidad.DataSource = lista;
                cmbEspecialidad.DisplayMember = "Nombre";
                cmbEspecialidad.ValueMember = "Id";
                cmbEspecialidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar especialidades:\n{ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            txtTelefono.Text = _docenteEdicion.Telefono ?? string.Empty;
            txtCorreo.Text = _docenteEdicion.Correo ?? string.Empty;

            // Mostrar la especialidad asignada en el combo
            if (!string.IsNullOrWhiteSpace(_docenteEdicion.Especialidad))
            {
                cmbEspecialidad.Text = _docenteEdicion.Especialidad;
            }
            else if (_docenteEdicion.EspecialidadId > 0)
            {
                cmbEspecialidad.SelectedValue = _docenteEdicion.EspecialidadId;
            }
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

            string espTexto = cmbEspecialidad.Text.Trim();
            if (string.IsNullOrWhiteSpace(espTexto) || espTexto.Equals("Ej:Matemáticas, Ciencias, etc.", StringComparison.OrdinalIgnoreCase))
            {
                errorProvider.SetError(cmbEspecialidad, "Debe ingresar o seleccionar una especialidad.");
                valido = false;
            }

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

                // Asignar el texto de la especialidad (escrita o seleccionada)
                string espTexto = cmbEspecialidad.Text.Trim();
                docente.CambiarEspecialidad(espTexto);

                // Si seleccionó una especialidad existente, asociar su ID opcionalmente
                if (cmbEspecialidad.SelectedItem is EspecialidadEntity esp && esp.Id > 0)
                {
                    docente.AsignarEspecialidadId(esp.Id);
                }

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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
