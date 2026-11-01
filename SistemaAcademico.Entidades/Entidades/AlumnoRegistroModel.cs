using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AlumnoRegistroModel
    {
        // Datos del Alumno
        public string EstudianteCodigo { get; private set; } = string.Empty;
        public string EstudianteNombres { get; private set; } = string.Empty;
        public string EstudianteApellidos { get; private set; } = string.Empty;
        public DateTime EstudianteFechaNac { get; private set; } = DateTime.Today.AddYears(-12);
        public string Estado { get; private set; } = "Activo";

        // Matrícula
        public int IdAnio { get; private set; }
        public int IdSeccion { get; private set; }

        // Datos del Tutor
        public string TutorNombres { get; private set; } = string.Empty;
        public string TutorApellidos { get; private set; } = string.Empty;
        public string TutorCedula { get; private set; } = string.Empty;
        public string TutorTelefono { get; private set; } = string.Empty;
        public string? TutorDireccion { get; private set; }

        #region Constructores

        public AlumnoRegistroModel() { }

        #endregion

        #region Métodos de Encapsulamiento

        public void CambiarDatosEstudiante(string nombres, string apellidos, DateTime fechaNac, string estado = "Activo")
        {
            if (string.IsNullOrWhiteSpace(nombres))
                throw new Exception("Debe ingresar los nombres del estudiante.");

            if (string.IsNullOrWhiteSpace(apellidos))
                throw new Exception("Debe ingresar los apellidos del estudiante.");

            EstudianteNombres = nombres.Trim();
            EstudianteApellidos = apellidos.Trim();
            EstudianteFechaNac = fechaNac;
            Estado = string.IsNullOrWhiteSpace(estado) ? "Activo" : estado.Trim();
        }

        public void AsignarCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new Exception("El código del estudiante no puede estar vacío.");

            EstudianteCodigo = codigo.Trim();
        }

        public void AsignarMatricula(int idAnio, int idSeccion)
        {
            if (idAnio <= 0)
                throw new Exception("Debe seleccionar un año académico válido.");

            if (idSeccion <= 0)
                throw new Exception("Debe seleccionar una sección válida.");

            IdAnio = idAnio;
            IdSeccion = idSeccion;
        }

        public void AsignarTutor(string nombres, string apellidos, string cedula, string telefono, string? direccion = null)
        {
            if (string.IsNullOrWhiteSpace(nombres))
                throw new Exception("Debe ingresar los nombres del tutor.");

            if (string.IsNullOrWhiteSpace(apellidos))
                throw new Exception("Debe ingresar los apellidos del tutor.");

            if (string.IsNullOrWhiteSpace(cedula))
                throw new Exception("Debe ingresar el número de cédula del tutor.");

            if (string.IsNullOrWhiteSpace(telefono))
                throw new Exception("Debe ingresar el teléfono del tutor.");

            TutorNombres = nombres.Trim();
            TutorApellidos = apellidos.Trim();
            TutorCedula = cedula.Trim();
            TutorTelefono = telefono.Trim();
            TutorDireccion = string.IsNullOrWhiteSpace(direccion) ? null : direccion.Trim();
        }

        #endregion
    }
}
