
namespace BlazorApp1.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public List<ProductDto> Products { get; set; } = new List<ProductDto>();
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync <SuccessResponse<List<ProductDto>>>("api/product");
            if(result is not null && result.Data is not null)
                Products = result.Data;
        }
    }
}
