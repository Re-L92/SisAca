using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL.Common;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL
{
    public class CalificacionDal
    {
        public async Task<List<MatriculaEntity>> ListarMatriculasAsync(int idAnio = 0, int idSeccion = 0, string filtro = "")
        {
            var lista = new List<MatriculaEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarMatriculas", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = idAnio;
            cmd.Parameters.Add("@IdSeccion", SqlDbType.Int).Value = idSeccion;
            cmd.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = filtro?.Trim() ?? string.Empty;

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                MatriculaEntity matricula = new();
                matricula.AsignarId(Convert.ToInt32(dr["IdMatricula"]));
                matricula.AsignarEstudiante(
                    Convert.ToInt32(dr["IdEstudiante"]),
                    dr["CodigoEstudiante"].ToString() ?? string.Empty,
                    dr["NombreEstudiante"].ToString() ?? string.Empty
                );
                matricula.AsignarAnioSeccion(
                    Convert.ToInt32(dr["IdAnio"]),
                    dr["NombreAnio"].ToString() ?? string.Empty,
                    dr["Ciclo"] != DBNull.Value ? dr["Ciclo"].ToString() ?? string.Empty : string.Empty,
                    Convert.ToInt32(dr["IdSeccion"]),
                    dr["NombreSeccion"].ToString() ?? string.Empty
                );
                matricula.AsignarDetalles(
                    Convert.ToDateTime(dr["FechaMatricula"]),
                    dr["EstadoMatricula"].ToString() ?? "Activo",
                    dr["DocenteGuia"].ToString() ?? "Sin Docente Guía",
                    dr["Aula"].ToString() ?? "Por Asignar"
                );

                lista.Add(matricula);
            }

            return lista;
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
                    dr["NombreAsignatura"].ToString() ?? string.Empty
                );

                decimal? nota1 = dr["NotaI_Semestre"] != DBNull.Value ? Convert.ToDecimal(dr["NotaI_Semestre"]) : null;
                decimal? nota2 = dr["NotaII_Semestre"] != DBNull.Value ? Convert.ToDecimal(dr["NotaII_Semestre"]) : null;
                decimal? notaFinal = dr["NotaFinal"] != DBNull.Value ? Convert.ToDecimal(dr["NotaFinal"]) : null;
                decimal? notaRep = dr["NotaReparacion"] != DBNull.Value ? Convert.ToDecimal(dr["NotaReparacion"]) : null;
                string estado = dr["EstadoAsignatura"].ToString() ?? "En proceso";
                string obs = dr["Observacion"] != DBNull.Value ? dr["Observacion"].ToString() ?? string.Empty : string.Empty;

                cal.AsignarValoresDesdeBD(nota1, nota2, notaFinal, notaRep, estado, obs);

                lista.Add(cal);
            }

            return lista;
        }

        public async Task AsegurarCalificacionesMatriculaAsync(int idMatricula, int idAnio)
        {
            if (idMatricula <= 0 || idAnio <= 0) return;

            string query = @"
                INSERT INTO dbo.Calificacion (IdMatricula, IdAsignatura, NotaI_Semestre, NotaII_Semestre, NotaFinal, NotaReparacion, EstadoAsignatura, Observacion)
                SELECT @IdMatricula, ga.IdAsignatura, NULL, NULL, NULL, NULL, 'En proceso', 'Inscripción inicial'
                FROM dbo.Grado_Asignatura ga
                WHERE ga.IdAnio = @IdAnio
                  AND NOT EXISTS (
                      SELECT 1 FROM dbo.Calificacion c 
                      WHERE c.IdMatricula = @IdMatricula AND c.IdAsignatura = ga.IdAsignatura
                  );";

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new(query, cn)
            {
                CommandType = CommandType.Text
            };

            cmd.Parameters.Add("@IdMatricula", SqlDbType.Int).Value = idMatricula;
            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = idAnio;

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task GuardarCalificacionAsync(CalificacionEntity calificacion)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_GuardarCalificacionEstudiante", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdCalificacion", SqlDbType.Int).Value = calificacion.IdCalificacion;
            cmd.Parameters.Add("@NotaI_Semestre", SqlDbType.Decimal).Value = (object?)calificacion.NotaI_Semestre ?? DBNull.Value;
            cmd.Parameters.Add("@NotaII_Semestre", SqlDbType.Decimal).Value = (object?)calificacion.NotaII_Semestre ?? DBNull.Value;
            cmd.Parameters.Add("@NotaReparacion", SqlDbType.Decimal).Value = (object?)calificacion.NotaReparacion ?? DBNull.Value;

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task GuardarCalificacionesLoteAsync(List<CalificacionEntity> lista)
        {
            if (lista == null || lista.Count == 0) return;

            using SqlConnection cn = Conexion.ObtenerConexion();
            await cn.OpenAsync();

            using SqlTransaction tran = cn.BeginTransaction();
            try
            {
                foreach (var cal in lista)
                {
                    using SqlCommand cmd = new("dbo.SP_GuardarCalificacionEstudiante", cn, tran)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add("@IdCalificacion", SqlDbType.Int).Value = cal.IdCalificacion;
                    cmd.Parameters.Add("@NotaI_Semestre", SqlDbType.Decimal).Value = (object?)cal.NotaI_Semestre ?? DBNull.Value;
                    cmd.Parameters.Add("@NotaII_Semestre", SqlDbType.Decimal).Value = (object?)cal.NotaII_Semestre ?? DBNull.Value;
                    cmd.Parameters.Add("@NotaReparacion", SqlDbType.Decimal).Value = (object?)cal.NotaReparacion ?? DBNull.Value;

                    await cmd.ExecuteNonQueryAsync();
                }

                await tran.CommitAsync();
            }
            catch
            {
                await tran.RollbackAsync();
                throw;
            }
        }
    }
}
