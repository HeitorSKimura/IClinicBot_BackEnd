using IClinicBot.Domain.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IClinicBot.Application.API.Services
{
    public class TokenBuilder : ITokenBuilder
    {
        private readonly IConfiguration _configuration;
        private readonly List<Claim> _claims;
        private DateTime _expiration;

        public TokenBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
            _claims = new List<Claim>();
            _expiration = DateTime.UtcNow.AddHours(1); // Definindo um valor padrão
        }

        public ITokenBuilder AddClaim(string type, string value)
        {
            _claims.Add(new Claim(type, value));
            return this;
        }

        public ITokenBuilder SetExpiration(TimeSpan expiration)
        {
            _expiration = DateTime.UtcNow.Add(expiration);
            return this;
        }

        public string Build()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("12345678901234567890123456789012345678901234567890123456789012345678901234567890");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(_claims),
                Expires = _expiration,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
