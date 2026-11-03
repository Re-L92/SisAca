using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaAcademico.DAL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.BLL
{
    public class MatriculaBll
    {
        private readonly MatriculaDal _matriculaDal;

        public MatriculaBll(MatriculaDal? matriculaDal = null)
        {
            _matriculaDal = matriculaDal ?? new MatriculaDal();
        }

        public async Task<List<MatriculaEntity>> ListarMatriculasAsync(int idAnio = 0, int idSeccion = 0, string filtro = "")
        {
            return await _matriculaDal.ListarMatriculasAsync(idAnio, idSeccion, filtro?.Trim() ?? string.Empty);
        }

        public async Task<List<CalificacionEntity>> ObtenerCalificacionesPorMatriculaAsync(int idMatricula)
        {
            if (idMatricula <= 0)
                throw new Exception("Identificador de matrícula inválido.");

            return await _matriculaDal.ObtenerCalificacionesPorMatriculaAsync(idMatricula);
        }

        public async Task<List<SeccionEntity>> ListarSeccionesConDisponibilidadAsync(int idAnio)
        {
            if (idAnio <= 0) return new List<SeccionEntity>();
            return await _matriculaDal.ListarSeccionesConDisponibilidadAsync(idAnio);
        }

        public async Task<List<AnioAcademicoEntity>> ListarAniosAcademicosAsync()
        {
            return await _matriculaDal.ListarAniosAcademicosAsync();
        }

        /// <summary>
        /// Evalúa el rendimiento escolar del alumno y determina con exactitud si puede avanzar al siguiente año,
        /// si se gradúa de 5to año, si debe presentar examen de reparación o si debe repetir el año lectivo.
        /// </summary>
        public EvaluacionPromocionModel EvaluarPromocionEstudiante(MatriculaEntity matricula, List<CalificacionEntity> calificaciones)
        {
            var evaluacion = new EvaluacionPromocionModel
            {
                IdMatricula = matricula.IdMatricula,
                IdEstudiante = matricula.IdEstudiante,
                CodigoEstudiante = matricula.CodigoEstudiante,
                NombreEstudiante = matricula.NombreEstudiante,
                IdAnioActual = matricula.IdAnio,
                NombreAnioActual = matricula.NombreAnio,
                IdSeccionActual = matricula.IdSeccion,
                NombreSeccionActual = matricula.NombreSeccion,
                Calificaciones = calificaciones ?? new List<CalificacionEntity>()
            };

            if (calificaciones == null || calificaciones.Count == 0)
            {
                evaluacion.Dictamen = "El estudiante no tiene asignaturas registradas para este año académico.";
                return evaluacion;
            }

            evaluacion.TotalMaterias = calificaciones.Count;

            int aprobadas = 0;
            int enReparacion = 0;
            int reprobadas = 0;
            int enProceso = 0;
            decimal sumaFinales = 0;
            int notasFinalesContadas = 0;

            foreach (var cal in calificaciones)
            {
                // Asegurar que las reglas de negocio estén calculadas
                cal.CalcularResultado();

                if (cal.NotaFinal.HasValue)
                {
                    decimal notaConsiderada = cal.NotaReparacion.HasValue ? cal.NotaReparacion.Value : cal.NotaFinal.Value;
                    sumaFinales += notaConsiderada;
                    notasFinalesContadas++;
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

            evaluacion.MateriasAprobadas = aprobadas;
            evaluacion.MateriasEnReparacion = enReparacion;
            evaluacion.MateriasReprobadas = reprobadas;
            evaluacion.MateriasEnProceso = enProceso;
            evaluacion.PromedioFinal = notasFinalesContadas > 0 ? Math.Round(sumaFinales / notasFinalesContadas, 2) : 0;

            // Determinar siguiente año
            evaluacion.SiguienteIdAnio = matricula.IdAnio + 1;
            evaluacion.SiguienteAnioNombre = evaluacion.SiguienteIdAnio switch
            {
                2 => "8vo Grado",
                3 => "9no Grado",
                4 => "10mo Grado (4to Año)",
                5 => "11mo Grado (5to Año)",
                _ => "Graduado"
            };

            // 1. Validar si existen notas incompletas
            if (enProceso > 0)
            {
                evaluacion.TieneNotasIncompletas = true;
                evaluacion.Dictamen = $"El estudiante tiene {enProceso} asignatura(s) con calificaciones pendientes o en proceso. No se puede determinar su promoción hasta asentar todas las notas semestrales.";
                return evaluacion;
            }

            // 2. Regla: 3 o más clases a reparar -> Repite el año directamente
            if ((enReparacion + reprobadas) >= 3)
            {
                evaluacion.DebeRepetir = true;
                evaluacion.Dictamen = $"El estudiante reprobó/dejó a reparación {enReparacion + reprobadas} asignaturas (máximo permitido para reparación: 2). Por normativa académica no califica para examen de promoción y debe repetir el año escolar.";
                return evaluacion;
            }

            // 3. Regla: Dejó reparaciones y reprobó al menos 1 en examen de reparación -> Repite el año
            if (reprobadas > 0)
            {
                evaluacion.DebeRepetir = true;
                evaluacion.Dictamen = $"El estudiante reprobó {reprobadas} asignatura(s) en Examen de Reparación. Por normativa académica debe repetir el año escolar.";
                return evaluacion;
            }

            // 4. Regla: Tiene 1 o 2 clases a reparar pendientes
            if (enReparacion > 0)
            {
                evaluacion.EnReparacion = true;
                evaluacion.Dictamen = $"El estudiante tiene {enReparacion} asignatura(s) pendientes de rendir Examen de Reparación. Para matricularse al siguiente año debe aprobar todas las materias.";
                return evaluacion;
            }

            // 5. Todas las asignaturas están aprobadas
            if (aprobadas == evaluacion.TotalMaterias && evaluacion.TotalMaterias > 0)
            {
                // Si es 11mo Grado (5to Año)
                if (matricula.IdAnio == 5 || matricula.NombreAnio.Contains("11"))
                {
                    evaluacion.EsGraduado = true;
                    evaluacion.Dictamen = "¡Felicidades, estudiante graduado! Ha aprobado todas las materias de 5to año y completado exitosamente su bachillerato.";
                }
                else
                {
                    evaluacion.PuedeAvanzar = true;
                    evaluacion.Dictamen = $"Todas las asignaturas del año han sido aprobadas satisfactoriamente (Promedio: {evaluacion.PromedioFinal:N2}). Estudiante apto para ser matriculado en {evaluacion.SiguienteAnioNombre}.";
                }
            }

            return evaluacion;
        }

        public async Task<(int NuevoIdMatricula, string Mensaje)> MatricularSiguienteAnioAsync(int idMatriculaActual, int idSeccionNueva)
        {
            if (idMatriculaActual <= 0)
                throw new Exception("Debe seleccionar una matrícula válida.");

            if (idSeccionNueva <= 0)
                throw new Exception("Debe seleccionar la sección para el nuevo año escolar.");

            return await _matriculaDal.MatricularSiguienteAnioAsync(idMatriculaActual, idSeccionNueva);
        }

        public async Task<(int NuevoIdMatricula, string Mensaje)> MatricularMismoAnioAsync(int idMatriculaActual, int idSeccionNueva)
        {
            if (idMatriculaActual <= 0)
                throw new Exception("Debe seleccionar una matrícula válida.");

            if (idSeccionNueva <= 0)
                throw new Exception("Debe seleccionar la sección donde repetirá el año escolar.");

            return await _matriculaDal.MatricularMismoAnioAsync(idMatriculaActual, idSeccionNueva);
        }
    }
}
