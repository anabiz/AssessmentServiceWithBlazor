using Domain.Entities;
using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;


namespace Infrastructure.Repositories
{
    public class OptionRepository : Repository<Option>, IOptionRepository
    {
        public OptionRepository(DataContext context) : base(context)
        {
        }
    }
}
