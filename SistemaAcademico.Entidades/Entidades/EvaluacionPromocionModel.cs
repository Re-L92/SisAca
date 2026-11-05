using System;
using System.Collections.Generic;

namespace SistemaAcademico.Entidades.Entidades
{
    public class EvaluacionPromocionModel
    {
        public int IdMatricula { get; set; }
        public int IdEstudiante { get; set; }
        public string CodigoEstudiante { get; set; } = string.Empty;
        public string NombreEstudiante { get; set; } = string.Empty;
        public int IdAnioActual { get; set; }
        public string NombreAnioActual { get; set; } = string.Empty;
        public int IdSeccionActual { get; set; }
        public string NombreSeccionActual { get; set; } = string.Empty;
        public string EstadoActualMatricula { get; set; } = string.Empty;
        public string EstadoEstudiante { get; set; } = "Activo";
        public bool EsInactivo { get; set; }

        public int TotalMaterias { get; set; }
        public int MateriasAprobadas { get; set; }
        public int MateriasReprobadas { get; set; }
        public int MateriasEnReparacion { get; set; }
        public int MateriasEnProceso { get; set; }
        public decimal PromedioFinal { get; set; }

        public bool PuedeAvanzar { get; set; }
        public bool EsGraduado { get; set; }
        public bool DebeRepetir { get; set; }
        public bool EnReparacion { get; set; }
        public bool TieneNotasIncompletas { get; set; }

        // Nuevos estados de validación de historial
        public bool YaFueAprobado { get; set; }
        public bool YaFueReprobado { get; set; }
        public bool YaGraduado { get; set; }

        public string Dictamen { get; set; } = string.Empty;
        public string SiguienteAnioNombre { get; set; } = string.Empty;
        public int SiguienteIdAnio { get; set; }

        public List<CalificacionEntity> Calificaciones { get; set; } = new();
    }
}
