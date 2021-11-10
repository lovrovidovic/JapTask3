using Microsoft.AspNetCore.Mvc;
using RecipesAPI.Dtos;
using RecipesAPI.Models;
using RecipesAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesAPI.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IEnumerable<GetRecipesDto>>> GetRecipes([FromQuery] string search, int n)
        {
            return Ok( await _service.GetRecipes(search, n));
        }

        // GET: api/Recipe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetRecipeDetailsDto>> GetRecipeDetails(int id)
        {
            return Ok( await _service.GetRecipeDetails(id));
        }
    }
}
