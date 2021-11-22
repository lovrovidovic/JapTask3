using Microsoft.AspNetCore.Mvc;
using Recipes.Api.Dtos;
using Recipes.Api.Services;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<ActionResult> LoginUser(LoginDto request)
        {
            var token = await _loginService.LoginUser(request.Username, request.Password);
            if (token == null)
            {
                return BadRequest();
            }
            return Ok(token);
        }
    }
}
