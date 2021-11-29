using Recipes.Core.Responses;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface ILoginService
    {
        Task<ServiceResponse<string>> LoginUserAsync(string username, string password);
    }
}
