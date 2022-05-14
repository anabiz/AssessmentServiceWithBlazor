using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _dataContext;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IAssessmentRepository> _assessmentRepository;
        private readonly Lazy<IQuestionRepository> _questionRepository;
        private readonly Lazy<IAssessmentQuestionRepository> _assessmentQuestionRepository;
        private readonly Lazy<IQuestionOptionRepository> _questionOptionRepository;

        public RepositoryManager(DataContext dataContext)
        {
            _dataContext = dataContext;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(dataContext));
            _assessmentRepository = new Lazy<IAssessmentRepository>(() => new AssessmentRepository(dataContext));
            _questionRepository = new Lazy<IQuestionRepository>(() => new QuestionRepository(dataContext));
            _assessmentQuestionRepository = new Lazy<IAssessmentQuestionRepository>(() => new AssessmentQuestionRepository(dataContext));
            _questionOptionRepository = new Lazy<IQuestionOptionRepository>(() => new QuestionOptionRepository(dataContext));
        }

        public IProductRepository Product => _productRepository.Value;

        public IAssessmentRepository Assessment => _assessmentRepository.Value;

        public IQuestionRepository Question => _questionRepository.Value;

        public IAssessmentQuestionRepository AssessmentQuestion => _assessmentQuestionRepository.Value;

        public IQuestionOptionRepository QuestionOption => _questionOptionRepository.Value;

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
