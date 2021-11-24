using Recipes.Core.Dtos;
using System.Collections.Generic;

namespace Recipes.Core.Requests
{
    public class RequestCreateRecipe
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<CreateRecipeIngredientDto> RecipeIngredient { get; set; }
    }
}
