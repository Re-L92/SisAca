using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.UI.Formularios.Alumnos
{
    public partial class FrmBuscarAlumno : Form
    {
        private readonly AlumnoBll _alumnoBll = new();
        private List<AlumnoEntity> _listaAlumnos = new();

        public FrmBuscarAlumno()
        {
            InitializeComponent();
        }

        private async void FrmBuscarAlumno_Load(object sender, EventArgs e)
        {
            cboFiltroEstado.SelectedIndex = 0; // "Todos"
            await CargarAlumnosAsync();
        }

        public async Task CargarAlumnosAsync()
        {
            string filtro = txtBuscar.Text.Trim();
            string estado = "";

            if (cboFiltroEstado.SelectedIndex == 1) estado = "Activo";
            else if (cboFiltroEstado.SelectedIndex == 2) estado = "Inactivo";

            Cursor = Cursors.WaitCursor;
            try
            {
                _listaAlumnos = await _alumnoBll.ListarAsync(filtro, estado);
                dgvAlumnos.AutoGenerateColumns = false;
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = _listaAlumnos;

                lblTotal.Text = $"Total de registros: {_listaAlumnos.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los estudiantes:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Búsqueda interactiva en tiempo real mientras el usuario escribe
            await CargarAlumnosAsync();
        }

        private async void cboFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarAlumnosAsync();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cboFiltroEstado.SelectedIndex = 0;
            await CargarAlumnosAsync();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            using var frm = new FrmNuevoAlumno();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                await CargarAlumnosAsync();
            }
        }

        private async void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow?.DataBoundItem is not AlumnoEntity alumno)
            {
                MessageBox.Show("Por favor seleccione un estudiante de la lista para cambiar su estado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool estaActivo = alumno.Estado.Equals("Activo", StringComparison.OrdinalIgnoreCase);
            string accion = estaActivo ? "dar de baja (borrado lógico)" : "reactivar";
            string nuevoEstadoEsperado = estaActivo ? "Inactivo" : "Activo";

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea {accion} al estudiante '{alumno.NombreCompleto}'?\n\nSu estado pasará a ser: {nuevoEstadoEsperado}.",
                "Confirmación de Borrado Lógico",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            Cursor = Cursors.WaitCursor;
            try
            {
                string estadoFinal = await _alumnoBll.CambiarEstadoEstudianteAsync(alumno.IdEstudiante, nuevoEstadoEsperado);
                MessageBox.Show($"El estado del alumno fue actualizado correctamente a '{estadoFinal}'.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarAlumnosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado del alumno:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAlumnos.Columns[e.ColumnIndex].Name == "colEstado" && e.Value != null)
            {
                string estado = e.Value.ToString() ?? "";
                if (estado.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52); // Verde oscuro
                    e.CellStyle.Font = new Font(dgvAlumnos.Font, FontStyle.Bold);
                }
                else if (estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(225, 29, 72); // Rojo
                    e.CellStyle.Font = new Font(dgvAlumnos.Font, FontStyle.Bold);
                }
            }
        }
    }
}
