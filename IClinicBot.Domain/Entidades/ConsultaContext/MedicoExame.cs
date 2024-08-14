using IClinicBot.Domain.CadastroContext;
using System.ComponentModel.DataAnnotations;

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