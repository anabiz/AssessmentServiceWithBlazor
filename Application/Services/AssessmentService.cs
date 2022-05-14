using Application.Contracts;
using Application.Enums;
using Application.Helpers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BlazorApp1.Shared;
using Domain.Entities;
using Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Application.Services
{
    public class AssessmentService : IAssessmentService
    {
        private IRepositoryManager _repository;
        private IMapper _mapper;

        public AssessmentService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<SuccessResponse<GetAssessmentDto>> CreateAssessmentAsync(CreateAssessmentDto model)
        {
            var assessment = _mapper.Map<Assessment>(model);

            assessment.Status = assessment.StartDate > DateTime.Now ? EAssessmentStatus.PENDING.ToString() : EAssessmentStatus.ONGOING.ToString();
            await _repository.Assessment.AddAsync(assessment);
            await _repository.SaveChangesAsync();

            return new SuccessResponse<GetAssessmentDto>
            {
                Success = true,
                Data = _mapper.Map<GetAssessmentDto>(assessment),
                Message = "Assessment successfully created"
            };
        }

        public Task<SuccessResponse<GetQuestionDto>> CreateAssessmentQuestion(CreateQuestionDto model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAssessmentAsync(Guid assessmentId)
        {
            var assessment = await _repository.Assessment.GetByIdAsync(assessmentId);

            if (assessment == null)
                throw new RestException(HttpStatusCode.NotFound, "Assessment not found");

            _repository.Assessment.Remove(assessment);
            await _repository.SaveChangesAsync();

        }

        public async Task<PagedResponse<ICollection<GetAssessmentDto>>> GetAllAssessmentAsync(ResourceParameter parameter, string name, IUrlHelper urlHelper)
        {
            var assessmentsQuery = _repository.Assessment.QueryAll();

            if (!string.IsNullOrEmpty(parameter.Search))
            {
                var search = parameter.Search.Trim().ToLower();
                assessmentsQuery = assessmentsQuery.Where(x =>
                      (x.Title.ToLower().Contains(search))
                     || (x.Status.ToLower().Contains(search)));
            }

            var assessments = assessmentsQuery.ProjectTo<GetAssessmentDto>(_mapper.ConfigurationProvider);
            var assessmentList = await PagedList<GetAssessmentDto>.Create(assessments, parameter.PageNumber, parameter.PageSize, parameter.Sort);

            var page = PageUtility<GetAssessmentDto>.CreateResourcePageUrl(parameter, name, assessmentList, urlHelper);

            return new PagedResponse<ICollection<GetAssessmentDto>>
            {
                Message = "Data successfully retrieved",
                Data = assessmentList,
                Meta = new Meta
                {
                    Pagination = page
                }
            };

        }

        public async Task<SuccessResponse<GetAssessmentDto>> GetAssessmentByIdAsync(Guid assessmentId)
        {
            var assessment = await _repository.Assessment.GetByIdAsync(assessmentId);

            if (assessment == null)
                throw new RestException(HttpStatusCode.NotFound, "Assessment not found");

            return new SuccessResponse<GetAssessmentDto>
            {
                Success = true,
                Data = _mapper.Map<GetAssessmentDto>(assessment),
                Message = "Assessment successfully retrieved"
            };
        }
    }
}
