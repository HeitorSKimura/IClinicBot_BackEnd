using IClinicBot.Domain.CadastroContext;

namespace IClinicBot.Infra.SqlServer.Interfaces
{
    public interface IAuthRepository
    {
        public Task<User?> GetClienteByEmailAndPassword(string email, string password);
    }
}
