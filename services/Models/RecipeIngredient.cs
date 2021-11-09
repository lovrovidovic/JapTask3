using RecipesAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Models
{
    public class RecipeIngredient
    {
        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        public float Quantity { get; set; }

        public Unit Unit { get; set; }

    }
}
