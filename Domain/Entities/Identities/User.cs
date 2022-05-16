using System;
using System.Collections.Generic;
using Domain.Common;
using Domain.Entities.BaseInterfaces;
using Domain.Entities.Organizations;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Identities
{
    public class User: IdentityUser<Guid>, IAuditableEntity,ISoftDeletedEntity
    {
	    /// <summary>
        /// Organizations are the institutions that have account on this system
        /// every user belongs to an institution and can have admin or student role
        /// </summary>
        public Guid OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Verified { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime? LastLogin { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        // IAuditable properties implementations
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public Guid? CreatedById { get; set; }

        // Soft Delete Implementations
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
		public bool  IsSuspended { get; set; }

		// Navigation Properties
		public ICollection<UserActivity> UserActivities { get; set; }
        public StudentLevel StudentLevel { get; set; }
        public Organization Organization { get; set; }
		
	}
}