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

        public List<AgendaChatBot> GetAgendaChatBotById(int idCadastro)
        {
            return _context.AgendasChatBot.Where(a => a.idCadastro == idCadastro).ToList();
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
                idCadastro = agendaChatBot.idCadastro,
                IsAtendido = agendaChatBot.IsAtendido,
            };
            _context.AgendasChatBot.Add(agendaChatBotRepository);
            _context.SaveChanges();
            return agendaChatBotRepository;
        }

        public AgendaChatBot UpdateAgendaChatBot(int id, ViewModelAgendaChatBot agendaChatBot)
        {
            var originalAgendaChatBot = _context.AgendasChatBot.FirstOrDefault(a => a.idAgendaChatBot == id);

            if (originalAgendaChatBot == null)
                throw new Exception("AgendaChatBot não encontrada.");

            originalAgendaChatBot.DataAgendaChatBot = agendaChatBot.DataAgendaChatBot;
            originalAgendaChatBot.Cel = agendaChatBot.Cel;
            originalAgendaChatBot.Nome = agendaChatBot.Nome;
            originalAgendaChatBot.Especialidade = agendaChatBot.Especialidade;
            originalAgendaChatBot.FormaPagamento = agendaChatBot.FormaPagamento;
            originalAgendaChatBot.idCadastro = agendaChatBot.idCadastro;
            originalAgendaChatBot.IsAtendido = agendaChatBot.IsAtendido;

            _context.AgendasChatBot.Update(originalAgendaChatBot);
            _context.SaveChanges();

            return originalAgendaChatBot;
        }
    }
}
