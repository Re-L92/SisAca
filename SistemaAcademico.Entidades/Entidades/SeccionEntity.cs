using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class SeccionEntity
    {
        public int IdSeccion { get; private set; }
        public string NombreSeccion { get; private set; } = string.Empty;
        public int CapacidadMaxima { get; private set; } = 40;
        public int Matriculados { get; private set; } = 0;
        public int CuposDisponibles { get; private set; } = 40;

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

        #region Constructores

        public SeccionEntity() { }

        public SeccionEntity(string nombreSeccion, int capacidadMaxima = 40)
        {
            CambiarNombreSeccion(nombreSeccion);
            AsignarCapacidadMaxima(capacidadMaxima);
        }

        #endregion

        #region Métodos de Encapsulamiento

        public void AsignarId(int id)
        {
            IdSeccion = id;
        }

        public void CambiarNombreSeccion(string nombreSeccion)
        {
            if (string.IsNullOrWhiteSpace(nombreSeccion))
                throw new Exception("El nombre de la sección es obligatorio.");

            NombreSeccion = nombreSeccion.Trim();
        }

        public void AsignarCapacidadMaxima(int capacidad)
        {
            CapacidadMaxima = capacidad > 0 ? capacidad : 40;
            CuposDisponibles = Math.Max(0, CapacidadMaxima - Matriculados);
        }

        public void AsignarMatriculados(int matriculados)
        {
            Matriculados = Math.Max(0, matriculados);
            CuposDisponibles = Math.Max(0, CapacidadMaxima - Matriculados);
        }

        public void AsignarCuposDisponibles(int cupos)
        {
            CuposDisponibles = Math.Max(0, cupos);
        }

        #endregion

        public override string ToString() => DescripcionCompleta;
    }
}
