using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerCadastroContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        readonly IRepositoryEspecialidade _repository;

        public EspecialidadeController(IRepositoryEspecialidade repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Especialidade>> GetAll()
        {
            return Ok(_repository.GetAllEspecialidade());
        }

        [HttpPost]
        public ActionResult<Especialidade> Post(ViewModelEspecialidade especialidade)
        {
            var retorno = _repository.PostEspecialidade(especialidade);
            return Ok(retorno);
        }
    }
}
