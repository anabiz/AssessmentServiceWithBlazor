
using Application.Contracts;
using Infrastructure.Contracts;
using Infrastructure.Services;

namespace Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        public ServiceManager(IRepositoryManager repository)
        {
            _productService = new Lazy<IProductService>(() => new ProductService( repository));
        }
        public IProductService ProductService => _productService.Value;
        // IAssessmentService AssessmentService => _assessmentService.Value;
    }
}
