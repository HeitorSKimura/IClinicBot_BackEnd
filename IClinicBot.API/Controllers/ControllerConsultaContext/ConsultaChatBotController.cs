using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaChatBotController : ControllerBase
    {
        readonly IRepositoryConsultaChatBot _conultaChatBot;

        public ConsultaChatBotController(IRepositoryConsultaChatBot repository)
        {
            _conultaChatBot = repository;
        }

        [HttpGet]
        public ActionResult<List<ConsultaChatBot>> GetAll()
        {
            return Ok(_conultaChatBot.GetAllConsultaChatBot());
        }

        [HttpPost]
        public ActionResult<ConsultaChatBot> Post(ViewModelConsultaChatBot chatBot)
        {
            var retorno = _conultaChatBot.PostConsultaChatBot(chatBot);
            return Ok(retorno);
        }
    }
}
