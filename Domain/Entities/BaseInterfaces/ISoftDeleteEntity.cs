using System;

namespace Domain.Entities.BaseInterfaces
{
    public interface ISoftDeletedEntity
	{
		bool IsDeleted { get; set; }
		DateTime? DeletedAt { get; set; }

	}
}
