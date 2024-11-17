using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpGet("{id}")]
        public IActionResult GetAgendaChatBotById(int id)
        {
            try
            {
                return Ok(_repositoryAgendaChatBot.GetAgendaChatBotById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<AgendaChatBot> Post(ViewModelAgendaChatBot agendaChatBot)
        {
            var retorno = _repositoryAgendaChatBot.PostAgendaChatBot(agendaChatBot);
            return Ok(retorno);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAgendaChatBot(int id, ViewModelAgendaChatBot agendaChatBot)
        {
            try
            {
                _repositoryAgendaChatBot.UpdateAgendaChatBot(id, agendaChatBot);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}