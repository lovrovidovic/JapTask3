using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Recipes.Common.Enums;
using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using Recipes.Database;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            List<Ingredient> ingredients;
            var query = _recipesDbContext.Ingredients
                .OrderBy(x => x.Id)
                .Where(Filter(request.Filters))
                .AsQueryable();

            AddOrder(request, ref query);

            query = query
                .Skip(request.Page * request.PageSize)
                .Take(request.PageSize);

            ingredients = await query.ToListAsync();
            response.Data = _mapper.Map<List<ResponseGetIngredient>>(ingredients);
            response.Count = response.Data.Count();
            response.NextPage = request.Page + 1;
            return response;
        }

        private static void AddOrder(RequestGetPagedIngredients request, ref IQueryable<Ingredient> query)
        {
            if (!string.IsNullOrEmpty(request.SortBy))
            {
                if (request.SortOrder == SortOrder.DESC)
                {
                    if (request.SortBy == "name")
                    {
                        query = query.OrderByDescending(x => x.Name);
                    }
                    else if (request.SortBy == "normativePrice")
                    {
                        query = query.OrderByDescending(x => x.NormativePrice);
                    }
                    else if (request.SortBy == "normativeQuantity")
                    {
                        query = query.OrderByDescending(x => x.NormativeQuantity);
                    }
                    else if (request.SortBy == "normativeUnit")
                    {
                        query = query.OrderByDescending(x => x.NormativeUnit);
                    }
                    else if (request.SortBy == "unitPrice")
                    {
                        query = query.OrderByDescending(x => x.UnitPrice);
                    }
                }
                else
                {
                    if (request.SortBy == "name")
                    {
                        query = query.OrderBy(x => x.Name);
                    }
                    else if (request.SortBy == "normativePrice")
                    {
                        query = query.OrderBy(x => x.NormativePrice);
                    }
                    else if (request.SortBy == "normativeQuantity")
                    {
                        query = query.OrderBy(x => x.NormativeQuantity);
                    }
                    else if (request.SortBy == "normativeUnit")
                    {
                        query = query.OrderBy(x => x.NormativeUnit);
                    }
                    else if (request.SortBy == "unitPrice")
                    {
                        query = query.OrderBy(x => x.UnitPrice);
                    }
                }
            }
        }

        private static Expression<Func<Ingredient, bool>> Filter(IngredientFiltersDto filters)
        {
            return x => (filters == null)
            || (filters.Name == null || (x.Name.ToLower().Contains(filters.Name.ToLower()))
            && (filters.MinQuantity == null || x.NormativeQuantity > filters.MinQuantity)
            && (filters.MaxQuantity == null || x.NormativeQuantity < filters.MaxQuantity)
            && (filters.UnitType == null || x.NormativeUnit.Equals(filters.UnitType)));
        }

        public async Task<bool> CreateIngredientAsync(RequestCreateIngredient request)
        {
            var ingredient = _mapper.Map<Ingredient>(request);
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

            _mapper.Map(request, ingredient);
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
