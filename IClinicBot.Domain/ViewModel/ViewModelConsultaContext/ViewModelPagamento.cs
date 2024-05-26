using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IClinicBot.Domain.ConsultaContext.Pagamento;

namespace IClinicBot.Domain.ViewModel.ViewModelConsultaContext
{
    public class ViewModelPagamento
    {
        public string Valor { get; set; }
        public TipoPagamento Tipo { get; set; }
        public StatusPagamento Status { get; set; }
        public int idConsulta { get; set; }
    }
}
