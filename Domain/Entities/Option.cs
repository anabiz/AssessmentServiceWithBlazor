

namespace Domain.Entities
{
    public class Option
    {
        public Guid Id { get; set; }
        public string Body { get; set; } = string.Empty;
        public bool IsAnswer { get; set; }
    }
}
