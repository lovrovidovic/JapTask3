using services.Models.Base;
using services.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Models
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }

        public float NormativePrice { get; set; }

        public float NormativeQuantity { get; set; }

        public Unit NormativeUnit { get; set; }

        public int MyProperty { get; set; }
    }
}
