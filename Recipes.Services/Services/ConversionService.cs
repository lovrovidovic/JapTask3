using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Common.Enums;
using System;
using System.Linq;
using Recipes.Services.Interfaces;

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
                NormativeQuantity = ConvertQuantity(x.Ingredient.NormativeQuantity, x.Ingredient.NormativeUnit),
                NormativeUnit = x.Ingredient.NormativeUnit,
                NormativePrice = x.Ingredient.NormativePrice
            });

            float totalCost = conversionObj.Sum(x => x.StartingQuantity * (x.NormativePrice / x.NormativeQuantity));
            return (float)Math.Round(totalCost, 2);
        }

        public float CalculateIngredientCost(RecipeIngredient ingredient)
        {
            var conversionObj = new ConversionDto
            {
                StartingQuantity = ConvertQuantity(ingredient.Quantity, ingredient.Unit),
                StartingUnit = ingredient.Unit,
                NormativeQuantity = ConvertQuantity(ingredient.Ingredient.NormativeQuantity, ingredient.Ingredient.NormativeUnit),
                NormativeUnit = ingredient.Ingredient.NormativeUnit,
                NormativePrice = ingredient.Ingredient.NormativePrice
            };

            float ingredientCost = conversionObj.StartingQuantity * (conversionObj.NormativePrice / conversionObj.NormativeQuantity);
            return (float)Math.Round(ingredientCost, 2);
        }
    }
}
