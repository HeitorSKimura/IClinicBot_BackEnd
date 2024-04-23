using IClinicBot.Domain.ConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.CadastroContext
{
    public class Paciente : User
    {
        public string Peso { get; set; }
        public string Idade { get; set; }
        public string Tamanho { get; set; }

        // Ligações:
        public IList<Consulta> Consultas { get; set; }

        public IList<Exame> Exames { get; set; }
    }
}
