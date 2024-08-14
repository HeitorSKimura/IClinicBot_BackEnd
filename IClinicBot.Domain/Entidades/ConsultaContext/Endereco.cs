using System.ComponentModel.DataAnnotations;

namespace IClinicBot.Domain.ConsultaContext
{
    public class Endereco
    {
        [Key]
        public int idEndereco {  get; set; }
        public string CEP { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Localidade { get; set; }
        public string? UF { get; set; }
        public string Numero { get; set; }

        // Ligações:
        public IList<Consulta> Consultas { get; set; }
    }
}