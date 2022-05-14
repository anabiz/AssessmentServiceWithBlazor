
namespace BlazorApp1.Shared
{
    public class GetQuestionDto
    {
        public Guid Id { get; set; }
        public Guid AssessmentId { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<GetOptionDto> Options { get; set; }
    }

    public class GetOptionDto : CreateOptionDto
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class CreateQuestionDto
    {
        public string Body { get; set; }
        public string Type { get; set; } = string.Empty;
        public int Score { get; set; }
        public ICollection<CreateOptionDto> Options { get; set; }
    }

    public class CreateOptionDto
    {
        public bool IsAnswer { get; set; } = false;
        public string Body { get; set; }
 
    }
}
