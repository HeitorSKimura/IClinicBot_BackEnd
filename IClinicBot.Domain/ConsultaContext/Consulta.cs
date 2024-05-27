using IClinicBot.Domain.CadastroContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public TipoConsulta Tipo { get; set; }
        public DateTime DataConsulta { get; set; }
        // https://medium.com/agilix/entity-framework-core-enums-ee0f8f4063f2

        // Ligações:
        public int idEndereco { get; set; }
        public Endereco Endereco { get; set; }

        public int idPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public IList<Medico> Medicos { get; set; }

        public IList<Agenda>? Agendas { get; set; }

        public IList<Pagamento>? Pagamentos { get; set; }
    }
}
