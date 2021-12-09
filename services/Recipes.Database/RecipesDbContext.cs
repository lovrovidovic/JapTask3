using Microsoft.EntityFrameworkCore;
using Recipes.Core.Entities;
using Recipes.Database.Configurations;
using Recipes.Database.Seeders;

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

            builder.SeedCategories();
            builder.SeedIngredients();
            builder.SeedRecipes();
            builder.SeedRecipeIngredients();
        }
    }
}
