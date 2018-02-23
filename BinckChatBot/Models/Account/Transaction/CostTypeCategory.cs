namespace Binck.OpenApi.Models.Account.Transaction
{
    /// <summary>
    /// Specifies the cost type category
    /// </summary>
    public enum CostTypeCategory
    {
#pragma warning disable 1591
        Commission,
        StampDuty,
        CapitalGainTax,
        CapitalIncomeTax,
        ExchangeTax,                        //      Beurstaks
        WithHoldingTax,                     //      RoerendeVoorheffing
        StampDutyBE,                        //      ZegelrechtBE
        VAT,                                //      BTW
        SecuritiesFee,
        SocialTax,
        IncomeTax,
        SRDExtensionCommission,
        SRDDifference,
        SRDSettlement,
        SRDCompensationPayment,
        SRDCommission,
        SpeculationTax,                     //      Speculatietaks
        AssetManagementFee
#pragma warning restore 1591
    }
}
