using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class SeccionEntity
    {
        public int IdSeccion { get; set; }
        public string NombreSeccion { get; set; } = string.Empty;
        public int CapacidadMaxima { get; set; } = 40;
        public int Matriculados { get; set; } = 0;
        public int CuposDisponibles { get; set; } = 40;

        public bool EstaLlena => Matriculados >= CapacidadMaxima;

        public string DescripcionCompleta
        {
            get
            {
                if (EstaLlena)
                    return $"Sección {NombreSeccion} ({Matriculados}/{CapacidadMaxima} alumnos - LLENA)";
                return $"Sección {NombreSeccion} ({Matriculados}/{CapacidadMaxima} alumnos - {CuposDisponibles} cupos disp.)";
            }
        }

        public override string ToString() => DescripcionCompleta;
    }
}
