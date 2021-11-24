using Microsoft.EntityFrameworkCore;
using Recipes.Core.Entities;

namespace Recipes.Database.Configurations
{
    public static class RecipeIngredientConfiguration
    {
        public static void ConfigureRecipeIngredient(this ModelBuilder builder)
        {
            builder.Entity<RecipeIngredient>()
                .HasKey(x => new { x.RecipeId, x.IngredientId });

            builder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId);

            builder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId);
        }
    }
}
