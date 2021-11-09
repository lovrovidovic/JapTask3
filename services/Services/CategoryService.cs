using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecipesAPI.Data;
using RecipesAPI.Dtos;
using RecipesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<GetCategoriesDto>>> GetCategories()
        {
            var response = new ServiceResponse<IEnumerable<GetCategoriesDto>>();

            var categories = await _context.Categories.ToListAsync();

            response.Data = categories.Select(x => _mapper.Map<GetCategoriesDto>(x)).ToList();

            return response;
        }
    }
}
