using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<ServiceResponse<IEnumerable<ResponseGetRecipes>>> GetRecipes(string search, int n, int categoryId);

        Task<ServiceResponse<ResponseGetRecipeDetails>> GetRecipeDetails(int id);

        Task<ServiceResponse<Recipe>> CreateRecipe(RequestCreateRecipe newRecipe);
    }
}
