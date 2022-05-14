using Domain.Entities;
using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;

namespace Infrastructure.Repositories
{
    public class QuestionOptionRepository : Repository<QuestionOption>, IQuestionOptionRepository
    {
        public QuestionOptionRepository(DataContext context) : base(context)
        {
        }
    }
}
