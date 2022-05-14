using Domain.Entities;
using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AssessmentQuestionRepository : Repository<AssessmentQuestion>, IAssessmentQuestionRepository
    {
        public AssessmentQuestionRepository(DataContext context) : base(context)
        {
        }
    }
}
