using BlazorApp1.Shared;
using Domain.Entities;
using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;
using Infrastructure.Repositories;


namespace Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
