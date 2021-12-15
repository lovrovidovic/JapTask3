using Recipes.Common.Enums;

namespace Recipes.Core.Dtos
{
    public class IngredientFiltersDto
    {
        public string Name { get; set; }

        public float? MinQuantity { get; set; }

        public float? MaxQuantity { get; set; }

        public UnitType? UnitType { get; set; }
    }
}
