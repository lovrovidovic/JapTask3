using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipes.Api.Data;

namespace Recipes.Api.Extensions
{
    public static class DbContextConfiguration
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DBConnection")));
        }
    }
}
