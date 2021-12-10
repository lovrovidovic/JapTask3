using Recipes.Common.Enums;
using Recipes.Core.Entities.Base;
using System.Collections.Generic;

namespace Recipes.Core.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public UserType UserType { get; set; }

        public List<Recipe> Recipes { get; set; }
    }
}
