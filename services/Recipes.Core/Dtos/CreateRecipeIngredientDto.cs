using Recipes.Common.Enums;

namespace Recipes.Core.Dtos
{
    public class CreateRecipeIngredientDto
    {
        public int IngredientId { get; set; }

        public float Quantity { get; set; }

        public UnitType UnitType { get; set; }
    }
}
