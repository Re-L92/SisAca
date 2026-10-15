using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.UI.Formularios.Docentes
{
    public partial class FrmBuscarDocente : Form
    {
        private readonly DocenteBll _docenteBll = new();
        private List<DocenteEntity> _listaDocentes = new();

        public FrmBuscarDocente()
        {
            InitializeComponent();
        }

        private async void FrmBuscarDocente_Load(object sender, EventArgs e)
        {
            await CargarDocentesAsync();
        }

        public async Task CargarDocentesAsync(string filtro = "")
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                _listaDocentes = await _docenteBll.ListarAsync(filtro);
                dgvDocentes.AutoGenerateColumns = false;
                dgvDocentes.DataSource = null;
                dgvDocentes.DataSource = _listaDocentes;

                lblTotal.Text = $"Total de registros: {_listaDocentes.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar el cuerpo docente:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            await CargarDocentesAsync(txtBuscar.Text.Trim());
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await CargarDocentesAsync();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            using var frm = new FrmNuevoDocente();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                await CargarDocentesAsync(txtBuscar.Text.Trim());
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirEdicionSeleccionada();
        }

        private void dgvDocentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AbrirEdicionSeleccionada();
            }
        }

        private async void AbrirEdicionSeleccionada()
        {
            if (dgvDocentes.CurrentRow?.DataBoundItem is DocenteEntity docenteSeleccionado)
            {
                using var frm = new FrmNuevoDocente(docenteSeleccionado);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarDocentesAsync(txtBuscar.Text.Trim());
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un docente de la lista para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
