using Recipes.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<ServiceResponse<IEnumerable<ResponseGetIngredient>>> GetIngredientsAsync();
    }
}
