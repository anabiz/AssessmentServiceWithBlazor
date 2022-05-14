

using AutoMapper;
using BlazorApp1.Shared;
using Domain.Entities;

namespace Application.Mapper
{
    public class OptionMapper : Profile
    {
        public OptionMapper()
        {
            CreateMap<CreateOptionDto, Option>();
        }
    }
}
