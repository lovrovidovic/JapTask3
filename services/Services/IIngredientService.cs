using RecipesAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public interface IIngredientService
    {
        Task<ServiceResponse<IEnumerable<GetIngredientDto>>> GetIngredients(string search);

    }
}
