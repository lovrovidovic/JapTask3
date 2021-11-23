using Recipes.Core.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<GetCategoriesDto>>> GetCategories(int n);
    }
}
