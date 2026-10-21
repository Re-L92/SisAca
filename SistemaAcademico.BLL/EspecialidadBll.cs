using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaAcademico.DAL;
using SistemaAcademico.Entidades.Entidades;

namespace SistemaAcademico.BLL
{
    public class EspecialidadBll
    {
        private readonly EspecialidadDal _especialidadDal;

        public EspecialidadBll(EspecialidadDal? especialidadDal = null)
        {
            _especialidadDal = especialidadDal ?? new EspecialidadDal();
        }

        public async Task<List<EspecialidadEntity>> ListarAsync()
        {
            return await _especialidadDal.ListarAsync();
        }
    }
}
