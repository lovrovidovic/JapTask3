using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Responses
{
    public class ResponseGetSortedRecipes
    {
        public string Recipe_Name { get; set; }

        public string Category_Name { get; set; }

        public float Cost { get; set; }
    }
}
