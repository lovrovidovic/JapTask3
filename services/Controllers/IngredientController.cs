using Microsoft.AspNetCore.Mvc;
using RecipesAPI.Services;
using System.Threading.Tasks;

namespace RecipesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _service;

        public IngredientController(IIngredientService service)
        {
            _service = service;
        }

        // GET: api/Ingredient
        [HttpGet]
        public async Task<ActionResult> GetIngredients()
        {
            return Ok(await _service.GetIngredients());
        }
    }
}
