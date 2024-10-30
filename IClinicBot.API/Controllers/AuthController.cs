using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.DTOs;
using IClinicBot.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("signIn")]
        public async Task<ActionResult<string>> SignIn(SignInCustomerDTO signInCustomerDTO)
        {
            string token = await _authService.SignIn(signInCustomerDTO.Email, signInCustomerDTO.Password);

            return CreatedAtAction(nameof(SignIn), token);
        }
    }
}
