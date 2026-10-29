using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class AsignaturaEntity
    {
        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get; set; } = string.Empty;
        public int HorasSemanales { get; set; } = 4;

        public override string ToString() => NombreAsignatura;
    }
}
