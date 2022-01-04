using AutoMapper;
using Recipes.Core.Dtos;
using Recipes.Core.Entities;
using Recipes.Core.Requests;
using Recipes.Core.Responses;
using System;

namespace Recipes.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, ResponseGetCategories>();
            CreateMap<Category, ResponseGetCategoryDetails>();
            CreateMap<RequestCreateCategory, Category>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(src => DateTime.Now));

            CreateMap<Recipe, GetRecipeOfCategoryDto>();
            CreateMap<Recipe, ResponseGetRecipes>();
            CreateMap<Recipe, ResponseGetRecipeDetails>();

            CreateMap<Ingredient, ResponseGetIngredient>();
            CreateMap<Ingredient, ResponseGetIngredientDetails>();
            CreateMap<RequestCreateIngredient, Ingredient>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.UserId));
            CreateMap<RequestUpdateIngredient, Ingredient>()
                .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}
