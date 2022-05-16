using Application.Enums;
using Domain.Common;
using Domain.Entities.Identities;

namespace Domain.Entities.Organizations
{
    public class Organization : AuditableEntity
	{
        public Organization()
        {
            Students = new HashSet<User>();
        }
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public string Size  { get; set; }
        public string Type { get; set; }
        public string Status { get; set; } = EOrganizationStatus.Inactive.ToString();
        public string Description { get; set; }
        public string Country { get; set; }
        public Guid? AdminId { get; set; }
        
        // Navigation Properties
        public IEnumerable<User> Students { get; set; }
    }
}
