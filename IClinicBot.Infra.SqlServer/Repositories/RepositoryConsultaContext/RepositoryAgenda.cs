using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryAgenda : IRepositoryAgenda
    {
        private readonly SqlServerContext _context;

        public RepositoryAgenda(SqlServerContext context)
        {
            _context = context;
        }

        public List<Agenda> GetAllAgenda()
        {
            return _context.Agendas.ToList();
        }

        public Agenda PostAgenda(ViewModelAgenda agenda)
        {
            var agendaRepository = new Agenda
            {
                DataAgenda = agenda.DataAgenda,
                Status = agenda.Status,
                idMedico = agenda.idMedico,
                idConsulta = agenda.idConsulta,
            };
            _context.Agendas.Add(agendaRepository);
            _context.SaveChanges();
            return agendaRepository;
        }
    }
}
