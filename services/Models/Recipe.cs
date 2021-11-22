using Recipes.Api.Models.Base;
using System;
using System.Collections.Generic;

namespace Recipes.Api.Models
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<RecipeIngredient> RecipeIngredient { get; set; }
    }
}
