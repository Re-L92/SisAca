using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AlumnoEntity
    {
        public int IdEstudiante { get; private set; }
        public string CodigoEstudiante { get; private set; } = string.Empty;
        public string Nombres { get; private set; } = string.Empty;
        public string Apellidos { get; private set; } = string.Empty;
        public DateTime FechaNacimiento { get; private set; }
        public string Estado { get; private set; } = "Activo";
        public DateTime FechaRegistro { get; private set; } = DateTime.Now;

        public int IdTutor { get; private set; }
        public string NombreTutor { get; private set; } = string.Empty;
        public string? TelefonoTutor { get; private set; }
        public string? CedulaTutor { get; private set; }

        public string NombreCompleto => $"{Nombres} {Apellidos}".Trim();

        #region Constructores

        public AlumnoEntity() { }

        public AlumnoEntity(string codigo, string nombres, string apellidos, DateTime fechaNacimiento, string estado = "Activo")
        {
            CambiarCodigoEstudiante(codigo);
            CambiarNombres(nombres);
            CambiarApellidos(apellidos);
            CambiarFechaNacimiento(fechaNacimiento);
            CambiarEstado(estado);
        }

        #endregion

        #region Métodos de Encapsulamiento

        public void AsignarId(int id)
        {
            IdEstudiante = id;
        }

        public void CambiarCodigoEstudiante(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new Exception("El código del estudiante es obligatorio.");

            CodigoEstudiante = codigo.Trim();
        }

        public void CambiarNombres(string nombres)
        {
            if (string.IsNullOrWhiteSpace(nombres))
                throw new Exception("Debe ingresar los nombres del estudiante.");

            Nombres = nombres.Trim();
        }

        public void CambiarApellidos(string apellidos)
        {
            if (string.IsNullOrWhiteSpace(apellidos))
                throw new Exception("Debe ingresar los apellidos del estudiante.");

            Apellidos = apellidos.Trim();
        }

        public void CambiarFechaNacimiento(DateTime fechaNacimiento)
        {
            FechaNacimiento = fechaNacimiento;
        }

        public void CambiarEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new Exception("El estado no puede estar vacío.");

            Estado = estado.Trim();
        }

        public void AsignarFechaRegistro(DateTime fechaRegistro)
        {
            FechaRegistro = fechaRegistro;
        }

        public void AsignarTutor(int idTutor, string nombreTutor, string? telefonoTutor = null, string? cedulaTutor = null)
        {
            IdTutor = idTutor;
            NombreTutor = nombreTutor?.Trim() ?? string.Empty;
            TelefonoTutor = string.IsNullOrWhiteSpace(telefonoTutor) ? null : telefonoTutor.Trim();
            CedulaTutor = string.IsNullOrWhiteSpace(cedulaTutor) ? null : cedulaTutor.Trim();
        }

        #endregion
    }
}
