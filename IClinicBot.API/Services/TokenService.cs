using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IClinicBot.Application.API.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenBuilder _tokenBuilder;

        public TokenService(IConfiguration configuration, ITokenBuilder tokenBuilder)
        {
            _configuration = configuration;
            _tokenBuilder = tokenBuilder;
        }

        public string CreateToken(User user)
        {
            return _tokenBuilder
                .AddClaim(ClaimTypes.Name, user.NomeCompleto)
                .AddClaim(ClaimTypes.Email, user.Email)
                .AddClaim("id", user.idCadastro.ToString())
                .AddClaim(ClaimTypes.Role, user.Role)
                .SetExpiration(TimeSpan.FromHours(1))
                .Build();
        }
    }
}
