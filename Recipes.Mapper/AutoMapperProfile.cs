using AutoMapper;
using Recipes.Core.Dtos;
using Recipes.Core.Entities;

namespace Recipes.Mapper
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
