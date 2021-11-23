using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipes.Database;

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
