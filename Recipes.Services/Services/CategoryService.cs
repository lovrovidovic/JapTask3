using Microsoft.EntityFrameworkCore;
using Recipes.Database;
using Recipes.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Services.Interfaces;
using Recipes.Core.Dtos;
using AutoMapper;

namespace Recipes.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<GetCategoriesDto>>> GetCategories(int n)
        {
            var response = new ServiceResponse<IEnumerable<GetCategoriesDto>>();
            List<Category> categories;

            if (n != 0)
            {
                categories = await _context.Categories.OrderByDescending(x => x.CreatedAt).Take(n).ToListAsync();
            }
            else
            {
                categories = await _context.Categories.OrderByDescending(x => x.CreatedAt).ToListAsync();
            }

            response.Data = categories.Select(x => _mapper.Map<GetCategoriesDto>(x)).ToList();
            return response;
        }
    }
}
