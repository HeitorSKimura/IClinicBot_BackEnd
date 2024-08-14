using IClinicBot.Domain.CadastroContext;
using System.ComponentModel.DataAnnotations;

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