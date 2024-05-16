using IClinicBot.Domain.CadastroContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ConsultaContext
{
    public class Agenda
    {
        public enum StatusAgenda
        {
            Disponivel,
            Ocupado
        }

        [Key]
        public int idAgenda { get; set; }
        public DateTime DataAgenda { get; set; }
        public DateTime RegistroAgenda { get; set; }
        public StatusAgenda Status {  get; set; }

        // Ligações:

        public int idMedico { get; set; }
        public Medico Medico { get; set; }

        public int? idConsulta { get; set; }
        public Consulta? Consulta { get; set; }

    }
}
