using Recipes.Common.Enums;

namespace Recipes.Core.Dtos
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
