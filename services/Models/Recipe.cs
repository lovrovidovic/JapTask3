using services.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Models
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int TotalCost { get; set; }

        public DateTime CreatedAt { get; set; }

        public User UserId { get; set; }

        public Category Category { get; set; }
    }
}
