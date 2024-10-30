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
    public class ConsultaPresencialController : ControllerBase
    {
        readonly IRepositoryConsultaPresencial _repositoryConsultaPresencial;

        public ConsultaPresencialController(IRepositoryConsultaPresencial repository)
        {
            _repositoryConsultaPresencial = repository;
        }

        [HttpGet]
        public ActionResult<List<ConsultaPresencial>> GetAll()
        {
            return Ok(_repositoryConsultaPresencial.GetAllConsultaPresencial());
        }

        [HttpPost]
        public ActionResult<ConsultaPresencial> Post(ViewModelConsultaPresencial consultaPresencial)
        {
            var retorno = _repositoryConsultaPresencial.PostConsultaPresencial(consultaPresencial);
            return Ok(retorno);
        }
    }
}