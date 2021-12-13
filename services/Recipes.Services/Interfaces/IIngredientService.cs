using Recipes.Common.Enums;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<ServiceResponse<IEnumerable<ResponseGetIngredient>>> GetIngredientsAsync();

        Task<ServiceResponse<ResponseGetIngredientDetails>> GetIngredientDetailsAsync(int id);

        Task<PagedResponse<IEnumerable<ResponseGetIngredient>>> GetPagedIngredientsAsync(RequestGetPagedIngredients request);

        Task<bool> CreateIngredientAsync(RequestCreateIngredient request);

        Task<bool> UpdateIngredientAsync(RequestUpdateIngredient request);

        Task<bool> DeleteIngredientAsync(int id);

        Task<ServiceResponse<IEnumerable<ResponseGetMostUsedIngredients>>> GetMostUsedIngredientsAsync(UnitType unit, int min, int max);
    }
}
