using AutoMapper;
using Recipes.Api.Dtos;
using Recipes.Api.Models;

namespace Recipes.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetCategoriesDto>();
            CreateMap<Recipe, GetRecipesDto>();
            CreateMap<Recipe, GetRecipeDetailsDto>();
            CreateMap<Ingredient, GetIngredientDto>();
        }
    }
}
