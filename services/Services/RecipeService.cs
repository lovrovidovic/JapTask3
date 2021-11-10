using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecipesAPI.Data;
using RecipesAPI.Dtos;
using RecipesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public RecipeService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<GetRecipesDto>>> GetRecipes(string search, int n, int categoryId)
        {
            var response = new ServiceResponse<IEnumerable<GetRecipesDto>>();
            var recipes = await _context.Recipes
                .Include(x => x.RecipeIngredient)
                .ThenInclude(y => y.Ingredient)
                .Where(Filter(search, categoryId))
                .OrderByDescending(x => x.CreatedAt)
                .Take(n).ToListAsync();

            response.Data = recipes.Select(x => _mapper.Map<GetRecipesDto>(x)).ToList();
            return response;
        }

        private static Expression<Func<Recipe, bool>> Filter(string search, int categoryId)
        {
            search = search?.Trim().ToLower();
            return x => x.CategoryId == categoryId && 
            (string.IsNullOrEmpty(search) 
            || x.Name.ToLower().Contains(search) 
            || x.Description.ToLower().Contains(search) 
            || x.RecipeIngredient.Any(y => y.Ingredient.Name.ToLower().Contains(search)));
        }

        public async Task<ServiceResponse<GetRecipeDetailsDto>> GetRecipeDetails(int id)
        {
            var response = new ServiceResponse<GetRecipeDetailsDto>();

            var recipe = await _context.Recipes
                .Include(x => x.RecipeIngredient)
                .ThenInclude(y => y.Ingredient)
                .Include(x => x.Category)
                .FirstOrDefaultAsync(x => x.Id == id);

            var mappedIngredients = recipe.RecipeIngredient.Select(x => new GetIngredientOfRecipeDto
            {
                Name = x.Ingredient.Name,
                Quantity = x.Quantity,
                Unit = x.Unit,
                NormativePrice = x.Ingredient.NormativePrice,
                NormativeQuantity = x.Ingredient.NormativeQuantity,
                NormativeUnit = x.Ingredient.NormativeUnit
            });

            response.Data = _mapper.Map<GetRecipeDetailsDto>(recipe);
            response.Data.CategoryName = recipe.Category.Name;
            response.Data.Ingredients = mappedIngredients;

            return response;
        }
    }
}
