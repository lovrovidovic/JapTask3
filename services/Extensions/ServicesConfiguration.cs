using Microsoft.Extensions.DependencyInjection;
using Recipes.Services.Interfaces;
using Recipes.Services.Services;

namespace Recipes.Api.Extensions
{
    public static class ServicesConfiguration
    {
        public static void ConfigureServiceInjection(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IConversionService, ConversionService>();
            services.AddScoped<ILoginService, LoginService>();
        }
    }
}
