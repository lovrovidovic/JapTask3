using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using MoreLinq;
using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using Recipes.Database;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly RecipesDbContext _recipesDbContext;
        private readonly IMapper _mapper;
        private readonly IConversionService _conversionService;

        public RecipeService(RecipesDbContext recipesDbContext, IMapper mapper, IConversionService conversionService)
        {
            _recipesDbContext = recipesDbContext;
            _mapper = mapper;
            _conversionService = conversionService;
        }

        public async Task<PagedResponse<IEnumerable<ResponseGetRecipes>>> GetRecipesAsync(RequestSearchRecipe request)
        {
            var response = new PagedResponse<IEnumerable<ResponseGetRecipes>>();
            var recipes = await _recipesDbContext.Recipes
                .Include(x => x.RecipeIngredients)
                .ThenInclude(y => y.Ingredient)
                .Where(Filter(request.Search, request.CategoryId))
                .Take(request.TakeAmmount)
                .Select(x => new ResponseGetRecipes
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatedAt = x.CreatedAt,
                    Description = x.Description,
                    Price = _conversionService.CalculateRecipeCost(x)
                })
                .ToListAsync();

            response.Data = recipes.OrderBy(x => x.Price);
            response.Count = recipes.Count;
            return response;
        }

        private static Expression<Func<Recipe, bool>> Filter(string search, int categoryId)
        {
            search = search?.Trim().ToLower();
            return x => x.CategoryId == categoryId &&
            (string.IsNullOrEmpty(search)
            || x.Name.ToLower().Contains(search)
            || x.Description.ToLower().Contains(search)
            || x.RecipeIngredients.Any(y => y.Ingredient.Name.ToLower().Contains(search)));
        }

        public async Task<ServiceResponse<ResponseGetRecipeDetails>> GetRecipeDetailsAsync(int id)
        {
            var response = new ServiceResponse<ResponseGetRecipeDetails>();

            var recipe = await _recipesDbContext.Recipes
                .Include(x => x.RecipeIngredients)
                .ThenInclude(y => y.Ingredient)
                .Include(x => x.Category)
                .FirstOrDefaultAsync(x => x.Id == id);

            var mappedIngredients = recipe.RecipeIngredients.Select(x => new GetIngredientOfRecipeDto
            {
                Price = (float)_conversionService.CalculateIngredientCost(x),
                Name = x.Ingredient.Name,
                Quantity = x.Quantity,
                Unit = x.Unit,
                NormativePrice = x.Ingredient.NormativePrice,
                NormativeQuantity = x.Ingredient.NormativeQuantity,
                NormativeUnit = x.Ingredient.NormativeUnit
            });

            response.Data = _mapper.Map<ResponseGetRecipeDetails>(recipe);
            response.Data.CategoryName = recipe.Category.Name; //TODO check if i need this
            response.Data.Ingredients = mappedIngredients;
            response.Data.TotalPrice = _conversionService.CalculateRecipeCost(recipe);

            return response;
        }

        public async Task<bool> CreateRecipeAsync(RequestCreateRecipe newRecipe)
        {
            if (newRecipe.RecipeIngredient.Count() == 0)
            {
                return false;
            }

            var response = new ServiceResponse<Recipe>();

            var recipe = new Recipe
            {
                Name = newRecipe.Name,
                Description = newRecipe.Description,
                CreatedAt = DateTime.Now,
                CreatedBy = newRecipe.UserId,
                CategoryId = newRecipe.CategoryId,
                RecipeIngredients = newRecipe.RecipeIngredient.Select(x => new RecipeIngredient
                {
                    Quantity = x.Quantity,
                    Unit = x.Unit,
                    IngredientId = x.IngredientId
                }).DistinctBy(x => x.IngredientId).ToList()
            };

            await _recipesDbContext.Recipes.AddAsync(recipe);
            await _recipesDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetRecipeWith10Ing>>> GetRecipesWith10IngredientsAsync()
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetRecipeWith10Ing>>();

            var result = await _recipesDbContext.Database.GetDbConnection()
                .QueryAsync<ResponseGetRecipeWith10Ing>("GetRecipesWith10Ing", commandType: System.Data.CommandType.StoredProcedure);

            response.Data = result;
            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetSortedRecipes>>> GetSortedRecipesAsync()
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetSortedRecipes>>();

            var result = await _recipesDbContext.Database.GetDbConnection()
                .QueryAsync<ResponseGetSortedRecipes>("GetSortedRecipes", commandType: System.Data.CommandType.StoredProcedure);

            response.Data = result;
            return response;
        }
    }
}
