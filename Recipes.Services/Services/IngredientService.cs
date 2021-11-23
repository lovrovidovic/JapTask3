using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Recipes.Database;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Services.Interfaces;
using Recipes.Core.Responses;

namespace Recipes.Services.Services
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

        public async Task<ServiceResponse<IEnumerable<ResponseGetIngredient>>> GetIngredients()
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetIngredient>>();
            var ingredients = await _context.Ingredients.ToListAsync();

            response.Data = ingredients.Select(x => _mapper.Map<ResponseGetIngredient>(x)).ToList();
            return response;
        }
    }
}
