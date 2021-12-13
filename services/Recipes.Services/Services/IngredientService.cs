using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Recipes.Common.Enums;
using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using Recipes.Database;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Services.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly RecipesDbContext _recipesDbContext;
        private readonly IMapper _mapper;
        private readonly ICalculationService _calculationService;

        public IngredientService(RecipesDbContext recipesDbContext, IMapper mapper, ICalculationService calculationService)
        {
            _recipesDbContext = recipesDbContext;
            _mapper = mapper;
            _calculationService = calculationService;
        }

        public async Task<ServiceResponse<IEnumerable<ResponseGetIngredient>>> GetIngredientsAsync()
        {
            var response = new ServiceResponse<IEnumerable<ResponseGetIngredient>>();
            response.Data = await _recipesDbContext.Ingredients.Select(x => _mapper.Map<ResponseGetIngredient>(x)).ToListAsync();
            return response;
        }

        public async Task<ServiceResponse<ResponseGetIngredientDetails>> GetIngredientDetailsAsync(int id)
        {
            var response = new ServiceResponse<ResponseGetIngredientDetails>();
            response.Data = _mapper.Map<ResponseGetIngredientDetails>(await _recipesDbContext.Ingredients.FirstOrDefaultAsync(x => x.Id == id));
            return response;
        }

        public async Task<PagedResponse<IEnumerable<ResponseGetIngredient>>> GetPagedIngredientsAsync(RequestGetPagedIngredients request)
        {
            var response = new PagedResponse<IEnumerable<ResponseGetIngredient>>();
            response.Data = await _recipesDbContext.Ingredients
                .OrderBy(x => x.Id)
                .Skip(request.Page * request.PageSize)
                .Take(request.PageSize)
                .Select(x => _mapper.Map<ResponseGetIngredient>(x))
                .ToListAsync();
            response.Count = response.Data.Count();
            response.NextPage = request.Page + 1;
            return response;
        }

        public async Task<bool> CreateIngredientAsync(RequestCreateIngredient request)
        {
            var ingredient = new Ingredient
            {
                CreatedAt = DateTime.Now,
                CreatedBy = request.UserId,
                ModifiedAt = DateTime.Now,
                Name = request.Name,
                NormativePrice = request.NormativePrice,
                NormativeQuantity = request.NormativeQuantity,
                NormativeUnit = request.NormativeUnit,
            };
            ingredient.UnitPrice = _calculationService.CalculateIngredientUnitCost(ingredient);

            await _recipesDbContext.Ingredients.AddAsync(ingredient);
            await _recipesDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateIngredientAsync(RequestUpdateIngredient request)
        {
            var ingredient = await _recipesDbContext.Ingredients.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (ingredient == null)
            {
                return false;
            }

            ingredient.Name = request.Name;
            ingredient.ModifiedAt = DateTime.Now;
            ingredient.NormativePrice = request.NormativePrice;
            ingredient.NormativeQuantity = request.NormativeQuantity;
            ingredient.NormativeUnit = request.NormativeUnit;
            ingredient.UnitPrice = _calculationService.CalculateIngredientUnitCost(ingredient);

            await _recipesDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteIngredientAsync(int id)
        {
            var ingredient = await _recipesDbContext.Ingredients.FirstOrDefaultAsync(x => x.Id == id);

            if (ingredient == null)
            {
                return false;
            }

            _recipesDbContext.Ingredients.Remove(ingredient);
            await _recipesDbContext.SaveChangesAsync();
            return true;
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
