using System;

namespace Recipes.Core.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public int CreatedBy { get; set; }
    }
}
