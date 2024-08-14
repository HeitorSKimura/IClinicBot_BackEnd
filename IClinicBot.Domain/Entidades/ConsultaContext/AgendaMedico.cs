using IClinicBot.Domain.CadastroContext;

namespace IClinicBot.Domain.ConsultaContext
{
    public class AgendaMedico
    {
        public int idAgendaMedico {  get; set; }
        public DateTime DataAgendaDisponivel { get; set; }

        public string Especialidade { get; set; }



        // Ligações:
        public int idMedico { get; set; }
        public Medico Medico { get; set; }
    }
}