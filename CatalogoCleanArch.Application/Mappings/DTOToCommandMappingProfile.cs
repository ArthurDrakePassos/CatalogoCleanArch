using AutoMapper;
using CatalogoCleanArch.Application.DTOs;
using CatalogoCleanArch.Application.Products.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoCleanArch.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>().ReverseMap();
            CreateMap<ProductDTO, ProductUpdateCommand>().ReverseMap();

        }
    }
}
