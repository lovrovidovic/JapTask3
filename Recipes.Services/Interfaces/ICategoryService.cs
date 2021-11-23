using Recipes.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<ResponseGetCategories>>> GetCategories(int n);
    }
}
