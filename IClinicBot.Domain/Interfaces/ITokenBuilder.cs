using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.Interfaces
{
    public interface ITokenBuilder
    {
        ITokenBuilder AddClaim(string type, string value);
        ITokenBuilder SetExpiration(TimeSpan expiration);
        string Build();
    }
}
