using IClinicBot.Domain.CadastroContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ConsultaContext
{
    public class MedicoExame
    {
        [Key]
        public int idMedicoExame { get; set; }

        public int idMedico { get; set; }
        public Medico Medico { get; set; }

        public int idExame { get; set; }
        public Exame Exame { get; set; }
    }
}
