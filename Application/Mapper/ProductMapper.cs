using AutoMapper;
using BlazorApp1.Shared;
using Domain.Entities;

namespace Application.Mapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Option, GetOptionDto>();
        }
    }
}

