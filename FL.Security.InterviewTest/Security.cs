using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FL.Security.InterviewTest
{
    public class Factsheets
    {
        public DateTime? ProfessionalClassAccurateDate { get; set; }
        public string ProfessionalClass { get; set; }
        public DateTime? PrivateClassAccurateDate { get; set; }
        public string PrivateClass { get; set; }
        public DateTime? ProfessionalUnitAccurateDate { get; set; }
        public string ProfessionalUnit { get; set; }
        public DateTime? PrivateUnitAccurateDate { get; set; }
        public string PrivateUnit { get; set; }
        public string PostSale { get; set; }
        public DateTime? PostSaleAccurateDate { get; set; }
        public string LatestPrivate { get; set; }
        public DateTime? LatestPrivateAccurateDate { get; set; }
        public string LatestProfessional { get; set; }
        public DateTime? LatestProfessionalAccurateDate { get; set; }
    }

    public class Kiids
    {
        public string FundUnit { get; set; }
        public string FundUnitSource { get; set; }
        public DateTime FundUnitAccurateDate { get; set; }
    }

    public class PriipKids
    {
        public string FundUnit { get; set; }
        public string FundUnitSource { get; set; }
        public DateTime FundUnitAccurateDate { get; set; }
    }

    public class Prospectus
    {
        public DateTime SimplifiedProspectusAccurateDate { get; set; }
        public string SimplifiedProspectus { get; set; }
        public object FullProspectus { get; set; }
        public object FullProspectusAccurateDate { get; set; }
    }

    public class ReportsAndAccounts
    {
        public DateTime AnnualReportAccurateDate { get; set; }
        public string AnnualReport { get; set; }
        public DateTime InterimReportAccurateDate { get; set; }
        public string InterimReport { get; set; }
        public string LatestReport { get; set; }
        public DateTime LatestReportAccurateDate { get; set; }
    }

    public class Siids
    {
        public string Fund { get; set; }
    }

    public class Documents
    {
        public Factsheets Factsheets { get; set; }
        public List<object> AlternativeLanguageFactsheets { get; set; }
        public Kiids Kiids { get; set; }
        public List<object> AlternativeLanguageKiids { get; set; }
        public PriipKids PriipKids { get; set; }
        public List<object> AlternativeLanguagePriipKids { get; set; }
        public Prospectus Prospectus { get; set; }
        public List<object> AlternativeLanguageProspectus { get; set; }
        public ReportsAndAccounts ReportsAndAccounts { get; set; }
        public List<object> AlternativeLanguageReportsAndAccounts { get; set; }
        public string LatestPointOfSaleDocument { get; set; }
        public DateTime? LatestPointOfSaleAccurateDate { get; set; }
        public Siids Siids { get; set; }
        public List<object> AlternativeLanguageSiids { get; set; }
    }

    public class AssetTypes
    {
        public List<object> Lookthrough { get; set; }
        public List<object> Original { get; set; }
    }

    public class DerivativeExposure
    {
        public double LongNonDerivativeExposure { get; set; }
        public double LongDerivativeExposure { get; set; }
        public double ShortDerivativeExposure { get; set; }
        public double NetExposure { get; set; }
        public double GrossExposure { get; set; }
        public double CashAndOther { get; set; }
        public int LongNonDerivativePositions { get; set; }
        public int ShortDerivativePositions { get; set; }
        public int NetPositions { get; set; }
        public int GrossPositions { get; set; }
        public int PairedPositions { get; set; }
        public int PairedExposure { get; set; }
    }

    public class Duration
    {
        public double FundBondCoverage { get; set; }
        public double FundDurationForBonds { get; set; }
        public double FundModifiedDuration { get; set; }
    }

    public class Lookthrough
    {
        public int NumberHoldings { get; set; }
    }

    public class Original
    {
        public int NumberHoldings { get; set; }
    }

    public class Issuers
    {
        public int NumberIssuers { get; set; }
    }

    public class Holdings
    {
        public Lookthrough Lookthrough { get; set; }
        public Original Original { get; set; }
        public Issuers Issuers { get; set; }
    }

    public class Icb
    {
        public List<object> IndustryCode { get; set; }
        public List<object> SectorCode { get; set; }
        public List<object> SubsectorCode { get; set; }
        public List<object> SupersectorCode { get; set; }
    }

    public class Size
    {
        public double NavOfFund { get; set; }
        public string NavCurrency { get; set; }
        public string NavCurrencyCode { get; set; }
    }

    public class TopTen
    {
        public List<object> Issuers { get; set; }
        public List<object> Lookthrough { get; set; }
        public List<object> Original { get; set; }
    }

    public class PortfolioData
    {
        public AssetTypes AssetTypes { get; set; }
        public List<object> Countries { get; set; }
        public List<object> Currencies { get; set; }
        public List<object> DebtMaturity { get; set; }
        public List<object> DebtQuality { get; set; }
        public DerivativeExposure DerivativeExposure { get; set; }
        public Duration Duration { get; set; }
        public Holdings Holdings { get; set; }
        public List<object> PropertySectors { get; set; }
        public Icb Icb { get; set; }
        public List<object> IaSector { get; set; }
        public List<object> MarketCap { get; set; }
        public List<object> Regions { get; set; }
        public Size Size { get; set; }
        public List<object> AssetTypesExtensive { get; set; }
        public List<object> SubAssetTypesExtensive { get; set; }
        public TopTen TopTen { get; set; }
        public DateTime? AccurateDate { get; set; }
        public DateTime? PortfolioProcessedAccurateDate { get; set; }
        public object PrimaryAssetType { get; set; }
    }

    public class Charges
    {
        public double AmcPercentage { get; set; }
        public object AdditionalExpenses { get; set; }
        public string AnnualChargeType { get; set; }
        public double AnnualChargePercentage { get; set; }
        public DateTime AnnualChargeCalculationDate { get; set; }
        public object AnnualFundPercentage { get; set; }
        public string Exit { get; set; }
        public int Initial { get; set; }
        public string Performance { get; set; }
        public DateTime? TerEffectiveDate { get; set; }
        public bool? TerPerformanceIncluded { get; set; }
        public bool? TerEstimated { get; set; }
        public double? TerCalculated { get; set; }
        public DateTime OcfCalculationDate { get; set; }
        public bool? OcfEstimated { get; set; }
        public double OcfCalculated { get; set; }
        public object Administration { get; set; }
        public object EarlyApplicationBenefits { get; set; }
        public object ExistingInvestorBenefits { get; set; }
        public object InitialCommission { get; set; }
        public object CashRebateAvailable { get; set; }
        public object TrailCommission { get; set; }
    }

    public class EffectOfDeductions
    {
        public int? AssumedGrowthRateLow { get; set; }
        public double? EffectOfDeductionsForLowGrowthRate { get; set; }
        public int? AssumedGrowthRateHigh { get; set; }
        public double? EffectOfDeductionsForHighGrowthRate { get; set; }
        public bool HigherGrowthRateAvailable { get; set; }
    }

    public class Essentials
    {
        public string BenchmarkDescription { get; set; }
        public bool? ClassCleanValue { get; set; }
        public string IaSector { get; set; }
        public object AbiSector { get; set; }
        public string Objectives { get; set; }
        public object InvestmentPolicy { get; set; }
        public string FundDomicile { get; set; }
        public string FundType { get; set; }
        public bool? IsaQualifying { get; set; }
        public bool? SippQualifying { get; set; }
        public bool? CashIsaQualifying { get; set; }
        public string ValuationFrequency { get; set; }
        public string ValuationPoint { get; set; }
        public object CompanySector { get; set; }
        public object CompanyIndustry { get; set; }
        public object MarketExchange { get; set; }
        public string AicSector { get; set; }
        public bool? AicMember { get; set; }
        public string AicAssetType { get; set; }
        public int? PortfolioAssetTypePercentage { get; set; }
        public string CompanyIndex { get; set; }
        public object DealingDate { get; set; }
        public object ShareBuybackPolicy { get; set; }
        public object ShareBuybackPolicyDescription { get; set; }
        public object MinimumInvestment { get; set; }
        public object MaximumInvestment { get; set; }
        public object TopUpOffer { get; set; }
        public object AmountRaising { get; set; }
        public object SubscriptionLinkedToOtherVct { get; set; }
        public object OverAllotmentFacility { get; set; }
        public object OverAllotmentAmount { get; set; }
        public object ShareAllotmentFrequency { get; set; }
        public object SubscriptionOpen { get; set; }
        public object SubscriptionOpenDate { get; set; }
        public object SubscriptionCloseForTaxYear { get; set; }
        public object SubscriptionCloseDate { get; set; }
        public object FinalDateForReceiptOfApplications { get; set; }
        public object ApplicationsAcceptDate { get; set; }
        public object SubscriptionExtension { get; set; }
        public object SubscriptionExtensionCloseDate { get; set; }
        public string StockListingCurrency { get; set; }
        public string StockListingCurrencyCode { get; set; }
        public DateTime? AnnualReportingDate { get; set; }
        public DateTime? InterimReportingDate { get; set; }
        public object BenchmarkReplication { get; set; }
        public object ReplicationMethod { get; set; }
        public object LegalStructure { get; set; }
        public object RebalancingStructure { get; set; }
        public object CollateralStructure { get; set; }
        public object ExchangeProductType { get; set; }
        public object MaximumLendPercentage { get; set; }
        public object MaximumLendPercentageAccurateDate { get; set; }
        public object AverageLoanAmount { get; set; }
        public object AverageLoanAmountAccurateDate { get; set; }
        public object FundReturn { get; set; }
        public object LendingRevenueSplit { get; set; }
        public string ReportingStatus { get; set; }
    }

    public class Attributes
    {
        public bool MultiManager { get; set; }
        public bool IndexTracker { get; set; }
        public bool Property { get; set; }
        public bool Commodity { get; set; }
        public bool ProtectedAbsoluteReturn { get; set; }
        public bool Bric { get; set; }
        public bool Bond { get; set; }
        public object Leverage { get; set; }
        public bool? Cash { get; set; }
        public bool? SingleAssetClass { get; set; }
        public bool? HigherVolatility { get; set; }
        public object InternallyManaged { get; set; }
        public object WithProfits { get; set; }
        public string AssetType { get; set; }
        public string ManagementStyle { get; set; }
        public bool? GlobalBond { get; set; }
        public bool? CorporateBonds { get; set; }
        public bool? Equities { get; set; }
        public bool? Gilts { get; set; }
        public bool? GuaranteedFunds { get; set; }
        public bool? MixedAsset { get; set; }
        public bool? SpecialistOther { get; set; }
        public bool? LifeStyle { get; set; }
        public object VctType { get; set; }
        public bool? Hedged { get; set; }
        public object CurrentlyStockLending { get; set; }
        public object PermittedStockLending { get; set; }
        public bool IsPriip { get; set; }
    }

    public class EtfAttributes
    {
        public object ProductConstructionMethod { get; set; }
        public bool StockLendingAbility { get; set; }
        public object LegalStructure { get; set; }
        public object IndexRebalancingFrequency { get; set; }
        public object Leverage { get; set; }
    }

    public class LaunchDetails
    {
        public DateTime? ClassLaunchDate { get; set; }
        public DateTime FundLaunchDate { get; set; }
        public double FundLaunchPrice { get; set; }
        public string FundLaunchCurrency { get; set; }
        public string FundLaunchCurrencyCode { get; set; }
        public string UnitLaunchCurrency { get; set; }
        public string UnitLaunchCurrencyCode { get; set; }
        public DateTime? UnitLaunchDate { get; set; }
        public int? UnitLaunchPrice { get; set; }
        public string PriceCurrency { get; set; }
        public string PriceCurrencyCode { get; set; }
        public object EstimatedOrdinaryShareLaunchNav { get; set; }
        public object AmountRaised { get; set; }
        public object AmountRaisedAsAtDate { get; set; }
        public object MaximumNumberOfOrdinarySharesOffered { get; set; }
        public object MaximumNumberOfOrdinarySharesInIssue { get; set; }
    }

    public class Identification
    {
        public string InternalFundCode { get; set; }
        public string ClassName { get; set; }
        public string ClassType { get; set; }
        public object ClassMinimalName { get; set; }
        public string BaseCurrency { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string BloombergCode { get; set; }
        public string UnitType { get; set; }
        public string InternalCode { get; set; }
        public string IsinCode { get; set; }
        public string MexCode { get; set; }
        public object EpicCode { get; set; }
        public object ReutersCode { get; set; }
        public string SedolCode { get; set; }
        public string Citicode { get; set; }
        public string NameAbbreviated { get; set; }
        public string Name { get; set; }
        public string NamePreferred { get; set; }
        public object UnitName { get; set; }
        public object CompanyRegistrationNumber { get; set; }
        public object LocalMarketCode { get; set; }
        public object SectorName { get; set; }
        public string FullName { get; set; }
        public object ProductId { get; set; }
    }

    public class Management
    {
        public List<object> Team { get; set; }
        public string AdministratorId { get; set; }
        public string AuthorisedCorporateDirector { get; set; }
        public string CustodianId { get; set; }
        public string RegistrarId { get; set; }
        public string TrusteeDepositoryId { get; set; }
        public string ActivelyManaged { get; set; }
        public string InternalGroupCode { get; set; }
        public string AbbreviatedGroupName { get; set; }
        public string GroupDealingTelNumber { get; set; }
        public string GroupEnquiriesEmail { get; set; }
        public string GroupFaxNumber { get; set; }
        public string GroupAddress { get; set; }
        public string GroupHomepage { get; set; }
        public string GroupTelNumber { get; set; }
        public bool? GroupEtf { get; set; }
        public string GroupLongName { get; set; }
        public string GroupMenuName { get; set; }
        public string GroupShortName { get; set; }
        public object GroupType { get; set; }
        public string GroupLogo { get; set; }
        public int? FcaAcdReference { get; set; }
        public string ContractConfirmationContact { get; set; }
        public string PriceFileContact { get; set; }
        public object IssuingCompany { get; set; }
        public string FundCommentary { get; set; }
        public bool? IsFundCommentaryRequired { get; set; }
        public DateTime? FundCommentaryAccurateDate { get; set; }
        public object InvestmentPhilosophy { get; set; }
        public object FundDescription { get; set; }
        public object UnderlyingFundDescription { get; set; }
        public object InvestmentProcess { get; set; }
    }

    public class Regulatory
    {
        public object EusdEffectiveDate { get; set; }
        public string EusdStatus { get; set; }
        public bool FcaRecognised { get; set; }
        public string DerivativesAllowed { get; set; }
        public string RegulatoryStatus { get; set; }
    }

    public class Risks
    {
        public bool ChargesToCapital { get; set; }
        public bool ConcentratedPortfolio { get; set; }
        public bool DepositorySolvency { get; set; }
        public bool DerivativeExposure { get; set; }
        public bool DirectProperty { get; set; }
        public bool EmergingMarkets { get; set; }
        public bool EthicalRestrictions { get; set; }
        public bool ExchangeRate { get; set; }
        public bool GearedInvestments { get; set; }
        public bool HighYieldBonds { get; set; }
        public bool HighRisk { get; set; }
        public bool IncomeErodingGrowth { get; set; }
        public bool Inflation { get; set; }
        public bool LongTermInvestments { get; set; }
        public bool BondIssuerSolvency { get; set; }
        public bool Liquidity { get; set; }
        public bool NewFundCharges { get; set; }
        public bool Offshore { get; set; }
        public bool PerformanceCharges { get; set; }
        public bool ReturnsAreNotGuaranteed { get; set; }
        public bool SectorSpecific { get; set; }
        public bool SmallerCompanies { get; set; }
        public bool TaxationTaxRelief { get; set; }
        public bool UmbrellaLiabilities { get; set; }
        public bool ValueOfInvestments { get; set; }
    }

    public class Srri
    {
        public int ValidatedSrri { get; set; }
    }

    public class KiidExtraction
    {
        public object Kiids { get; set; }
        public Srri Srri { get; set; }
    }

    public class Dealing
    {
        public int SettlementBuyPeriod { get; set; }
        public int SettlementSellPeriod { get; set; }
        public int? ClassMinimumRegularSavings { get; set; }
        public bool? ClassRegularSavingsAvailable { get; set; }
        public bool? ClassWrappedRegularSavingsGroup { get; set; }
        public bool? ClassUnwrappedRegularSavingsGroup { get; set; }
        public bool? ClassWrappedRegularSavingsPlatform { get; set; }
        public bool? ClassUnwrappedRegularSavingsPlatform { get; set; }
        public int? ClassMinimumWithdrawal { get; set; }
        public int? ClassMinimumHolding { get; set; }
        public bool? MinimumWaived { get; set; }
        public bool? EmxDealing { get; set; }
        public bool? SwiftDealing { get; set; }
        public bool? FaxDealing { get; set; }
        public bool? PhoneDealing { get; set; }
        public string ApplicationFormRequired { get; set; }
        public int? LowAssumedGrowthRate { get; set; }
        public double? DeductionEffectLowGrowthRate { get; set; }
        public int? HighAssumedGrowthRate { get; set; }
        public double? DeductionEffectHighGrowthRate { get; set; }
        public bool? HasHigherGrowthRate { get; set; }
        public bool AdvanceRedemptionNotice { get; set; }
        public string UnitRedemptionOrder { get; set; }
        public string ValuationFrequency { get; set; }
        public object ValuationDay { get; set; }
        public string ValuationLocalTime { get; set; }
        public string ValuationCutOffTime { get; set; }
        public string ValuationTimeZone { get; set; }
    }

    public class StaticData
    {
        public Charges Charges { get; set; }
        public EffectOfDeductions EffectOfDeductions { get; set; }
        public Essentials Essentials { get; set; }
        public Attributes Attributes { get; set; }
        public EtfAttributes EtfAttributes { get; set; }
        public LaunchDetails LaunchDetails { get; set; }
        public Identification Identification { get; set; }
        public Management Management { get; set; }
        public Regulatory Regulatory { get; set; }
        public Risks Risks { get; set; }
        public KiidExtraction KiidExtraction { get; set; }
        public Dealing Dealing { get; set; }
        public object BondAttributes { get; set; }
    }

    public class NextIncomePaymentDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
    }

    public class IncomeDates
    {
        public List<object> Class { get; set; }
        public List<object> Fund { get; set; }
        public List<object> VctDates { get; set; }
        public DateTime? ClassFirstIncomePaymentDate { get; set; }
        public DateTime? FundFirstIncomePaymentDate { get; set; }
        public NextIncomePaymentDate NextIncomePaymentDate { get; set; }
    }

    public class IncomeDetails
    {
        public string ClassBasisXdivDateWkdHol { get; set; }
        public string ClassBasisXdivDateWkdHolExplanation { get; set; }
        public string ClassIncomeFrequency { get; set; }
        public string ClassIncomeTreatment { get; set; }
        public string FundBasisXdivDateWkdHol { get; set; }
        public object FundBasisXdivDateWkdHolExplanation { get; set; }
        public string FundIncomeFrequency { get; set; }
        public string FundIncomeTreatment { get; set; }
        public object Guarantee { get; set; }
        public object IncomeFrequency { get; set; }
        public string ClassPaymentBasis { get; set; }
    }

    public class Bond
    {
        public int DistributionYield { get; set; }
        public int UnderlyingYield { get; set; }
        public object YieldDate { get; set; }
        public object ChargesToCapital { get; set; }
        public object DistributionBasis { get; set; }
    }

    public class Equity
    {
        public double HistoricYield { get; set; }
        public object YieldDate { get; set; }
        public object ChargesToCapital { get; set; }
        public object CapitalChargesDistributionIncrease { get; set; }
        public object DividendYield { get; set; }
    }

    public class Yields
    {
        public Bond Bond { get; set; }
        public Equity Equity { get; set; }
        public double? RelevantYield { get; set; }
        public string Type { get; set; }
    }

    public class IncomeDistributions
    {
        public List<object> IncomeDistribution { get; set; }
    }

    public class IncomeData
    {
        public IncomeDates IncomeDates { get; set; }
        public IncomeDetails IncomeDetails { get; set; }
        public Yields Yields { get; set; }
        public IncomeDistributions IncomeDistributions { get; set; }
    }

    public class Security
    {
        public string Id { get; set; }
        public Documents Documents { get; set; }
        public PortfolioData PortfolioData { get; set; }
        public object PortfolioManagerData { get; set; }
        public object RatingsData { get; set; }
        public StaticData StaticData { get; set; }
        public IncomeData IncomeData { get; set; }
        public object PerformanceData { get; set; }
        public object Type { get; set; }
        public object MifidData { get; set; }
    }
}
