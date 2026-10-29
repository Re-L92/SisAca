using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL.Common
{
    public class Conexion
    {
        public static string CadenaConexion { get; set; } = string.Empty;

        public static string ConstruirCadena(ConexionEntity config)
        {
            string db = string.IsNullOrWhiteSpace(config.BaseDatos) || config.BaseDatos.Trim().Equals("master", StringComparison.OrdinalIgnoreCase)
                ? "DB_GestionAcademica"
                : config.BaseDatos.Trim();

            return $"Server={config.Servidor?.Trim()};" +
                   $"Database={db};" +
                   $"User Id={config.UsuarioSql?.Trim()};" +
                   $"Password={config.Password};" +
                   $"TrustServerCertificate=True;";
        }

        public static SqlConnection ObtenerConexion()
        {
            if (string.IsNullOrWhiteSpace(CadenaConexion))
            {
                ConfiguracionDal configDal = new();
                configDal.CargarConexionActiva();
            }

            return new SqlConnection(CadenaConexion);
        }

        public static async Task<SqlConnection> AbrirConexionAsync()
        {
            var cn = ObtenerConexion();
            await cn.OpenAsync();

            // Si por alguna razón la conexión abrió sobre master, forzar a la base de datos del sistema
            if (!string.IsNullOrWhiteSpace(cn.Database) && cn.Database.Equals("master", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    await cn.ChangeDatabaseAsync("DB_GestionAcademica");
                }
                catch
                {
                    // Si no estuviera creada DB_GestionAcademica, continúa con la base actual
                }
            }

            return cn;
        }

        public static async Task<bool> ProbarConexion(string cadena)
        {
            try
            {
                using SqlConnection cn = new(cadena);
                await cn.OpenAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
