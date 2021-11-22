using Recipes.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Dtos
{
    public class CreateRecipeIngredientDto
    {
        public int IngredientId { get; set; }

        public float Quantity { get; set; }

        public Unit Unit { get; set; }
    }
}
