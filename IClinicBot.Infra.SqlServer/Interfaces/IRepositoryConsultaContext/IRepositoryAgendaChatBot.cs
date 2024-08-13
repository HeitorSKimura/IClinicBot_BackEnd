using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext
{
    public interface IRepositoryAgendaChatBot
    {
        public List<AgendaChatBot> GetAllAgendaChatBot();
        public AgendaChatBot PostAgendaChatBot(ViewModelAgendaChatBot agendaChatBot);
    }
}
