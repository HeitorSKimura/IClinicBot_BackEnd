using IClinicBot.Domain.CadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerCadastroContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoEspecialidadeController : ControllerBase
    {
        readonly IRepositoryMedicoEspecialidade _repository;

        public MedicoEspecialidadeController(IRepositoryMedicoEspecialidade repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<MedicoEspecialidade>> GetAll()
        {
            return Ok(_repository.GetAllMedicoEspecialidade());
        }

        [HttpPost]
        public ActionResult<MedicoEspecialidade> Post(int idmedico, int idespecialidade)
        {
            MedicoEspecialidade medicoEspIdSaved = _repository.PostMedicoEspecialidade(idmedico, idespecialidade);
            return Ok(medicoEspIdSaved);
        }
    }
}
