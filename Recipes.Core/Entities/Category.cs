using Recipes.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace Recipes.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Recipe> Recipes { get; set; }
    }
}
