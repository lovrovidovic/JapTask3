using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Recipes.Database;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Services.Interfaces;
using Recipes.Core.Responses;
using Dapper;
using Recipes.Common.Enums;

namespace Recipes.Services.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly RecipesDbContext _recipesDbContext;
        private readonly IMapper _mapper;

        public IngredientService(RecipesDbContext recipesDbContext, IMapper mapper)
        {
            _recipesDbContext = recipesDbContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetIngredient>>> GetIngredientsAsync()
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetIngredient>>();
            response.Data = await _recipesDbContext.Ingredients.Select(x => _mapper.Map<ResponseGetIngredient>(x)).ToListAsync();
            return response;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetMostUsedIngredients>>> GetMostUsedIngredientsAsync(UnitType unit, int min, int max)
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetMostUsedIngredients>>();
            var parameters = new DynamicParameters();
            parameters.Add("unit", unit);
            parameters.Add("min", min);
            parameters.Add("max", max);

            var result = await _recipesDbContext.Database.GetDbConnection()
                .QueryAsync<ResponseGetMostUsedIngredients>("GetMostUsedIngredients", parameters, commandType: System.Data.CommandType.StoredProcedure);

            response.Data = result;
            return response;
        }
    }
}
