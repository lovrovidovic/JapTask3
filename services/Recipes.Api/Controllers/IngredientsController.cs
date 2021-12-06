using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Enums;
using Recipes.Services.Interfaces;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        // GET: api/Ingredient
        [HttpGet]
        public async Task<ActionResult> GetIngredients()
        {
            return Ok(await _ingredientService.GetIngredientsAsync());
        }

        [HttpGet("procedure/1")]
        public async Task<ActionResult> GetMostUsedIngredients(UnitType unit, int min, int max)
        {
            return Ok(await _ingredientService.GetMostUsedIngredientsAsync(unit, min, max));
        }
    }
}
