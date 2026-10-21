using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL.Common;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL
{
    public class EspecialidadDal
    {
        public async Task<List<EspecialidadEntity>> ListarAsync()
        {
            var lista = new List<EspecialidadEntity>();
            const string query = "SELECT Id, Nombre FROM Especialidades ORDER BY Nombre";

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new(query, cn)
            {
                CommandType = CommandType.Text
            };

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                EspecialidadEntity item = new();
                item.AsignarId(Convert.ToInt32(dr["Id"]));
                item.CambiarNombre(dr["Nombre"].ToString() ?? string.Empty);

                lista.Add(item);
            }

            return lista;
        }
    }
}
