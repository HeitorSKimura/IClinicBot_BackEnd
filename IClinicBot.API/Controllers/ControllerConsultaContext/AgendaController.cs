﻿using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers.ControllerConsultaContext
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AgendaController : ControllerBase
    {
        readonly IRepositoryAgenda _repositoryAgenda;

        public AgendaController(IRepositoryAgenda repository)
        {
            _repositoryAgenda = repository;
        }

        [HttpGet]
        public ActionResult<List<Agenda>> GetAll()
        {
            return Ok(_repositoryAgenda.GetAllAgenda());
        }

        [HttpPost]
        public ActionResult<Agenda> Post(ViewModelAgenda agenda)
        {
            var retorno = _repositoryAgenda.PostAgenda(agenda);
            return Ok(retorno);
        }

        [HttpPut]
        public ActionResult<Agenda> PutColetor(int idAgenda)
        {
            _repositoryAgenda.DesmarcarAgenda(idAgenda);
            return Ok("Agenda Desmarcada com Sucesso!!");
        }
    }
}