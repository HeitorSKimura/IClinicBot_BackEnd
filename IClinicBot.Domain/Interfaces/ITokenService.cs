using IClinicBot.Domain.CadastroContext;

namespace IClinicBot.Domain.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User cliente);
    }
}