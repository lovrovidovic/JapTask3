using Recipes.Core.Dtos;
using System;
using System.Collections.Generic;

namespace Recipes.Core.Responses
{
    public class ResponseGetRecipeDetails
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public float TotalPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<GetIngredientOfRecipeDto> Ingredients { get; set; }

        public float RecommendedPrice { get; set; }
    }
}
