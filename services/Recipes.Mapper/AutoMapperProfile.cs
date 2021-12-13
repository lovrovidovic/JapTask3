using AutoMapper;
using Recipes.Core.Entities;
using Recipes.Core.Responses;

namespace Recipes.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, ResponseGetCategories>();
            CreateMap<Recipe, ResponseGetRecipes>();
            CreateMap<Recipe, ResponseGetRecipeDetails>();
            CreateMap<Ingredient, ResponseGetIngredient>();
            CreateMap<Ingredient, ResponseGetIngredientDetails>();
        }
    }
}
