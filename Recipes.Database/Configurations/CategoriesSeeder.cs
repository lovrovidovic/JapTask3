using Microsoft.EntityFrameworkCore;
using Recipes.Common;
using Recipes.Core.Entities;
using System;
using System.Collections.Generic;

namespace Recipes.Database.Configurations
{
    public static class CategoriesSeeder
    {
        public static void SeedCategories(this ModelBuilder builder)
        {
            Random rnd = new Random();
            List<String> categoryNames = new() { "Salata", "Palacinke", "Waffle", "Hamburger", "Sendvic", "Torta", "Kolac", "Pita", "Pizza", "Sladoled", "Jela s rostilja", "Peciva" };
            List<Category> categories = new();
            for (int i = 0; i <= 12; i++)
            {
                categories.Add(new Category
                {
                    Id = i,
                    Name = categoryNames[i] + i.ToString(),
                    CreatedAt = RandomDateGenerator.GenerateRandomDateTime(new DateTime(2010, 1, 1, 0, 0, 0), new DateTime(2021, 12, 30, 0, 0, 0)),
                    CreatedBy = rnd.Next(1, 4),
                    ModifiedAt = RandomDateGenerator.GenerateRandomDateTime(new DateTime(2010, 1, 1, 0, 0, 0), new DateTime(2021, 12, 30, 0, 0, 0))
                });
            }
            builder.Entity<Category>().HasData(categories);
        }
    }
}
