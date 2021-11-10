using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecipesAPI.Data;
using RecipesAPI.Dtos;
using RecipesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RecipesAPI.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public IngredientService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<GetIngredientDto>>> GetIngredients(string search)
        {
            var response = new ServiceResponse<IEnumerable<GetIngredientDto>>();
            var ingredients = await _context.Ingredients
                .Where(Filter(search))
                .ToListAsync();
            
            response.Data = ingredients.Select(x => _mapper.Map<GetIngredientDto>(x)).ToList();
            return response;
        }

        private static Expression<Func<Ingredient, bool>> Filter(string search)
        {
            search = search?.Trim().ToLower();
            return x => string.IsNullOrEmpty(search)
            || x.Name.ToLower().Contains(search);
        }
    }
}
