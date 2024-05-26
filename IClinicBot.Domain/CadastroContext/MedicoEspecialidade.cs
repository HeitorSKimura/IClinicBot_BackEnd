using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.CadastroContext
{
    public class MedicoEspecialidade
    {
        [Key]
        public int idMedicoEspecialidade { get; set; }

        public int idMedico {  get; set; }
        public Medico Medico { get; set; }

        public int idEspecialidade { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
