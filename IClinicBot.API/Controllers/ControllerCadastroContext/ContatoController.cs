using IClinicBot.Domain.Entidades.CadastroContext;
using IClinicBot.Domain.Interfaces.IServicesCadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerCadastroContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        readonly IServiceContato _serviceContato;

        public ContatoController(IServiceContato service)
        {
            _serviceContato = service;
        }

        [HttpGet]
        public ActionResult<List<Contato>> GetAll()
        {
            return Ok(_serviceContato.GetAllContato());
        }

        [HttpPost]
        public ActionResult<Contato> Post(ViewModelContato contato)
        {
            var retorno = _serviceContato.PostContato(contato);
            return Ok(retorno);
        }
    }
}