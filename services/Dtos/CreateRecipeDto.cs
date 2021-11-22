using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Dtos
{
    public class CreateRecipeDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<CreateRecipeIngredientDto> RecipeIngredient { get; set; }
    }
}
