using Microsoft.AspNetCore.Mvc;
using Recipes.Core.Requests;
using Recipes.Services.Interfaces;
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
        public async Task<ActionResult> LoginUser(RequestLogin request)
        {
            var token = await _loginService.LoginUserAsync(request.Username, request.Password);
            if (token == null)
            {
                return BadRequest();
            }
            return Ok(token);
        }
    }
}
