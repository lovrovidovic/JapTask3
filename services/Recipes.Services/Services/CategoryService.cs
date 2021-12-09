using Microsoft.EntityFrameworkCore;
using Recipes.Database;
using Recipes.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Services.Interfaces;
using AutoMapper;
using Recipes.Core.Responses;
using Recipes.Core.Requests;

namespace Recipes.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly RecipesDbContext _recipesDbContext;
        private readonly IMapper _mapper;

        public CategoryService(RecipesDbContext recipesDbContext, IMapper mapper)
        {
            _recipesDbContext = recipesDbContext;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<ResponseGetCategories>>> GetCategoriesAsync(BaseSearch searchObj)
        {
            //var page = 10;
            var response = new PagedResponse<IEnumerable<ResponseGetCategories>>();
            List<Category> categories;

            var query = _recipesDbContext.Categories.OrderByDescending(x => x.CreatedAt).AsQueryable();
            if (searchObj.Page >= 0)
            {
                query = query
                    .Skip(searchObj.Page * 10)
                    .Take(10);
            }

            categories = await query.ToListAsync();    

            response.Data =_mapper.Map<List<ResponseGetCategories>>(categories);
            response.Count = categories.Count;
            response.NextPage = searchObj.Page + 1;
            return response;
        }
    }
}
