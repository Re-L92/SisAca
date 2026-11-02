using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL.Common;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL
{
    public class AlumnoDal
    {
        public async Task<List<AlumnoEntity>> ListarAsync(string filtro = "")
        {
            var lista = new List<AlumnoEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarEstudiantes", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = filtro?.Trim() ?? string.Empty;

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                AlumnoEntity alumno = new();
                alumno.AsignarId(Convert.ToInt32(dr["IdEstudiante"]));
                alumno.CambiarCodigoEstudiante(dr["CodigoEstudiante"].ToString() ?? string.Empty);
                alumno.CambiarNombres(dr["Nombres"].ToString() ?? string.Empty);
                alumno.CambiarApellidos(dr["Apellidos"].ToString() ?? string.Empty);
                alumno.CambiarFechaNacimiento(Convert.ToDateTime(dr["FechaNacimiento"]));
                alumno.CambiarEstado(dr["Estado"].ToString() ?? "Activo");
                alumno.AsignarFechaRegistro(Convert.ToDateTime(dr["FechaRegistro"]));
                alumno.AsignarTutor(
                    Convert.ToInt32(dr["IdTutor"]),
                    dr["NombreTutor"].ToString() ?? string.Empty,
                    dr["TelefonoTutor"] != DBNull.Value ? dr["TelefonoTutor"].ToString() : null,
                    dr["CedulaTutor"] != DBNull.Value ? dr["CedulaTutor"].ToString() : null
                );

                lista.Add(alumno);
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

        public async Task<List<SeccionEntity>> ListarSeccionesAsync()
        {
            var lista = new List<SeccionEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarSecciones", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                SeccionEntity seccion = new();
                seccion.AsignarId(Convert.ToInt32(dr["IdSeccion"]));
                seccion.CambiarNombreSeccion(dr["NombreSeccion"].ToString() ?? string.Empty);
                seccion.AsignarCapacidadMaxima(dr["CapacidadMaxima"] != DBNull.Value ? Convert.ToInt32(dr["CapacidadMaxima"]) : 40);

                lista.Add(seccion);
            }

            return lista;
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

        public async Task<List<AsignaturaEntity>> ListarAsignaturasPorAnioAsync(int idAnio)
        {
            var lista = new List<AsignaturaEntity>();

            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ListarAsignaturasPorAnio", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = idAnio;

            await cn.OpenAsync();
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                AsignaturaEntity asignatura = new();
                asignatura.AsignarId(Convert.ToInt32(dr["IdAsignatura"]));
                asignatura.CambiarNombreAsignatura(dr["NombreAsignatura"].ToString() ?? string.Empty);
                asignatura.AsignarHorasSemanales(dr["HorasSemanales"] != DBNull.Value ? Convert.ToInt32(dr["HorasSemanales"]) : 4);

                lista.Add(asignatura);
            }

            return lista;
        }

        public async Task<string> CambiarEstadoEstudianteAsync(int idEstudiante, string? nuevoEstado = null)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_CambiarEstadoEstudiante", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@IdEstudiante", SqlDbType.Int).Value = idEstudiante;
            cmd.Parameters.Add("@NuevoEstado", SqlDbType.NVarChar, 25).Value = (object?)nuevoEstado ?? DBNull.Value;

            await cn.OpenAsync();
            object? result = await cmd.ExecuteScalarAsync();
            return result?.ToString() ?? "Activo";
        }

        public async Task<int> ObtenerSiguienteCorrelativoEstudianteAsync()
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_ObtenerSiguienteCorrelativoEstudiante", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            await cn.OpenAsync();
            object? result = await cmd.ExecuteScalarAsync();
            return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 1;
        }

        public async Task<int> ObtenerSiguienteNumeroMatriculaAsync()
        {
            return await ObtenerSiguienteCorrelativoEstudianteAsync();
        }

        public async Task<(int IdEstudiante, int IdMatricula)> RegistrarEstudianteYMatriculaAsync(AlumnoRegistroModel model)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new("dbo.SP_RegistrarEstudianteYMatricula", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@TutorNombres", SqlDbType.NVarChar, 100).Value = model.TutorNombres;
            cmd.Parameters.Add("@TutorApellidos", SqlDbType.NVarChar, 100).Value = model.TutorApellidos;
            cmd.Parameters.Add("@TutorTelefono", SqlDbType.NVarChar, 20).Value = model.TutorTelefono;
            cmd.Parameters.Add("@TutorCedula", SqlDbType.NVarChar, 25).Value = model.TutorCedula;
            cmd.Parameters.Add("@TutorDireccion", SqlDbType.NVarChar, 200).Value = (object?)model.TutorDireccion ?? string.Empty;

            cmd.Parameters.Add("@EstudianteCodigo", SqlDbType.VarChar, 100).Value = model.EstudianteCodigo;
            cmd.Parameters.Add("@EstudianteNombres", SqlDbType.NVarChar, 100).Value = model.EstudianteNombres;
            cmd.Parameters.Add("@EstudianteApellidos", SqlDbType.NVarChar, 100).Value = model.EstudianteApellidos;
            cmd.Parameters.Add("@EstudianteFechaNac", SqlDbType.Date).Value = model.EstudianteFechaNac;

            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = model.IdAnio;
            cmd.Parameters.Add("@IdSeccion", SqlDbType.Int).Value = model.IdSeccion;

            SqlParameter paramNuevoIdEstudiante = new("@NuevoIdEstudiante", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramNuevoIdEstudiante);

            SqlParameter paramNuevoIdMatricula = new("@NuevoIdMatricula", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramNuevoIdMatricula);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            int nuevoIdEstudiante = (paramNuevoIdEstudiante.Value != DBNull.Value) ? Convert.ToInt32(paramNuevoIdEstudiante.Value) : 0;
            int nuevoIdMatricula = (paramNuevoIdMatricula.Value != DBNull.Value) ? Convert.ToInt32(paramNuevoIdMatricula.Value) : 0;

            return (nuevoIdEstudiante, nuevoIdMatricula);
        }
    }
}
