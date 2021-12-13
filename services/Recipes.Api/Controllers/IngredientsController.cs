using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Enums;
using Recipes.Core.Requests;
using Recipes.Services.Interfaces;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
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

        [HttpGet("paged")]
        public async Task<ActionResult> GetPagedIngredients([FromQuery] RequestGetPagedIngredients request)
        {
            return Ok(await _ingredientService.GetPagedIngredientsAsync(request));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetIngredientDetails(int id)
        {
            return Ok(await _ingredientService.GetIngredientDetailsAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> CreateIngredient(RequestCreateIngredient request)
        {
            return Ok(await _ingredientService.CreateIngredientAsync(request));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateIngredient(RequestUpdateIngredient request)
        {
            return Ok(await _ingredientService.UpdateIngredientAsync(request));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteIngredient(int id)
        {
            return Ok(await _ingredientService.DeleteIngredientAsync(id));
        }
    }
}
