﻿

namespace Infrastructure.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IAssessmentRepository Assessment { get; }
        IQuestionRepository Question { get; }
        IAssessmentQuestionRepository AssessmentQuestion { get; }
        IQuestionOptionRepository QuestionOption { get; }
        IOptionRepository Option { get; }

        Task SaveChangesAsync();
        Task BeginTransaction(Func<Task> action);
    }
}
