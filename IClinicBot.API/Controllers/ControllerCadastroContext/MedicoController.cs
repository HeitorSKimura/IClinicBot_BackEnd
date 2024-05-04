using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.CadastroContextViewModel;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace IClinicBot.Application.API.Controllers.ControllerCadastroContext
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        readonly IRepositoryMedico _repositoryMedico;

        public MedicoController(IRepositoryMedico repository)
        {
            _repositoryMedico = repository;
        }

        [HttpGet]
        public ActionResult<List<Medico>> GetAll()
        {
            return Ok(_repositoryMedico.GetAllMedico());
        }

        [HttpPost]
        public ActionResult<Medico> Post(ViewModelMedico medico)
        {
            var retorno = _repositoryMedico.PostMedico(medico);
            return Ok(retorno);
        }
    }
}
