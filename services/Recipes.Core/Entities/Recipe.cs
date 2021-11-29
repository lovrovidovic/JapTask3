using Recipes.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace Recipes.Core.Entities
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public User User { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public float Cost { get; set; }

        public IEnumerable<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
