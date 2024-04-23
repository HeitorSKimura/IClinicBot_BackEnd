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
        [Key]
        public int idConsulta { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime RegistroConsulta { get; set; }
        public enum Tipo { }

        // Ligações:
        public int idEndereco { get; set; }
        public Endereco Endereco { get; set; }

        public int idPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public IList<Medico> Medicos { get; set; }
    }
}
