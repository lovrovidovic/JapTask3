using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Core.Requests;
using Recipes.Services.Interfaces;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        // GET: api/Recipe
        [HttpGet]
        public async Task<ActionResult> GetRecipes([FromQuery] RequestSearchRecipe request)
        {
            return Ok(await _recipeService.GetRecipesAsync(request));
        }

        // GET: api/Recipe/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetRecipeDetails(int id)
        {
            return Ok(await _recipeService.GetRecipeDetailsAsync(id));
        }

        // POST: api/Recipe
        [HttpPost]
        public async Task<ActionResult> CreateRecipe(RequestCreateRecipe newRecipe)
        {
            return Ok(await _recipeService.CreateRecipeAsync(newRecipe));
        }
    }
}
