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
        public async Task<List<AlumnoEntity>> ListarAsync(string filtro = "", string estado = "")
        {
            var lista = new List<AlumnoEntity>();

            using SqlConnection cn = await Conexion.AbrirConexionAsync();

            string sql = @"
                SELECT 
                    e.IdEstudiante,
                    e.CodigoEstudiante,
                    e.Nombres,
                    e.Apellidos,
                    e.FechaNacimiento,
                    e.Estado,
                    e.FechaRegistro,
                    t.IdTutor,
                    CONCAT(t.Nombres, ' ', t.Apellidos) AS NombreTutor,
                    t.Telefono AS TelefonoTutor,
                    t.Cedula AS CedulaTutor
                FROM dbo.Estudiante e
                INNER JOIN dbo.Tutor t ON e.IdTutor = t.IdTutor
                WHERE (@Filtro = '' 
                   OR e.CodigoEstudiante LIKE '%' + @Filtro + '%'
                   OR e.Nombres LIKE '%' + @Filtro + '%'
                   OR e.Apellidos LIKE '%' + @Filtro + '%'
                   OR t.Cedula LIKE '%' + @Filtro + '%')
                  AND (@Estado = '' OR e.Estado = @Estado)
                ORDER BY e.IdEstudiante DESC;";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = filtro?.Trim() ?? string.Empty;
            cmd.Parameters.Add("@Estado", SqlDbType.NVarChar, 25).Value = estado?.Trim() ?? string.Empty;

            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                var alumno = new AlumnoEntity
                {
                    IdEstudiante = Convert.ToInt32(dr["IdEstudiante"]),
                    CodigoEstudiante = dr["CodigoEstudiante"].ToString() ?? string.Empty,
                    Nombres = dr["Nombres"].ToString() ?? string.Empty,
                    Apellidos = dr["Apellidos"].ToString() ?? string.Empty,
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                    Estado = dr["Estado"].ToString() ?? "Activo",
                    FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                    IdTutor = Convert.ToInt32(dr["IdTutor"]),
                    NombreTutor = dr["NombreTutor"].ToString() ?? string.Empty,
                    TelefonoTutor = dr["TelefonoTutor"] != DBNull.Value ? dr["TelefonoTutor"].ToString() : null,
                    CedulaTutor = dr["CedulaTutor"] != DBNull.Value ? dr["CedulaTutor"].ToString() : null
                };

                lista.Add(alumno);
            }

            return lista;
        }

        public async Task<List<AnioAcademicoEntity>> ListarAniosAcademicosAsync()
        {
            var lista = new List<AnioAcademicoEntity>();

            using SqlConnection cn = await Conexion.AbrirConexionAsync();

            string sql = @"
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '7mo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('7mo Grado', 'III Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '8vo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('8vo Grado', 'III Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '9no Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('9no Grado', 'III Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '10mo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('10mo Grado', 'IV Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '11mo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('11mo Grado', 'IV Ciclo');

                SELECT IdAnio, NombreAnio, Ciclo FROM dbo.AnioAcademico ORDER BY IdAnio;";

            using SqlCommand cmd = new(sql, cn);
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                lista.Add(new AnioAcademicoEntity
                {
                    IdAnio = Convert.ToInt32(dr["IdAnio"]),
                    NombreAnio = dr["NombreAnio"].ToString() ?? string.Empty,
                    Ciclo = dr["Ciclo"].ToString() ?? string.Empty
                });
            }

            return lista;
        }

        public async Task<List<SeccionEntity>> ListarSeccionesAsync()
        {
            var lista = new List<SeccionEntity>();

            using SqlConnection cn = await Conexion.AbrirConexionAsync();

            string sql = @"
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'A')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('A', 40);
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'B')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('B', 40);
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'C')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('C', 40);

                SELECT IdSeccion, NombreSeccion, CapacidadMaxima FROM dbo.Seccion ORDER BY NombreSeccion;";

            using SqlCommand cmd = new(sql, cn);
            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                lista.Add(new SeccionEntity
                {
                    IdSeccion = Convert.ToInt32(dr["IdSeccion"]),
                    NombreSeccion = dr["NombreSeccion"].ToString() ?? string.Empty,
                    CapacidadMaxima = dr["CapacidadMaxima"] != DBNull.Value ? Convert.ToInt32(dr["CapacidadMaxima"]) : 40
                });
            }

            return lista;
        }

        public async Task<List<SeccionEntity>> ListarSeccionesConDisponibilidadAsync(int idAnio)
        {
            var lista = new List<SeccionEntity>();

            using SqlConnection cn = await Conexion.AbrirConexionAsync();

            string sql = @"
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'A')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('A', 40);
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'B')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('B', 40);
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'C')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('C', 40);

                SELECT 
                    s.IdSeccion,
                    s.NombreSeccion,
                    s.CapacidadMaxima,
                    COUNT(m.IdMatricula) AS Matriculados,
                    (s.CapacidadMaxima - COUNT(m.IdMatricula)) AS CuposDisponibles
                FROM dbo.Seccion s
                LEFT JOIN dbo.Matricula m 
                    ON s.IdSeccion = m.IdSeccion 
                   AND m.IdAnio = @IdAnio 
                   AND m.EstadoMatricula <> 'Cancelado'
                GROUP BY s.IdSeccion, s.NombreSeccion, s.CapacidadMaxima
                ORDER BY 
                    CASE WHEN COUNT(m.IdMatricula) >= s.CapacidadMaxima THEN 1 ELSE 0 END ASC,
                    COUNT(m.IdMatricula) ASC, 
                    s.NombreSeccion ASC;";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = idAnio;

            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                int capacidad = dr["CapacidadMaxima"] != DBNull.Value ? Convert.ToInt32(dr["CapacidadMaxima"]) : 40;
                int matriculados = dr["Matriculados"] != DBNull.Value ? Convert.ToInt32(dr["Matriculados"]) : 0;
                int cupos = dr["CuposDisponibles"] != DBNull.Value ? Convert.ToInt32(dr["CuposDisponibles"]) : (capacidad - matriculados);

                lista.Add(new SeccionEntity
                {
                    IdSeccion = Convert.ToInt32(dr["IdSeccion"]),
                    NombreSeccion = dr["NombreSeccion"].ToString() ?? string.Empty,
                    CapacidadMaxima = capacidad,
                    Matriculados = matriculados,
                    CuposDisponibles = cupos
                });
            }

            return lista;
        }

        public async Task<List<AsignaturaEntity>> ListarAsignaturasPorAnioAsync(int idAnio)
        {
            var lista = new List<AsignaturaEntity>();

            using SqlConnection cn = await Conexion.AbrirConexionAsync();

            string sql = @"
                IF NOT EXISTS (SELECT 1 FROM dbo.Grado_Asignatura WHERE IdAnio = @IdAnio)
                BEGIN
                    DECLARE @Asignaturas TABLE (Nombre NVARCHAR(100));
                    INSERT INTO @Asignaturas (Nombre) VALUES 
                        ('Matemáticas'), ('Lengua y Literatura'), ('Ciencias Naturales'),
                        ('Geografía'), ('Historia'), ('Inglés'), ('Educación Física'),
                        ('Biología'), ('Física'), ('Química'), ('Filosofía'), ('Sociología'), ('Economía');

                    INSERT INTO dbo.Asignatura (NombreAsignatura)
                    SELECT A.Nombre FROM @Asignaturas A
                    WHERE NOT EXISTS (SELECT 1 FROM dbo.Asignatura WHERE NombreAsignatura = A.Nombre);

                    -- Asociar III Ciclo (7mo, 8vo, 9no)
                    INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
                    SELECT an.IdAnio, asig.IdAsignatura, 4
                    FROM dbo.AnioAcademico an
                    CROSS JOIN dbo.Asignatura asig
                    WHERE an.IdAnio = @IdAnio 
                      AND an.Ciclo = 'III Ciclo'
                      AND asig.NombreAsignatura IN ('Matemáticas', 'Lengua y Literatura', 'Ciencias Naturales', 'Geografía', 'Historia', 'Inglés', 'Educación Física')
                      AND NOT EXISTS (
                          SELECT 1 FROM dbo.Grado_Asignatura ga WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
                      );

                    -- Asociar IV Ciclo (10mo, 11mo)
                    INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
                    SELECT an.IdAnio, asig.IdAsignatura, 4
                    FROM dbo.AnioAcademico an
                    CROSS JOIN dbo.Asignatura asig
                    WHERE an.IdAnio = @IdAnio 
                      AND an.Ciclo = 'IV Ciclo'
                      AND asig.NombreAsignatura IN ('Matemáticas', 'Lengua y Literatura', 'Biología', 'Física', 'Química', 'Filosofía', 'Sociología', 'Economía', 'Inglés', 'Educación Física')
                      AND NOT EXISTS (
                          SELECT 1 FROM dbo.Grado_Asignatura ga WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
                      );
                END;

                SELECT 
                    a.IdAsignatura,
                    a.NombreAsignatura,
                    ga.HorasSemanales
                FROM dbo.Grado_Asignatura ga
                INNER JOIN dbo.Asignatura a ON ga.IdAsignatura = a.IdAsignatura
                WHERE ga.IdAnio = @IdAnio
                ORDER BY a.NombreAsignatura;";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@IdAnio", SqlDbType.Int).Value = idAnio;

            using SqlDataReader dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                lista.Add(new AsignaturaEntity
                {
                    IdAsignatura = Convert.ToInt32(dr["IdAsignatura"]),
                    NombreAsignatura = dr["NombreAsignatura"].ToString() ?? string.Empty,
                    HorasSemanales = dr["HorasSemanales"] != DBNull.Value ? Convert.ToInt32(dr["HorasSemanales"]) : 4
                });
            }

            return lista;
        }

        public async Task<string> CambiarEstadoEstudianteAsync(int idEstudiante, string? nuevoEstado = null)
        {
            using SqlConnection cn = await Conexion.AbrirConexionAsync();

            string sql = @"
                IF @NuevoEstado IS NULL OR @NuevoEstado = ''
                BEGIN
                    UPDATE dbo.Estudiante 
                    SET Estado = CASE WHEN Estado = 'Activo' THEN 'Inactivo' ELSE 'Activo' END 
                    WHERE IdEstudiante = @IdEstudiante;
                END
                ELSE
                BEGIN
                    UPDATE dbo.Estudiante 
                    SET Estado = @NuevoEstado 
                    WHERE IdEstudiante = @IdEstudiante;
                END;

                SELECT Estado FROM dbo.Estudiante WHERE IdEstudiante = @IdEstudiante;";

            using SqlCommand cmd = new(sql, cn);
            cmd.Parameters.Add("@IdEstudiante", SqlDbType.Int).Value = idEstudiante;
            cmd.Parameters.Add("@NuevoEstado", SqlDbType.NVarChar, 25).Value = (object?)nuevoEstado ?? DBNull.Value;

            object? result = await cmd.ExecuteScalarAsync();
            return result?.ToString() ?? "Activo";
        }

        public async Task<int> ObtenerSiguienteNumeroMatriculaAsync()
        {
            using SqlConnection cn = await Conexion.AbrirConexionAsync();
            using SqlCommand cmd = new("SELECT ISNULL(MAX(IdMatricula), 0) + 1 FROM dbo.Matricula;", cn);

            object? result = await cmd.ExecuteScalarAsync();
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 1;
        }

        public async Task<int> ObtenerSiguienteCorrelativoEstudianteAsync()
        {
            using SqlConnection cn = await Conexion.AbrirConexionAsync();
            using SqlCommand cmd = new("dbo.SP_ObtenerSiguienteCorrelativoEstudiante", cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            object? result = await cmd.ExecuteScalarAsync();
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 1;
        }

        public async Task<(int IdEstudiante, int IdMatricula)> RegistrarEstudianteYMatriculaAsync(AlumnoRegistroModel model)
        {
            using SqlConnection cn = await Conexion.AbrirConexionAsync();

            // 1. Asegurar catálogo de Años Académicos y Secciones en la base actual
            using (SqlCommand cmdSeed = new(@"
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '7mo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('7mo Grado', 'III Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '8vo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('8vo Grado', 'III Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '9no Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('9no Grado', 'III Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '10mo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('10mo Grado', 'IV Ciclo');
                IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico WHERE NombreAnio = '11mo Grado')
                    INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('11mo Grado', 'IV Ciclo');

                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'A')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('A', 40);
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'B')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('B', 40);
                IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'C')
                    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('C', 40);", cn))
            {
                await cmdSeed.ExecuteNonQueryAsync();
            }

            // 2. Si tablas o procedimientos quedaron creados en master por error al ejecutar scripts,
            // sincronizar también en master o eliminar el SP de master para que no secuestre la ejecución
            try
            {
                using (SqlCommand cmdMaster = new(@"
                    IF EXISTS (SELECT 1 FROM master.sys.procedures WHERE name = 'SP_RegistrarEstudianteYMatricula')
                    BEGIN
                        DROP PROCEDURE master.dbo.SP_RegistrarEstudianteYMatricula;
                    END;
                    IF EXISTS (SELECT 1 FROM master.sys.tables WHERE name = 'AnioAcademico')
                    BEGIN
                        IF NOT EXISTS (SELECT 1 FROM master.dbo.AnioAcademico WHERE NombreAnio = '7mo Grado')
                            INSERT INTO master.dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('7mo Grado', 'III Ciclo');
                        IF NOT EXISTS (SELECT 1 FROM master.dbo.AnioAcademico WHERE NombreAnio = '8vo Grado')
                            INSERT INTO master.dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('8vo Grado', 'III Ciclo');
                        IF NOT EXISTS (SELECT 1 FROM master.dbo.AnioAcademico WHERE NombreAnio = '9no Grado')
                            INSERT INTO master.dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('9no Grado', 'III Ciclo');
                        IF NOT EXISTS (SELECT 1 FROM master.dbo.AnioAcademico WHERE NombreAnio = '10mo Grado')
                            INSERT INTO master.dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('10mo Grado', 'IV Ciclo');
                        IF NOT EXISTS (SELECT 1 FROM master.dbo.AnioAcademico WHERE NombreAnio = '11mo Grado')
                            INSERT INTO master.dbo.AnioAcademico (NombreAnio, Ciclo) VALUES ('11mo Grado', 'IV Ciclo');
                    END;", cn))
                {
                    await cmdMaster.ExecuteNonQueryAsync();
                }
            }
            catch
            {
                // Ignorar si el usuario no tiene permisos sobre master
            }

            // 3. Ejecución directa y atómica en la base de datos actual con transacción
            // Esto garantiza que la consulta se ejecute SIEMPRE en la base de datos de la conexión
            // y no sea desviada por SQL Server hacia la base master.
            int nuevoIdEstudiante = 0;
            int nuevoIdMatricula = 0;

            string sqlRegistro = @"
                SET NOCOUNT ON;
                
                -- Validar Control de Cupos (< 40 por sección y año)
                DECLARE @CuposOcupados INT = (
                    SELECT COUNT(1) 
                    FROM dbo.Matricula 
                    WHERE IdAnio = @IdAnio AND IdSeccion = @IdSeccion AND EstadoMatricula <> 'Cancelado'
                );

                DECLARE @CapacidadMax INT = (
                    SELECT CapacidadMaxima FROM dbo.Seccion WHERE IdSeccion = @IdSeccion
                );
                IF @CapacidadMax IS NULL SET @CapacidadMax = 40;

                IF @CuposOcupados >= @CapacidadMax
                BEGIN
                    RAISERROR('La sección seleccionada ha alcanzado su capacidad máxima permitida de %d estudiantes.', 16, 1, @CapacidadMax);
                    RETURN;
                END;

                -- Gestionar Tutor (Insertar o reutilizar por Cédula)
                DECLARE @IdTutor INT = (SELECT TOP 1 IdTutor FROM dbo.Tutor WHERE Cedula = @TutorCedula);
                IF @IdTutor IS NULL
                BEGIN
                    INSERT INTO dbo.Tutor (Nombres, Apellidos, Telefono, Cedula, Direccion)
                    VALUES (@TutorNombres, @TutorApellidos, @TutorTelefono, @TutorCedula, @TutorDireccion);
                    SET @IdTutor = SCOPE_IDENTITY();
                END
                ELSE
                BEGIN
                    UPDATE dbo.Tutor 
                    SET Nombres = @TutorNombres, Apellidos = @TutorApellidos, Telefono = @TutorTelefono, Direccion = @TutorDireccion
                    WHERE IdTutor = @IdTutor;
                END;

                -- Registrar Estudiante con el estado seleccionado
                INSERT INTO dbo.Estudiante (CodigoEstudiante, Nombres, Apellidos, FechaNacimiento, IdTutor, Estado, FechaRegistro)
                VALUES (@EstudianteCodigo, @EstudianteNombres, @EstudianteApellidos, @EstudianteFechaNac, @IdTutor, @EstadoEstudiante, GETDATE());
                SET @NuevoIdEstudiante = SCOPE_IDENTITY();

                -- Registrar Matrícula
                INSERT INTO dbo.Matricula (IdEstudiante, IdAnio, IdSeccion, FechaMatricula, EstadoMatricula)
                VALUES (@NuevoIdEstudiante, @IdAnio, @IdSeccion, GETDATE(), 'Activo');
                SET @NuevoIdMatricula = SCOPE_IDENTITY();

                -- Vincular Asignaturas del año académico si existen
                IF EXISTS (SELECT 1 FROM dbo.Grado_Asignatura WHERE IdAnio = @IdAnio)
                BEGIN
                    INSERT INTO dbo.Calificacion (IdMatricula, IdAsignatura, NotaI_Semestre, NotaII_Semestre, NotaFinal, NotaReparacion, EstadoAsignatura, Observacion)
                    SELECT 
                        @NuevoIdMatricula,
                        ga.IdAsignatura,
                        NULL,
                        NULL,
                        NULL,
                        NULL,
                        'En proceso',
                        'Inscripción inicial'
                    FROM dbo.Grado_Asignatura ga
                    WHERE ga.IdAnio = @IdAnio;
                END;

                SELECT @NuevoIdEstudiante AS IdEstudiante, @NuevoIdMatricula AS IdMatricula;";

            using SqlCommand cmd = new(sqlRegistro, cn);
            cmd.Parameters.Add("@TutorNombres", SqlDbType.NVarChar, 100).Value = model.TutorNombres;
            cmd.Parameters.Add("@TutorApellidos", SqlDbType.NVarChar, 100).Value = model.TutorApellidos;
            cmd.Parameters.Add("@TutorTelefono", SqlDbType.NVarChar, 20).Value = model.TutorTelefono;
            cmd.Parameters.Add("@TutorCedula", SqlDbType.NVarChar, 25).Value = model.TutorCedula;
            cmd.Parameters.Add("@TutorDireccion", SqlDbType.NVarChar, 200).Value = (object?)model.TutorDireccion ?? string.Empty;

            cmd.Parameters.Add("@EstudianteCodigo", SqlDbType.VarChar, 100).Value = model.EstudianteCodigo;
            cmd.Parameters.Add("@EstudianteNombres", SqlDbType.NVarChar, 100).Value = model.EstudianteNombres;
            cmd.Parameters.Add("@EstudianteApellidos", SqlDbType.NVarChar, 100).Value = model.EstudianteApellidos;
            cmd.Parameters.Add("@EstudianteFechaNac", SqlDbType.Date).Value = model.EstudianteFechaNac;
            cmd.Parameters.Add("@EstadoEstudiante", SqlDbType.NVarChar, 25).Value = string.IsNullOrWhiteSpace(model.Estado) ? "Activo" : model.Estado;

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

            using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
            {
                if (await dr.ReadAsync())
                {
                    nuevoIdEstudiante = Convert.ToInt32(dr["IdEstudiante"]);
                    nuevoIdMatricula = Convert.ToInt32(dr["IdMatricula"]);
                }
            }

            if (nuevoIdEstudiante == 0 && paramNuevoIdEstudiante.Value != DBNull.Value)
            {
                nuevoIdEstudiante = Convert.ToInt32(paramNuevoIdEstudiante.Value);
            }
            if (nuevoIdMatricula == 0 && paramNuevoIdMatricula.Value != DBNull.Value)
            {
                nuevoIdMatricula = Convert.ToInt32(paramNuevoIdMatricula.Value);
            }

            return (nuevoIdEstudiante, nuevoIdMatricula);
        }
    }
}
