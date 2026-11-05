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
        /// Evalúa el rendimiento escolar del alumno y determina si puede avanzar al siguiente año,
        /// si se gradúa, si debe presentar examen de reparación o si debe repetir el año.
        /// Incluye validaciones estrictas en caso de que el estudiante ya haya sido aprobado o reprobado previamente.
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
                EstadoActualMatricula = matricula.EstadoMatricula,
                Calificaciones = calificaciones ?? new List<CalificacionEntity>()
            };

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

            // =========================================================================
            // VALIDACIÓN 1: ¿EL ESTUDIANTE YA FUE APROBADO O REPROBADO ANTERIORMENTE?
            // =========================================================================
            if (matricula.EstadoMatricula.Equals("Promovido", StringComparison.OrdinalIgnoreCase))
            {
                evaluacion.YaFueAprobado = true;
                evaluacion.PuedeAvanzar = false;
                evaluacion.DebeRepetir = false;
                evaluacion.Dictamen = $"ATENCIÓN: El estudiante ya ha sido APROBADO y PROMOVIDO anteriormente al año consecutivo ({evaluacion.SiguienteAnioNombre}). No es posible volver a aprobarlo ni matricularlo desde este ciclo concluido.";
                return evaluacion;
            }

            if (matricula.EstadoMatricula.Equals("Repite Año", StringComparison.OrdinalIgnoreCase) ||
                matricula.EstadoMatricula.Equals("Repite Ano", StringComparison.OrdinalIgnoreCase))
            {
                evaluacion.YaFueReprobado = true;
                evaluacion.PuedeAvanzar = false;
                evaluacion.DebeRepetir = false;
                evaluacion.Dictamen = $"ATENCIÓN: El estudiante ya ha sido REPROBADO anteriormente en este grado escolar ({matricula.NombreAnio}) y registrado para repetir. No es posible volver a registrarlo como reprobado.";
                return evaluacion;
            }

            if (matricula.EstadoMatricula.Equals("Estudiante Graduado", StringComparison.OrdinalIgnoreCase))
            {
                evaluacion.YaGraduado = true;
                evaluacion.PuedeAvanzar = false;
                evaluacion.DebeRepetir = false;
                evaluacion.EsGraduado = false;
                evaluacion.Dictamen = "ATENCIÓN: El estudiante ya culminó con éxito su bachillerato y se encuentra formalmente GRADUADO. Su expediente escolar se encuentra cerrado.";
                return evaluacion;
            }

            // =========================================================================
            // VALIDACIÓN 2: EVALUACIÓN DE MATERIAS Y CALIFICACIONES ACTIVAS
            // =========================================================================
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

            // Notas incompletas
            if (enProceso > 0)
            {
                evaluacion.TieneNotasIncompletas = true;
                evaluacion.Dictamen = $"El estudiante tiene {enProceso} asignatura(s) con calificaciones pendientes o en proceso. No se puede determinar su promoción hasta asentar todas las notas semestrales.";
                return evaluacion;
            }

            // Regla: 3 o más clases a reparar -> Repite el año directamente
            if ((enReparacion + reprobadas) >= 3)
            {
                evaluacion.DebeRepetir = true;
                evaluacion.Dictamen = $"El estudiante reprobó/dejó a reparación {enReparacion + reprobadas} asignaturas (máximo permitido para reparación: 2). Por normativa académica debe repetir el año escolar.";
                return evaluacion;
            }

            // Regla: Dejó reparaciones y reprobó al menos 1 en examen de reparación -> Repite el año
            if (reprobadas > 0)
            {
                evaluacion.DebeRepetir = true;
                evaluacion.Dictamen = $"El estudiante reprobó {reprobadas} asignatura(s) en Examen de Reparación. Por normativa académica debe repetir el año escolar.";
                return evaluacion;
            }

            // Regla: Tiene 1 o 2 clases a reparar pendientes
            if (enReparacion > 0)
            {
                evaluacion.EnReparacion = true;
                evaluacion.Dictamen = $"El estudiante tiene {enReparacion} asignatura(s) pendientes de rendir Examen de Reparación. Para matricularse al siguiente año debe aprobar todas las materias.";
                return evaluacion;
            }

            // Regla: Todas las asignaturas están aprobadas
            if (aprobadas == evaluacion.TotalMaterias && evaluacion.TotalMaterias > 0)
            {
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

            // Validar si el estudiante ya fue aprobado o reprobado previamente
            var lista = await _matriculaDal.ListarMatriculasAsync();
            var actual = lista.FirstOrDefault(m => m.IdMatricula == idMatriculaActual);
            if (actual != null)
            {
                if (actual.EstadoMatricula.Equals("Promovido", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Validación de Matrícula: El estudiante ya ha sido aprobado y promovido anteriormente al siguiente grado académico.");

                if (actual.EstadoMatricula.Equals("Estudiante Graduado", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Validación de Matrícula: El estudiante ya se encuentra graduado formalmente de la institución.");

                if (actual.EstadoMatricula.Equals("Repite Año", StringComparison.OrdinalIgnoreCase) ||
                    actual.EstadoMatricula.Equals("Repite Ano", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Validación de Matrícula: El estudiante reprobó este grado escolar y no puede ser promovido al siguiente año.");
            }

            return await _matriculaDal.MatricularSiguienteAnioAsync(idMatriculaActual, idSeccionNueva);
        }

        public async Task<(int NuevoIdMatricula, string Mensaje)> MatricularMismoAnioAsync(int idMatriculaActual, int idSeccionNueva)
        {
            if (idMatriculaActual <= 0)
                throw new Exception("Debe seleccionar una matrícula válida.");

            if (idSeccionNueva <= 0)
                throw new Exception("Debe seleccionar la sección donde repetirá el año escolar.");

            // Validar que no se intente reprobar a quien ya aprobó o ya fue registrado como repitente
            var lista = await _matriculaDal.ListarMatriculasAsync();
            var actual = lista.FirstOrDefault(m => m.IdMatricula == idMatriculaActual);
            if (actual != null)
            {
                if (actual.EstadoMatricula.Equals("Promovido", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Validación de Matrícula: El estudiante ya aprobó satisfactoriamente este grado escolar; no puede ser registrado como reprobado ni repetir el año.");

                if (actual.EstadoMatricula.Equals("Estudiante Graduado", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Validación de Matrícula: El estudiante ya se encuentra graduado de la institución.");

                if (actual.EstadoMatricula.Equals("Repite Año", StringComparison.OrdinalIgnoreCase) ||
                    actual.EstadoMatricula.Equals("Repite Ano", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Validación de Matrícula: El estudiante ya fue registrado anteriormente como repitente para este año académico.");
            }

            return await _matriculaDal.MatricularMismoAnioAsync(idMatriculaActual, idSeccionNueva);
        }
    }
}
