using IClinicBot.Domain.ConsultaContext;

namespace IClinicBot.Domain.CadastroContext
{
    public class Medico : User
    {
        public string CRM { get; set; }

        // Ligações:
        public IList<Consulta> Consultas { get; set; }

        public IList<Exame> Exames { get; set; }

        public IList<Agenda> Agendas { get; set; }
        public IList<AgendaMedico> AgendasMedico { get; set; }
        public IList<AgendaChatBot> AgendasChatBot { get; set; }
    }
}