

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'DB_GestionAcademica')
BEGIN
    CREATE DATABASE DB_GestionAcademica;
END
GO

USE DB_GestionAcademica;
GO


-- 1. TABLAS DEL SISTEMA EN TERCERA FORMA NORMAL (3FN)


-- 1.1 Tabla: Rol
IF OBJECT_ID('dbo.Rol', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Rol (
        IdRol INT IDENTITY(1,1) PRIMARY KEY,
        NombreRol NVARCHAR(50) NOT NULL UNIQUE
    );
END
GO

-- 1.2 Tabla: Usuario
IF OBJECT_ID('dbo.Usuario', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Usuario (
        IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
        IdRol INT NOT NULL FOREIGN KEY REFERENCES dbo.Rol(IdRol),
        NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
        Clave NVARCHAR(256) NOT NULL,
        NombreCompleto NVARCHAR(150) NOT NULL,
        Estado NVARCHAR(20) NOT NULL DEFAULT 'Activo'
    );
END
GO

-- 1.3 Tabla: AnioAcademico (7mo a 11mo grado)
IF OBJECT_ID('dbo.AnioAcademico', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.AnioAcademico (
        IdAnio INT IDENTITY(1,1) PRIMARY KEY,
        NombreAnio NVARCHAR(50) NOT NULL UNIQUE,
        Ciclo NVARCHAR(20) NOT NULL -- 'III Ciclo', 'IV Ciclo'
    );
END
GO

-- 1.4 Tabla: Seccion (Capacidad maxima 40)
IF OBJECT_ID('dbo.Seccion', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Seccion (
        IdSeccion INT IDENTITY(1,1) PRIMARY KEY,
        NombreSeccion NVARCHAR(10) NOT NULL UNIQUE,
        CapacidadMaxima INT NOT NULL DEFAULT 40
    );
END
GO

-- 1.5 Tabla: Docente
IF OBJECT_ID('dbo.Docente', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Docente (
        IdDocente INT IDENTITY(1,1) PRIMARY KEY,
        Nombres NVARCHAR(100) NOT NULL,
        Apellidos NVARCHAR(100) NOT NULL,
        Cedula NVARCHAR(25) NOT NULL UNIQUE,
        Telefono NVARCHAR(20) NULL,
        Correo NVARCHAR(100) NULL,
        Especialidad NVARCHAR(100) NULL,
        Estado NVARCHAR(20) NOT NULL DEFAULT 'Activo'
    );
END
GO

-- 1.6 Tabla Intermedia 3FN: Aula_Seccion (Vincula Anio, Seccion, Aula y Docente Guia)
IF OBJECT_ID('dbo.Aula_Seccion', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Aula_Seccion (
        IdAulaSeccion INT IDENTITY(1,1) PRIMARY KEY,
        IdAnio INT NOT NULL FOREIGN KEY REFERENCES dbo.AnioAcademico(IdAnio),
        IdSeccion INT NOT NULL FOREIGN KEY REFERENCES dbo.Seccion(IdSeccion),
        IdDocenteGuia INT NULL FOREIGN KEY REFERENCES dbo.Docente(IdDocente),
        Aula NVARCHAR(50) NOT NULL,
        CONSTRAINT UQ_Anio_Seccion UNIQUE (IdAnio, IdSeccion)
    );
END
GO

-- 1.7 Tabla: Tutor
IF OBJECT_ID('dbo.Tutor', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tutor (
        IdTutor INT IDENTITY(1,1) PRIMARY KEY,
        Nombres NVARCHAR(100) NOT NULL,
        Apellidos NVARCHAR(100) NOT NULL,
        Telefono NVARCHAR(20) NOT NULL,
        Cedula NVARCHAR(25) NOT NULL UNIQUE,
        Direccion NVARCHAR(200) NULL
    );
END
GO

-- 1.8 Tabla: Estudiante
IF OBJECT_ID('dbo.Estudiante', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Estudiante (
        IdEstudiante INT IDENTITY(1,1) PRIMARY KEY,
        CodigoEstudiante VARCHAR(100) NOT NULL UNIQUE,
        Nombres NVARCHAR(100) NOT NULL,
        Apellidos NVARCHAR(100) NOT NULL,
        FechaNacimiento DATE NOT NULL,
        IdTutor INT NOT NULL FOREIGN KEY REFERENCES dbo.Tutor(IdTutor),
        Estado NVARCHAR(25) NOT NULL DEFAULT 'Activo',
        FechaRegistro DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

-- 1.9 Tabla: Asignatura (3FN Estricta: Ãšnicamente Id y Nombre)
IF OBJECT_ID('dbo.Asignatura', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Asignatura (
        IdAsignatura INT IDENTITY(1,1) PRIMARY KEY,
        NombreAsignatura NVARCHAR(100) NOT NULL UNIQUE
    );
END
GO

-- 1.10 Tabla Intermedia 3FN: Grado_Asignatura (Malla Curricular por Grado)
IF OBJECT_ID('dbo.Grado_Asignatura', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Grado_Asignatura (
        IdGradoAsignatura INT IDENTITY(1,1) PRIMARY KEY,
        IdAnio INT NOT NULL FOREIGN KEY REFERENCES dbo.AnioAcademico(IdAnio),
        IdAsignatura INT NOT NULL FOREIGN KEY REFERENCES dbo.Asignatura(IdAsignatura),
        HorasSemanales INT NOT NULL DEFAULT 4,
        CONSTRAINT UQ_Grado_Asignatura UNIQUE (IdAnio, IdAsignatura)
    );
END
GO

-- 1.11 Tabla Intermedia 3FN: Docente_Asignatura (Carga horaria sin traslapes)
IF OBJECT_ID('dbo.Docente_Asignatura', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Docente_Asignatura (
        IdDocenteAsignatura INT IDENTITY(1,1) PRIMARY KEY,
        IdDocente INT NOT NULL FOREIGN KEY REFERENCES dbo.Docente(IdDocente),
        IdAsignatura INT NOT NULL FOREIGN KEY REFERENCES dbo.Asignatura(IdAsignatura),
        IdAnio INT NOT NULL FOREIGN KEY REFERENCES dbo.AnioAcademico(IdAnio),
        IdSeccion INT NOT NULL FOREIGN KEY REFERENCES dbo.Seccion(IdSeccion),
        CONSTRAINT UQ_Docente_Carga UNIQUE (IdAsignatura, IdAnio, IdSeccion)
    );
END
GO

-- 1.12 Tabla: Matricula (Control de Cupos < 40)
IF OBJECT_ID('dbo.Matricula', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Matricula (
        IdMatricula INT IDENTITY(1,1) PRIMARY KEY,
        IdEstudiante INT NOT NULL FOREIGN KEY REFERENCES dbo.Estudiante(IdEstudiante),
        IdAnio INT NOT NULL FOREIGN KEY REFERENCES dbo.AnioAcademico(IdAnio),
        IdSeccion INT NOT NULL FOREIGN KEY REFERENCES dbo.Seccion(IdSeccion),
        FechaMatricula DATETIME NOT NULL DEFAULT GETDATE(),
        EstadoMatricula NVARCHAR(30) NOT NULL DEFAULT 'Activo',
        CONSTRAINT UQ_Estudiante_Anio UNIQUE (IdEstudiante, IdAnio)
    );
END
GO

-- 1.13 Tabla: Calificacion
IF OBJECT_ID('dbo.Calificacion', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Calificacion (
        IdCalificacion INT IDENTITY(1,1) PRIMARY KEY,
        IdMatricula INT NOT NULL FOREIGN KEY REFERENCES dbo.Matricula(IdMatricula),
        IdAsignatura INT NOT NULL FOREIGN KEY REFERENCES dbo.Asignatura(IdAsignatura),
        NotaI_Semestre DECIMAL(5,2) NULL,
        NotaII_Semestre DECIMAL(5,2) NULL,
        NotaFinal DECIMAL(5,2) NULL,
        NotaReparacion DECIMAL(5,2) NULL,
        EstadoAsignatura NVARCHAR(30) NOT NULL DEFAULT 'En proceso',
        Observacion NVARCHAR(200) NULL,
        CONSTRAINT UQ_Matricula_Asignatura UNIQUE (IdMatricula, IdAsignatura)
    );
END
GO

-- 2. PROCEDIMIENTOS ALMACENADOS 

-- 2.1 SP_CrearAdministradorInicial (Sembrado y credenciales iniciales)
CREATE PROCEDURE dbo.SP_CrearAdministradorInicial
    @ClaveEncriptada NVARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Insertar Roles
        IF NOT EXISTS (SELECT 1 FROM dbo.Rol WHERE NombreRol = 'Administrador')
            INSERT INTO dbo.Rol (NombreRol) VALUES ('Administrador');

        IF NOT EXISTS (SELECT 1 FROM dbo.Rol WHERE NombreRol = 'Docente')
            INSERT INTO dbo.Rol (NombreRol) VALUES ('Docente');

        IF NOT EXISTS (SELECT 1 FROM dbo.Rol WHERE NombreRol = 'Secretario')
            INSERT INTO dbo.Rol (NombreRol) VALUES ('Secretario');

        -- Insertar Usuario Admin inicial
        DECLARE @IdRolAdmin INT = (SELECT IdRol FROM dbo.Rol WHERE NombreRol = 'Administrador');

        IF NOT EXISTS (SELECT 1 FROM dbo.Usuario WHERE NombreUsuario = 'admin')
        BEGIN
            INSERT INTO dbo.Usuario (IdRol, NombreUsuario, Clave, NombreCompleto, Estado)
            VALUES (@IdRolAdmin, 'admin', @ClaveEncriptada, 'Administrador del Sistema', 'Activo');
        END

        -- Sembrar AÃ±os AcadÃ©micos
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

        -- Sembrar Secciones
        IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'A')
            INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('A', 40);
        IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'B')
            INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('B', 40);
        IF NOT EXISTS (SELECT 1 FROM dbo.Seccion WHERE NombreSeccion = 'C')
            INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('C', 40);

        -- Sembrar Asignaturas (III y IV Ciclo)
        DECLARE @Asignaturas TABLE (Nombre NVARCHAR(100));
        INSERT INTO @Asignaturas (Nombre) VALUES 
            ('MatemÃ¡ticas'),
            ('Lengua y Literatura'),
            ('Ciencias Naturales'),
            ('GeografÃ­a'),
            ('Historia'),
            ('InglÃ©s'),
            ('EducaciÃ³n FÃ­sica'),
            ('BiologÃ­a'),
            ('FÃ­sica'),
            ('QuÃ­mica'),
            ('FilosofÃ­a'),
            ('SociologÃ­a'),
            ('EconomÃ­a');

        INSERT INTO dbo.Asignatura (NombreAsignatura)
        SELECT A.Nombre FROM @Asignaturas A
        WHERE NOT EXISTS (SELECT 1 FROM dbo.Asignatura WHERE NombreAsignatura = A.Nombre);

        -- Asociar Malla Curricular DinÃ¡mica
        -- III Ciclo: 7mo, 8vo, 9no
        INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
        SELECT an.IdAnio, asig.IdAsignatura, 4
        FROM dbo.AnioAcademico an
        CROSS JOIN dbo.Asignatura asig
        WHERE an.Ciclo = 'III Ciclo'
          AND asig.NombreAsignatura IN ('MatemÃ¡ticas', 'Lengua y Literatura', 'Ciencias Naturales', 'GeografÃ­a', 'Historia', 'InglÃ©s', 'EducaciÃ³n FÃ­sica')
          AND NOT EXISTS (
              SELECT 1 FROM dbo.Grado_Asignatura ga 
              WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
          );

        -- IV Ciclo: 10mo, 11mo
        INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
        SELECT an.IdAnio, asig.IdAsignatura, 4
        FROM dbo.AnioAcademico an
        CROSS JOIN dbo.Asignatura asig
        WHERE an.Ciclo = 'IV Ciclo'
          AND asig.NombreAsignatura IN ('MatemÃ¡ticas', 'Lengua y Literatura', 'BiologÃ­a', 'FÃ­sica', 'QuÃ­mica', 'FilosofÃ­a', 'SociologÃ­a', 'EconomÃ­a', 'InglÃ©s', 'EducaciÃ³n FÃ­sica')
          AND NOT EXISTS (
              SELECT 1 FROM dbo.Grado_Asignatura ga 
              WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
          );

        COMMIT TRANSACTION;
        SELECT 1 AS Resultado, 'Administrador y catÃ¡logos inicializados correctamente' AS Mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 2.2 SP_RegistrarEstudianteYMatricula (Transacción Atómica y Control de Cupo < 40)
CREATE OR ALTER PROCEDURE dbo.SP_RegistrarEstudianteYMatricula
    @TutorNombres NVARCHAR(100),
    @TutorApellidos NVARCHAR(100),
    @TutorTelefono NVARCHAR(20),
    @TutorCedula NVARCHAR(25),
    @TutorDireccion NVARCHAR(200) = '',
    @EstudianteCodigo VARCHAR(100),
    @EstudianteNombres NVARCHAR(100),
    @EstudianteApellidos NVARCHAR(100),
    @EstudianteFechaNac DATE,
    @IdAnio INT,
    @IdSeccion INT,
    @NuevoIdEstudiante INT OUTPUT,
    @NuevoIdMatricula INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- 1. Validar Control de Cupos (< 40 por sección y año)
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
        END

        -- 2. Gestionar Tutor (Insertar o reutilizar por Cédula)
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
        END

        -- 3. Registrar Estudiante
        INSERT INTO dbo.Estudiante (CodigoEstudiante, Nombres, Apellidos, FechaNacimiento, IdTutor, Estado, FechaRegistro)
        VALUES (@EstudianteCodigo, @EstudianteNombres, @EstudianteApellidos, @EstudianteFechaNac, @IdTutor, 'Activo', GETDATE());
        SET @NuevoIdEstudiante = SCOPE_IDENTITY();

        -- 4. Registrar Matrícula
        INSERT INTO dbo.Matricula (IdEstudiante, IdAnio, IdSeccion, FechaMatricula, EstadoMatricula)
        VALUES (@NuevoIdEstudiante, @IdAnio, @IdSeccion, GETDATE(), 'Activo');
        SET @NuevoIdMatricula = SCOPE_IDENTITY();

        -- 5. Inicializar Registro de Calificaciones en base a la Malla Curricular del Año
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

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 2.3 SP_GuardarDocenteConAsignaturas (Garantiza no traslapes por secciÃ³n)
CREATE PROCEDURE dbo.SP_GuardarDocenteConAsignaturas
    @IdDocente INT = 0,
    @Nombres NVARCHAR(100),
    @Apellidos NVARCHAR(100),
    @Cedula NVARCHAR(25),
    @Telefono NVARCHAR(20),
    @Correo NVARCHAR(100),
    @Especialidad NVARCHAR(100),
    @NuevoIdDocente INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        IF @IdDocente <= 0
        BEGIN
            IF EXISTS (SELECT 1 FROM dbo.Docente WHERE Cedula = @Cedula)
            BEGIN
                RAISERROR('Ya existe un docente registrado con el nÃºmero de cÃ©dula proporcionado.', 16, 1);
            END

            INSERT INTO dbo.Docente (Nombres, Apellidos, Cedula, Telefono, Correo, Especialidad, Estado)
            VALUES (@Nombres, @Apellidos, @Cedula, @Telefono, @Correo, @Especialidad, 'Activo');
            SET @NuevoIdDocente = SCOPE_IDENTITY();
        END
        ELSE
        BEGIN
            UPDATE dbo.Docente
            SET Nombres = @Nombres,
                Apellidos = @Apellidos,
                Cedula = @Cedula,
                Telefono = @Telefono,
                Correo = @Correo,
                Especialidad = @Especialidad
            WHERE IdDocente = @IdDocente;
            SET @NuevoIdDocente = @IdDocente;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 2.3.1 SP_AsignarCargaDocente (Evita traslape de la asignatura en el grado y secciÃ³n)
CREATE PROCEDURE dbo.SP_AsignarCargaDocente
    @IdDocente INT,
    @IdAsignatura INT,
    @IdAnio INT,
    @IdSeccion INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Validar si la asignatura en esa secciÃ³n ya estÃ¡ asignada a otro docente
        IF EXISTS (
            SELECT 1 FROM dbo.Docente_Asignatura 
            WHERE IdAsignatura = @IdAsignatura 
              AND IdAnio = @IdAnio 
              AND IdSeccion = @IdSeccion 
              AND IdDocente <> @IdDocente
        )
        BEGIN
            RAISERROR('La asignatura seleccionada en este grado y secciÃ³n ya estÃ¡ asignada a otro docente.', 16, 1);
        END

        IF EXISTS (
            SELECT 1 FROM dbo.Docente_Asignatura 
            WHERE IdAsignatura = @IdAsignatura 
              AND IdAnio = @IdAnio 
              AND IdSeccion = @IdSeccion 
              AND IdDocente = @IdDocente
        )
        BEGIN
            -- Ya asignado al mismo docente
            COMMIT TRANSACTION;
            RETURN;
        END

        INSERT INTO dbo.Docente_Asignatura (IdDocente, IdAsignatura, IdAnio, IdSeccion)
        VALUES (@IdDocente, @IdAsignatura, @IdAnio, @IdSeccion);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 2.4 SP_GuardarCalificacionEstudiante
CREATE PROCEDURE dbo.SP_GuardarCalificacionEstudiante
    @IdCalificacion INT,
    @NotaI_Semestre DECIMAL(5,2) = NULL,
    @NotaII_Semestre DECIMAL(5,2) = NULL,
    @NotaReparacion DECIMAL(5,2) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @NotaFinal DECIMAL(5,2) = NULL;
        DECLARE @EstadoAsignatura NVARCHAR(30) = 'En proceso';
        DECLARE @Observacion NVARCHAR(200) = '';

        -- Si ambas notas semestrales estÃ¡n presentes
        IF @NotaI_Semestre IS NOT NULL AND @NotaII_Semestre IS NOT NULL
        BEGIN
            -- Semestre I (50%) + Semestre II (50%) = Nota Final
            SET @NotaFinal = ROUND((@NotaI_Semestre * 0.50) + (@NotaII_Semestre * 0.50), 2);

            IF @NotaFinal >= 60.0
            BEGIN
                SET @EstadoAsignatura = 'Aprobada';
                SET @Observacion = 'Aprobada en curso regular';
            END
            ELSE
            BEGIN
                SET @EstadoAsignatura = 'ReparaciÃ³n';
                SET @Observacion = 'Pendiente de examen de reparaciÃ³n';
            END
        END

        -- Si rindiÃ³ examen de reparaciÃ³n
        IF @NotaReparacion IS NOT NULL
        BEGIN
            IF @NotaReparacion >= 60.0
            BEGIN
                SET @EstadoAsignatura = 'Aprobada';
                SET @Observacion = 'Aprobada en Examen de ReparaciÃ³n';
            END
            ELSE
            BEGIN
                SET @EstadoAsignatura = 'Reprobada';
                SET @Observacion = 'Reprobada en Examen de ReparaciÃ³n';
            END
        END

        UPDATE dbo.Calificacion
        SET NotaI_Semestre = @NotaI_Semestre,
            NotaII_Semestre = @NotaII_Semestre,
            NotaFinal = @NotaFinal,
            NotaReparacion = @NotaReparacion,
            EstadoAsignatura = @EstadoAsignatura,
            Observacion = @Observacion
        WHERE IdCalificacion = @IdCalificacion;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 2.5 SP_PromoverEstudiante (Cierre de ciclo, reparaciÃ³n, repite aÃ±o o graduaciÃ³n)
CREATE PROCEDURE dbo.SP_PromoverEstudiante
    @IdMatricula INT,
    @ResultadoPromocion NVARCHAR(50) OUTPUT,
    @MateriasReprobadas INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @IdEstudiante INT;
        DECLARE @IdAnio INT;
        DECLARE @NombreAnio NVARCHAR(50);

        SELECT @IdEstudiante = m.IdEstudiante, @IdAnio = m.IdAnio, @NombreAnio = a.NombreAnio
        FROM dbo.Matricula m
        INNER JOIN dbo.AnioAcademico a ON m.IdAnio = a.IdAnio
        WHERE m.IdMatricula = @IdMatricula;

        -- Contar materias reprobadas definitivas o en reparaciÃ³n
        DECLARE @TotalMaterias INT = (SELECT COUNT(1) FROM dbo.Calificacion WHERE IdMatricula = @IdMatricula);
        DECLARE @MateriasAprobadas INT = (SELECT COUNT(1) FROM dbo.Calificacion WHERE IdMatricula = @IdMatricula AND EstadoAsignatura = 'Aprobada');
        DECLARE @ReprobadasDirectas INT = (SELECT COUNT(1) FROM dbo.Calificacion WHERE IdMatricula = @IdMatricula AND EstadoAsignatura = 'Reprobada');
        DECLARE @EnReparacion INT = (SELECT COUNT(1) FROM dbo.Calificacion WHERE IdMatricula = @IdMatricula AND EstadoAsignatura = 'ReparaciÃ³n');
        DECLARE @Pendientes INT = (SELECT COUNT(1) FROM dbo.Calificacion WHERE IdMatricula = @IdMatricula AND EstadoAsignatura = 'En proceso');

        IF @Pendientes > 0
        BEGIN
            RAISERROR('No se puede promover el estudiante: existen asignaturas con notas en proceso/incompletas.', 16, 1);
        END

        SET @MateriasReprobadas = @ReprobadasDirectas + @EnReparacion;

        IF @MateriasReprobadas = 0
        BEGIN
            -- AprobÃ³ todas las materias
            IF @NombreAnio = '11mo Grado'
            BEGIN
                SET @ResultadoPromocion = 'Estudiante Graduado';
                UPDATE dbo.Matricula SET EstadoMatricula = 'Estudiante Graduado' WHERE IdMatricula = @IdMatricula;
                UPDATE dbo.Estudiante SET Estado = 'Estudiante Graduado' WHERE IdEstudiante = @IdEstudiante;
            END
            ELSE
            BEGIN
                SET @ResultadoPromocion = 'Promovido';
                UPDATE dbo.Matricula SET EstadoMatricula = 'Promovido' WHERE IdMatricula = @IdMatricula;
                UPDATE dbo.Estudiante SET Estado = 'Promovido' WHERE IdEstudiante = @IdEstudiante;
            END
        END
        ELSE IF @MateriasReprobadas IN (1, 2) AND @ReprobadasDirectas = 0
        BEGIN
            -- 1 o 2 materias pendientes pasan a ReparaciÃ³n
            SET @ResultadoPromocion = 'Examen de ReparaciÃ³n';
            UPDATE dbo.Matricula SET EstadoMatricula = 'ReparaciÃ³n' WHERE IdMatricula = @IdMatricula;
        END
        ELSE
        BEGIN
            -- 3 o mÃ¡s reprobadas, o reprobÃ³ examen de reparaciÃ³n
            SET @ResultadoPromocion = 'Repite AÃ±o';
            UPDATE dbo.Matricula SET EstadoMatricula = 'Repite AÃ±o' WHERE IdMatricula = @IdMatricula;
            UPDATE dbo.Estudiante SET Estado = 'Repite AÃ±o' WHERE IdEstudiante = @IdEstudiante;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO


-- 3. PROCEDIMIENTOS ALMACENADOS COMPLEMENTARIOS DE CONSULTA Y GESTIÃ“N


-- 3.1 SP_ValidarLogin
CREATE PROCEDURE dbo.SP_ValidarLogin
    @NombreUsuario NVARCHAR(50),
    @Clave NVARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        u.IdUsuario,
        u.NombreUsuario,
        u.NombreCompleto,
        u.Estado,
        r.IdRol,
        r.NombreRol
    FROM dbo.Usuario u
    INNER JOIN dbo.Rol r ON u.IdRol = r.IdRol
    WHERE u.NombreUsuario = @NombreUsuario AND u.Clave = @Clave AND u.Estado = 'Activo';
END;
GO

-- 3.2 SP_ListarEstudiantes
CREATE OR ALTER PROCEDURE dbo.SP_ListarEstudiantes
    @Filtro NVARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;
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
    ORDER BY e.IdEstudiante DESC;
END;
GO

-- 3.3 SP_ObtenerSiguienteCorrelativoEstudiante
CREATE OR ALTER PROCEDURE dbo.SP_ObtenerSiguienteCorrelativoEstudiante
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ISNULL(MAX(IdEstudiante), 0) + 1 AS SiguienteId FROM dbo.Estudiante;
END;
GO

-- 3.3.1 SP_CambiarEstadoEstudiante
CREATE OR ALTER PROCEDURE dbo.SP_CambiarEstadoEstudiante
    @IdEstudiante INT,
    @NuevoEstado NVARCHAR(25) = NULL
AS
BEGIN
    SET NOCOUNT ON;

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

    SELECT Estado FROM dbo.Estudiante WHERE IdEstudiante = @IdEstudiante;
END;
GO

-- 3.4 SP_ListarMatriculas
CREATE OR ALTER PROCEDURE dbo.SP_ListarMatriculas
    @IdAnio INT = 0,
    @IdSeccion INT = 0,
    @Filtro NVARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;

    WITH UltimaMatricula AS (
        SELECT 
            m.IdMatricula,
            m.IdEstudiante,
            m.IdAnio,
            m.IdSeccion,
            m.FechaMatricula,
            m.EstadoMatricula,
            ROW_NUMBER() OVER (PARTITION BY m.IdEstudiante ORDER BY m.IdMatricula DESC) AS Fila
        FROM dbo.Matricula m
        WHERE m.EstadoMatricula <> 'Cancelado'
    )
    SELECT 
        um.IdMatricula,
        e.IdEstudiante,
        e.CodigoEstudiante,
        CONCAT(e.Nombres, ' ', e.Apellidos) AS NombreEstudiante,
        e.Estado AS EstadoEstudiante,
        an.IdAnio,
        an.NombreAnio,
        an.Ciclo,
        sec.IdSeccion,
        sec.NombreSeccion,
        um.FechaMatricula,
        um.EstadoMatricula,
        ISNULL(CONCAT(doc.Nombres, ' ', doc.Apellidos), 'Sin Docente Guía') AS DocenteGuia,
        ISNULL(aus.Aula, 'Por Asignar') AS Aula
    FROM UltimaMatricula um
    INNER JOIN dbo.Estudiante e ON um.IdEstudiante = e.IdEstudiante
    INNER JOIN dbo.AnioAcademico an ON um.IdAnio = an.IdAnio
    INNER JOIN dbo.Seccion sec ON um.IdSeccion = sec.IdSeccion
    LEFT JOIN dbo.Aula_Seccion aus ON aus.IdAnio = um.IdAnio AND aus.IdSeccion = um.IdSeccion
    LEFT JOIN dbo.Docente doc ON aus.IdDocenteGuia = doc.IdDocente
    WHERE um.Fila = 1
      AND (@IdAnio = 0 OR um.IdAnio = @IdAnio)
      AND (@IdSeccion = 0 OR um.IdSeccion = @IdSeccion)
      AND (@Filtro = '' 
           OR e.CodigoEstudiante LIKE '%' + @Filtro + '%'
           OR e.Nombres LIKE '%' + @Filtro + '%'
           OR e.Apellidos LIKE '%' + @Filtro + '%')
    ORDER BY um.IdMatricula DESC;
END;
GO

-- 3.5 SP_ObtenerCalificacionesPorMatricula
CREATE PROCEDURE dbo.SP_ObtenerCalificacionesPorMatricula
    @IdMatricula INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        c.IdCalificacion,
        c.IdMatricula,
        asig.IdAsignatura,
        asig.NombreAsignatura,
        c.NotaI_Semestre,
        c.NotaII_Semestre,
        c.NotaFinal,
        c.NotaReparacion,
        c.EstadoAsignatura,
        c.Observacion
    FROM dbo.Calificacion c
    INNER JOIN dbo.Asignatura asig ON c.IdAsignatura = asig.IdAsignatura
    WHERE c.IdMatricula = @IdMatricula
    ORDER BY asig.NombreAsignatura ASC;
END;
GO

-- 3.6 SP_ListarDocentes
CREATE PROCEDURE dbo.SP_ListarDocentes
    @Filtro NVARCHAR(100) = ''
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        d.IdDocente,
        d.Nombres,
        d.Apellidos,
        d.Cedula,
        d.Telefono,
        d.Correo,
        d.Especialidad,
        d.Estado
    FROM dbo.Docente d
    WHERE (@Filtro = '' 
       OR d.Nombres LIKE '%' + @Filtro + '%'
       OR d.Apellidos LIKE '%' + @Filtro + '%'
       OR d.Cedula LIKE '%' + @Filtro + '%'
       OR d.Especialidad LIKE '%' + @Filtro + '%')
    ORDER BY d.Apellidos, d.Nombres;
END;
GO

-- 3.7 SP_ListarCargaDocente
CREATE PROCEDURE dbo.SP_ListarCargaDocente
    @IdDocente INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        da.IdDocenteAsignatura,
        da.IdDocente,
        da.IdAsignatura,
        asig.NombreAsignatura,
        da.IdAnio,
        an.NombreAnio,
        da.IdSeccion,
        sec.NombreSeccion
    FROM dbo.Docente_Asignatura da
    INNER JOIN dbo.Asignatura asig ON da.IdAsignatura = asig.IdAsignatura
    INNER JOIN dbo.AnioAcademico an ON da.IdAnio = an.IdAnio
    INNER JOIN dbo.Seccion sec ON da.IdSeccion = sec.IdSeccion
    WHERE da.IdDocente = @IdDocente
    ORDER BY an.IdAnio, sec.NombreSeccion, asig.NombreAsignatura;
END;
GO

-- 3.8 SP_EliminarCargaDocente
CREATE PROCEDURE dbo.SP_EliminarCargaDocente
    @IdDocenteAsignatura INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Docente_Asignatura WHERE IdDocenteAsignatura = @IdDocenteAsignatura;
END;
GO

-- 3.9 SP_ListarAulasSecciones
CREATE PROCEDURE dbo.SP_ListarAulasSecciones
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        aus.IdAulaSeccion,
        aus.IdAnio,
        an.NombreAnio,
        aus.IdSeccion,
        sec.NombreSeccion,
        aus.Aula,
        aus.IdDocenteGuia,
        ISNULL(CONCAT(d.Nombres, ' ', d.Apellidos), 'No asignado') AS DocenteGuia
    FROM dbo.Aula_Seccion aus
    INNER JOIN dbo.AnioAcademico an ON aus.IdAnio = an.IdAnio
    INNER JOIN dbo.Seccion sec ON aus.IdSeccion = sec.IdSeccion
    LEFT JOIN dbo.Docente d ON aus.IdDocenteGuia = d.IdDocente
    ORDER BY an.IdAnio, sec.NombreSeccion;
END;
GO

-- 3.10 SP_GuardarAulaSeccion
CREATE PROCEDURE dbo.SP_GuardarAulaSeccion
    @IdAnio INT,
    @IdSeccion INT,
    @Aula NVARCHAR(50),
    @IdDocenteGuia INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM dbo.Aula_Seccion WHERE IdAnio = @IdAnio AND IdSeccion = @IdSeccion)
        BEGIN
            UPDATE dbo.Aula_Seccion
            SET Aula = @Aula, IdDocenteGuia = @IdDocenteGuia
            WHERE IdAnio = @IdAnio AND IdSeccion = @IdSeccion;
        END
        ELSE
        BEGIN
            INSERT INTO dbo.Aula_Seccion (IdAnio, IdSeccion, IdDocenteGuia, Aula)
            VALUES (@IdAnio, @IdSeccion, @IdDocenteGuia, @Aula);
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 3.11 SP_ObtenerDatosBoletin
CREATE PROCEDURE dbo.SP_ObtenerDatosBoletin
    @IdMatricula INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Cabecera del Boletin
    SELECT 
        m.IdMatricula,
        e.IdEstudiante,
        e.CodigoEstudiante,
        CONCAT(e.Nombres, ' ', e.Apellidos) AS NombreEstudiante,
        an.IdAnio,
        an.NombreAnio,
        an.Ciclo,
        sec.IdSeccion,
        sec.NombreSeccion,
        m.FechaMatricula,
        m.EstadoMatricula,
        CONCAT(t.Nombres, ' ', t.Apellidos) AS NombreTutor,
        t.Telefono AS TelefonoTutor,
        ISNULL(aus.Aula, 'Por definir') AS Aula,
        ISNULL(CONCAT(d.Nombres, ' ', d.Apellidos), 'Docente GuÃ­a No Asignado') AS DocenteGuia
    FROM dbo.Matricula m
    INNER JOIN dbo.Estudiante e ON m.IdEstudiante = e.IdEstudiante
    INNER JOIN dbo.Tutor t ON e.IdTutor = t.IdTutor
    INNER JOIN dbo.AnioAcademico an ON m.IdAnio = an.IdAnio
    INNER JOIN dbo.Seccion sec ON m.IdSeccion = sec.IdSeccion
    LEFT JOIN dbo.Aula_Seccion aus ON aus.IdAnio = m.IdAnio AND aus.IdSeccion = m.IdSeccion
    LEFT JOIN dbo.Docente d ON aus.IdDocenteGuia = d.IdDocente
    WHERE m.IdMatricula = @IdMatricula;

    -- Detalle de Notas
    SELECT 
        c.IdCalificacion,
        asig.IdAsignatura,
        asig.NombreAsignatura,
        c.NotaI_Semestre,
        c.NotaII_Semestre,
        c.NotaFinal,
        c.NotaReparacion,
        c.EstadoAsignatura,
        c.Observacion
    FROM dbo.Calificacion c
    INNER JOIN dbo.Asignatura asig ON c.IdAsignatura = asig.IdAsignatura
    WHERE c.IdMatricula = @IdMatricula
    ORDER BY asig.NombreAsignatura ASC;
END;
GO

-- 3.12 SP_ListarAniosAcademicos y SP_ListarSecciones
CREATE OR ALTER PROCEDURE dbo.SP_ListarAniosAcademicos
AS
BEGIN
    SET NOCOUNT ON;

    -- Sembrar Años Académicos si la tabla está vacía
    IF NOT EXISTS (SELECT 1 FROM dbo.AnioAcademico)
    BEGIN
        INSERT INTO dbo.AnioAcademico (NombreAnio, Ciclo) VALUES 
            ('7mo Grado', 'III Ciclo'),
            ('8vo Grado', 'III Ciclo'),
            ('9no Grado', 'III Ciclo'),
            ('10mo Grado', 'IV Ciclo'),
            ('11mo Grado', 'IV Ciclo');
    END

    SELECT IdAnio, NombreAnio, Ciclo FROM dbo.AnioAcademico ORDER BY IdAnio;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarSecciones
AS
BEGIN
    SET NOCOUNT ON;

    -- Sembrar Secciones si la tabla está vacía
    IF NOT EXISTS (SELECT 1 FROM dbo.Seccion)
    BEGIN
        INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES 
            ('A', 40),
            ('B', 40),
            ('C', 40);
    END

    SELECT IdSeccion, NombreSeccion, CapacidadMaxima FROM dbo.Seccion ORDER BY NombreSeccion;
END;
GO

-- 3.13 SP_ListarSeccionesConDisponibilidad
-- Consulta la capacidad de las 3 secciones (A, B, C) para un año determinado
-- y retorna la sección más vacía en primer lugar para seleccionarla automáticamente.
CREATE OR ALTER PROCEDURE dbo.SP_ListarSeccionesConDisponibilidad
    @IdAnio INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Sembrar Secciones si no existen
    IF NOT EXISTS (SELECT 1 FROM dbo.Seccion)
    BEGIN
        INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES 
            ('A', 40),
            ('B', 40),
            ('C', 40);
    END

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
        -- Si la sección ya tiene 40 o más alumnos, se envía al final
        CASE WHEN COUNT(m.IdMatricula) >= s.CapacidadMaxima THEN 1 ELSE 0 END ASC,
        -- La sección con menor cantidad de alumnos (la más vacía) aparece de primera
        COUNT(m.IdMatricula) ASC, 
        s.NombreSeccion ASC;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarAsignaturasPorAnio
    @IdAnio INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Si la malla del grado está vacía, sembrarla automáticamente
    IF NOT EXISTS (SELECT 1 FROM dbo.Grado_Asignatura WHERE IdAnio = @IdAnio)
    BEGIN
        DECLARE @Asignaturas TABLE (Nombre NVARCHAR(100));
        INSERT INTO @Asignaturas (Nombre) VALUES 
            ('Matemáticas'),
            ('Lengua y Literatura'),
            ('Ciencias Naturales'),
            ('Geografía'),
            ('Historia'),
            ('Inglés'),
            ('Educación Física'),
            ('Biología'),
            ('Física'),
            ('Química'),
            ('Filosofía'),
            ('Sociología'),
            ('Economía');

        INSERT INTO dbo.Asignatura (NombreAsignatura)
        SELECT A.Nombre FROM @Asignaturas A
        WHERE NOT EXISTS (SELECT 1 FROM dbo.Asignatura WHERE NombreAsignatura = A.Nombre);

        -- Asociar III Ciclo: 7mo, 8vo, 9no
        INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
        SELECT an.IdAnio, asig.IdAsignatura, 4
        FROM dbo.AnioAcademico an
        CROSS JOIN dbo.Asignatura asig
        WHERE an.IdAnio = @IdAnio
          AND an.Ciclo = 'III Ciclo'
          AND asig.NombreAsignatura IN ('Matemáticas', 'Lengua y Literatura', 'Ciencias Naturales', 'Geografía', 'Historia', 'Inglés', 'Educación Física')
          AND NOT EXISTS (
              SELECT 1 FROM dbo.Grado_Asignatura ga 
              WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
          );

        -- Asociar IV Ciclo: 10mo, 11mo
        INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
        SELECT an.IdAnio, asig.IdAsignatura, 4
        FROM dbo.AnioAcademico an
        CROSS JOIN dbo.Asignatura asig
        WHERE an.IdAnio = @IdAnio
          AND an.Ciclo = 'IV Ciclo'
          AND asig.NombreAsignatura IN ('Matemáticas', 'Lengua y Literatura', 'Biología', 'Física', 'Química', 'Filosofía', 'Sociología', 'Economía', 'Inglés', 'Educación Física')
          AND NOT EXISTS (
              SELECT 1 FROM dbo.Grado_Asignatura ga 
              WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
          );
    END

    SELECT 
        a.IdAsignatura,
        a.NombreAsignatura,
        ga.HorasSemanales
    FROM dbo.Grado_Asignatura ga
    INNER JOIN dbo.Asignatura a ON ga.IdAsignatura = a.IdAsignatura
    WHERE ga.IdAnio = @IdAnio
    ORDER BY a.NombreAsignatura;
END;
GO

-- 4. POBLADO INICIAL AUTOMÁTICO DE CATÁLOGOS BASE (EJECUCIÓN INMEDIATA)
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
    INSERT INTO dbo.Seccion (NombreSeccion, CapacidadMaxima) VALUES ('C', 40);

DECLARE @AsignaturasInit TABLE (Nombre NVARCHAR(100));
INSERT INTO @AsignaturasInit (Nombre) VALUES 
    ('Matemáticas'), ('Lengua y Literatura'), ('Ciencias Naturales'),
    ('Geografía'), ('Historia'), ('Inglés'), ('Educación Física'),
    ('Biología'), ('Física'), ('Química'), ('Filosofía'), ('Sociología'), ('Economía');

INSERT INTO dbo.Asignatura (NombreAsignatura)
SELECT A.Nombre FROM @AsignaturasInit A
WHERE NOT EXISTS (SELECT 1 FROM dbo.Asignatura WHERE NombreAsignatura = A.Nombre);

-- Asociar Malla para III Ciclo
INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
SELECT an.IdAnio, asig.IdAsignatura, 4
FROM dbo.AnioAcademico an
CROSS JOIN dbo.Asignatura asig
WHERE an.Ciclo = 'III Ciclo'
  AND asig.NombreAsignatura IN ('Matemáticas', 'Lengua y Literatura', 'Ciencias Naturales', 'Geografía', 'Historia', 'Inglés', 'Educación Física')
  AND NOT EXISTS (
      SELECT 1 FROM dbo.Grado_Asignatura ga 
      WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
  );

-- Asociar Malla para IV Ciclo
INSERT INTO dbo.Grado_Asignatura (IdAnio, IdAsignatura, HorasSemanales)
SELECT an.IdAnio, asig.IdAsignatura, 4
FROM dbo.AnioAcademico an
CROSS JOIN dbo.Asignatura asig
WHERE an.Ciclo = 'IV Ciclo'
  AND asig.NombreAsignatura IN ('Matemáticas', 'Lengua y Literatura', 'Biología', 'Física', 'Química', 'Filosofía', 'Sociología', 'Economía', 'Inglés', 'Educación Física')
  AND NOT EXISTS (
      SELECT 1 FROM dbo.Grado_Asignatura ga 
      WHERE ga.IdAnio = an.IdAnio AND ga.IdAsignatura = asig.IdAsignatura
  );
GO




-- =========================================================================
-- 4. PROCEDIMIENTOS ALMACENADOS PARA EL MÓDULO DE MATRÍCULAS Y PROMOCIÓN
-- =========================================================================

-- 4.1 Ajuste de Restricción para permitir histórico y repetición de año escolar
IF EXISTS (SELECT 1 FROM sys.key_constraints WHERE name = 'UQ_Estudiante_Anio')
BEGIN
    ALTER TABLE dbo.Matricula DROP CONSTRAINT UQ_Estudiante_Anio;
END;
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'UQ_Estudiante_Anio_Activo')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX UQ_Estudiante_Anio_Activo 
    ON dbo.Matricula (IdEstudiante, IdAnio) 
    WHERE EstadoMatricula = 'Activo';
END;
GO

-- 4.2 SP_MatricularSiguienteAnio (Promoción y avance de grado curricular)
CREATE OR ALTER PROCEDURE dbo.SP_MatricularSiguienteAnio
    @IdMatriculaActual INT,
    @IdSeccionNueva INT,
    @NuevoIdMatricula INT OUTPUT,
    @MensajeResultado NVARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @IdEstudiante INT;
        DECLARE @IdAnioActual INT;
        DECLARE @NombreAnioActual NVARCHAR(50);

        SELECT @IdEstudiante = m.IdEstudiante, 
               @IdAnioActual = m.IdAnio, 
               @NombreAnioActual = a.NombreAnio
        FROM dbo.Matricula m
        INNER JOIN dbo.AnioAcademico a ON m.IdAnio = a.IdAnio
        WHERE m.IdMatricula = @IdMatriculaActual;

        IF @IdEstudiante IS NULL
        BEGIN
            RAISERROR('No se encontró el registro de matrícula especificado.', 16, 1);
        END

        -- 1. Validar que no haya calificaciones pendientes
        DECLARE @Pendientes INT = (SELECT COUNT(1) FROM dbo.Calificacion WHERE IdMatricula = @IdMatriculaActual AND EstadoAsignatura = 'En proceso');
        IF @Pendientes > 0
        BEGIN
            RAISERROR('No se puede matricular al siguiente año: existen asignaturas con calificaciones incompletas.', 16, 1);
        END

        -- 2. Validar que todas las asignaturas estén Aprobadas
        DECLARE @Reprobadas INT = (SELECT COUNT(1) FROM dbo.Calificacion WHERE IdMatricula = @IdMatriculaActual AND EstadoAsignatura IN ('Reprobada', 'Reparación'));
        IF @Reprobadas > 0
        BEGIN
            RAISERROR('No se puede matricular al siguiente año: el estudiante tiene asignaturas reprobadas o pendientes de examen de reparación.', 16, 1);
        END

        -- 3. Caso especial: Si ya completó 11mo Grado (5to Año)
        IF @NombreAnioActual = '11mo Grado' OR @IdAnioActual = 5
        BEGIN
            UPDATE dbo.Matricula SET EstadoMatricula = 'Estudiante Graduado' WHERE IdMatricula = @IdMatriculaActual;
            UPDATE dbo.Estudiante SET Estado = 'Estudiante Graduado' WHERE IdEstudiante = @IdEstudiante;
            SET @NuevoIdMatricula = @IdMatriculaActual;
            SET @MensajeResultado = '¡Felicidades, estudiante graduado!';
            COMMIT TRANSACTION;
            RETURN;
        END

        -- 4. Calcular el siguiente año académico
        DECLARE @IdAnioNuevo INT = @IdAnioActual + 1;
        DECLARE @NombreAnioNuevo NVARCHAR(50) = (SELECT NombreAnio FROM dbo.AnioAcademico WHERE IdAnio = @IdAnioNuevo);

        IF @NombreAnioNuevo IS NULL
        BEGIN
            RAISERROR('No existe un año académico consecutivo registrado.', 16, 1);
        END

        -- 5. Validar cupo en la nueva sección
        DECLARE @CuposOcupados INT = (
            SELECT COUNT(1) FROM dbo.Matricula 
            WHERE IdAnio = @IdAnioNuevo AND IdSeccion = @IdSeccionNueva AND EstadoMatricula = 'Activo'
        );
        DECLARE @CapacidadMax INT = (SELECT CapacidadMaxima FROM dbo.Seccion WHERE IdSeccion = @IdSeccionNueva);
        IF @CapacidadMax IS NULL SET @CapacidadMax = 40;

        IF @CuposOcupados >= @CapacidadMax
        BEGIN
            RAISERROR('La sección seleccionada para el nuevo año ha alcanzado su capacidad máxima permitida (%d alumnos).', 16, 1, @CapacidadMax);
        END

        -- 6. Actualizar matrícula anterior a Promovido
        UPDATE dbo.Matricula SET EstadoMatricula = 'Promovido' WHERE IdMatricula = @IdMatriculaActual;

        -- 7. Insertar nueva matrícula
        INSERT INTO dbo.Matricula (IdEstudiante, IdAnio, IdSeccion, FechaMatricula, EstadoMatricula)
        VALUES (@IdEstudiante, @IdAnioNuevo, @IdSeccionNueva, GETDATE(), 'Activo');
        SET @NuevoIdMatricula = SCOPE_IDENTITY();

        -- 8. Inicializar calificaciones de la malla curricular del nuevo año
        INSERT INTO dbo.Calificacion (IdMatricula, IdAsignatura, NotaI_Semestre, NotaII_Semestre, NotaFinal, NotaReparacion, EstadoAsignatura, Observacion)
        SELECT 
            @NuevoIdMatricula,
            ga.IdAsignatura,
            NULL,
            NULL,
            NULL,
            NULL,
            'En proceso',
            'Inscripción de nuevo año académico'
        FROM dbo.Grado_Asignatura ga
        WHERE ga.IdAnio = @IdAnioNuevo;

        -- 9. Actualizar estado del estudiante
        UPDATE dbo.Estudiante SET Estado = 'Activo' WHERE IdEstudiante = @IdEstudiante;

        SET @MensajeResultado = CONCAT('¡Estudiante promovido y matriculado exitosamente en ', @NombreAnioNuevo, '!');
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- 4.3 SP_MatricularMismoAnio (Repetición de año escolar)
CREATE OR ALTER PROCEDURE dbo.SP_MatricularMismoAnio
    @IdMatriculaActual INT,
    @IdSeccionNueva INT,
    @NuevoIdMatricula INT OUTPUT,
    @MensajeResultado NVARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @IdEstudiante INT;
        DECLARE @IdAnioActual INT;
        DECLARE @NombreAnioActual NVARCHAR(50);

        SELECT @IdEstudiante = m.IdEstudiante, 
               @IdAnioActual = m.IdAnio, 
               @NombreAnioActual = a.NombreAnio
        FROM dbo.Matricula m
        INNER JOIN dbo.AnioAcademico a ON m.IdAnio = a.IdAnio
        WHERE m.IdMatricula = @IdMatriculaActual;

        IF @IdEstudiante IS NULL
        BEGIN
            RAISERROR('No se encontró el registro de matrícula especificado.', 16, 1);
        END

        -- 1. Validar cupo en la sección seleccionada
        DECLARE @CuposOcupados INT = (
            SELECT COUNT(1) FROM dbo.Matricula 
            WHERE IdAnio = @IdAnioActual AND IdSeccion = @IdSeccionNueva AND EstadoMatricula = 'Activo' AND IdMatricula <> @IdMatriculaActual
        );
        DECLARE @CapacidadMax INT = (SELECT CapacidadMaxima FROM dbo.Seccion WHERE IdSeccion = @IdSeccionNueva);
        IF @CapacidadMax IS NULL SET @CapacidadMax = 40;

        IF @CuposOcupados >= @CapacidadMax
        BEGIN
            RAISERROR('La sección seleccionada ha alcanzado su capacidad máxima permitida (%d alumnos).', 16, 1, @CapacidadMax);
        END

        -- 2. Actualizar matrícula anterior a Repite Año
        UPDATE dbo.Matricula SET EstadoMatricula = 'Repite Año' WHERE IdMatricula = @IdMatriculaActual;

        -- 3. Insertar nueva matrícula para el mismo año (repite año)
        INSERT INTO dbo.Matricula (IdEstudiante, IdAnio, IdSeccion, FechaMatricula, EstadoMatricula)
        VALUES (@IdEstudiante, @IdAnioActual, @IdSeccionNueva, GETDATE(), 'Activo');
        SET @NuevoIdMatricula = SCOPE_IDENTITY();

        -- 4. Inicializar nuevas calificaciones para el ciclo que repite
        INSERT INTO dbo.Calificacion (IdMatricula, IdAsignatura, NotaI_Semestre, NotaII_Semestre, NotaFinal, NotaReparacion, EstadoAsignatura, Observacion)
        SELECT 
            @NuevoIdMatricula,
            ga.IdAsignatura,
            NULL,
            NULL,
            NULL,
            NULL,
            'En proceso',
            'Repitiendo año académico'
        FROM dbo.Grado_Asignatura ga
        WHERE ga.IdAnio = @IdAnioActual;

        -- 5. Actualizar estado del estudiante a Activo
        UPDATE dbo.Estudiante SET Estado = 'Activo' WHERE IdEstudiante = @IdEstudiante;

        SET @MensajeResultado = CONCAT('Estudiante matriculado nuevamente en ', @NombreAnioActual, ' (Repitiendo año lectivo).');
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
