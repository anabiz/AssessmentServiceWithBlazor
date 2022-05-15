using Application.Contracts;
using Application.Enums;
using Application.Helpers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BlazorApp1.Shared;
using Domain.Entities;
using Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Application.Services
{
    public class AssessmentService : IAssessmentService
    {
        #region Settings
        private IRepositoryManager _repository;
        private IMapper _mapper;

        public AssessmentService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion
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

        public async Task<SuccessResponse<GetQuestionDto>> CreateAssessmentQuestionAsync(CreateQuestionDto model, Guid assessmentId)
        {
            var assessment = await _repository.Assessment.QueryAll(x => x.Id == assessmentId).FirstOrDefaultAsync();

            if (assessment == null)
                throw new RestException(HttpStatusCode.NotFound, "Assessment not found");

            var question = _mapper.Map<Question>(model);
            question.AssessmentId = assessment.Id;
            question.Score = 1;
            await _repository.Question.AddAsync(question);

            List<Option> options = new();
            foreach (var option in model.Options)
            {
                var questionOption = _mapper.Map<Option>(option);
                questionOption.QuestionId = question.Id;
                options.Add(questionOption);
            };
            //await _repository.Option.AddRangeAsync(options);
            await _repository.SaveChangesAsync();

            var responseQuestionQuery = await _repository.Question.Get(x => x.Id == question.Id)
                .Include(x => x.Options)
                .FirstOrDefaultAsync();

            GetQuestionDto response = _mapper.Map<GetQuestionDto>(responseQuestionQuery);
            
            return new SuccessResponse<GetQuestionDto>
            {
                Data = response,
                Success = true,
                Message = "Message successfully created"
            };

        }

        public async Task DeleteAssessmentAsync(Guid assessmentId)
        {
            var assessment = await _repository.Assessment.GetByIdAsync(assessmentId);

            if (assessment == null)
                throw new RestException(HttpStatusCode.NotFound, "Assessment not found");

            _repository.Assessment.Remove(assessment);
            await _repository.SaveChangesAsync();

        }

        public async Task DeleteQuestionAsync(Guid questionId)
        {
            var question = await _repository.Question.Get(x => x.Id == questionId)
             .Include(x => x.Options)
             .FirstOrDefaultAsync();

            if (question is null)
                throw new RestException(HttpStatusCode.NotFound, "Question not found");

            _repository.Question.Remove(question);

            if(question.Options.Count() > 0)
            _repository.Option.RemoveRange(question.Options);

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

        public async Task<SuccessResponse<ICollection<GetQuestionDto>>> GetAssessmentQuestionsAsync(Guid assessmentId)
        {
            var assessment = await GetAssessment(assessmentId);

            var questions = await _repository.Question.Get(x => x.AssessmentId == assessment.Id)
                .Include(x => x.Options)
                .ToArrayAsync();

            var result = _mapper.Map<ICollection<GetQuestionDto>>(questions);

            return new SuccessResponse<ICollection<GetQuestionDto>>
            {
                Data = result,
                Success = true,
                Message = "Data successfully retrieved"
            };
        }

        #region reusuables
        private async Task<Assessment> GetAssessment(Guid assessmentId)
        {
            var assessment = await _repository.Assessment.Get(x => x.Id == assessmentId).FirstOrDefaultAsync();

            if (assessment == null)
                throw new RestException(HttpStatusCode.NotFound, "Assessment does not exist");

            return assessment;
        }
        #endregion
    }
}
