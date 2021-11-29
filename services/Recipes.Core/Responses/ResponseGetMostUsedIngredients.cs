using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Responses
{
    public class ResponseGetMostUsedIngredients
    {
        public string Name { get; set; }

        public int Ingredient_Count { get; set; }
    }
}
