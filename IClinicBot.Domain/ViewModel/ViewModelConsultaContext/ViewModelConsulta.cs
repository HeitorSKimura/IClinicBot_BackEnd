using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IClinicBot.Domain.ConsultaContext.Consulta;

namespace IClinicBot.Domain.ViewModel.ViewModelConsultaContext
{
    public class ViewModelConsulta
    {
        public int idEndereco { get; set; }
        public int idPaciente { get; set; }
        public DateTime DataConsulta { get; set; }
        public TipoConsulta Tipo {  get; set; }
    }
}
