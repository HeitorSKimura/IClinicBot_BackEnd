using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        readonly IRepositoryPagamento _repository;

        public PagamentoController(IRepositoryPagamento repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Pagamento>> GetAll()
        {
            return Ok(_repository.GetAllPagamento());
        }

        [HttpPost]
        public ActionResult<Pagamento> Post(ViewModelPagamento view)
        {
            var retorno = _repository.PostPagamento(view);
            return Ok(retorno);
        }
    }
}
