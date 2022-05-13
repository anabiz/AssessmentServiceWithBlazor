

namespace Domain.Entities
{
    public class AssessmentQuestion
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public Guid AssessmentId { get; set; }
        public Question Question { get; set; }
        public Assessment Assessment { get; set; }
    }
}
