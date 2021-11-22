using Recipes.Api.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Api.Services
{
    public interface IIngredientService
    {
        Task<ServiceResponse<IEnumerable<GetIngredientDto>>> GetIngredients();
    }
}
