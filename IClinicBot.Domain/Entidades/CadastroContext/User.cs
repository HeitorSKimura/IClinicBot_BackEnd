using System.ComponentModel.DataAnnotations;

namespace IClinicBot.Domain.CadastroContext
{
    public abstract class User
    {
        [Key]
        public int idCadastro { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public DateTime RegistroCadastro { get; set; }
    }
}