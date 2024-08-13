using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext
{
    public interface IRepositoryAgendaMedico
    {
        public List<AgendaMedico> GetAllAgendaMedico();
        public AgendaMedico PostAgendaMedico(ViewModelAgendaMedico agendaMedico);
    }
}
