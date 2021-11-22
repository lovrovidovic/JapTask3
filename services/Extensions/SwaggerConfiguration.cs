using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Recipes.Api.Extensions
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "services", Version = "v1" });
            });
        }
    }
}
