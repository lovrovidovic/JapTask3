using Microsoft.Extensions.DependencyInjection;

namespace Recipes.Api.Extensions
{
    public static class CorsConfiguration
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
                 .AllowAnyHeader());
            });
        }
    }
}
