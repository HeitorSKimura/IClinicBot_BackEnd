using static IClinicBot.Domain.ConsultaContext.Agenda;

namespace IClinicBot.Domain.ViewModel.ViewModelConsultaContext
{
    public class ViewModelAgenda
    {
        public DateTime DataAgenda { get; set; }
        public StatusAgenda Status { get; set; }
        public int idMedico { get; set; }
        public int idConsulta { get; set; }
    }
}