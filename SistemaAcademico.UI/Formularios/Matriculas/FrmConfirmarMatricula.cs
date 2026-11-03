using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.UI.Formularios.Matriculas
{
    public partial class FrmConfirmarMatricula : Form
    {
        private readonly List<SeccionEntity> _secciones;

        public int IdSeccionSeleccionada { get; private set; }

        public FrmConfirmarMatricula(string estudiante, string anioDestino, List<SeccionEntity> secciones)
        {
            InitializeComponent();
            _secciones = secciones ?? new List<SeccionEntity>();

            lblEstudianteNombre.Text = estudiante;
            lblAnioNombre.Text = anioDestino;

            CargarSecciones();
        }

        private void CargarSecciones()
        {
            cboSeccionDestino.DataSource = null;
            cboSeccionDestino.DisplayMember = "DescripcionCompleta";
            cboSeccionDestino.ValueMember = "IdSeccion";
            cboSeccionDestino.DataSource = _secciones;

            if (_secciones.Count > 0)
            {
                cboSeccionDestino.SelectedIndex = 0; // Preselecciona la más vacía
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboSeccionDestino.SelectedItem is not SeccionEntity seccion)
            {
                MessageBox.Show("Por favor seleccione una sección válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seccion.EstaLlena)
            {
                MessageBox.Show("La sección seleccionada ha alcanzado su capacidad máxima (40 alumnos). Por favor elija otra sección con cupos disponibles.", "Sección Llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IdSeccionSeleccionada = seccion.IdSeccion;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
