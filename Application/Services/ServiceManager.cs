using Application.Contracts;
using AutoMapper;
using Infrastructure.Contracts;
using Infrastructure.Services;

namespace Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        public ServiceManager(
            IRepositoryManager repository,
            IMapper mapper
            )
        {
            _productService = new Lazy<IProductService>(() => new ProductService( repository, mapper));
        }
        public IProductService ProductService => _productService.Value;
        // IAssessmentService AssessmentService => _assessmentService.Value;
    }
}
