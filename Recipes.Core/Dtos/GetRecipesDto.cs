using System;

namespace Recipes.Core.Dtos
{
    public class GetRecipesDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public float Price { get; set; }
    }
}
