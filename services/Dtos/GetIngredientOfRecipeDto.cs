using Recipes.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Dtos
{
    public class GetIngredientOfRecipeDto
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public float Quantity { get; set; }

        public Unit Unit { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }
    }
}
