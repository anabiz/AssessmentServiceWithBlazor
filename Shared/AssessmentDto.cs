

namespace BlazorApp1.Shared
{
    public record GetAssessmentDto
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalObtainableScore { get; set; }
        public int PassMark { get; set; }
        public int NoOfSubmission { get; set; }
        public int Duration { get; set; }
        public string CompletionMessage { get; set; }
    }
    public record CreateAssessmentDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalObtainableScore { get; set; }
        public int PassMark { get; set; }
        public int NoOfSubmission { get; set; }
        public int Duration { get; set; }
        public string CompletionMessage { get; set; }
    }
}
