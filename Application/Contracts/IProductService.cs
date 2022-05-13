using Application.Helpers;
using BlazorApp1.Shared;

namespace Application.Contracts
{
    public interface IProductService
    {
        Task<SuccessResponse<List<ProductDto>>> GetProductsAsync();
    }
}