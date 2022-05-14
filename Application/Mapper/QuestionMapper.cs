using AutoMapper;
using BlazorApp1.Shared;
using Domain.Entities;

namespace Application.Mapper
{
    public class QuestionMapper : Profile
    {
        public QuestionMapper()
        {
            CreateMap<Question, GetQuestionDto>();
            CreateMap<Question, CreateQuestionDto>().ReverseMap();
        }
    }
}
