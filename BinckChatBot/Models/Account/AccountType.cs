namespace Binck.OpenApi.Models.Account
{
    /// <summary>
    /// Specifies the type of an account. Enum matches Topline values.
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Savings account
        /// </summary>
        Savings = 3,

        /// <summary>
        /// Binck complete account
        /// </summary>
        BinckComplete = 6,

        /// <summary>
        /// Fund coach account
        /// </summary>
        FundCoach = 8,

        /// <summary>
        /// PEA account
        /// </summary>
        PlanEpargneAction = 9,

        /// <summary>
        /// PEA / PME account
        /// </summary>
        PlanEpargneActionPme = 10,

        /// <summary>
        /// Global asset management account
        /// </summary>
        GlobalAssetManagement = 11,

        /// <summary>
        /// Savings broker account
        /// </summary>
        SavingsBroker = 12
    }
}
