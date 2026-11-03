using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class CalificacionEntity
    {
        public int IdCalificacion { get; private set; }
        public int IdMatricula { get; private set; }
        public int IdAsignatura { get; private set; }
        public string NombreAsignatura { get; private set; } = string.Empty;
        public int HorasSemanales { get; private set; } = 4;
        public decimal? NotaI_Semestre { get; private set; }
        public decimal? NotaII_Semestre { get; private set; }
        public decimal? NotaFinal { get; private set; }
        public decimal? NotaReparacion { get; private set; }
        public string EstadoAsignatura { get; private set; } = "En proceso";
        public string Observacion { get; private set; } = "Calificaciones en proceso";

        #region Constructores

        public CalificacionEntity() { }

        public CalificacionEntity(int idMatricula, int idAsignatura, string nombreAsignatura, int horasSemanales = 4)
        {
            AsignarMatricula(idMatricula);
            AsignarAsignatura(idAsignatura, nombreAsignatura, horasSemanales);
            EstadoAsignatura = "En proceso";
            Observacion = "Inscripción inicial";
        }

        #endregion

        #region Métodos de Encapsulamiento y Autovalidación

        public void AsignarId(int id)
        {
            IdCalificacion = id;
        }

        public void AsignarMatricula(int idMatricula)
        {
            if (idMatricula <= 0)
                throw new Exception("El identificador de matrícula debe ser válido.");

            IdMatricula = idMatricula;
        }

        public void AsignarAsignatura(int idAsignatura, string nombreAsignatura, int horasSemanales = 4)
        {
            if (idAsignatura <= 0)
                throw new Exception("El identificador de asignatura debe ser válido.");

            IdAsignatura = idAsignatura;
            NombreAsignatura = string.IsNullOrWhiteSpace(nombreAsignatura) ? "Asignatura" : nombreAsignatura.Trim();
            HorasSemanales = horasSemanales > 0 ? horasSemanales : 4;
        }

        public void AsignarValoresDesdeBD(
            decimal? nota1,
            decimal? nota2,
            decimal? notaFinal,
            decimal? reparacion,
            string estado,
            string observacion)
        {
            NotaI_Semestre = nota1;
            NotaII_Semestre = nota2;
            NotaFinal = notaFinal;
            NotaReparacion = reparacion;
            EstadoAsignatura = string.IsNullOrWhiteSpace(estado) ? "En proceso" : estado.Trim();
            Observacion = observacion?.Trim() ?? string.Empty;
        }

        public void CambiarNotaISemestre(decimal? nota)
        {
            if (nota.HasValue && (nota.Value < 0 || nota.Value > 100))
                throw new Exception("La calificación del I Semestre debe estar comprendida entre 0 y 100 puntos.");

            NotaI_Semestre = nota.HasValue ? Math.Round(nota.Value, 2) : null;
            CalcularResultado();
        }

        public void CambiarNotaIISemestre(decimal? nota)
        {
            if (nota.HasValue && (nota.Value < 0 || nota.Value > 100))
                throw new Exception("La calificación del II Semestre debe estar comprendida entre 0 y 100 puntos.");

            NotaII_Semestre = nota.HasValue ? Math.Round(nota.Value, 2) : null;
            CalcularResultado();
        }

        public void CambiarNotaReparacion(decimal? nota)
        {
            if (nota.HasValue && (nota.Value < 0 || nota.Value > 100))
                throw new Exception("La calificación de examen de reparación debe estar comprendida entre 0 y 100 puntos.");

            NotaReparacion = nota.HasValue ? Math.Round(nota.Value, 2) : null;
            CalcularResultado();
        }

        /// <summary>
        /// Realiza el cálculo automático de Nota Final (0-100) y determina el Estado según las reglas del sistema:
        /// - Semestre I (50%) + Semestre II (50%) = Nota Final.
        /// - Nota Final >= 60.00: Aprobada en curso regular.
        /// - Nota Final < 60.00: Pasa a Reparación.
        /// - Si rinde Examen de Reparación (>= 60.00: Aprobada; < 60.00: Reprobada).
        /// </summary>
        public void CalcularResultado()
        {
            // 1. Si ambas notas semestrales están presentes, calculamos el promedio ponderado (50% cada una)
            if (NotaI_Semestre.HasValue && NotaII_Semestre.HasValue)
            {
                NotaFinal = Math.Round((NotaI_Semestre.Value * 0.50m) + (NotaII_Semestre.Value * 0.50m), 2);

                if (NotaFinal.Value >= 60.00m)
                {
                    EstadoAsignatura = "Aprobada";
                    Observacion = "Aprobada en curso regular";
                }
                else
                {
                    EstadoAsignatura = "Reparación";
                    Observacion = "Pendiente de examen de reparación";
                }
            }
            else
            {
                NotaFinal = null;
                EstadoAsignatura = "En proceso";
                Observacion = "Calificaciones semestrales incompletas";
            }

            // 2. Si rindió examen de reparación, este prevalece sobre el estado final
            if (NotaReparacion.HasValue)
            {
                if (NotaReparacion.Value >= 60.00m)
                {
                    EstadoAsignatura = "Aprobada";
                    Observacion = "Aprobada en Examen de Reparación";
                }
                else
                {
                    EstadoAsignatura = "Reprobada";
                    Observacion = "Reprobada en Examen de Reparación";
                }
            }
        }

        #endregion

        public override string ToString() => $"{NombreAsignatura} - Final: {NotaFinal?.ToString("N2") ?? "S/N"} ({EstadoAsignatura})";
    }
}
