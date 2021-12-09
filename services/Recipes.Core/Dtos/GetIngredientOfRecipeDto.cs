using Recipes.Common.Enums;

namespace Recipes.Core.Dtos
{
    public class GetIngredientOfRecipeDto
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public float Quantity { get; set; }

        public UnitType UnitType { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public UnitType NormativeUnit { get; set; }
    }
}
