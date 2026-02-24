using AutoMapper;
using CatalogoCleanArch.Application.DTOs;
using CatalogoCleanArch.Domain.Entities;

namespace CatalogoCleanArch.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category,CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
