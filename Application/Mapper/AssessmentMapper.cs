using AutoMapper;
using BlazorApp1.Shared;
using Domain.Entities;

namespace Application.Mapper
{
    internal class AssessmentMapper : Profile
    {
        public AssessmentMapper()
        {
            CreateMap<CreateAssessmentDto, Assessment>();
            CreateMap<Assessment, GetAssessmentDto>();
        }
    }
}
