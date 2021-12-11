using Recipes.Core.Requests;
using Recipes.Core.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<PagedResponse<IEnumerable<ResponseGetCategories>>> GetCategoriesAsync(BaseSearch searchArgs);

        Task<bool> CreateCategoryAsync(RequestCreateCategory request);

        Task<bool> UpdateCategoryAsync(RequestUpdateCategory request);

        Task<bool> DeleteCategoryAsync(int id);
    }
}
