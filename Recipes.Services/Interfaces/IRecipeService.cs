using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<ServiceResponse<IEnumerable<GetRecipesDto>>> GetRecipes(string search, int n, int categoryId);

        Task<ServiceResponse<GetRecipeDetailsDto>> GetRecipeDetails(int id);

        Task<ServiceResponse<Recipe>> CreateRecipe(CreateRecipeDto newRecipe);
    }
}
