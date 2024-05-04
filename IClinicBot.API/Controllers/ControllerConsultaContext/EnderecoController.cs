using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        readonly IRepositoryEndereco _repositoryEndereco;

        public EnderecoController(IRepositoryEndereco repository)
        {
            _repositoryEndereco = repository;
        }

        [HttpGet]
        public ActionResult<List<Endereco>> GetAll()
        {
            return Ok(_repositoryEndereco.GetAllEndereco());
        }

        [HttpPost]
        public ActionResult<Endereco> Post(ViewModelEndereco endereco)
        {
            var retorno = _repositoryEndereco.PostEndereco(endereco);
            return Ok(retorno);
        }
    }
}
