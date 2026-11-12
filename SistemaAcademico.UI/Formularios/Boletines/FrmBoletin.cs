using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.UI.Formularios.Boletines
{
    public partial class FrmBoletin : Form
    {
        private readonly BoletinBll _boletinBll = new();

        public FrmBoletin()
        {
            InitializeComponent();
        }

        #region Eventos de Búsqueda y Consulta

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await ConsultarBoletinAsync();
        }

        private async void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evitar el sonido 'beep' de Windows
                await ConsultarBoletinAsync();
            }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text.Trim();
            if (codigo.Length >= 3)
            {
                await CargarDatosSiExisteAsync(codigo);
            }
            else if (codigo.Length == 0)
            {
                LimpiarVista();
            }
        }

        private async Task CargarDatosSiExisteAsync(string codigo)
        {
            try
            {
                var boletin = await _boletinBll.ConsultarBoletinEstudianteAsync(codigo);
                if (boletin != null && boletin.Matricula != null)
                {
                    lblNombreEstudiante.Text = boletin.Matricula.NombreEstudiante;
                    lblCarnet.Text = $"Carnet: {boletin.Matricula.CodigoEstudiante}";
                    lblGradoSeccion.Text = $"Grado Actual: {boletin.Matricula.NombreAnio} | Sección: '{boletin.Matricula.NombreSeccion}' ({boletin.Matricula.Ciclo})";
                    lblPromedio.Text = $"Promedio General: {boletin.PromedioGeneral:N2} pts";

                    ActualizarBadgeEstado(boletin.Matricula.EstadoEstudiante, boletin.Matricula.EstadoMatricula);

                    dgvBoletin.AutoGenerateColumns = false;
                    dgvBoletin.DataSource = null;
                    dgvBoletin.DataSource = boletin.Calificaciones;

                    lblEstado.Text = $"Boletín cargado: {boletin.Calificaciones.Count} asignaturas correspondientes a {boletin.Matricula.NombreAnio} (Ciclo Vigente).";
                    lblEstado.ForeColor = Color.FromArgb(22, 101, 52);
                }
            }
            catch
            {
                // Modo silencioso mientras el usuario escribe en tiempo real
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            LimpiarVista();
            txtBuscar.Focus();
        }

        private async Task ConsultarBoletinAsync()
        {
            string codigo = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show(
                    "Por favor ingrese el código o carnet del estudiante a consultar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtBuscar.Focus();
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                var boletin = await _boletinBll.ConsultarBoletinEstudianteAsync(codigo);

                if (boletin == null || boletin.Matricula == null)
                {
                    LimpiarVista();
                    lblEstado.Text = $"No se encontró ningún estudiante matriculado con el carnet '{codigo}'.";
                    lblEstado.ForeColor = Color.FromArgb(185, 28, 28);
                    MessageBox.Show(
                        $"No se encontró ningún estudiante matriculado con el código o carnet '{codigo}'.\n\n" +
                        "Verifique el identificador e intente nuevamente.",
                        "Estudiante No Encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // 1. Mostrar los datos del estudiante en el año vigente que cursa actualmente
                lblNombreEstudiante.Text = boletin.Matricula.NombreEstudiante;
                lblCarnet.Text = $"Carnet: {boletin.Matricula.CodigoEstudiante}";
                lblGradoSeccion.Text = $"Grado Actual: {boletin.Matricula.NombreAnio} | Sección: '{boletin.Matricula.NombreSeccion}' ({boletin.Matricula.Ciclo})";
                lblPromedio.Text = $"Promedio General: {boletin.PromedioGeneral:N2} pts";

                // 2. Colorear el badge de estado
                ActualizarBadgeEstado(boletin.Matricula.EstadoEstudiante, boletin.Matricula.EstadoMatricula);

                // 3. Enlazar las calificaciones del ciclo actual al DataGridView
                dgvBoletin.AutoGenerateColumns = false;
                dgvBoletin.DataSource = null;
                dgvBoletin.DataSource = boletin.Calificaciones;

                lblEstado.Text = $"Boletín cargado: {boletin.Calificaciones.Count} asignaturas correspondientes a {boletin.Matricula.NombreAnio} (Ciclo Vigente).";
                lblEstado.ForeColor = Color.FromArgb(22, 101, 52);
            }
            catch (Exception ex)
            {
                lblEstado.Text = $"Error al consultar el boletín: {ex.Message}";
                lblEstado.ForeColor = Color.FromArgb(185, 28, 28);
                MessageBox.Show(
                    $"Ocurrió un error al cargar las calificaciones del estudiante:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ActualizarBadgeEstado(string estadoEstudiante, string estadoMatricula)
        {
            string est = estadoEstudiante?.Trim().ToLower() ?? "activo";
            string mat = estadoMatricula?.Trim().ToLower() ?? "activo";

            if (est == "inactivo")
            {
                lblBadgeEstado.Text = "INACTIVO";
                lblBadgeEstado.BackColor = Color.FromArgb(254, 226, 226);
                lblBadgeEstado.ForeColor = Color.FromArgb(153, 27, 27);
            }
            else if (mat == "estudiante graduado" || est == "estudiante graduado")
            {
                lblBadgeEstado.Text = "ESTUDIANTE GRADUADO";
                lblBadgeEstado.BackColor = Color.FromArgb(254, 243, 199);
                lblBadgeEstado.ForeColor = Color.FromArgb(146, 64, 14);
            }
            else if (mat == "promovido")
            {
                lblBadgeEstado.Text = "APROBADO / PROMOVIDO";
                lblBadgeEstado.BackColor = Color.FromArgb(219, 234, 254);
                lblBadgeEstado.ForeColor = Color.FromArgb(30, 64, 175);
            }
            else if (mat == "repite año" || mat == "repite ano")
            {
                lblBadgeEstado.Text = "REPROBADO / REPITE AÑO";
                lblBadgeEstado.BackColor = Color.FromArgb(254, 226, 226);
                lblBadgeEstado.ForeColor = Color.FromArgb(153, 27, 27);
            }
            else
            {
                lblBadgeEstado.Text = "ACTIVO (CURSANDO)";
                lblBadgeEstado.BackColor = Color.FromArgb(220, 252, 231);
                lblBadgeEstado.ForeColor = Color.FromArgb(22, 101, 52);
            }
        }

        private void LimpiarVista()
        {
            lblNombreEstudiante.Text = "Ingrese un carnet para consultar el boletín";
            lblCarnet.Text = "Carnet: ----";
            lblGradoSeccion.Text = "Grado Actual: -- | Sección: -- (Año Vigente)";
            lblPromedio.Text = "Promedio General: --";

            lblBadgeEstado.Text = "---";
            lblBadgeEstado.BackColor = Color.FromArgb(241, 245, 249);
            lblBadgeEstado.ForeColor = Color.FromArgb(100, 116, 139);

            dgvBoletin.DataSource = null;
            lblEstado.Text = "Listo. Escriba el carnet del estudiante y presione Buscar o Enter para consultar sus notas.";
            lblEstado.ForeColor = Color.FromArgb(100, 116, 139);
        }

        #endregion

        #region Formato Visual de Grilla

        private void dgvBoletin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBoletin.DataSource is not List<CalificacionEntity> lista || e.RowIndex < 0 || e.RowIndex >= lista.Count)
                return;

            var cal = lista[e.RowIndex];
            var col = dgvBoletin.Columns[e.ColumnIndex];

            // 1. Formatear valores numéricos a dos decimales
            if (col == colNota1 || col == colNota2 || col == colNotaFinal || col == colReparacion)
            {
                if (e.Value is decimal decVal)
                {
                    e.Value = decVal.ToString("N2", CultureInfo.CurrentCulture);
                    e.FormattingApplied = true;
                }
            }

            // 2. Destacar Nota Final aprobada o reprobada
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

            // 3. Colorear el estado de la asignatura
            if (col == colEstado)
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
        }

        #endregion
    }
}
