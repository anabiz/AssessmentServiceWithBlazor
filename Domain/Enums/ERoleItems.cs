
using System.ComponentModel;


namespace Domain.Enums
{
    public enum ERole
    {
        [Description("SCHOOLADMIN")]
        HRADMIN = 1,
        [Description("SUPERADMIN")]
        SUPERADMIN = 2,
        [Description("STUDENT")]
        STUDENT = 3,
    }
 

    public enum ERoleStatus
    {
        [Description("Active")]
        Active = 1,
        [Description("Deactivated")]
        Deactivated = 2
    }


    }
