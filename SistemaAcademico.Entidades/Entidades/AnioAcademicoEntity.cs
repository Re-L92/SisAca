using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AnioAcademicoEntity
    {
        public int IdAnio { get; set; }
        public string NombreAnio { get; set; } = string.Empty;
        public string Ciclo { get; set; } = string.Empty;

        public override string ToString() => NombreAnio;
    }
}
