using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL.Common;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL
{
    public class MatriculaDal
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

                string estadoEstudiante = "Activo";
                try
                {
                    if (dr["EstadoEstudiante"] != DBNull.Value)
                    {
                        estadoEstudiante = dr["EstadoEstudiante"].ToString() ?? "Activo";
                    }
                }
                catch
                {
                    estadoEstudiante = "Activo";
                }

                matricula.AsignarEstudiante(
                    Convert.ToInt32(dr["IdEstudiante"]),
                    dr["CodigoEstudiante"].ToString() ?? string.Empty,
                    dr["NombreEstudiante"].ToString() ?? string.Empty,
                    estadoEstudiante
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
                    dr["Aula"].ToString() ?? "Por Asignar",
                    estadoEstudiante
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

        public async Task<(int NuevoIdMatricula, string Mensaje)> MatricularSiguienteAnioAsync(int idMatriculaActual, int idSeccionNueva)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_MatricularSiguienteAnio", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdMatriculaActual", SqlDbType.Int).Value = idMatriculaActual;
            cmd.Parameters.Add("@IdSeccionNueva", SqlDbType.Int).Value = idSeccionNueva;

            SqlParameter paramNuevoId = new("@NuevoIdMatricula", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramNuevoId);

            SqlParameter paramMensaje = new("@MensajeResultado", SqlDbType.NVarChar, 200)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramMensaje);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            int nuevoId = (paramNuevoId.Value != DBNull.Value) ? Convert.ToInt32(paramNuevoId.Value) : 0;
            string mensaje = paramMensaje.Value?.ToString() ?? "Operación completada exitosamente.";

            return (nuevoId, mensaje);
        }

        public async Task<(int NuevoIdMatricula, string Mensaje)> MatricularMismoAnioAsync(int idMatriculaActual, int idSeccionNueva)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_MatricularMismoAnio", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdMatriculaActual", SqlDbType.Int).Value = idMatriculaActual;
            cmd.Parameters.Add("@IdSeccionNueva", SqlDbType.Int).Value = idSeccionNueva;

            SqlParameter paramNuevoId = new("@NuevoIdMatricula", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramNuevoId);

            SqlParameter paramMensaje = new("@MensajeResultado", SqlDbType.NVarChar, 200)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramMensaje);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            int nuevoId = (paramNuevoId.Value != DBNull.Value) ? Convert.ToInt32(paramNuevoId.Value) : 0;
            string mensaje = paramMensaje.Value?.ToString() ?? "Operación completada exitosamente.";

            return (nuevoId, mensaje);
        }

        public async Task<List<SeccionEntity>> ListarSeccionesConDisponibilidadAsync(int idAnio)
        {
            var lista = new List<SeccionEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarSeccionesConDisponibilidad", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = idAnio;

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                int capacidad = dr["CapacidadMaxima"] != DBNull.Value ? Convert.ToInt32(dr["CapacidadMaxima"]) : 40;
                int matriculados = dr["Matriculados"] != DBNull.Value ? Convert.ToInt32(dr["Matriculados"]) : 0;
                int cupos = dr["CuposDisponibles"] != DBNull.Value ? Convert.ToInt32(dr["CuposDisponibles"]) : (capacidad - matriculados);

                SeccionEntity seccion = new();
                seccion.AsignarId(Convert.ToInt32(dr["IdSeccion"]));
                seccion.CambiarNombreSeccion(dr["NombreSeccion"].ToString() ?? string.Empty);
                seccion.AsignarCapacidadMaxima(capacidad);
                seccion.AsignarMatriculados(matriculados);
                seccion.AsignarCuposDisponibles(cupos);

                lista.Add(seccion);
            }

            return lista;
        }

        public async Task<List<AnioAcademicoEntity>> ListarAniosAcademicosAsync()
        {
            var lista = new List<AnioAcademicoEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarAniosAcademicos", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                AnioAcademicoEntity anio = new();
                anio.AsignarId(Convert.ToInt32(dr["IdAnio"]));
                anio.CambiarNombreAnio(dr["NombreAnio"].ToString() ?? string.Empty);
                anio.CambiarCiclo(dr["Ciclo"].ToString() ?? string.Empty);

                lista.Add(anio);
            }

            return lista;
        }
    }
}
