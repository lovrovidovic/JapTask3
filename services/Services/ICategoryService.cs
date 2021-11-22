using Recipes.Api.Dtos;
using Recipes.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Api.Services
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<GetCategoriesDto>>> GetCategories(int n);
    }
}
