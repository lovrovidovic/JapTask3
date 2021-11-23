using Microsoft.Extensions.DependencyInjection;
using Recipes.Mapper;

namespace Recipes.Api.Extensions
{
    public static class MapperConfiguration
    {
        public static void ConfigureMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }
    }
}
