using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaAcademico.DAL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.BLL
{
    public class BoletinBll
    {
        private readonly BoletinDal _boletinDal;

        public BoletinBll(BoletinDal? boletinDal = null)
        {
            _boletinDal = boletinDal ?? new BoletinDal();
        }

        public async Task<BoletinModel?> ConsultarBoletinEstudianteAsync(string codigoEstudiante)
        {
            if (string.IsNullOrWhiteSpace(codigoEstudiante))
                return null;

            // 1. Obtener la matrícula vigente del estudiante (año que está cursando actualmente)
            var matricula = await _boletinDal.ObtenerMatriculaActualPorCodigoAsync(codigoEstudiante.Trim());
            if (matricula == null)
                return null;

            // 2. Obtener las asignaturas y calificaciones de este ciclo académico
            var calificaciones = await _boletinDal.ObtenerCalificacionesPorMatriculaAsync(matricula.IdMatricula);

            // 3. Estructurar el modelo del boletín y calcular estadísticas del ciclo
            var boletin = new BoletinModel
            {
                Matricula = matricula,
                Calificaciones = calificaciones ?? new List<CalificacionEntity>()
            };

            int aprobadas = 0;
            int reprobadas = 0;
            int enReparacion = 0;
            int enProceso = 0;
            decimal sumaFinales = 0;
            int notasContadas = 0;

            foreach (var cal in boletin.Calificaciones)
            {
                cal.CalcularResultado();

                if (cal.NotaFinal.HasValue)
                {
                    decimal notaFinalDefinitiva = cal.NotaReparacion.HasValue ? cal.NotaReparacion.Value : cal.NotaFinal.Value;
                    sumaFinales += notaFinalDefinitiva;
                    notasContadas++;
                }

                switch (cal.EstadoAsignatura.Trim().ToLower())
                {
                    case "aprobada":
                        aprobadas++;
                        break;
                    case "reparación":
                    case "reparacion":
                        enReparacion++;
                        break;
                    case "reprobada":
                        reprobadas++;
                        break;
                    default:
                        enProceso++;
                        break;
                }
            }

            boletin.MateriasAprobadas = aprobadas;
            boletin.MateriasReprobadas = reprobadas;
            boletin.MateriasEnReparacion = enReparacion;
            boletin.MateriasEnProceso = enProceso;
            boletin.PromedioGeneral = notasContadas > 0 ? Math.Round(sumaFinales / notasContadas, 2) : 0;

            return boletin;
        }
    }
}
