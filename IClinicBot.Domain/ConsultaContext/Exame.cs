using IClinicBot.Domain.CadastroContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ConsultaContext
{
    public class Exame
    {
        [Key]
        public int idExame { get; set; }
        public DateTime DataExame { get; set; }
        public DateTime RegistroExame { get; set; }

        // Ligações:

        public int idPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public IList<Medico> Medicos { get; set; }
    }
}
