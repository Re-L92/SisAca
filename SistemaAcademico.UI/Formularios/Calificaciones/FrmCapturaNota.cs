using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.UI.Formularios.Calificaciones
{
    public partial class FrmCapturaNota : Form
    {
        private readonly CalificacionEntity _calificacion;
        private readonly string _nombreEstudiante;
        private readonly CalificacionBll _calificacionBll;
        private bool _cargandoDatos = false;

        public CalificacionEntity Calificacion => _calificacion;

        public FrmCapturaNota() : this(new CalificacionEntity(), "Estudiante")
        {
        }

        public FrmCapturaNota(CalificacionEntity calificacion, string nombreEstudiante)
        {
            InitializeComponent();
            _calificacion = calificacion ?? throw new ArgumentNullException(nameof(calificacion));
            _nombreEstudiante = nombreEstudiante ?? string.Empty;
            _calificacionBll = new CalificacionBll();

            CargarDatosEnControles();
        }

        private void CargarDatosEnControles()
        {
            _cargandoDatos = true;

            lblEstudianteInfo.Text = string.IsNullOrWhiteSpace(_nombreEstudiante)
                ? "Estudiante: No especificado"
                : $"Estudiante: {_nombreEstudiante}";

            lblAsignaturaInfo.Text = $"Asignatura: {_calificacion.NombreAsignatura} ({_calificacion.HorasSemanales} hrs/sem)";

            txtNota1.Text = _calificacion.NotaI_Semestre?.ToString("0.##", CultureInfo.InvariantCulture) ?? string.Empty;
            txtNota2.Text = _calificacion.NotaII_Semestre?.ToString("0.##", CultureInfo.InvariantCulture) ?? string.Empty;
            txtReparacion.Text = _calificacion.NotaReparacion?.ToString("0.##", CultureInfo.InvariantCulture) ?? string.Empty;

            _cargandoDatos = false;

            ActualizarPrevisualizacion();
        }

        private void Calificacion_TextChanged(object sender, EventArgs e)
        {
            if (_cargandoDatos) return;

            try
            {
                errorProvider.Clear();

                decimal? nota1 = ParsearNota(txtNota1, "I Semestre");
                decimal? nota2 = ParsearNota(txtNota2, "II Semestre");
                decimal? reparacion = ParsearNota(txtReparacion, "Examen de Reparación");

                // Asignar al modelo invocando los métodos encapsulados del dominio
                _calificacion.CambiarNotaISemestre(nota1);
                _calificacion.CambiarNotaIISemestre(nota2);
                _calificacion.CambiarNotaReparacion(reparacion);

                ActualizarPrevisualizacion();
            }
            catch (Exception ex)
            {
                if (sender is TextBox txt)
                {
                    errorProvider.SetError(txt, ex.Message);
                }
            }
        }

        private decimal? ParsearNota(TextBox txt, string nombreCampo)
        {
            string texto = txt.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return null;

            // Reemplazar coma por punto para compatibilidad de teclado numérico
            texto = texto.Replace(',', '.');

            if (!decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valor))
            {
                errorProvider.SetError(txt, $"Formato de número inválido para {nombreCampo}.");
                throw new Exception($"El valor ingresado en {nombreCampo} no es un número válido.");
            }

            if (valor < 0 || valor > 100)
            {
                errorProvider.SetError(txt, $"La nota debe estar entre 0 y 100.");
                throw new Exception($"La nota de {nombreCampo} debe estar comprendida entre 0 y 100 puntos.");
            }

            return valor;
        }

        private void ActualizarPrevisualizacion()
        {
            lblNotaFinalValor.Text = _calificacion.NotaFinal.HasValue
                ? _calificacion.NotaFinal.Value.ToString("N2", CultureInfo.CurrentCulture)
                : "--.--";

            lblEstadoValor.Text = _calificacion.EstadoAsignatura;
            lblObservacionValor.Text = _calificacion.Observacion;

            // Colorear el estado dinámicamente
            switch (_calificacion.EstadoAsignatura)
            {
                case "Aprobada":
                    lblEstadoValor.ForeColor = Color.FromArgb(16, 185, 129); // Verde éxito
                    break;
                case "Reparación":
                    lblEstadoValor.ForeColor = Color.FromArgb(245, 158, 11); // Naranja advertencia
                    break;
                case "Reprobada":
                    lblEstadoValor.ForeColor = Color.FromArgb(239, 68, 68); // Rojo peligro
                    break;
                default:
                    lblEstadoValor.ForeColor = Color.FromArgb(37, 99, 235); // Azul en proceso
                    break;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                decimal? nota1 = ParsearNota(txtNota1, "I Semestre");
                decimal? nota2 = ParsearNota(txtNota2, "II Semestre");
                decimal? reparacion = ParsearNota(txtReparacion, "Examen de Reparación");

                _calificacion.CambiarNotaISemestre(nota1);
                _calificacion.CambiarNotaIISemestre(nota2);
                _calificacion.CambiarNotaReparacion(reparacion);

                btnGuardar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (_calificacion.IdCalificacion > 0)
                {
                    await _calificacionBll.GuardarCalificacionAsync(_calificacion);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación de Calificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
