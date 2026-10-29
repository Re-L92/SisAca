using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AlumnoEntity
    {
        public int IdEstudiante { get; set; }
        public string CodigoEstudiante { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Estado { get; set; } = "Activo";
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public int IdTutor { get; set; }
        public string NombreTutor { get; set; } = string.Empty;
        public string? TelefonoTutor { get; set; }
        public string? CedulaTutor { get; set; }

        public string NombreCompleto => $"{Nombres} {Apellidos}".Trim();
    }
}
