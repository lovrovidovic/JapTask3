using Recipes.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Dtos
{
    public class GetIngredientDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }
    }
}
