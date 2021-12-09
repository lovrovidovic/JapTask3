using Recipes.Common.Enums;
using Recipes.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface ICalculationService
    {
        float CalculateRecipeCost(Recipe recipe);

        float CalculateIngredientCost(float quantity, UnitType unit, float unitPrice);

        float CalculateIngredientUnitCost(Ingredient ingredient);
    }
}
