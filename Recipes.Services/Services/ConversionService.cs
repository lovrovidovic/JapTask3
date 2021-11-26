using Recipes.Common.Enums;
using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Services.Interfaces;
using System;
using System.Linq;

namespace Recipes.Services.Services
{
    public class ConversionService : IConversionService
    {
        public float ConvertQuantity(float quantity, Unit unit)
        {
            if (unit == Unit.kg || unit == Unit.l)
            {
                return quantity * 1000;
            }
            return quantity;
        }

        public float CalculateRecipeCost(Recipe recipe)
        {
            var conversionObj = recipe.RecipeIngredients.Select(x => new ConversionDto
            {
                StartingQuantity = ConvertQuantity(x.Quantity, x.Unit),
                StartingUnit = x.Unit,
                UnitPrice = x.Ingredient.UnitPrice
            });

            float totalCost = conversionObj.Sum(x => x.StartingQuantity * x.UnitPrice);
            return (float)Math.Round(totalCost, 2);
        }

        public float CalculateIngredientCost(RecipeIngredient ingredient)
        {
            var conversionObj = new ConversionDto
            {
                StartingQuantity = ConvertQuantity(ingredient.Quantity, ingredient.Unit),
                StartingUnit = ingredient.Unit,
                UnitPrice = ingredient.Ingredient.UnitPrice
            };

            float ingredientCost = conversionObj.StartingQuantity * conversionObj.UnitPrice;
            return (float)Math.Round(ingredientCost, 2);
        }

        public float CalculateIngredientUnitCost(Ingredient ingredient)
        {
            var convertedNormativeQuantity = ConvertQuantity(ingredient.NormativeQuantity, ingredient.NormativeUnit);
            return ingredient.NormativePrice / convertedNormativeQuantity;
        }
    }
}
