using AutoMapper;
using services.Dtos;
using services.Models;

namespace services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetCategoriesDto>();
        }
    }
}
