using Recipes.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Core.Dtos
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
