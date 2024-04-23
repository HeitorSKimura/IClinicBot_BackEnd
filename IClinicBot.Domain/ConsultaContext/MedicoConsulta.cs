using IClinicBot.Domain.CadastroContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ConsultaContext
{
    public class MedicoConsulta
    {
        [Key]
        public int idMedicoConsulta { get; set; }

        public int idMedico { get; set; }
        public Medico Medico { get; set; }

        public int idConsulta { get; set; }
        public Consulta Consulta { get; set; }
    }
}
