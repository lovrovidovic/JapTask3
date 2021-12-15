using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Core.Requests;
using Recipes.Services.Interfaces;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult> GetCategories([FromQuery] BaseSearch searchArgs)
        {
            return Ok(await _categoryService.GetCategoriesAsync(searchArgs));
        }

        // GET: api/Category/id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCategoryDetails(int id)
        {
            return Ok(await _categoryService.GetCategoryDetailsAsync(id));
        }

        // POST: api/Category
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> CreateCategory([FromBody] RequestCreateCategory request)
        {
            request.UserId = int.Parse(User.FindFirst("userId").Value);
            var response = await _categoryService.CreateCategoryAsync(request);
            if (response)
            {
                return Ok();
            }
            return BadRequest("Must select ingredients for recipe!");
        }

        // PUT: api/Category
        [Authorize]
        [HttpPut]
        public async Task<ActionResult> UpdateCategory([FromBody] RequestUpdateCategory request)
        {
            var response = await _categoryService.UpdateCategoryAsync(request);
            if (!response)
            {
                return BadRequest();
            }
            return Ok();
        }

        // DELETE: api/Category
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            var response = await _categoryService.DeleteCategoryAsync(id);
            if (!response)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
