using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Core.Dtos;
using Recipes.Services.Interfaces;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;

        public RecipeController(IRecipeService service)
        {
            _service = service;
        }

        // GET: api/Recipe
        [HttpGet]
        public async Task<ActionResult> GetRecipes([FromQuery] string search, [FromQuery] int n, [FromQuery] int categoryId)
        {
            return Ok(await _service.GetRecipes(search, n, categoryId));
        }

        // GET: api/Recipe/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetRecipeDetails(int id)
        {
            return Ok(await _service.GetRecipeDetails(id));
        }

        // POST: api/Recipe
        [HttpPost]
        public async Task<ActionResult> CreateRecipe(CreateRecipeDto newRecipe)
        {
            return Ok(await _service.CreateRecipe(newRecipe));
        }
    }
}
