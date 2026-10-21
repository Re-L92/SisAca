using System;

namespace SistemaAcademico.Entidades.Entidades
{
    public class EspecialidadEntity
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; } = string.Empty;

        #region Constructores

        public EspecialidadEntity() { }

        public EspecialidadEntity(int id, string nombre)
        {
            AsignarId(id);
            CambiarNombre(nombre);
        }

        #endregion

        #region Métodos

        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre de la especialidad no puede estar vacío.");

            Nombre = nombre.Trim();
        }

        public override string ToString()
        {
            return Nombre;
        }

        #endregion
    }
}
