using Recipes.Common.Enums;

namespace Recipes.Core.Requests
{
    public class RequestCreateIngredient
    {
        public string Name { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public UnitType NormativeUnit { get; set; }

        public int UserId { get; set; }
    }
}
