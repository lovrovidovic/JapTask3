﻿using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<PagedResponse<IEnumerable<ResponseGetRecipes>>> GetRecipesAsync(RequestSearchRecipe request);

        Task<ServiceResponse<ResponseGetRecipeDetails>> GetRecipeDetailsAsync(int id);

        Task<bool> CreateRecipeAsync(RequestCreateRecipe newRecipe);

        Task<ServiceResponse<IEnumerable<ResponseGetRecipeWith10Ing>>> GetRecipesWith10IngredientsAsync();

        Task<ServiceResponse<IEnumerable<ResponseGetSortedRecipes>>> GetSortedRecipesAsync();

        Task<bool> UpdateRecipeAsync(RequestUpdateRecipe request);

        Task<bool> DeleteRecipeAsync(int id);
    }
}
