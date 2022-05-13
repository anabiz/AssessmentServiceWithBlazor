

namespace Infrastructure.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
       
        Task SaveChangesAsync();
        Task BeginTransaction(Func<Task> action);
    }
}
