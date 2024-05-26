using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ConsultaContext
{
    public class Pagamento
    {
        public enum TipoPagamento
        {
            PIX,
            Dinheiro,
            Debito,
            Credito,
        }

        public enum StatusPagamento
        {
            Não_Confirmado,
            Confirmado,
        }

        public int idPagamento { get; set; }
        public string Valor { get; set; }
        public TipoPagamento Tipo { get; set; }
        public StatusPagamento Status { get; set; }
        public DateTime RegistroPagamento { get; set; }

        // Ligações:

        public int idConsulta { get; set; }
        public Consulta Consulta { get; set; } = null!;
    }
}
