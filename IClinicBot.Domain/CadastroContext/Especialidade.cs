using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.CadastroContext
{
    public class Especialidade
    {
        [Key]
        public int idEspecialidade { get; set; }
        public string Nome { get; set; }

        // Ligações:
        public IList<Medico> Medicos { get; set; }
    }
}
