using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL.Common
{
    public class Conexion
    {
        public static string CadenaConexion { get; set; } = string.Empty;

        public static string ConstruirCadena(ConexionEntity config)
        {
            return $"Server={config.Servidor};" +
                   $"Database={config.BaseDatos};" +
                   $"User Id={config.UsuarioSql};" +
                   $"Password={config.Password};" +
                   $"TrustServerCertificate=True;";
        }

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
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
