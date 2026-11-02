using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AsignaturaEntity
    {
        public int IdAsignatura { get; private set; }
        public string NombreAsignatura { get; private set; } = string.Empty;
        public int HorasSemanales { get; private set; } = 4;

        #region Constructores

        public AsignaturaEntity() { }

        public AsignaturaEntity(string nombreAsignatura, int horasSemanales = 4)
        {
            CambiarNombreAsignatura(nombreAsignatura);
            AsignarHorasSemanales(horasSemanales);
        }

        #endregion

        #region Métodos de Encapsulamiento

        public void AsignarId(int id)
        {
            IdAsignatura = id;
        }

        public void CambiarNombreAsignatura(string nombreAsignatura)
        {
            if (string.IsNullOrWhiteSpace(nombreAsignatura))
                throw new Exception("El nombre de la asignatura es obligatorio.");

            NombreAsignatura = nombreAsignatura.Trim();
        }

        public void AsignarHorasSemanales(int horas)
        {
            HorasSemanales = horas > 0 ? horas : 4;
        }

        #endregion

        public override string ToString() => NombreAsignatura;
    }
}
