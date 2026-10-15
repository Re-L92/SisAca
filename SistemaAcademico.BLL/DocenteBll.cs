using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.BLL
{
    public class DocenteBll
    {
        private readonly DocenteDal _docenteDal;

        public DocenteBll(DocenteDal? docenteDal = null)
        {
            _docenteDal = docenteDal ?? new DocenteDal();
        }

        public async Task<List<DocenteEntity>> ListarAsync(string filtro = "")
        {
            return await _docenteDal.ListarAsync(filtro.Trim());
        }

        public async Task<int> GuardarAsync(DocenteEntity docente)
        {
            if (docente == null)
                throw new Exception("La información del docente no puede ser nula.");

            try
            {
                return await _docenteDal.GuardarAsync(docente);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601 || ex.Message.Contains("cédula") || ex.Message.Contains("cedula"))
                    throw new Exception("Ya existe un docente registrado con el número de cédula proporcionado.");

                throw new Exception($"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar el docente: {ex.Message}");
            }
        }
    }
}
