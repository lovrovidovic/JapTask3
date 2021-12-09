using Microsoft.EntityFrameworkCore;
using Recipes.Common;
using Recipes.Core.Entities;
using System;
using System.Collections.Generic;

namespace Recipes.Database.Seeders
{
    public static class CategoriesSeeder
    {
        public static void SeedCategories(this ModelBuilder builder)
        {
            Random rnd = new Random();
            List<string> categoryNames = new() { "Salata", "Palacinke", "Waffle", "Hamburger", "Sendvic", "Torta", "Kolac", "Pita", "Pizza", "Sladoled", "Jela s rostilja", "Peciva" };
            List<Category> categories = new();
            var startDate = new DateTime(2010, 1, 1, 0, 0, 0);
            var endDate = new DateTime(2021, 12, 30, 0, 0, 0);
            for (int i = 1; i <= 100; i++)
            {
                categories.Add(new Category
                {
                    Id = i,
                    Name = categoryNames[i % 12] + i.ToString(),
                    CreatedAt = RandomDateGenerator.GenerateRandomDateTime(startDate, endDate),
                    CreatedBy = rnd.Next(1, 4),
                    ModifiedAt = RandomDateGenerator.GenerateRandomDateTime(startDate, endDate)
                });
            }
            builder.Entity<Category>().HasData(categories);
        }
    }
}
