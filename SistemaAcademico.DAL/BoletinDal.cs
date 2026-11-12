using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL.Common;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL
{
    public class BoletinDal
    {
        public async Task<MatriculaEntity?> ObtenerMatriculaActualPorCodigoAsync(string codigoEstudiante)
        {
            if (string.IsNullOrWhiteSpace(codigoEstudiante))
                return null;

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarMatriculas", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@IdSeccion", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = codigoEstudiante.Trim();

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                string codigo = dr["CodigoEstudiante"]?.ToString() ?? string.Empty;

                // Comparar si coincide con el código (carnet) del estudiante
                if (codigo.Equals(codigoEstudiante.Trim(), StringComparison.OrdinalIgnoreCase) ||
                    codigo.Contains(codigoEstudiante.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    MatriculaEntity matricula = new();
                    matricula.AsignarId(Convert.ToInt32(dr["IdMatricula"]));

                    string estadoEstudiante = "Activo";
                    try
                    {
                        if (dr["EstadoEstudiante"] != DBNull.Value)
                            estadoEstudiante = dr["EstadoEstudiante"].ToString() ?? "Activo";
                    }
                    catch
                    {
                        estadoEstudiante = "Activo";
                    }

                    matricula.AsignarEstudiante(
                        Convert.ToInt32(dr["IdEstudiante"]),
                        codigo,
                        dr["NombreEstudiante"]?.ToString() ?? string.Empty,
                        estadoEstudiante
                    );

                    matricula.AsignarAnioSeccion(
                        Convert.ToInt32(dr["IdAnio"]),
                        dr["NombreAnio"]?.ToString() ?? string.Empty,
                        dr["Ciclo"] != DBNull.Value ? dr["Ciclo"].ToString() ?? string.Empty : string.Empty,
                        Convert.ToInt32(dr["IdSeccion"]),
                        dr["NombreSeccion"]?.ToString() ?? string.Empty
                    );

                    matricula.AsignarDetalles(
                        Convert.ToDateTime(dr["FechaMatricula"]),
                        dr["EstadoMatricula"]?.ToString() ?? "Activo",
                        dr["DocenteGuia"]?.ToString() ?? "Sin Docente Guía",
                        dr["Aula"]?.ToString() ?? "Por Asignar",
                        estadoEstudiante
                    );

                    return matricula;
                }
            }

            return null;
        }

        public async Task<List<CalificacionEntity>> ObtenerCalificacionesPorMatriculaAsync(int idMatricula)
        {
            var lista = new List<CalificacionEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ObtenerCalificacionesPorMatricula", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdMatricula", SqlDbType.Int).Value = idMatricula;

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                CalificacionEntity cal = new();
                cal.AsignarId(Convert.ToInt32(dr["IdCalificacion"]));
                cal.AsignarMatricula(Convert.ToInt32(dr["IdMatricula"]));
                cal.AsignarAsignatura(
                    Convert.ToInt32(dr["IdAsignatura"]),
                    dr["NombreAsignatura"]?.ToString() ?? string.Empty
                );

                decimal? nota1 = dr["NotaI_Semestre"] != DBNull.Value ? Convert.ToDecimal(dr["NotaI_Semestre"]) : null;
                decimal? nota2 = dr["NotaII_Semestre"] != DBNull.Value ? Convert.ToDecimal(dr["NotaII_Semestre"]) : null;
                decimal? notaFinal = dr["NotaFinal"] != DBNull.Value ? Convert.ToDecimal(dr["NotaFinal"]) : null;
                decimal? notaRep = dr["NotaReparacion"] != DBNull.Value ? Convert.ToDecimal(dr["NotaReparacion"]) : null;
                string estado = dr["EstadoAsignatura"]?.ToString() ?? "En proceso";
                string obs = dr["Observacion"] != DBNull.Value ? dr["Observacion"].ToString() ?? string.Empty : string.Empty;

                cal.AsignarValoresDesdeBD(nota1, nota2, notaFinal, notaRep, estado, obs);
                lista.Add(cal);
            }

            return lista;
        }
    }
}
