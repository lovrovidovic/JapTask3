using Microsoft.EntityFrameworkCore;
using Recipes.Core.Entities;
using Recipes.Common.Enums;
using System;
using Recipes.Database.Configurations;

namespace Recipes.Database
{
    public class RecipesDbContext : DbContext
    {
        public RecipesDbContext(DbContextOptions<RecipesDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ConfigureRecipeIngredient();
            builder.ConfigureUser();

            builder.Entity<User>().HasData(
                new User { Id = 1, Username = "user", Password = "123" },
                new User { Id = 2, Username = "Mark", Password = "sifra" },
                new User { Id = 3, Username = "John", Password = "lozinka" }
                );

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Salata", CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 2, Name = "Palacinke", CreatedAt = new DateTime(2009, 6, 12, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 3, Name = "Waffle", CreatedAt = new DateTime(2018, 12, 21, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 4, Name = "Hamburger", CreatedAt = new DateTime(2021, 10, 30, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 5, Name = "Sendvic", CreatedAt = new DateTime(2001, 5, 16, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 6, Name = "Torta", CreatedAt = new DateTime(2005, 1, 1, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 7, Name = "Kolac", CreatedAt = new DateTime(2021, 11, 1, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 8, Name = "Pita", CreatedAt = new DateTime(2020, 5, 8, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 9, Name = "Pizza", CreatedAt = new DateTime(2020, 4, 14, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 10, Name = "Sladoled", CreatedAt = new DateTime(2018, 8, 6, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 11, Name = "Jela s rostilja", CreatedAt = new DateTime(2017, 7, 9, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) },
                new Category { Id = 12, Name = "Peciva", CreatedAt = new DateTime(2000, 4, 4, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 11, 30, 8, 30, 52) }
                );

            builder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Brasno", NormativePrice = 18.4F, NormativeQuantity = 25, NormativeUnit = Unit.kg, UnitPrice = 0.000736F, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Ingredient { Id = 2, Name = "Mlijeko", NormativePrice = 10.3F, NormativeQuantity = 15, NormativeUnit = Unit.l, UnitPrice = 10.3F/15000, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Ingredient { Id = 3, Name = "Secer", NormativePrice = 5.5F, NormativeQuantity = 250, NormativeUnit = Unit.g, UnitPrice = 0.022F, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Ingredient { Id = 4, Name = "Maslac", NormativePrice = 20, NormativeQuantity = 2, NormativeUnit = Unit.kg, UnitPrice = 0.01F, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Ingredient { Id = 5, Name = "Mlijecna cokolada", NormativePrice = 10, NormativeQuantity = 500, NormativeUnit = Unit.g, UnitPrice = 0.02F, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Ingredient { Id = 6, Name = "Crna cokolada", NormativePrice = 17.4F, NormativeQuantity = 500, NormativeUnit = Unit.g, UnitPrice = 0.0348F, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Ingredient { Id = 7, Name = "Jaje", NormativePrice = 3.6F, NormativeQuantity = 10, NormativeUnit = Unit.kom, UnitPrice = 0.36F, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Ingredient { Id = 8, Name = "Voda", NormativePrice = 1.2F, NormativeQuantity = 1, NormativeUnit = Unit.l, UnitPrice = 0.0012F, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) }
                );

