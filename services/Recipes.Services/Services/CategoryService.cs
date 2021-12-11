using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using Recipes.Database;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            response.Data = _mapper.Map<List<ResponseGetCategories>>(categories);
            response.Count = categories.Count;
            response.NextPage = searchObj.Page + 1;
            return response;
        }

        public async Task<bool> CreateCategoryAsync(RequestCreateCategory request)
        {
            var category = new Category
            {
                Name = request.Name,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                CreatedBy = request.UserId
            };

            await _recipesDbContext.Categories.AddAsync(category);
            await _recipesDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateCategoryAsync(RequestUpdateCategory request)
        {
            var category = await _recipesDbContext.Categories.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (category == null)
            {
                return false;
            }

            category.Name = request.Name;
            category.CreatedAt = request.CreatedAt;
            category.ModifiedAt = DateTime.Now;
            category.CreatedBy = request.CreatedBy;

            await _recipesDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await _recipesDbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if (category == null)
            {
                return false;
            }

            _recipesDbContext.Categories.Remove(category);
            await _recipesDbContext.SaveChangesAsync();
            return true;
        }
    }
}
