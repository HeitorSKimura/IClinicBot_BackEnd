using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.DTOs;
using IClinicBot.Domain.Interfaces;
using IClinicBot.Infra.SqlServer.Interfaces;
using System.Security.Claims;

namespace IClinicBot.Application.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly ITokenService _tokenService;

        public AuthService(IAuthRepository authRepository, ITokenService tokenService)
        {
            _authRepository = authRepository;
            _tokenService = tokenService;
        }

        public async Task<string> SignIn(string email, string password)
        {
            User user = await GetUserByEmailAndPassword(email, password);
            string token = _tokenService.CreateToken(user);

            return token;
        }

        private async Task<User> GetUserByEmailAndPassword(string email, string password)
        {
            User? user = await _authRepository.GetClienteByEmailAndPassword(email, password);
            if (user == null)
            {
                throw new Exception("Usuário e/ou senha inválidos");
            }

            return user;
        }

        public string GetAuthenticatedUserId(ClaimsPrincipal User)
        {
            string? userId = User.Claims.First(c => c.Type == "id")?.Value;
            if (userId == null)
            {
                throw new Exception("User not found on token JWT");
            }

            return userId;
        }
    }
}
