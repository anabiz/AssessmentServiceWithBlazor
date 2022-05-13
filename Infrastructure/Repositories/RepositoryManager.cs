using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _dataContext;
        private readonly Lazy<IProductRepository> _productRepository;

        public RepositoryManager(DataContext dataContext)
        {
            _dataContext = dataContext;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(dataContext));
            
        }

        public IProductRepository Product => _productRepository.Value;

        public async Task BeginTransaction(Func<Task> action)
        {
            await using var transaction = await _dataContext.Database.BeginTransactionAsync();
            try
            {
                await action();

                await SaveChangesAsync();
                await transaction.CommitAsync();

            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task SaveChangesAsync() => await _dataContext.SaveChangesAsync();
    }
}
