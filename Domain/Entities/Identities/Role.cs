using Domain.Entities.Organizations;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Identities
{
	public class Role : IdentityRole<Guid>
	{
		public Role() : base ()
		{ }

		// add extra special column/properties here
		public string Description { get; set; }
		public bool IsSystemRole { get; set; }
		public string Status { get; set; } = ERoleStatus.Active.ToString();
		public Guid? OrganizationId { get; set; }
		public Organization Organization { get; set; }

	}
	
}
