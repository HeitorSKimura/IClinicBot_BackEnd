using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaMedicoController : ControllerBase
    {
        readonly IRepositoryAgendaMedico _repositoryAgendaMedico;

        public AgendaMedicoController(IRepositoryAgendaMedico repository)
        {
            _repositoryAgendaMedico = repository;
        }

        [HttpGet]
        public ActionResult<List<AgendaMedico>> GetAll()
        {
            return Ok(_repositoryAgendaMedico.GetAllAgendaMedico());
        }

        [HttpPost]
        public ActionResult<AgendaMedico> Post(ViewModelAgendaMedico agendaMedico)
        {
            var retorno = _repositoryAgendaMedico.PostAgendaMedico(agendaMedico);
            return Ok(retorno);
        }
    }
}
