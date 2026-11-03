using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaAcademico.DAL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.BLL
{
    public class CalificacionBll
    {
        private readonly CalificacionDal _calificacionDal;
        private readonly AlumnoDal _alumnoDal;

        public CalificacionBll(CalificacionDal? calificacionDal = null, AlumnoDal? alumnoDal = null)
        {
            _calificacionDal = calificacionDal ?? new CalificacionDal();
            _alumnoDal = alumnoDal ?? new AlumnoDal();
        }

        public async Task<List<AnioAcademicoEntity>> ListarAniosAcademicosAsync()
        {
            return await _alumnoDal.ListarAniosAcademicosAsync();
        }

        public async Task<List<SeccionEntity>> ListarSeccionesAsync()
        {
            return await _alumnoDal.ListarSeccionesAsync();
        }

        public async Task<List<MatriculaEntity>> ListarMatriculasAsync(int idAnio = 0, int idSeccion = 0, string filtro = "")
        {
            return await _calificacionDal.ListarMatriculasAsync(idAnio, idSeccion, filtro?.Trim() ?? string.Empty);
        }

        public async Task<List<CalificacionEntity>> ObtenerCalificacionesPorMatriculaAsync(int idMatricula, int idAnio = 0)
        {
            if (idMatricula <= 0)
                throw new Exception("Debe seleccionar un estudiante matriculado válido.");

            var lista = await _calificacionDal.ObtenerCalificacionesPorMatriculaAsync(idMatricula);

            // Si por alguna razón la matrícula no tenía calificaciones inicializadas y conocemos el año
            if ((lista == null || lista.Count == 0) && idAnio > 0)
            {
                await _calificacionDal.AsegurarCalificacionesMatriculaAsync(idMatricula, idAnio);
                lista = await _calificacionDal.ObtenerCalificacionesPorMatriculaAsync(idMatricula);
            }

            return lista ?? new List<CalificacionEntity>();
        }

        public async Task GuardarCalificacionAsync(CalificacionEntity calificacion)
        {
            if (calificacion == null)
                throw new Exception("La información de calificación no puede ser nula.");

            if (calificacion.IdCalificacion <= 0)
                throw new Exception("Identificador de calificación no válido.");

            // Validar límites 0 - 100
            ValidarNota(calificacion.NotaI_Semestre, "I Semestre");
            ValidarNota(calificacion.NotaII_Semestre, "II Semestre");
            ValidarNota(calificacion.NotaReparacion, "Examen de Reparación");

            // Recalcular resultados y estados según reglas del sistema
            calificacion.CalcularResultado();

            await _calificacionDal.GuardarCalificacionAsync(calificacion);
        }

        public async Task GuardarCalificacionesLoteAsync(List<CalificacionEntity> lista)
        {
            if (lista == null || lista.Count == 0)
                throw new Exception("No hay calificaciones para guardar.");

            foreach (var cal in lista)
            {
                ValidarNota(cal.NotaI_Semestre, $"I Semestre ({cal.NombreAsignatura})");
                ValidarNota(cal.NotaII_Semestre, $"II Semestre ({cal.NombreAsignatura})");
                ValidarNota(cal.NotaReparacion, $"Examen de Reparación ({cal.NombreAsignatura})");

                cal.CalcularResultado();
            }

            await _calificacionDal.GuardarCalificacionesLoteAsync(lista);
        }

        public ResumenCalificacionesModel CalcularResumen(List<CalificacionEntity> lista)
        {
            var resumen = new ResumenCalificacionesModel();

            if (lista == null || lista.Count == 0)
                return resumen;

            resumen.TotalAsignaturas = lista.Count;

            int aprobadas = 0;
            int enReparacion = 0;
            int reprobadas = 0;
            int enProceso = 0;

            decimal sumaNotasFinales = 0;
            int notasFinalesContadas = 0;

            foreach (var c in lista)
            {
                if (c.NotaFinal.HasValue)
                {
                    // Si rindió reparación, la nota que cuenta para aprobación es reparación, pero para promedio ponderado final
                    decimal notaConsiderada = c.NotaReparacion.HasValue ? c.NotaReparacion.Value : c.NotaFinal.Value;
                    sumaNotasFinales += notaConsiderada;
                    notasFinalesContadas++;
                }

                switch (c.EstadoAsignatura.ToLower())
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

            resumen.AsignaturasAprobadas = aprobadas;
            resumen.AsignaturasEnReparacion = enReparacion;
            resumen.AsignaturasReprobadas = reprobadas;
            resumen.AsignaturasEnProceso = enProceso;

            if (notasFinalesContadas > 0)
            {
                resumen.PromedioGeneral = Math.Round(sumaNotasFinales / notasFinalesContadas, 2);
            }
            else
            {
                resumen.PromedioGeneral = 0;
            }

            return resumen;
        }

        private static void ValidarNota(decimal? nota, string campo)
        {
            if (nota.HasValue)
            {
                if (nota.Value < 0 || nota.Value > 100)
                    throw new Exception($"La nota de '{campo}' debe estar en el rango de 0 a 100 puntos.");
            }
        }
    }
}
