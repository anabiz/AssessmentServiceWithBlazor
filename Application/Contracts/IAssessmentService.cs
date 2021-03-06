using Application.Helpers;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Application.Contracts
{
    public interface IAssessmentService
    {
        Task<SuccessResponse<GetAssessmentDto>> CreateAssessmentAsync(CreateAssessmentDto model);
        Task DeleteAssessmentAsync(Guid assessmentId);
        Task<SuccessResponse<GetAssessmentDto>> GetAssessmentByIdAsync(Guid assessmentId);
        Task<PagedResponse<ICollection<GetAssessmentDto>>> GetAllAssessmentAsync(ResourceParameter parameter, string name, IUrlHelper urlHelper);
        Task<SuccessResponse<GetQuestionDto>> CreateAssessmentQuestion(CreateQuestionDto model);
    }
}
