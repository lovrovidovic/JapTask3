using Recipes.Api.Dtos;
using Recipes.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Services
{
    public interface IRecipeService
    {
        Task<ServiceResponse<IEnumerable<GetRecipesDto>>> GetRecipes(string search, int n, int categoryId);

        Task<ServiceResponse<GetRecipeDetailsDto>> GetRecipeDetails(int id);

        Task<ServiceResponse<Recipe>> CreateRecipe(CreateRecipeDto newRecipe);
    }
}
