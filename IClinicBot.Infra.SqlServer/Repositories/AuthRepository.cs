using IClinicBot.Domain.CadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IClinicBot.Infra.SqlServer.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SqlServerContext _context;

        public AuthRepository(SqlServerContext context)
        {
            _context = context;
        }

        public async Task<User?> GetClienteByEmailAndPassword(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(c => c.Email == email && c.Senha == password);
        }
    }
}
