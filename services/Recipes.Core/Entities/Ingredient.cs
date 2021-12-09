﻿using Recipes.Core.Entities.Base;
using Recipes.Common.Enums;
using System.Collections.Generic;

namespace Recipes.Core.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public UnitType NormativeUnit { get; set; }

        public float UnitPrice { get; set; }

        public IEnumerable<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
