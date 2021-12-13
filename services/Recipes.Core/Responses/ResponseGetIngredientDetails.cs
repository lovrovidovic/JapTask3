using Recipes.Common.Enums;
using System;

namespace Recipes.Core.Responses
{
    public class ResponseGetIngredientDetails
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public UnitType NormativeUnit { get; set; }

        public float UnitPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public int CreatedBy { get; set; }
    }
}
