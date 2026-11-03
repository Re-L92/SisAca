USE DB_GestionAcademica;
GO

IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'AdministradorSis')
BEGIN
    CREATE LOGIN AdministradorSis WITH PASSWORD = 'admin123+-', CHECK_POLICY = OFF;
END
ELSE
BEGIN
    ALTER LOGIN AdministradorSis WITH PASSWORD = 'admin123+-';
END
GO

ALTER SERVER ROLE sysadmin ADD MEMBER AdministradorSis;
GO