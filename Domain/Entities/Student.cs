using Domain.Common;
using Domain.Entities.Identities;
using Domain.Entities.Organizations;

namespace Domain.Entities
{
    public class Student : AuditableEntity
    {
        public string ImageUrl { get; set; }
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid StudentLevelId { get; set; }
        public Guid OrganizationId { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public User User { get; set; }
        public StudentLevel StudentLevel { get; set; }
        public Organization Organization { get; set; }
    }
}
