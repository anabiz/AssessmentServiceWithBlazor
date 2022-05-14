
namespace BlazorApp1.Shared
{
    public class GetQuestionDto
    {
        public Guid Id { get; set; }
        public Guid AssessmentId { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Score { get; set; }
        public ICollection<GetOptionDto> Options { get; set; }
    }

    public class GetOptionDto : CreateOptionDto
    {
        public Guid QuestionId { get; set; }
    }

    public class CreateQuestionDto
    {
        public Guid Id { get; set; }
        public Guid AssessmentId { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Score { get; set; }
        public ICollection<CreateOptionDto> Options { get; set; }
    }

    public class CreateOptionDto
    {
        public Guid Id { get; set; }
        public bool IsAnswer { get; set; }
        public string Body { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
