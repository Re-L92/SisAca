using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class ResumenCalificacionesModel
    {
        public decimal PromedioGeneral { get; set; } = 0;
        public int TotalAsignaturas { get; set; } = 0;
        public int AsignaturasAprobadas { get; set; } = 0;
        public int AsignaturasEnReparacion { get; set; } = 0;
        public int AsignaturasReprobadas { get; set; } = 0;
        public int AsignaturasEnProceso { get; set; } = 0;

        public string EstadoRendimiento
        {
            get
            {
                if (TotalAsignaturas == 0) return "Sin Calificaciones";
                if (AsignaturasEnProceso > 0) return "En Proceso";
                if (AsignaturasReprobadas > 0 || AsignaturasEnReparacion >= 3) return "Riesgo de Repetición";
                if (AsignaturasEnReparacion > 0) return "Pendiente de Reparación";
                if (PromedioGeneral >= 90) return "Excelente";
                if (PromedioGeneral >= 80) return "Muy Bueno";
                if (PromedioGeneral >= 60) return "Aprobado";
                return "Reprobado";
            }
        }
    }
}
