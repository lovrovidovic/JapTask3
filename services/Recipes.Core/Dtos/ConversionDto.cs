using Recipes.Common.Enums;

namespace Recipes.Core.Dtos
{
    public class ConversionDto
    {
        public float StartingQuantity { get; set; }

        public UnitType StartingUnit { get; set; }

        public float UnitPrice { get; set; }
    }
}
