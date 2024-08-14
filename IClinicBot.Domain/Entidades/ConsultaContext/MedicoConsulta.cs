using IClinicBot.Domain.CadastroContext;
using System.ComponentModel.DataAnnotations;

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