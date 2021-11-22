using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Recipes.Api.Data;
using Recipes.Api.Dtos;
using Recipes.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Recipes.Api.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IConversionService _convert;

        public RecipeService(DataContext context, IMapper mapper, IConversionService convert)
        {
            _context = context;
            _mapper = mapper;
            _convert = convert;
        }

        public async Task<ServiceResponse<IEnumerable<GetRecipesDto>>> GetRecipes(string search, int n, int categoryId)
        {
            var response = new ServiceResponse<IEnumerable<GetRecipesDto>>();
            var recipes = await _context.Recipes
                .Include(x => x.RecipeIngredient)
                .ThenInclude(y => y.Ingredient)
                .Where(Filter(search, categoryId))
                .Take(n).ToListAsync();

            response.Data = recipes.Select(x => new GetRecipesDto
            {
                Id = x.Id,
                Name = x.Name,
                CreatedAt = x.CreatedAt,
                Description = x.Description,
                Price = _convert.CalculateRecipeCost(x)
            });
            response.Data = response.Data.OrderBy(x => x.Price);

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
                Price = _convert.CalculateIngredientCost(x),
                Name = x.Ingredient.Name,
                Quantity = x.Quantity,
                Unit = x.Unit,
                NormativePrice = x.Ingredient.NormativePrice,
                NormativeQuantity = x.Ingredient.NormativeQuantity,
                NormativeUnit = x.Ingredient.NormativeUnit
            });

            response.Data = _mapper.Map<GetRecipeDetailsDto>(recipe);
            response.Data.CategoryName = recipe.Category.Name; //TODO check if i need this
            response.Data.Ingredients = mappedIngredients;
            response.Data.TotalPrice = _convert.CalculateRecipeCost(recipe);

            return response;
        }

        public async Task<ServiceResponse<Recipe>> CreateRecipe(CreateRecipeDto newRecipe)
        {
            var response = new ServiceResponse<Recipe>();

            var mappedRecipeIngredient = newRecipe.RecipeIngredient.Select(x => new RecipeIngredient
            {
                Quantity = x.Quantity,
                Unit = x.Unit,
                IngredientId = x.IngredientId
            }).ToList();

            var recipe = new Recipe
            {
                Name = newRecipe.Name,
                Description = newRecipe.Description,
                CreatedAt = DateTime.Now,
                UserId = newRecipe.UserId,
                CategoryId = newRecipe.CategoryId,
                RecipeIngredient = mappedRecipeIngredient
            };

            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();

            return response;
        }
    }
}
