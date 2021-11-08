using Microsoft.AspNetCore.Mvc;
using services.Dtos;
using services.Models;
using services.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace services.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IEnumerable<GetCategoriesDto>>> GetCategories()
        {
            return Ok(await _service.GetCategories());
        }
    }
}
