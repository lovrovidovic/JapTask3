using Recipes.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Core.Requests
{
    public class RequestUpdateRecipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<CreateRecipeIngredientDto> RecipeIngredient { get; set; }

        public float RecommendedPrice { get; set; }
    }
}
