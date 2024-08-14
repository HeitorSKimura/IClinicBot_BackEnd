using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoConsultaController : ControllerBase
    {
        readonly IRepositoryMedicoConsulta _repositoryMedicoConsulta;

        public MedicoConsultaController(IRepositoryMedicoConsulta repository)
        {
            _repositoryMedicoConsulta = repository;
        }

        [HttpGet]
        public ActionResult<List<MedicoConsulta>> GetAll()
        {
            return Ok(_repositoryMedicoConsulta.GetAllMedicoConsulta());
        }

        [HttpPost]
        public ActionResult<MedicoConsulta> Post(int medico, int consulta)
        {
            MedicoConsulta medicoConsultaIdSaved = _repositoryMedicoConsulta.PostMedicoConsulta(medico, consulta);
            return Ok(medicoConsultaIdSaved);
        }
    }
}