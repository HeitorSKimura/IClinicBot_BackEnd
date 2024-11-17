using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext
{
    public interface IRepositoryAgendaChatBot
    {
        public List<AgendaChatBot> GetAllAgendaChatBot();
        public List<AgendaChatBot> GetAgendaChatBotById(int id);
        public AgendaChatBot PostAgendaChatBot(ViewModelAgendaChatBot agendaChatBot);
        public AgendaChatBot UpdateAgendaChatBot(int id, ViewModelAgendaChatBot agendaChatBot);
    }
}
