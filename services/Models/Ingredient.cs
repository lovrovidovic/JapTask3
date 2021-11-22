using Recipes.Api.Models.Base;
using Recipes.Api.Models.Enums;
using System.Collections.Generic;

namespace Recipes.Api.Models
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }

        public IEnumerable<RecipeIngredient> RecipeIngredient { get; set; }
    }
}
