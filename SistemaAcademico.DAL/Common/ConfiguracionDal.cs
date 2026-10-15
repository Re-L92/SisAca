using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.DAL.Common
{
    public class ConfiguracionDal
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "configuracion.json");

        public bool ExisteConfiguracion()
        {
            return File.Exists(rutaArchivo);
        }

        public bool Guardar(ConexionEntity config)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo)!);

                string json = JsonSerializer.Serialize(config,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(rutaArchivo, json);
                Conexion.CadenaConexion = Conexion.ConstruirCadena(config);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CargarConexionActiva()
        {
            var config = Obtener();
            if (config == null)
                return false;

            Conexion.CadenaConexion = Conexion.ConstruirCadena(config);
            return true;
        }

        public ConexionEntity? Obtener()
        {
            if (!File.Exists(rutaArchivo))
                return null;

            string json = File.ReadAllText(rutaArchivo);

            return JsonSerializer.Deserialize<ConexionEntity>(json);
        }
    }
}
