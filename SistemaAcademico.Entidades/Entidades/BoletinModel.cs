using System;
using System.Collections.Generic;

namespace SistemaAcademico.Entidades.Entidades
{
    public class BoletinModel
    {
        public MatriculaEntity Matricula { get; set; } = new();
        public List<CalificacionEntity> Calificaciones { get; set; } = new();
        public decimal PromedioGeneral { get; set; }
        public int MateriasAprobadas { get; set; }
        public int MateriasReprobadas { get; set; }
        public int MateriasEnReparacion { get; set; }
        public int MateriasEnProceso { get; set; }
    }
}
