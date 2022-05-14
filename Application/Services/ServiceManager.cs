using Application.Contracts;
using AutoMapper;
using Infrastructure.Contracts;
using Infrastructure.Services;

namespace Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IAssessmentService> _assessmentService;
        public ServiceManager(
              IRepositoryManager repository,
              IMapper mapper
            )
        {
            _productService = new Lazy<IProductService>(() => new ProductService( repository, mapper));
            _assessmentService = new Lazy<IAssessmentService>(() => new AssessmentService(repository, mapper));
        }
        public IProductService ProductService => _productService.Value;
        public IAssessmentService AssessmentService => _assessmentService.Value;
    }
}
