using Recipes.Common.Enums;

namespace Recipes.Core.Dtos
{
    public class ConversionDto
    {
        public float StartingQuantity { get; set; }

        public Unit StartingUnit { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }

        public float NormativePrice { get; set; }
    }
}
