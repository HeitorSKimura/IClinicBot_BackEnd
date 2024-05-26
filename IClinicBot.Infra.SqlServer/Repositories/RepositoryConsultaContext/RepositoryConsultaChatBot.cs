using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryConsultaChatBot : IRepositoryConsultaChatBot
    {
        private readonly SqlServerContext _context;

        public RepositoryConsultaChatBot(SqlServerContext context)
        {
            _context = context;
        }

        public List<ConsultaChatBot> GetAllConsultaChatBot()
        {
            return _context.ConsultasChatBot.ToList();
        }

        public ConsultaChatBot PostConsultaChatBot(ViewModelConsultaChatBot consultaChatBot)
        {
            var consultaRepository = new ConsultaChatBot
            {
                idEndereco = consultaChatBot.idEndereco,
                idPaciente = consultaChatBot.idPaciente,
                Conversa = consultaChatBot.Conversa,
                Tipo = consultaChatBot.Tipo,
                DataConsulta = consultaChatBot.DataConsulta,
            };
            _context.ConsultasChatBot.Add(consultaRepository);
            _context.SaveChanges();
            return consultaRepository;
        }
    }
}
