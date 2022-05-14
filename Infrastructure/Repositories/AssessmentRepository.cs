using Domain.Entities;
using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;


namespace Infrastructure.Repositories
{
    public class AssessmentRepository : Repository<Assessment>, IAssessmentRepository
    {
        public AssessmentRepository(DataContext context) : base(context)
        {
        }
    }
}
