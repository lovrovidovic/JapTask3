using Microsoft.EntityFrameworkCore;
using Recipes.Common;
using Recipes.Core.Entities;
using System;
using System.Collections.Generic;

namespace Recipes.Database.Configurations
{
    public static class RecipesSeeder
    {
        public static void SeedRecipes(this ModelBuilder builder)
        {
            Random rnd = new Random();
            List<String> recipeNames = new() { "Cokoladni kolac", "Bijeli kolac", "Rafaelo", "Ferrero", "Kolac s jagodama", "Kolac s jabukama", "Kinder", "Twix", "Snickers", "Orah", "Specijalitet kuce", "Dummy recept" };
            List<Recipe> recipes = new();
            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.";
            var startDate = new DateTime(2010, 1, 1, 0, 0, 0);
            var endDate = new DateTime(2021, 12, 30, 0, 0, 0);
            for (int i = 1; i <= 300; i++)
            {
                recipes.Add(new Recipe
                {
                    Id = i,
                    Name = recipeNames[i%12] + i.ToString(),
                    Description = loremIpsum,
                    CategoryId = rnd.Next(1, 100),
                    CreatedAt = RandomDateGenerator.GenerateRandomDateTime(startDate, endDate),
                    CreatedBy = rnd.Next(1, 4),
                    ModifiedAt = RandomDateGenerator.GenerateRandomDateTime(startDate, endDate),
                    Cost = (float)(rnd.Next(1, 100) + rnd.NextDouble()),
                });
            }
            builder.Entity<Recipe>().HasData(recipes);
        }
    }
}
