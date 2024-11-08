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

        public Agenda? GetbyIdAgenda(int id)
        {
            return _context.Agendas.Find(id);
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

        public bool DesmarcarAgenda(int idAgenda)
        {
            var agenda = GetbyIdAgenda(idAgenda);
            if (agenda == null)
            {
                return false;
            }
            agenda.SeAtivado = false;
            _context.Agendas.Update(agenda);
            _context.SaveChanges();
            return true;
        }
    }
}
