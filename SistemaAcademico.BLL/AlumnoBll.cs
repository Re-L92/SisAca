using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAcademico.DAL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.BLL
{
    public class AlumnoBll
    {
        private readonly AlumnoDal _alumnoDal;

        public AlumnoBll(AlumnoDal? alumnoDal = null)
        {
            _alumnoDal = alumnoDal ?? new AlumnoDal();
        }

        public async Task<List<AlumnoEntity>> ListarAsync(string filtro = "", string estado = "")
        {
            var lista = await _alumnoDal.ListarAsync(filtro.Trim());

            if (!string.IsNullOrWhiteSpace(estado))
            {
                lista = lista.FindAll(a => a.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase));
            }

            return lista;
        }

        public async Task<List<AnioAcademicoEntity>> ListarAniosAcademicosAsync()
        {
            return await _alumnoDal.ListarAniosAcademicosAsync();
        }

        public async Task<List<SeccionEntity>> ListarSeccionesAsync()
        {
            return await _alumnoDal.ListarSeccionesAsync();
        }

        public async Task<List<SeccionEntity>> ListarSeccionesConDisponibilidadAsync(int idAnio)
        {
            if (idAnio <= 0) return new List<SeccionEntity>();
            return await _alumnoDal.ListarSeccionesConDisponibilidadAsync(idAnio);
        }

        public async Task<List<AsignaturaEntity>> ListarAsignaturasPorAnioAsync(int idAnio)
        {
            if (idAnio <= 0) return new List<AsignaturaEntity>();
            return await _alumnoDal.ListarAsignaturasPorAnioAsync(idAnio);
        }

        public async Task<int> ObtenerSiguienteNumeroMatriculaAsync()
        {
            return await _alumnoDal.ObtenerSiguienteNumeroMatriculaAsync();
        }

        public async Task<int> ObtenerSiguienteCorrelativoEstudianteAsync()
        {
            return await _alumnoDal.ObtenerSiguienteCorrelativoEstudianteAsync();
        }

        public async Task<string> CambiarEstadoEstudianteAsync(int idEstudiante, string? nuevoEstado = null)
        {
            if (idEstudiante <= 0)
                throw new Exception("Identificador de estudiante inválido.");

            return await _alumnoDal.CambiarEstadoEstudianteAsync(idEstudiante, nuevoEstado);
        }

        /// <summary>
        /// Genera el identificador único del estudiante con las primeras letras de sus 2 nombres
        /// y 2 apellidos más el número correlativo de matrícula (ej: Jonathan David Jimenez Guido -> JDJG1).
        /// </summary>
        public string GenerarCodigoEstudiante(string nombres, string apellidos, int numeroMatricula)
        {
            string LetrasNombres(string texto)
            {
                var partes = texto.Trim()
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (partes.Length >= 2)
                {
                    return $"{char.ToUpper(partes[0][0])}{char.ToUpper(partes[1][0])}";
                }
                else if (partes.Length == 1 && partes[0].Length >= 2)
                {
                    return $"{char.ToUpper(partes[0][0])}{char.ToUpper(partes[0][1])}";
                }
                else if (partes.Length == 1)
                {
                    return $"{char.ToUpper(partes[0][0])}X";
                }
                return "XX";
            }

            string inicialesNombres = LetrasNombres(nombres);
            string inicialesApellidos = LetrasNombres(apellidos);

            return $"{inicialesNombres}{inicialesApellidos}{numeroMatricula}";
        }

        public async Task<(int IdEstudiante, int IdMatricula, string CodigoGenerado)> RegistrarEstudianteYMatriculaAsync(AlumnoRegistroModel model)
        {
            if (model == null)
                throw new Exception("La información del estudiante y matrícula no puede ser nula.");

            if (string.IsNullOrWhiteSpace(model.EstudianteNombres))
                throw new Exception("Debe ingresar los nombres del estudiante.");

            if (string.IsNullOrWhiteSpace(model.EstudianteApellidos))
                throw new Exception("Debe ingresar los apellidos del estudiante.");

            if (model.IdAnio <= 0)
                throw new Exception("Debe seleccionar el año académico a matricular.");

            if (model.IdSeccion <= 0)
                throw new Exception("Debe seleccionar la sección.");

            if (string.IsNullOrWhiteSpace(model.TutorNombres))
                throw new Exception("Debe ingresar los nombres del tutor o responsable.");

            if (string.IsNullOrWhiteSpace(model.TutorApellidos))
                throw new Exception("Debe ingresar los apellidos del tutor o responsable.");

            if (string.IsNullOrWhiteSpace(model.TutorCedula))
                throw new Exception("Debe ingresar el número de cédula del tutor.");

            if (string.IsNullOrWhiteSpace(model.TutorTelefono))
                throw new Exception("Debe ingresar el teléfono de contacto del tutor.");

            try
            {
                int correlativo = await _alumnoDal.ObtenerSiguienteCorrelativoEstudianteAsync();
                if (string.IsNullOrWhiteSpace(model.EstudianteCodigo))
                {
                    string codigo = GenerarCodigoEstudiante(model.EstudianteNombres, model.EstudianteApellidos, correlativo);
                    model.AsignarCodigo(codigo);
                }

                var (idEstudiante, idMatricula) = await _alumnoDal.RegistrarEstudianteYMatriculaAsync(model);
                return (idEstudiante, idMatricula, model.EstudianteCodigo);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("capacidad máxima") || ex.Message.Contains("alcanzado su capacidad"))
                {
                    throw new Exception("La sección seleccionada ha alcanzado su capacidad máxima permitida (40 alumnos). Por favor elija otra sección con cupos disponibles.");
                }

                if (ex.Message.Contains("UQ_Estudiante_Anio") || ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("CodigoEstudiante"))
                        throw new Exception("Ya existe un estudiante registrado con este código de estudiante.");

                    throw new Exception("El estudiante ya se encuentra matriculado en este año académico.");
                }

                throw new Exception($"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar la matrícula del alumno: {ex.Message}");
            }
        }
    }
}
