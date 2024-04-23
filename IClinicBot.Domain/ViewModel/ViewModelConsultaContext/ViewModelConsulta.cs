using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ViewModel.ViewModelConsultaContext
{
    public class ViewModelConsulta
    {
        public DateTime DataConsulta { get; set; }
        public enum Tipo { }
        public int idEndereco { get; set; }
        public int idPaciente { get; set; }
    }
}
