namespace IClinicBot.Domain.ConsultaContext
{
    public class AgendaChatBot
    {
        public int idAgendaChatBot { get; set; }
        public DateTime DataAgendaChatBot { get; set; }
        public string Cel {  get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public string FormaPagamento { get; set; }
        public int idCadastro { get; set; }
        public bool IsAtendido { get; set; }
    }
}