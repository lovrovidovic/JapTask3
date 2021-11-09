using AutoMapper;
using RecipesAPI.Dtos;
using RecipesAPI.Models;

namespace RecipesAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetCategoriesDto>();
        }
    }
}
