using SistemaAcademico.UI.Formularios.Alumnos;
using SistemaAcademico.UI.Formularios.Docentes;
using SistemaAcademico.UI.Formularios.Seguridad;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico.UI
{
    public partial class FormularioPrincipal : Form
    {
        private Form? _formularioActivo = null;
        private Button? _botonSeleccionado = null;

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            // Cargar por defecto el módulo de Docentes (Sesión 2)
            ActivarBoton(btnMenuDocentes);
            AbrirFormularioEnPanel(new FrmBuscarDocente(), "Personal Docente");
        }

        public void AbrirFormularioEnPanel(Form formularioHijo, string tituloModulo = "")
        {
            // Si ya hay un formulario cargado, se cierra y se libera
            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
                _formularioActivo.Dispose();
                pnlContenedor.Controls.Clear();
            }

            _formularioActivo = formularioHijo;

            // Configurar para embeber en el panel contenedor
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

            if (!string.IsNullOrWhiteSpace(tituloModulo))
            {
                lblModuloActual.Text = tituloModulo;
            }
        }

        private void ActivarBoton(Button boton)
        {
            if (_botonSeleccionado != null)
            {
                _botonSeleccionado.BackColor = Color.Transparent;
                _botonSeleccionado.ForeColor = Color.FromArgb(148, 163, 184);
                _botonSeleccionado.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }

            _botonSeleccionado = boton;
            _botonSeleccionado.BackColor = Color.FromArgb(30, 41, 59);
            _botonSeleccionado.ForeColor = Color.White;
            _botonSeleccionado.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
        }

        private void btnMenuDocentes_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnMenuDocentes);
            AbrirFormularioEnPanel(new FrmBuscarDocente(), "Personal Docente");
        }

        private void btnMenuEstudiantes_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnMenuEstudiantes);
            lblModuloActual.Text = "Estudiantes";
            AbrirFormularioEnPanel(new FrmBuscarAlumno(), "Alumnos");
        }

        private void btnMenuMatriculas_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnMenuMatriculas);
            lblModuloActual.Text = "Matrículas";
            MessageBox.Show("Módulo de Matrículas programado para la siguiente sesión.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMenuCalificaciones_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnMenuCalificaciones);
            lblModuloActual.Text = "Calificaciones";
            MessageBox.Show("Módulo de Calificaciones programado para la siguiente sesión.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMenuConfiguracion_Click(object sender, EventArgs e)
        {
            using var frmConfig = new ConfiguracionConexion();
            frmConfig.ShowDialog(this);
        }

        private void btnMenuSalir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir del Sistema Académico?",
                "Confirmación de Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
