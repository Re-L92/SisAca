using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class DocenteEntity
    {
        public int IdDocente { get; private set; }
        public string Nombres { get; private set; } = string.Empty;
        public string Apellidos { get; private set; } = string.Empty;
        public string Cedula { get; private set; } = string.Empty;
        public string? Telefono { get; private set; }
        public string? Correo { get; private set; }
        public string? Especialidad { get; private set; }
        public string Estado { get; private set; } = "Activo";

        public string NombreCompleto => $"{Nombres} {Apellidos}".Trim();

        #region Constructores

        public DocenteEntity() { }

        public DocenteEntity(string nombres, string apellidos, string cedula, string? especialidad = null, string? telefono = null, string? correo = null)
        {
            CambiarNombres(nombres);
            CambiarApellidos(apellidos);
            CambiarCedula(cedula);
            CambiarEspecialidad(especialidad);
            CambiarTelefono(telefono);
            CambiarCorreo(correo);
            Estado = "Activo";
        }

        #endregion

        #region Métodos 

        public void AsignarId(int id)
        {
            IdDocente = id;
        }

        public void CambiarNombres(string nombres)
        {
            if (string.IsNullOrWhiteSpace(nombres))
                throw new Exception("Debe ingresar los nombres del docente.");

            Nombres = nombres.Trim();
        }

        public void CambiarApellidos(string apellidos)
        {
            if (string.IsNullOrWhiteSpace(apellidos))
                throw new Exception("Debe ingresar los apellidos del docente.");

            Apellidos = apellidos.Trim();
        }

        public void CambiarCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                throw new Exception("Debe ingresar el número de cédula del docente.");

            Cedula = cedula.Trim();
        }

        public void CambiarEspecialidad(string? especialidad)
        {
            Especialidad = string.IsNullOrWhiteSpace(especialidad) ? null : especialidad.Trim();
        }

        public void CambiarTelefono(string? telefono)
        {
            Telefono = string.IsNullOrWhiteSpace(telefono) ? null : telefono.Trim();
        }

        public void CambiarCorreo(string? correo)
        {
            Correo = string.IsNullOrWhiteSpace(correo) ? null : correo.Trim();
        }

        public void CambiarEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new Exception("El estado no puede ser vacío.");

            Estado = estado.Trim();
        }

        #endregion
    }
}
