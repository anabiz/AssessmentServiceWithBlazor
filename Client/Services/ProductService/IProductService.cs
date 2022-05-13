using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.ProductService
{
    public interface IProductService
    {
        List<ProductDto> Products { get; set; }
        Task GetProducts();
    }
}
