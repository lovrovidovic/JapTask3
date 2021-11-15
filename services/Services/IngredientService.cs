using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecipesAPI.Data;
using RecipesAPI.Dtos;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<ServiceResponse<IEnumerable<GetIngredientDto>>> GetIngredients()
        {
            var response = new ServiceResponse<IEnumerable<GetIngredientDto>>();
            var ingredients = await _context.Ingredients.ToListAsync();

            response.Data = ingredients.Select(x => _mapper.Map<GetIngredientDto>(x)).ToList();
            return response;
        }
    }
}
