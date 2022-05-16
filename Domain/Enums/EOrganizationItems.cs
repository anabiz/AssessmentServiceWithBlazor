using System.ComponentModel;


namespace Application.Enums
{
    public enum EOrganizationStatus
    {
        [Description("Inactive")]
        Inactive = 1,
        [Description("Active")]
        Active = 2,
        [Description("Deactivation")]
        Deactivate = 3,

    }

    public enum EOrganizationType    {
        [Description("Tetiary Institution")]
        TETIARY = 1,
        [Description("Secondary")]
        SECONDARY = 2,
        [Description("Primary")]
        PRIMARY = 3,
        [Description("Nursary")]
        NURSARY = 4,
    }

    public enum EOrganizationSize
    {
        [Description("1-50")]
        ONE_50 = 1,
        [Description("51-200")]
        FIFTYONE_200 = 2,
        [Description("201-500")]
        TWO_HUNDRED_AND_ONE_500 = 3,
        [Description("501-1000")]
        FIVE_HUNDRED_AND_ONE_1000 = 4,
        [Description("1000+")]
        THOUSAND_PLUS = 5,
    }
}
