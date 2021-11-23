using System;

namespace Recipes.Core.Dtos
{
    public class GetCategoriesDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
