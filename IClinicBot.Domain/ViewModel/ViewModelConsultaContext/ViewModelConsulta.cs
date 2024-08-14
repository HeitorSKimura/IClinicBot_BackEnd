using static IClinicBot.Domain.ConsultaContext.Consulta;

namespace IClinicBot.Domain.ViewModel.ViewModelConsultaContext
{
    public class ViewModelConsulta
    {
        public int idEndereco { get; set; }
        public int idPaciente { get; set; }
        public TipoConsulta Tipo {  get; set; }
    }
}