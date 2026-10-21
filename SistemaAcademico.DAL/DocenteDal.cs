using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL.Common;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL
{
    public class DocenteDal
    {
        public async Task<List<DocenteEntity>> ListarAsync(string filtro = "")
        {
            var lista = new List<DocenteEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarDocentes", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = filtro?.ToLower() ?? string.Empty;

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                DocenteEntity docente = new();
                docente.AsignarId(Convert.ToInt32(dr["IdDocente"]));
                docente.CambiarNombres(dr["Nombres"].ToString() ?? string.Empty);
                docente.CambiarApellidos(dr["Apellidos"].ToString() ?? string.Empty);
                docente.CambiarCedula(dr["Cedula"].ToString() ?? string.Empty);
                docente.CambiarTelefono(dr["Telefono"] != DBNull.Value ? dr["Telefono"].ToString() : null);
                docente.CambiarCorreo(dr["Correo"] != DBNull.Value ? dr["Correo"].ToString() : null);

                // Mapeo dinámico y seguro de Especialidad y EspecialidadId
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string col = dr.GetName(i);
                    if (col.Equals("Especialidad", StringComparison.OrdinalIgnoreCase) && dr[i] != DBNull.Value)
                    {
                        docente.CambiarEspecialidad(dr[i].ToString());
                    }
                    else if (col.Equals("EspecialidadId", StringComparison.OrdinalIgnoreCase) && dr[i] != DBNull.Value)
                    {
                        docente.AsignarEspecialidadId(Convert.ToInt32(dr[i]));
                    }
                }

                docente.CambiarEstado(dr["Estado"].ToString() ?? "Activo");

                lista.Add(docente);
            }

            return lista;
        }

        public async Task<int> GuardarAsync(DocenteEntity docente)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_GuardarDocenteConAsignaturas", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdDocente", SqlDbType.Int).Value = docente.IdDocente;
            cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar, 100).Value = docente.Nombres;
            cmd.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 100).Value = docente.Apellidos;
            cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar, 25).Value = docente.Cedula;
            cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value = (object?)docente.Telefono ?? DBNull.Value;
            cmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = (object?)docente.Correo ?? DBNull.Value;

            // El SP ahora recibe el texto de la especialidad directamente (@Especialidad NVARCHAR(100))
            cmd.Parameters.Add("@Especialidad", SqlDbType.NVarChar, 100).Value = docente.Especialidad ?? string.Empty;

            SqlParameter paramNuevoId = new("@NuevoIdDocente", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramNuevoId);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return (paramNuevoId.Value != DBNull.Value) ? Convert.ToInt32(paramNuevoId.Value) : docente.IdDocente;
        }
    }
}
