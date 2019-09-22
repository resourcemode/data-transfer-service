namespace DataTransferService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplicationForm")]
    public partial class ApplicationForm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public Guid CaseId { get; set; }

        public string BusinessInformation_BusinessName { get; set; }

        public int BusinessInformation_BusinessType { get; set; }

        public string BusinessInformation_OwnerOrPartnerOrDirectorName { get; set; }

        public int BusinessInformation_Sector { get; set; }

        public string BusinessInformation_BusinessNature { get; set; }

        public int BusinessInformation_Category { get; set; }

        public string BusinessInformation_CustomerProductsOrServicesDetails { get; set; }

        public string BusinessInformation_BusinessAddress { get; set; }

        public string BusinessInformation_PhoneNo { get; set; }

        public string BusinessInformation_OfficeOrFactoryAddress { get; set; }

        public string BusinessInformation_WarehouseAddress { get; set; }

        public string BusinessInformation_RegisteredAddress { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BusinessInformation_DateOfIncorporation { get; set; }

        public int? BusinessInformation_NumberOfEmployees { get; set; }

        public string BusinessInformation_TradeLicence { get; set; }

        public string BusinessInformation_ETin { get; set; }

        public string BusinessInformation_VatRegistrationNo { get; set; }

        [Column("_CreatedBy")]
        [Required]
        public string C_CreatedBy { get; set; }

        [Column("_UpdatedBy")]
        [Required]
        public string C_UpdatedBy { get; set; }

        [Column("_CreatedAt")]
        public DateTime C_CreatedAt { get; set; }

        [Column("_UpdatedAt")]
        public DateTime C_UpdatedAt { get; set; }

        public double? OwnerInformation_BusinessMonthlyIncome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OwnerInformation_DateOfBirth { get; set; }

        public string OwnerInformation_Email { get; set; }

        public string OwnerInformation_FamilyAssetOrProperty { get; set; }

        public string OwnerInformation_FathersName { get; set; }

        public string OwnerInformation_HighestEducationalDegree { get; set; }

        public int? OwnerInformation_MaritalStatus { get; set; }

        public string OwnerInformation_MobileNo { get; set; }

        public double? OwnerInformation_MonthlyExpenses { get; set; }

        public string OwnerInformation_MothersName { get; set; }

        public string OwnerInformation_Name { get; set; }

        public string OwnerInformation_Nid { get; set; }

        public int? OwnerInformation_NumberOfDependents { get; set; }

        public double? OwnerInformation_OtherMonthlyIncome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OwnerInformation_PassportExpiryDate { get; set; }

        public string OwnerInformation_PassportNumber { get; set; }

        public string OwnerInformation_PermanentAddress { get; set; }

        public string OwnerInformation_PersonalAssetOrProperty { get; set; }

        public string OwnerInformation_PersonalLiability { get; set; }

        public string OwnerInformation_PresentAddress { get; set; }

        public int? OwnerInformation_PresentAddressType { get; set; }

        public string OwnerInformation_SpouseName { get; set; }

        public string OwnerInformation_Tin { get; set; }

        public int? OwnerInformation_YearsOfExperienceAsBusinessPerson { get; set; }

        public int? OwnerInformation_YearsOfExperienceAsManagementStaff { get; set; }

        public int? OwnerInformation_YearsOfExperienceInCurrentLineOfBusiness { get; set; }

        public double? AccountPerformance_AdjustmentCdAcBranch { get; set; }

        public double? AccountPerformance_AdjustmentOdCchAcBranch { get; set; }

        public double? AccountPerformance_AdjustmentSndAc { get; set; }

        public double? AccountPerformance_AdjustmentTotal { get; set; }

        public string AccountPerformance_CdAcBranch { get; set; }

        public double? AccountPerformance_CrSumCdAcBranch { get; set; }

        public double? AccountPerformance_CrSumOdCchAcBranch { get; set; }

        public double? AccountPerformance_CrSumSndAc { get; set; }

        public double? AccountPerformance_CrSumTotal { get; set; }

        public double? AccountPerformance_DrSumCdAcBranch { get; set; }

        public double? AccountPerformance_DrSumOdCchAcBranch { get; set; }

        public double? AccountPerformance_DrSumSndAc { get; set; }

        public double? AccountPerformance_DrSumTotal { get; set; }

        public double? AccountPerformance_LimitCdAcBranch { get; set; }

        public double? AccountPerformance_LimitOdCchAcBranch { get; set; }

        public double? AccountPerformance_LimitSndAc { get; set; }

        public double? AccountPerformance_LimitTotal { get; set; }

        public string AccountPerformance_OdCchAcBranch { get; set; }

        public double? AccountPerformance_PeriodCdAcBranch { get; set; }

        public double? AccountPerformance_PeriodOdCchAcBranch { get; set; }

        public double? AccountPerformance_PeriodSndAc { get; set; }

        public double? AccountPerformance_PeriodTotal { get; set; }

        public double? AccountPerformance_RecycleCdAcBranch { get; set; }

        public double? AccountPerformance_RecycleOdCchAcBranch { get; set; }

        public double? AccountPerformance_RecycleSndAc { get; set; }

        public double? AccountPerformance_RecycleTotal { get; set; }

        public double? FinancialInformation_CurrentAssetCurrentYear { get; set; }

        public double? FinancialInformation_CurrentAssetLastYear { get; set; }

        public double? FinancialInformation_CurrentAssetPreviousYear { get; set; }

        public double? FinancialInformation_CurrentLiabilitiesCurrentYear { get; set; }

        public double? FinancialInformation_CurrentLiabilitiesLastYear { get; set; }

        public double? FinancialInformation_CurrentLiabilitiesPreviousYear { get; set; }

        public int? FinancialInformation_CurrentYear { get; set; }

        public double? FinancialInformation_FixedAssetCurrentYear { get; set; }

        public double? FinancialInformation_FixedAssetLastYear { get; set; }

        public double? FinancialInformation_FixedAssetPreviousYear { get; set; }

        public double? FinancialInformation_GrossProfitCurrentYear { get; set; }

        public double? FinancialInformation_GrossProfitLastYear { get; set; }

        public double? FinancialInformation_GrossProfitMarginCurrentYear { get; set; }

        public double? FinancialInformation_GrossProfitMarginLastYear { get; set; }

        public double? FinancialInformation_GrossProfitMarginPreviousYear { get; set; }

        public double? FinancialInformation_GrossProfitPreviousYear { get; set; }

        public int? FinancialInformation_LastYear { get; set; }

        public double? FinancialInformation_NetProfitCurrentYear { get; set; }

        public double? FinancialInformation_NetProfitLastYear { get; set; }

        public double? FinancialInformation_NetProfitMarginCurrentYear { get; set; }

        public double? FinancialInformation_NetProfitMarginLastYear { get; set; }

        public double? FinancialInformation_NetProfitMarginPreviousYear { get; set; }

        public double? FinancialInformation_NetProfitPreviousYear { get; set; }

        public double? FinancialInformation_NetWorthCurrentYear { get; set; }

        public double? FinancialInformation_NetWorthLastYear { get; set; }

        public double? FinancialInformation_NetWorthPreviousYear { get; set; }

        public double? FinancialInformation_NonCurrentLiabilitiesCurrentYear { get; set; }

        public double? FinancialInformation_NonCurrentLiabilitiesLastYear { get; set; }

        public double? FinancialInformation_NonCurrentLiabilitiesPreviousYear { get; set; }

        public int? FinancialInformation_PreviousYear { get; set; }

        public double? FinancialInformation_TotalAssetCurrentYear { get; set; }

        public double? FinancialInformation_TotalAssetLastYear { get; set; }

        public double? FinancialInformation_TotalAssetPreviousYear { get; set; }

        public double? FinancialInformation_TotalLiabilitiesCurrentYear { get; set; }

        public double? FinancialInformation_TotalLiabilitiesLastYear { get; set; }

        public double? FinancialInformation_TotalLiabilitiesPreviousYear { get; set; }

        public double? FinancialInformation_TotalSalesCurrentYear { get; set; }

        public double? FinancialInformation_TotalSalesLastYear { get; set; }

        public double? FinancialInformation_TotalSalesPreviousYear { get; set; }

        public double? ProfitAndLossInformation_AdministrativeExpensesCurrentYear { get; set; }

        public double? ProfitAndLossInformation_AdministrativeExpensesLastYear { get; set; }

        public double? ProfitAndLossInformation_AdministrativeExpensesPreviousYear { get; set; }

        public double? ProfitAndLossInformation_CostOfGoodsSoldCurrentYear { get; set; }

        public double? ProfitAndLossInformation_CostOfGoodsSoldLastYear { get; set; }

        public double? ProfitAndLossInformation_CostOfGoodsSoldPreviousYear { get; set; }

        public int? ProfitAndLossInformation_CurrentYear { get; set; }

        public double? ProfitAndLossInformation_FinancialExpensesCurrentYear { get; set; }

        public double? ProfitAndLossInformation_FinancialExpensesLastYear { get; set; }

        public double? ProfitAndLossInformation_FinancialExpensesPreviousYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProfitAndLossInformation_FromDate { get; set; }

        public int? ProfitAndLossInformation_LastYear { get; set; }

        public double? ProfitAndLossInformation_NetOperatingProfitCurrentYear { get; set; }

        public double? ProfitAndLossInformation_NetOperatingProfitLastYear { get; set; }

        public double? ProfitAndLossInformation_NetOperatingProfitPreviousYear { get; set; }

        public double? ProfitAndLossInformation_NetProfitCurrentYear { get; set; }

        public double? ProfitAndLossInformation_NetProfitLastYear { get; set; }

        public double? ProfitAndLossInformation_NetProfitPreviousYear { get; set; }

        public double? ProfitAndLossInformation_OperatingProfitCurrentYear { get; set; }

        public double? ProfitAndLossInformation_OperatingProfitLastYear { get; set; }

        public double? ProfitAndLossInformation_OperatingProfitPreviousYear { get; set; }

        public int? ProfitAndLossInformation_PreviousYear { get; set; }

        public double? ProfitAndLossInformation_RentCurrentYear { get; set; }

        public double? ProfitAndLossInformation_RentLastYear { get; set; }

        public double? ProfitAndLossInformation_RentPreviousYear { get; set; }

        public double? ProfitAndLossInformation_RetainedEarningsCurrentYear { get; set; }

        public double? ProfitAndLossInformation_RetainedEarningsLastYear { get; set; }

        public double? ProfitAndLossInformation_RetainedEarningsPreviousYear { get; set; }

        public double? ProfitAndLossInformation_SalaryCurrentYear { get; set; }

        public double? ProfitAndLossInformation_SalaryLastYear { get; set; }

        public double? ProfitAndLossInformation_SalaryPreviousYear { get; set; }

        public double? ProfitAndLossInformation_SalesCurrentYear { get; set; }

        public double? ProfitAndLossInformation_SalesLastYear { get; set; }

        public double? ProfitAndLossInformation_SalesPreviousYear { get; set; }

        public double? ProfitAndLossInformation_TaxesCurrentYear { get; set; }

        public double? ProfitAndLossInformation_TaxesLastYear { get; set; }

        public double? ProfitAndLossInformation_TaxesPreviousYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProfitAndLossInformation_ToDate { get; set; }

        public double? ProfitAndLossInformation_TotalExpensesCurrentYear { get; set; }

        public double? ProfitAndLossInformation_TotalExpensesLastYear { get; set; }

        public double? ProfitAndLossInformation_TotalExpensesPreviousYear { get; set; }

        public double? ProfitAndLossInformation_UtilityBillCurrentYear { get; set; }

        public double? ProfitAndLossInformation_UtilityBillLastYear { get; set; }

        public double? ProfitAndLossInformation_UtilityBillPreviousYear { get; set; }

        public double? ProfitAndLossInformation_WithdrawalAndDividendsCurrentYear { get; set; }

        public double? ProfitAndLossInformation_WithdrawalAndDividendsLastYear { get; set; }

        public double? ProfitAndLossInformation_WithdrawalAndDividendsPreviousYear { get; set; }

        public double? BalanceSheet_AccountPayablesAmount { get; set; }

        public double? BalanceSheet_AccountsReceivablesAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BalanceSheet_AsOfDate { get; set; }

        public double? BalanceSheet_BankBalanceAmount { get; set; }

        public double? BalanceSheet_CashInHandAmount { get; set; }

        public double? BalanceSheet_DebtAmount { get; set; }

        public double BalanceSheet_DebtToEquityRatio { get; set; }

        public double? BalanceSheet_EquityAmount { get; set; }

        public double? BalanceSheet_InventoryAmount { get; set; }

        public double? BalanceSheet_LongTermLiabilityAmount { get; set; }

        public double? BalanceSheet_OtherCurrentLiabilitiesAmount { get; set; }

        public double? BalanceSheet_OthersAmount { get; set; }

        public double? BalanceSheet_OwnerEquityAndNetWorthAmount { get; set; }

        public double? BalanceSheet_RetainedEarningsAmount { get; set; }

        public double? BalanceSheet_ShortTermLoanAmount { get; set; }

        public double? BalanceSheet_TotalAssetAmount { get; set; }

        public double? BalanceSheet_TotalCurrentAssetAmount { get; set; }

        public double? BalanceSheet_TotalCurrentLiabilitiesAmount { get; set; }

        public double? BalanceSheet_TotalFixedAssetAmount { get; set; }

        public double? BalanceSheet_TotalLiabilitiesAndNetWorthAmount { get; set; }

        public double? BalanceSheet_TotalLiabilityAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CibReport_ReportDate { get; set; }

        public string Guarantor_BusinessOrEmployerName { get; set; }

        public string Guarantor_BusinessOrWorkAddress { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Guarantor_DateOfBirth { get; set; }

        public string Guarantor_FatherName { get; set; }

        public string Guarantor_HighestEducationalDegree { get; set; }

        public bool Guarantor_IsPreviouslyGuarantorOfAnyLoan { get; set; }

        public string Guarantor_LoanAccountNo { get; set; }

        public string Guarantor_MobileNo { get; set; }

        public string Guarantor_MotherName { get; set; }

        public string Guarantor_Name { get; set; }

        public string Guarantor_Nid { get; set; }

        public string Guarantor_PermanentAddress { get; set; }

        public string Guarantor_PersonalTin { get; set; }

        public string Guarantor_PresentAddress { get; set; }

        public string Guarantor_Profession { get; set; }

        public string Guarantor_RelationshipWithApplicant { get; set; }

        public string Guarantor_ResidencePhoneNo { get; set; }

        public string Guarantor_ResidenceStatus { get; set; }

        public string Guarantor_SpouseName { get; set; }

        public double? Guarantor_TotalMonthlyExpenditure { get; set; }

        public double? Guarantor_TotalMonthlyIncome { get; set; }

        public double? Guarantor_TotalMonthlySurplus { get; set; }

        public string Guarantor_UcbAccountNo { get; set; }

        public string Guarantor_Declaration_BankVeriferName { get; set; }

        public string Guarantor_Declaration_CompanyName { get; set; }

        public string Guarantor_Declaration_GuarantorFullName { get; set; }

        public string Guarantor_Declaration_GuarantorName { get; set; }

        public string Guarantor_Declaration_RelationshipWithApplicant { get; set; }

        public double? Guarantor_NetWorth_BankBalanceAmount { get; set; }

        public double? Guarantor_NetWorth_BankLoanAmount { get; set; }

        public double? Guarantor_NetWorth_BuildingAmount { get; set; }

        public double? Guarantor_NetWorth_BusinessLiabilityAmount { get; set; }

        public double? Guarantor_NetWorth_CashInHandAmount { get; set; }

        public double? Guarantor_NetWorth_FurnitureAndOrnamentAmount { get; set; }

        public double? Guarantor_NetWorth_LandAmount { get; set; }

        public double? Guarantor_NetWorth_PersonalLiabilityAmount { get; set; }

        public double? Guarantor_NetWorth_TotalAssetsAmount { get; set; }

        public double? Guarantor_NetWorth_TotalLiabilitiesAmount { get; set; }

        public double? Guarantor_NetWorth_VehiclesAmount { get; set; }

        public bool IsSigned { get; set; }
    }
}
