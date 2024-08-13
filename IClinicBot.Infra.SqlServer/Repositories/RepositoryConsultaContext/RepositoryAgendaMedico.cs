using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryAgendaMedico : IRepositoryAgendaMedico
    {
        private readonly SqlServerContext _context;

        public RepositoryAgendaMedico(SqlServerContext context)
        {
            _context = context;
        }

        public List<AgendaMedico> GetAllAgendaMedico()
        {
            return _context.AgendasMedico.ToList();
        }

        public AgendaMedico PostAgendaMedico(ViewModelAgendaMedico agendaMedico)
        {
            var agendaMedicoRepository = new AgendaMedico
            {
                DataAgendaDisponivel = agendaMedico.DataAgendaDisponivel,
                Especialidade = agendaMedico.Especialidade,
                idMedico = agendaMedico.idMedico,
            };
            _context.AgendasMedico.Add(agendaMedicoRepository);
            _context.SaveChanges();
            return agendaMedicoRepository;
        }
    }
}
