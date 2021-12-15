using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Recipes.Core.Validators;

namespace Recipes.Api.Extensions
{
    public static class FluentValidationConfiguration
    {
        public static void ConfigureFluentValidation(this IServiceCollection services)
        {
            services.AddMvc().AddFluentValidation(f =>
            {
                f.RegisterValidatorsFromAssemblyContaining<RequestCreateRecipeValidator>();
                f.RegisterValidatorsFromAssemblyContaining<RequestUpdateRecipeValidator>();
                f.RegisterValidatorsFromAssemblyContaining<RequestCreateIngredientValidator>();
                f.RegisterValidatorsFromAssemblyContaining<RequestUpdateIngredientValidator>();
                f.RegisterValidatorsFromAssemblyContaining<RequestCreateCategoryValidator>();
                f.RegisterValidatorsFromAssemblyContaining<RequestUpdateCategoryValidator>();
                f.ImplicitlyValidateChildProperties = true;
            });
        }
    }
}