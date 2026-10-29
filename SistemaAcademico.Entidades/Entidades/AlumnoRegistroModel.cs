using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AlumnoRegistroModel
    {
        // Datos del Alumno
        public string EstudianteCodigo { get; set; } = string.Empty;
        public string EstudianteNombres { get; set; } = string.Empty;
        public string EstudianteApellidos { get; set; } = string.Empty;
        public DateTime EstudianteFechaNac { get; set; } = DateTime.Today.AddYears(-12);
        public string Estado { get; set; } = "Activo"; // Borrado lógico: Activo o Inactivo

        // Matrícula
        public int IdAnio { get; set; }
        public int IdSeccion { get; set; }

        // Datos del Tutor
        public string TutorNombres { get; set; } = string.Empty;
        public string TutorApellidos { get; set; } = string.Empty;
        public string TutorCedula { get; set; } = string.Empty;
        public string TutorTelefono { get; set; } = string.Empty;
        public string TutorDireccion { get; set; } = string.Empty;
    }
}
