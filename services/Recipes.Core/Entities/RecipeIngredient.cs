using Recipes.Common.Enums;

namespace Recipes.Core.Entities
{
    public class RecipeIngredient
    {
        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        public float Quantity { get; set; }

        public UnitType UnitType { get; set; }
    }
}
