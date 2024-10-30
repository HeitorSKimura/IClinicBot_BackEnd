using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicoExameController : ControllerBase
    {
        readonly IRepositoryMedicoExame _repositoryMedicoExame;

        public MedicoExameController(IRepositoryMedicoExame repository)
        {
            _repositoryMedicoExame = repository;
        }

        [HttpGet]
        public ActionResult<List<MedicoExame>> GetAll()
        {
            return Ok(_repositoryMedicoExame.GetAllMedicoExame());
        }

        [HttpPost]
        public ActionResult<MedicoExame> Post(int medico, int exame)
        {
            MedicoExame medicoExameIdSaved = _repositoryMedicoExame.PostMedicoExame(medico, exame);
            return Ok(medicoExameIdSaved);
        }
    }
}