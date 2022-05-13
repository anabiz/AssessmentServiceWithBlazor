
using Application.Contracts;
using Application.Helpers;
using BlazorApp1.Shared;
using Domain.Entities;
using Infrastructure.Contracts;
using System.Net;

namespace Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;

        public ProductService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<SuccessResponse<List<ProductDto>>> GetProductsAsync()
        {
            var products = await _repository.Product.GetAllAsync();
            if(products == null)
                throw new RestException(HttpStatusCode.BadRequest, "Unable to retrieve products", "An Error occured while retrieving products");
            
            return new SuccessResponse<List<ProductDto>>()
            {
                Data = products.ToList(),
                Success = true,
                Message = "Data successfully retrieved"
            };
                

        }
    }
}
