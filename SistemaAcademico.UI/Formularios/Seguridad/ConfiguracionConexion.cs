using SistemaAcademico.BLL;
using SistemaAcademico.Entidades.Entidades;
using SistemaAcademico.UI.Helpers;
using SistemaAcademico.DAL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico.UI.Formularios.Seguridad
{
    public partial class ConfiguracionConexion : Form
    {
        private readonly ConexionBll _conexionBll = new();

        public ConfiguracionConexion()
        {
            InitializeComponent();
        }

        private void ConfiguracionConexion_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;

            // Vincular evento TextChanged para que cualquier cambio requiera probar de nuevo
            txtServidor.TextChanged += OnCampoModificado;
            txtBaseDatos.TextChanged += OnCampoModificado;
            txtUsuario.TextChanged += OnCampoModificado;
            txtContrasena.TextChanged += OnCampoModificado;

            CargarConfiguracionExistente();
        }

        private void CargarConfiguracionExistente()
        {
            var config = _conexionBll.ObtenerConfiguracion();
            if (config != null)
            {
                txtServidor.Text = config.Servidor;
                txtBaseDatos.Text = config.BaseDatos;
                txtUsuario.Text = config.UsuarioSql;
                txtContrasena.Text = config.Password;
            }
        }

        private void OnCampoModificado(object? sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private bool ValidarCampos()
        {
            errorIcon.Clear();

            bool valido = true;

            if (!Validacion.Requerido(txtServidor, errorIcon, "Debe ingresar el servidor."))
                valido = false;

            if (!Validacion.Requerido(txtBaseDatos, errorIcon, "Debe ingresar la base de datos."))
                valido = false;

            if (!Validacion.Requerido(txtUsuario, errorIcon, "Debe ingresar el usuario."))
                valido = false;

            if (!Validacion.Requerido(txtContrasena, errorIcon, "Debe ingresar la contraseña."))
                valido = false;

            return valido;
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private async void btnProbar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            Cursor = Cursors.WaitCursor;
            btnProbar.Enabled = false;

            try
            {
                bool ok = await _conexionBll.ProbarConexion(
                    txtServidor.Text.Trim(),
                    txtBaseDatos.Text.Trim(),
                    txtUsuario.Text.Trim(),
                    txtContrasena.Text);

                if (ok)
                {
                    MessageBox.Show("Conexión exitosa.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No fue posible conectar con el servidor.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGuardar.Enabled = false;
                }
            }
            finally
            {
                Cursor = Cursors.Default;
                btnProbar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            ConexionEntity config = new()
            {
                Servidor = txtServidor.Text.Trim(),
                BaseDatos = txtBaseDatos.Text.Trim(),
                UsuarioSql = txtUsuario.Text.Trim(),
                Password = txtContrasena.Text
            };

            bool resultado = _conexionBll.GuardarConfiguracion(config);

            if (!resultado)
            {
                MessageBox.Show("No fue posible guardar la configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Configuración guardada correctamente.", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
