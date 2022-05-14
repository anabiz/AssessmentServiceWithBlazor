using Domain.Entities;
using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;

namespace Infrastructure.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(DataContext context) : base(context)
        {
        }
    }
}
