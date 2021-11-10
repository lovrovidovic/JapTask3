using RecipesAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Dtos
{
    public class GetIngredientOfRecipeDto
    {
        public string Name { get; set; }

        //TODO calculate and return price of ingredient for this recipe
        public float Price { get; set; }

        public float Quantity { get; set; }

        public Unit Unit { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }
    }
}
