namespace Binck.OpenApi.Models.Account.Transaction
{
    /// <summary>
    /// Specifies the type of mutation
    /// </summary>
    public enum MutationType
    {
        /// <summary>
        /// Unknown mutation type
        /// </summary>
        Unknown,
        /// <summary>
        /// AFL, aflossing
        /// </summary>
        Repayment,
        /// <summary>
        /// CONV, conversie
        /// </summary>
        Conversion,
        /// <summary>
        /// EX C, exercise call
        /// </summary>
        ExcerciseCall,
        /// <summary>
        /// EX P, excercise put
        /// </summary>
        ExcercisePut,
        /// <summary>
        /// AS C
        /// </summary>
        AssignmentCall,
        /// <summary>
        /// AS P
        /// </summary>
        AssignmentPut,
        /// <summary>
        /// AWDVD, afwikkeling dividend
        /// </summary>
        SettlementDividend,
        /// <summary>
        /// D, deponering
        /// </summary>
        Deposit,
        /// <summary>
        /// EMISS, Toewijzing emissie 
        /// </summary>
        EmissionAllocation,
        /// <summary>
        /// INTBK
        /// </summary>
        InternalBooking,
        /// <summary>
        /// L, lichting
        /// </summary>
        TransferOutOfSecurities,
        /// <summary>
        /// LOSB, losbaarstelling
        /// </summary>
        NotificationOfRedemption,
        /// <summary>
        /// OBL, obligo boeking
        /// </summary>
        OutstandingBooking,
        /// <summary>
        /// OE, overboeking effecten
        /// </summary>
        SecurityTransfer,
        /// <summary>
        /// OWCLM, Omwisseling claims
        /// </summary>
        ConversionClaims,
        /// <summary>
        /// OWDVD, Omwisseling dividend
        /// </summary>
        ConversionDividend,
        /// <summary>
        /// CSHS, cash settlement
        /// </summary>
        CashSettlement,
        /// <summary>
        /// BYSTF, bijstelling
        /// </summary>
        Adjustment,
        /// <summary>
        /// TKCPN, toekenning coupon 
        /// </summary>
        AwardCoupon,
        /// <summary>
        /// OGIN, interne overboeking
        /// </summary>
        InternalTransfer,
        /// <summary>
        /// OGEX, externe overboeking
        /// </summary>
        ExternalTransfer,
        /// <summary>
        /// OGPBU, money transfer to a partnerbank
        /// </summary>
        CashTransferToPartnerBank,
        /// <summary>
        /// OGPBI, money transfer from a partnerbank
        /// </summary>
        CashTransferFromPartnerBank,
        /// <summary>
        /// OK, openingskoop
        /// </summary>
        OpeningBuy,
        /// <summary>
        /// OKF, openingskoop futures
        /// </summary>
        OpeningBuyFutures,
        /// <summary>
        /// OV, openingsverkoop
        /// </summary>
        OpeningSale,
        /// <summary>
        /// OVF, openingsale futures
        /// </summary>
        OpeningSaleFuture,
        /// <summary>
        /// REG, regulering
        /// </summary>
        Regulation,
        /// <summary>
        /// RTCR, creditrente
        /// </summary>
        CreditInterest,
        /// <summary>
        /// RTDB, debetrente
        /// </summary>
        DebitInterest,
        /// <summary>
        /// SK, sluitingskoop
        /// </summary>
        ClosingBuy,
        /// <summary>
        /// SKF, sluitingskoop future
        /// </summary>
        ClosingBuyFuture,
        /// <summary>
        /// SV, sluitingsverkoop
        /// </summary>
        ClosingSale,
        /// <summary>
        /// SVF, sluitingsverkoop future
        /// </summary>
        ClosingSaleFuture,
        /// <summary>
        /// TKCLM, toekenning claim
        /// </summary>
        AwardClaim,
        /// <summary>
        /// TKDVD, toekenning dividend
        /// </summary>
        AwardDividend,
        /// <summary>
        /// UKCPN, uitkering coupon
        /// </summary>
        CouponPayment,
        /// <summary>
        /// UKDVD, uitkering dividend
        /// </summary>
        DividendPayment,
        /// <summary>
        /// VRKV, Verrekening kosten/vergoeding
        /// </summary>
        SettlementCosts,
        /// <summary>
        /// V, verkoop
        /// </summary>
        Sell,
        /// <summary>
        /// K, buy
        /// </summary>
        Buy,
        /// <summary>
        /// OGLIQ
        /// </summary>
        LiquidationTransfer,
        /// <summary>
        /// EXOPD
        /// </summary>
        ExtensionOpenDeposit,
        /// <summary>
        /// EXOPL
        /// </summary>
        ExtensionOpenTransferOut,
        /// <summary>
        /// EXCLD
        /// </summary>
        ExtensionCloseDeposit,
        /// <summary>
        /// EXCLL
        /// </summary>
        ExtensionCloseTransferOut,
        /// <summary>
        /// STK
        /// </summary>
        SettlementBuy,
        /// <summary>
        /// STV
        /// </summary>
        SettlementSell,
        /// <summary>
        /// VDSL
        /// </summary>
        SecuritiesLendingDividendPayment,
        /// <summary>
        /// VCSL
        /// </summary>
        SecuritiesLendingCouponPayment,
        /// <summary>
        /// OGSL
        /// </summary>
        SecuritiesLendingInterestPayment,
        /// <summary>
        /// OGONL
        /// </summary>
        OnlineMoneyTransfer
    }
}