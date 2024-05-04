using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        readonly IRepositoryExame _repositoryExame;

        public ExameController(IRepositoryExame repository)
        {
            _repositoryExame = repository;
        }

        [HttpGet]
        public ActionResult<List<Exame>> GetAll()
        {
            return Ok(_repositoryExame.GetAllExame());
        }

        [HttpPost]
        public ActionResult<Exame> Post(ViewModelExame exame)
        {
            var retorno = _repositoryExame.PostExame(exame);
            return Ok(retorno);
        }
    }
}
