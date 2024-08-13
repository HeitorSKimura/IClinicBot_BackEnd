using IClinicBot.Domain.ConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
