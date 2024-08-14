using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaChatBotController : ControllerBase
    {
        readonly IRepositoryAgendaChatBot _repositoryAgendaChatBot;

        public AgendaChatBotController(IRepositoryAgendaChatBot repository)
        {
            _repositoryAgendaChatBot = repository;
        }

        [HttpGet]
        public ActionResult<List<AgendaChatBot>> GetAll()
        {
            return Ok(_repositoryAgendaChatBot.GetAllAgendaChatBot());
        }

        [HttpPost]
        public ActionResult<AgendaChatBot> Post(ViewModelAgendaChatBot agendaChatBot)
        {
            var retorno = _repositoryAgendaChatBot.PostAgendaChatBot(agendaChatBot);
            return Ok(retorno);
        }
    }
}