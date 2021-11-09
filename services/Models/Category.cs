using RecipesAPI.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Recipe> Recipes { get; set; }
    }
}