            builder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, Name = "Cokoladni kolac", Description = "Fini cokoladni kolac.", CategoryId = 7, CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 2, Name = "Bijeli kolac", Description = "Osvjezavajuci bijeli kolac", CategoryId = 7, CreatedAt = new DateTime(2009, 6, 12, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 3, Name = "Rafaelo", Description = "Kolac koji ima kokos", CategoryId = 7, CreatedAt = new DateTime(2018, 12, 21, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 4, Name = "Ferrero", Description = "Kolac koji ima ferrero roche (samo u imenu)", CategoryId = 7, CreatedAt = new DateTime(2021, 10, 30, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 5, Name = "Kolac s jagodama", Description = "Kolac napravljen s jabukama", CategoryId = 7, CreatedAt = new DateTime(2001, 5, 16, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 6, Name = "Kolac s jabukama", Description = "Kolac napravljen s jagodama", CategoryId = 7, CreatedAt = new DateTime(2005, 1, 1, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 7, Name = "Kinder", Description = "Kolac za djecu", CategoryId = 7, CreatedAt = new DateTime(2021, 11, 1, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 8, Name = "Twix", Description = "Dva kolaca u jednom", CategoryId = 7, CreatedAt = new DateTime(2020, 5, 8, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 9, Name = "Snickers", Description = "Kolac s ljesnacima i karamelom", CategoryId = 7, CreatedAt = new DateTime(2020, 4, 14, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 10, Name = "Orah", Description = "Kolac s orahom", CategoryId = 7, CreatedAt = new DateTime(1999, 8, 10, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 11, Name = "Specijalitet kuce", Description = "Ovaj kolac sluzi za pokazivanje funkcionalnosti load more buttona", CategoryId = 7, CreatedAt = new DateTime(1998, 8, 10, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) },
                new Recipe { Id = 12, Name = "Dummy recept", Description = "Dummy Description", CategoryId = 3, CreatedAt = new DateTime(2017, 7, 9, 8, 30, 52), CreatedBy = 1, ModifiedAt = new DateTime(2021, 10, 30, 8, 30, 52) }
                );

            builder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient { RecipeId = 1, IngredientId = 1, Quantity = 2, Unit = Unit.kg },
                new RecipeIngredient { RecipeId = 1, IngredientId = 2, Quantity = 2.5F, Unit = Unit.l },
                new RecipeIngredient { RecipeId = 1, IngredientId = 3, Quantity = 500, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 2, IngredientId = 4, Quantity = 20, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 2, IngredientId = 8, Quantity = 350, Unit = Unit.ml },
                new RecipeIngredient { RecipeId = 3, IngredientId = 7, Quantity = 4, Unit = Unit.kom },
                new RecipeIngredient { RecipeId = 3, IngredientId = 5, Quantity = 400, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 3, IngredientId = 6, Quantity = 1.7F, Unit = Unit.kg },
                new RecipeIngredient { RecipeId = 4, IngredientId = 1, Quantity = 275, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 5, IngredientId = 8, Quantity = 1.1F, Unit = Unit.l },
                new RecipeIngredient { RecipeId = 5, IngredientId = 4, Quantity = 125, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 5, IngredientId = 7, Quantity = 1, Unit = Unit.kom },
                new RecipeIngredient { RecipeId = 6, IngredientId = 2, Quantity = 50, Unit = Unit.ml },
                new RecipeIngredient { RecipeId = 6, IngredientId = 5, Quantity = 15, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 7, IngredientId = 6, Quantity = 3.2F, Unit = Unit.kg },
                new RecipeIngredient { RecipeId = 7, IngredientId = 4, Quantity = 80, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 8, IngredientId = 2, Quantity = 1, Unit = Unit.l },
                new RecipeIngredient { RecipeId = 8, IngredientId = 7, Quantity = 3, Unit = Unit.kom },
                new RecipeIngredient { RecipeId = 9, IngredientId = 2, Quantity = 2, Unit = Unit.l },
                new RecipeIngredient { RecipeId = 9, IngredientId = 3, Quantity = 1.9F, Unit = Unit.kg },
                new RecipeIngredient { RecipeId = 9, IngredientId = 4, Quantity = 20, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 9, IngredientId = 8, Quantity = 70, Unit = Unit.ml },
                new RecipeIngredient { RecipeId = 10, IngredientId = 1, Quantity = 5, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 10, IngredientId = 7, Quantity = 2, Unit = Unit.kom },
                new RecipeIngredient { RecipeId = 11, IngredientId = 5, Quantity = 100, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 11, IngredientId = 4, Quantity = 740, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 12, IngredientId = 5, Quantity = 100, Unit = Unit.g },
                new RecipeIngredient { RecipeId = 12, IngredientId = 4, Quantity = 740, Unit = Unit.g }
                );
        }
    }
}
