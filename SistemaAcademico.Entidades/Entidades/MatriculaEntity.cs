using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class MatriculaEntity
    {
        public int IdMatricula { get; private set; }
        public int IdEstudiante { get; private set; }
        public string CodigoEstudiante { get; private set; } = string.Empty;
        public string NombreEstudiante { get; private set; } = string.Empty;
        public int IdAnio { get; private set; }
        public string NombreAnio { get; private set; } = string.Empty;
        public string Ciclo { get; private set; } = string.Empty;
        public int IdSeccion { get; private set; }
        public string NombreSeccion { get; private set; } = string.Empty;
        public DateTime FechaMatricula { get; private set; } = DateTime.Now;
        public string EstadoMatricula { get; private set; } = "Activo";
        public string EstadoEstudiante { get; private set; } = "Activo";
        public string DocenteGuia { get; private set; } = "Sin Docente Guía";
        public string Aula { get; private set; } = "Por Asignar";

        public string DescripcionCompleta => $"{CodigoEstudiante} - {NombreEstudiante} ({NombreAnio} '{NombreSeccion}')";

        #region Constructores

        public MatriculaEntity() { }

        public MatriculaEntity(int idMatricula, int idEstudiante, string codigo, string nombre, int idAnio, string nombreAnio, int idSeccion, string nombreSeccion)
        {
            AsignarId(idMatricula);
            AsignarEstudiante(idEstudiante, codigo, nombre);
            AsignarAnioSeccion(idAnio, nombreAnio, "", idSeccion, nombreSeccion);
        }

        #endregion

        #region Métodos de Encapsulamiento

        public void AsignarId(int id)
        {
            IdMatricula = id;
        }

        public void AsignarEstudiante(int idEstudiante, string codigo, string nombre, string estadoEstudiante = "Activo")
        {
            IdEstudiante = idEstudiante;
            CodigoEstudiante = codigo?.Trim() ?? string.Empty;
            NombreEstudiante = nombre?.Trim() ?? string.Empty;
            EstadoEstudiante = string.IsNullOrWhiteSpace(estadoEstudiante) ? "Activo" : estadoEstudiante.Trim();
        }

        public void AsignarAnioSeccion(int idAnio, string nombreAnio, string ciclo, int idSeccion, string nombreSeccion)
        {
            IdAnio = idAnio;
            NombreAnio = nombreAnio?.Trim() ?? string.Empty;
            Ciclo = ciclo?.Trim() ?? string.Empty;
            IdSeccion = idSeccion;
            NombreSeccion = nombreSeccion?.Trim() ?? string.Empty;
        }

        public void AsignarDetalles(DateTime fecha, string estadoMatricula, string docenteGuia, string aula, string estadoEstudiante = "Activo")
        {
            FechaMatricula = fecha;
            EstadoMatricula = string.IsNullOrWhiteSpace(estadoMatricula) ? "Activo" : estadoMatricula.Trim();
            DocenteGuia = string.IsNullOrWhiteSpace(docenteGuia) ? "Sin Docente Guía" : docenteGuia.Trim();
            Aula = string.IsNullOrWhiteSpace(aula) ? "Por Asignar" : aula.Trim();
            EstadoEstudiante = string.IsNullOrWhiteSpace(estadoEstudiante) ? "Activo" : estadoEstudiante.Trim();
        }

        public void CambiarEstadoMatricula(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new Exception("El estado de la matrícula no puede ser vacío.");

            EstadoMatricula = estado.Trim();
        }

        public void CambiarEstadoEstudiante(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new Exception("El estado del estudiante no puede ser vacío.");

            EstadoEstudiante = estado.Trim();
        }

        #endregion

        public override string ToString() => DescripcionCompleta;
    }
}
