namespace Binck.OpenApi.Models.Models.Account.Transaction
{
    /// <summary>
    /// Sub category for the cost category
    /// </summary>
    public enum CostTypeSubCategory
    {
        /// 
        /// The enum is based on this database query :
        ///  select tc2_engels, original_value, kosten_nr from STG.STG_TYPE_KOSTEN k
        /// join STG.STG_ALL_TRANSLATION_VALUES_VW t on to_char (k.mul_ml_id) = t.original_code
        /// where original_table = 'STG_TYPE_KOSTEN'
        /// order by kosten_nr
        /// 
#pragma warning disable 1591
        Fixedcosts = 901,
        VariableStorage = 902,
        Feerebate = 903,
        AEBandASASCourtage = 904,
        OBOcosts = 905,
        Orderprocessingcosts = 906,
        Copystatementofaccount = 907,
        ExerciseCosts = 908,
        Aboutbooking = 909,
        NYcommissionFid = 910,
        FixedcostsUSA = 911,
        FTAFinsettlFUSFTI = 912,
        FTAFinsettlFTOFT5etc = 913,
        ClearFloorBrokerfee = 914,
        FTAClearingFees = 915,
        FTACourtageFTIL = 916,
        FTAFinsettlFFAFIAetc = 917,
        EOEBrokerageindexoptions2 = 919,
        EOEBrokeragepressindexoptions = 920,
        EOEBrokeragesharesopt2 = 921,
        EOEBrokeragebondoptions = 922,
        EOEBrokeragecurrencyoptions = 923,
        EOEBrokerageE100OPT2 = 924,
        EOEBrokerageE100opt3 = 925,
        ExercEOEoptpushAss = 926,
        ExercEOEoptAssobl = 927,
        ExercEOEAssOtheroptions = 928,
        ExercEOEoptdirectoryAss = 929,
        EOEFloorBrokerfee = 930,
        EOEClearingFees = 931,
        EOEespAEBclearingexass = 932,
        ExercEOEoptAssE100 = 933,
        EOEBrokerageE100opt4 = 934,
        Euronextexerciseassignment = 935,
        FTACourtage = 938,
        FTACourtageFTO = 939,
        AEBandASASCourtage2 = 940,         //  dubbel
        AEBClearingFees = 941,
        ASASClearingFees = 942,
        AEBASASandCommCTCI = 943,
        AEBASASandCommTSA = 944,
        BondCosts1 = 945,                  //  dubbel
        BondCosts2 = 946,                  //  dubbel
        BondCosts3 = 947,                  //  dubbel
        NYcommissionFid2 = 950,            //  dubbel
        NYClearingFees = 951,
        NYCommLiberty = 952,
        NYExerciseCosts = 953,
        USFixedCosts = 954,
        UScharges = 955,
        LondonFixedcosts = 956,
        FixedcostsZurich = 957,
        Londonstampduty = 958,
        StampdutyZurich = 959,
        FixedcostsFutChicago = 960,
        FixedcostsFutEurex = 961,
        Fixedkosten2USA = 962,
        Parisoverheads = 963,
        Brusselsfixedcosts = 964,
        FixedcostsCopenhagen = 965,
        FixedcostsStockholm = 966,
        FixedcostsOslo = 967,
        Euronextcharges = 970,
        futlight = 971,
        futindex = 972,
        Options = 973,
        Optionsgt065 = 974,
        Options000to005 = 975,
        Clearingexassow100 = 976,
        optlight000to005 = 977,
        optlightgt006 = 978,
        ClearingexassIndexow10 = 979,
        ClearingexassIndexow100 = 981,
        exasscurrencyoptionsNL = 982,
        currencyoptions = 983,
        Clearingexassstockoption = 984,
        FixedcostsUSExercised = 985,
        Currencyoptionslt005 = 986,
        Divdailystatement = 990,
        DivOverheads = 991,
        DivOrderbehoral = 992,
        MarketDataFees = 993,
        Divdailystatementexass = 995,
        DivexOverheadsass = 996,
        DivOrderbehoralexass = 997,
        Copystatementofaccount2 = 998,      //  dubbel
        ExerciseCosts2 = 999,               //  dubbel
        ProvisieGeldboekingen = 1020,       // nederlands
        VAT = 1030,
        Koersabonnementen = 1250,           // nederlands
        Vermogensbeheervergoeding = 1251,   // nederlands
        Bewaarloon = 1252,                  // nederlands
        Algemenedienstverlening = 1253,     // nederlands
        Productabonnementen = 1254,         // nederlands
        Retourprovisie = 1255,              // nederlands
        Aftedragenvergoeding = 1256,        // nederlands
        DienstverleningBTWvrij = 1257,      // nederlands
        AandelenItalie = 2249,              // nederlands
        FuturesItalie = 2250,               // nederlands
        OptiesItalie = 2251,                // nederlands
        ObligatiesEuroTLX = 2252,           // nederlands
        Capitalincometax = 2800,            // nederlands
        CapitalincometaxBNP = 2802,         // nederlands
        Capitalgaintax = 2803,
        Capitalincometax2 = 2804,            //  dubbel
        Capitalincometax3 = 2805,           //  dubbel
        Securitiesfee = 2810,
        Socialtax = 2820,                   // nederlands
        Socialtax2 = 2821,                  //  dubbel
        Beurstax = 2850,                    // nederlands
        RoerendeVoorheffing = 2851,         // nederlands
        ZegelrechtBelgium = 2852,           // nederlands
        RVtaxXrekalingehouden = 2855,       // nederlands
        RVtaxXNrekalingehouden = 2856,      // nederlands
        Speculatietaks = 2859,
        Fixed_income_capital_gain_tax = 2861
#pragma warning restore 1591
    }
}
