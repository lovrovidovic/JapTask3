using Microsoft.AspNetCore.Mvc;
using Recipes.Services.Interfaces;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        // GET: api/Ingredient
        [HttpGet]
        public async Task<ActionResult> GetIngredients()
        {
            return Ok(await _ingredientService.GetIngredientsAsync());
        }
    }
}
