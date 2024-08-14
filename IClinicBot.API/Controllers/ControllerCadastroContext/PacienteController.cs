using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerCadastroContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        readonly IRepositoryPaciente _repositoryPaciente;

        public PacienteController(IRepositoryPaciente repository)
        {
            _repositoryPaciente = repository;
        }

        [HttpGet]
        public ActionResult<List<Paciente>> GetAll()
        {
            return Ok(_repositoryPaciente.GetAllPaciente());
        }

        [HttpPost]
        public ActionResult<Paciente> Post(ViewModelPaciente paciente)
        {
            var retorno = _repositoryPaciente.PostPaciente(paciente);
            return Ok(retorno);
        }
    }
}