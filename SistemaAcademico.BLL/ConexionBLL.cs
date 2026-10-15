using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.DAL.Common;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.BLL
{
    public class ConexionBll
    {
        private readonly ConfiguracionDal _configuracionDal = new();

        public async Task<bool> ProbarConexion(string servidor, string baseDatos, string usuario, string password)
        {
            var config = new ConexionEntity
            {
                Servidor = servidor,
                BaseDatos = baseDatos,
                UsuarioSql = usuario,
                Password = password
            };

            string cadena = Conexion.ConstruirCadena(config);
            return await Conexion.ProbarConexion(cadena);
        }

        public bool GuardarConfiguracion(ConexionEntity config)
        {
            return _configuracionDal.Guardar(config);
        }

        public ConexionEntity? ObtenerConfiguracion()
        {
            return _configuracionDal.Obtener();
        }

        public bool ExisteConfiguracion()
        {
            return _configuracionDal.ExisteConfiguracion();
        }

        public async Task<bool> InicializarConexion()
        {
            if (!_configuracionDal.ExisteConfiguracion())
                return false;

            var config = _configuracionDal.Obtener();
            if (config == null)
                return false;

            string cadena = Conexion.ConstruirCadena(config);
            bool conecta = await Conexion.ProbarConexion(cadena);
            if (conecta)
            {
                Conexion.CadenaConexion = cadena;
                return true;
            }

            return false;
        }
    }
}
