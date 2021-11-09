using RecipesAPI.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public List<Recipe> Recipes { get; set; }
    }
}
