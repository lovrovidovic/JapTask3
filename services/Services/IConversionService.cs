using RecipesAPI.Models;
using RecipesAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public interface IConversionService
    {
        float ConvertQuantity(float quantity, Unit unit);

        float CalculateRecipeCost(Recipe recipe);

        float CalculateIngredientCost(RecipeIngredient ingredient);
    }
}
