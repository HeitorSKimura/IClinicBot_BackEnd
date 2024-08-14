using IClinicBot.Domain.CadastroContext;
using System.ComponentModel.DataAnnotations;

namespace IClinicBot.Domain.ConsultaContext
{
    public abstract class Consulta
    {
        public enum TipoConsulta
        {
            Consulta,
            Retorno
        }

        [Key]
        public int idConsulta { get; set; }
        public DateTime RegistroConsulta { get; set; }
        public TipoConsulta Tipo {  get; set; }

        // Ligações:
        public int idEndereco { get; set; }
        public Endereco Endereco { get; set; }

        public int idPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public IList<Medico> Medicos { get; set; }

        public IList<Agenda>? Agendas { get; set; }
    }
}