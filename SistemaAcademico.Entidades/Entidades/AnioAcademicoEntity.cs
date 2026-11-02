using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AnioAcademicoEntity
    {
        public int IdAnio { get; private set; }
        public string NombreAnio { get; private set; } = string.Empty;
        public string Ciclo { get; private set; } = string.Empty;

        #region Constructores

        public AnioAcademicoEntity() { }

        public AnioAcademicoEntity(string nombreAnio, string ciclo)
        {
            CambiarNombreAnio(nombreAnio);
            CambiarCiclo(ciclo);
        }

        #endregion

        #region Métodos de Encapsulamiento

        public void AsignarId(int id)
        {
            IdAnio = id;
        }

        public void CambiarNombreAnio(string nombreAnio)
        {
            if (string.IsNullOrWhiteSpace(nombreAnio))
                throw new Exception("El nombre del año académico es obligatorio.");

            NombreAnio = nombreAnio.Trim();
        }

        public void CambiarCiclo(string ciclo)
        {
            Ciclo = ciclo?.Trim() ?? string.Empty;
        }

        #endregion

        public override string ToString() => NombreAnio;
    }
}
