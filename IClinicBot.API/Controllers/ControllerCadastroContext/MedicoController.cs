using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.CadastroContextViewModel;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerCadastroContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        readonly IRepositoryMedico _repositoryMedico;

        public MedicoController(IRepositoryMedico repository)
        {
            _repositoryMedico = repository;
        }

        [HttpGet]
        public ActionResult<List<Medico>> GetAll()
        {
            return Ok(_repositoryMedico.GetAllMedico());
        }

        [HttpPost]
        public ActionResult<Medico> Post(ViewModelMedico medico)
        {
            if (medico.SenhaParaCadastrar != "IClinicBot")
                return BadRequest();

            var retorno = _repositoryMedico.PostMedico(medico);
            return Ok(retorno);
        }
    }
}