using System.ComponentModel.DataAnnotations;

namespace IClinicBot.Domain.Entidades.CadastroContext
{
    public class Contato
    {
        [Key]
        public int idContato { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
    }
}