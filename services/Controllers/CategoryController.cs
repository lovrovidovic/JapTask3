using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Api.Dtos;
using Recipes.Api.Models;
using Recipes.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult> GetCategories([FromQuery] int n)
        {
            return Ok(await _service.GetCategories(n));
        }
    }
}
