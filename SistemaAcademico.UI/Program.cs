using SistemaAcademico.BLL;
using SistemaAcademico.UI.Formularios.Seguridad;

namespace SistemaAcademico.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ConexionBll conexionBll = new();

            // Si ya existe configuración guardada y la conexión es exitosa, abrir el formulario principal
            if (conexionBll.ExisteConfiguracion() && conexionBll.InicializarConexion().GetAwaiter().GetResult())
            {
                Application.Run(new FormularioPrincipal());
            }
            else
            {
                // Si no existe o falló la conexión previa, solicitar la configuración
                using var frmConfig = new ConfiguracionConexion();
                if (frmConfig.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormularioPrincipal());
                }
            }
        }
    }
}