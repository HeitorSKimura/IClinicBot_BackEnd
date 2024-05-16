using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IClinicBot.Domain.ConsultaContext.Agenda;

namespace IClinicBot.Domain.ViewModel.ViewModelConsultaContext
{
    public class ViewModelAgenda
    {
        public DateTime DataAgenda { get; set; }
        public StatusAgenda Status { get; set; }
        public int idMedico { get; set; }
        public int idConsulta { get; set; }
    }
}
