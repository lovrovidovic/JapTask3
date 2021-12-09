using Recipes.Common.Enums;
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
            float totalCost = recipe.RecipeIngredients.Sum(x => x.Price);
            return (float)Math.Round(totalCost, 2);
        }

        public float CalculateIngredientCost(float quantity, UnitType unit, float unitPrice)
        {
            var conversionObj = new ConversionDto
            {
                StartingQuantity = _conversionService.ConvertQuantity(quantity, unit),
                StartingUnit = unit,
                UnitPrice = unitPrice
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
