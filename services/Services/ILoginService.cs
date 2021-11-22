using Recipes.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Services
{
    public interface ILoginService
    {
        Task<ServiceResponse<string>> LoginUser(string username, string password);
    }
}
