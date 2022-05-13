using BlazorApp1.Shared;

namespace BlazorApp1.Client.Shared
{
    public class MyProductList
    {
        public static List<ProductDto> Products = new List<ProductDto>
        {
            new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Lexus 122",
                Price = 100.35M
            },
             new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Toyota 330",
                Price = 90.35M
            },
             new ProductDto
            {
                Id = Guid.NewGuid(),
                Name = "Mesdix 992",
                Price = 105.35M
            }
        };

        

    }

    // private List<ProductDto> ProductList = MyProductList.Products;
}
