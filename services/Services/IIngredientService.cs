using RecipesAPI.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public interface IIngredientService
    {
        Task<ServiceResponse<IEnumerable<GetIngredientDto>>> GetIngredients();
    }
}
