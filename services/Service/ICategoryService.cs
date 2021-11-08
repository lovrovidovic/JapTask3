using services.Dtos;
using services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Service
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<GetCategoriesDto>>> GetCategories();
    }
}
