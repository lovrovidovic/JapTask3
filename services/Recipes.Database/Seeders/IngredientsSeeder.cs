﻿using Microsoft.EntityFrameworkCore;
using Recipes.Common;
using Recipes.Common.Enums;
using Recipes.Core.Entities;
using System;
using System.Collections.Generic;

namespace Recipes.Database.Seeders
{
    public static class IngredientsSeeder
    {
        public static void SeedIngredients(this ModelBuilder builder)
        {
            Random rnd = new Random();
            List<String> ingredientNames = new() { "Brasno", "Mlijeko", "Secer", "Maslac", "Mlijecna cokolada", "Crna cokolada", "Jaje", "Voda" };
            List<Ingredient> ingredients = new();
            List<UnitType> units = new() { UnitType.kg, UnitType.l, UnitType.g, UnitType.ml, UnitType.kom };
            var startDate = new DateTime(2010, 1, 1, 0, 0, 0);
            var endDate = new DateTime(2021, 12, 30, 0, 0, 0);

            for (int i = 1; i <= 100; i++)
            {
                float generatedPrice = (float)Math.Round(rnd.Next(1, 50) + rnd.NextDouble(), 2);
                int generatedQuantity = rnd.Next(1, 50);
                UnitType generatedUnit = units[rnd.Next(0, 5)];
                ingredients.Add(new Ingredient
                {
                    Id = i,
                    Name = ingredientNames[i%8] + i.ToString(),
                    NormativePrice = generatedPrice,
                    NormativeQuantity = generatedQuantity,
                    NormativeUnit = generatedUnit,
                    UnitPrice = GenerateUnitPrice(generatedQuantity, generatedPrice, generatedUnit),
                    CreatedAt = RandomDateGenerator.GenerateRandomDateTime(startDate, endDate),
                    CreatedBy = rnd.Next(1, 4),
                    ModifiedAt = RandomDateGenerator.GenerateRandomDateTime(startDate, endDate)
                });
            }

            builder.Entity<Ingredient>().HasData(ingredients);
        }

        private static float GenerateUnitPrice(int quantity, float price, UnitType unit)
        {
            if (unit == UnitType.kg || unit == UnitType.l)
            {
                quantity *= 1000;
            }
            return price / quantity;
        }
    }
}
