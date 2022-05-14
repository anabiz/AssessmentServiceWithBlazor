

namespace Application.Contracts
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        IAssessmentService AssessmentService { get; }
    }
}
