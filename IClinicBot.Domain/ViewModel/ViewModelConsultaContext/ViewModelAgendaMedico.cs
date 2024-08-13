using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ViewModel.ViewModelConsultaContext
{
    public class ViewModelAgendaMedico
    {
        public DateTime DataAgendaDisponivel { get; set; }

        public string Especialidade { get; set; }

        public int idMedico { get; set; }
    }
}
