using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;


namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryAgendaChatBot : IRepositoryAgendaChatBot
    {
        private readonly SqlServerContext _context;

        public RepositoryAgendaChatBot(SqlServerContext context)
        {
            _context = context;
        }

        public List<AgendaChatBot> GetAllAgendaChatBot()
        {
            return _context.AgendasChatBot.ToList();
        }

        public AgendaChatBot PostAgendaChatBot(ViewModelAgendaChatBot agendaChatBot)
        {
            var agendaChatBotRepository = new AgendaChatBot
            {
                DataAgendaChatBot = agendaChatBot.DataAgendaChatBot,
                Cel = agendaChatBot.Cel,
                Nome = agendaChatBot.Nome,
                Especialidade = agendaChatBot.Especialidade,
                FormaPagamento = agendaChatBot.FormaPagamento,
            };
            _context.AgendasChatBot.Add(agendaChatBotRepository);
            _context.SaveChanges();
            return agendaChatBotRepository;
        }
    }
}
