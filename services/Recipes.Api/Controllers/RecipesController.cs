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
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipesController(IRecipeService recipeService)
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
            newRecipe.UserId = int.Parse(User.FindFirst("userId").Value);
            var response = await _recipeService.CreateRecipeAsync(newRecipe);
            if (response)
            {
                return Ok();
            }
            return BadRequest("Must select ingredients for recipe!");
        }

        // GET: api/Recipe/procedure
        [HttpGet("procedure/1")]
        public async Task<ActionResult> GetRecipeWith10Ing()
        {
            return Ok(await _recipeService.GetRecipesWith10IngredientsAsync());
        }

        [HttpGet("procedure/2")]
        public async Task<ActionResult> GertSortedRecipes()
        {
            return Ok(await _recipeService.GetSortedRecipesAsync());
        }
    }
}
