

namespace Domain.Entities
{
    public class Assessment
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalObtainableScore { get; set; }
        public int PassMark { get; set; }
        public int NoOfSubmission { get; set; }
        public int Duration { get; set; }
        public string CompletionTitle { get; set; } = String.Empty;
        public string CompletionMessage { get; set; } = String.Empty;
    }
}
