using Application.Contracts;
using Application.Helpers;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlazorApp1.Server.Controllers
{
    //[Authorize]
    [ApiController]
    //[ApiVersion("1.0")]
    [Route("api/assessment")]
    public class AssessmentController : Controller
    {
        private readonly IServiceManager _services;

        public AssessmentController(IServiceManager services)
        {
            _services = services;
        }


        /// <summary>
        /// Endpoint to create an assessment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //[Authorize(Roles = "ProgramManager,Admin,Facilitator")]
        [HttpPost]
        [ProducesResponseType(typeof(SuccessResponse<GetAssessmentDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAssessmentAsync(CreateAssessmentDto model)
        {
            var response = await _services.AssessmentService.CreateAssessmentAsync(model);

            return Ok(response);
        }

        /// <summary>
        /// Endpoint to delete an assessment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> DeleteAssessmentAsync(Guid id)
        {
             await _services.AssessmentService.DeleteAssessmentAsync(id);

            return NoContent();
        }

        /// <summary>
        /// Endpoint to get an assessment by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(SuccessResponse<GetAssessmentDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAssessmentByIdAsync(Guid id)
        {
            var response = await _services.AssessmentService.GetAssessmentByIdAsync(id);

            return Ok(response);
        }

        /// <summary>
        /// Endpoint to get all assessments
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = nameof(GetAssessmentAllAsync))]
        [ProducesResponseType(typeof(PagedResponse<ICollection<GetAssessmentDto>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAssessmentAllAsync([FromQuery] ResourceParameter parameter)
        {
            var response = await _services.AssessmentService.GetAllAssessmentAsync(parameter, nameof(GetAssessmentAllAsync), Url);

            return Ok(response);
        }

        /// <summary>
        /// Endpoint to create an assessment question
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/data/question")]
        [ProducesResponseType(typeof(SuccessResponse<GetQuestionDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAssessmentQuestionAsync(CreateQuestionDto model, Guid id)
        {
            var response = await _services.AssessmentService.CreateAssessmentQuestionAsync(model, id);

            return Ok(response);
        }
    }
}
