using Microsoft.EntityFrameworkCore;
using MoreLinq;
using Recipes.Common.Enums;
using Recipes.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Recipes.Database.Configurations
{
    public static class RecipeIngredientSeeder
    {
        public static void SeedRecipeIngredients(this ModelBuilder builder)
        {
            Random rnd = new Random();
            List<RecipeIngredient> recipeIngredients = new();
            List<UnitType> units = new() { UnitType.kg, UnitType.l, UnitType.g, UnitType.ml, UnitType.kom };
            for (int i = 1; i <= 400; i++)
            {
                for (int j = 0; j <= rnd.Next(4, 15); j++)
                {
                    recipeIngredients.Add(new RecipeIngredient
                    {
                        RecipeId = i,
                        IngredientId = rnd.Next(1, 101),
                        Quantity = (float)Math.Round(rnd.Next(1, 50) + rnd.NextDouble(), 2),
                        UnitType = units[rnd.Next(0, 5)]
                    });
                }
            }

            recipeIngredients = recipeIngredients.DistinctBy(x => new { x.RecipeId, x.IngredientId }).ToList();
            builder.Entity<RecipeIngredient>().HasData(recipeIngredients);
        }
    }
}
