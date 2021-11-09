using RecipesAPI.Dtos;
using RecipesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<GetCategoriesDto>>> GetCategories();
    }
}
