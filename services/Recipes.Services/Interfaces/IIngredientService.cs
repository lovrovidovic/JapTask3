using Recipes.Common.Enums;
using Recipes.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<ServiceResponse<IEnumerable<ResponseGetIngredient>>> GetIngredientsAsync();

        Task<ServiceResponse<IEnumerable<ResponseGetMostUsedIngredients>>> GetMostUsedIngredientsAsync(UnitType unit, int min, int max);
    }
}
