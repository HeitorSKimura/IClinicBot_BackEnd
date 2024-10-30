using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ConsultaController : ControllerBase
    {
        readonly IRepositoryConsulta _repositoryConsulta;

        public ConsultaController(IRepositoryConsulta repository)
        {
            _repositoryConsulta = repository;
        }

        [HttpGet]
        public ActionResult<List<Consulta>> GetAll()
        {
            return Ok(_repositoryConsulta.GetAllConsulta());
        }


    }
}