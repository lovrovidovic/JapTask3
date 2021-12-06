using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly IConversionService _conversionService;

        public CalculationService(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        public float CalculateRecipeCost(Recipe recipe)
        {
            var conversionObj = recipe.RecipeIngredients.Select(x => new ConversionDto
            {
                StartingQuantity = _conversionService.ConvertQuantity(x.Quantity, x.UnitType),
                StartingUnit = x.UnitType,
                UnitPrice = x.Ingredient.UnitPrice
            });

            float totalCost = conversionObj.Sum(x => x.StartingQuantity * x.UnitPrice);
            return (float)Math.Round(totalCost, 2);
        }

        public float CalculateIngredientCost(RecipeIngredient ingredient)
        {
            var conversionObj = new ConversionDto
            {
                StartingQuantity = _conversionService.ConvertQuantity(ingredient.Quantity, ingredient.UnitType),
                StartingUnit = ingredient.UnitType,
                UnitPrice = ingredient.Ingredient.UnitPrice
            };

            float ingredientCost = conversionObj.StartingQuantity * conversionObj.UnitPrice;
            return (float)Math.Round(ingredientCost, 2);
        }

        public float CalculateIngredientUnitCost(Ingredient ingredient)
        {
            var convertedNormativeQuantity = _conversionService.ConvertQuantity(ingredient.NormativeQuantity, ingredient.NormativeUnit);
            return ingredient.NormativePrice / convertedNormativeQuantity;
        }
    }
}
