using RecipesAPI.Dtos;
using RecipesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public interface IRecipeService
    {
        Task<ServiceResponse<IEnumerable<GetRecipesDto>>> GetRecipes(string search, int n, int categoryId);

        Task<ServiceResponse<GetRecipeDetailsDto>> GetRecipeDetails(int id);

    }
}
