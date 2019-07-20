using RealPage.OneSite.All.Common.BusinessObjects;

namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects
{
	/// <summary>
	/// Interface for abc
	/// </summary>
	public interface IDashBoard : IBusinessObjectBase
{

	    /// <summary>
/// Represents the DistributedID
/// </summary>
int DistributedID { get; set; }

/// <summary>
/// Represents the PSiteID
/// </summary>
int PSiteID { get; set; }

/// <summary>
/// Represents the PropertyName
/// </summary>
string PropertyName { get; set; }

/// <summary>
/// Represents the BudgetYear
/// </summary>
int BudgetYear { get; set; }

/// <summary>
/// Represents the StartMonth
/// </summary>
string StartMonth { get; set; }

/// <summary>
/// Represents the BudgetModelID
/// </summary>
int BudgetModelID { get; set; }

/// <summary>
/// Represents the BudgetModelName
/// </summary>
string BudgetModelName { get; set; }

/// <summary>
/// Represents the BudgetType
/// </summary>
string BudgetType { get; set; }

/// <summary>
/// Represents the State
/// </summary>
string State { get; set; }

/// <summary>
/// Represents the StateDate
/// </summary>
string StateDate { get; set; }

/// <summary>
/// Represents the StateUser
/// </summary>
int StateUser { get; set; }

/// <summary>
/// Represents the StateBy
/// </summary>
string StateBy { get; set; }

/// <summary>
/// Represents the Status
/// </summary>
string Status { get; set; }

/// <summary>
/// Represents the StatusDate
/// </summary>
string StatusDate { get; set; }

/// <summary>
/// Represents the StatusBy
/// </summary>
string StatusBy { get; set; }

/// <summary>
/// Represents the IsFinal
/// </summary>
int IsFinal { get; set; }

/// <summary>
/// Represents the CurrentSequence
/// </summary>
int CurrentSequence { get; set; }

/// <summary>
/// Represents the HasProjection
/// </summary>
int HasProjection { get; set; }

/// <summary>
/// Represents the SuppressZeros
/// </summary>
int SuppressZeros { get; set; }

/// <summary>
/// Represents the NoOfPeriods
/// </summary>
int NoOfPeriods { get; set; }

/// <summary>
/// Represents the Source
/// </summary>
string Source { get; set; }

/// <summary>
/// Represents the LeaseRenewalMethod
/// </summary>
string LeaseRenewalMethod { get; set; }

/// <summary>
/// Represents the IncomeModel
/// </summary>
string IncomeModel { get; set; }

/// <summary>
/// Represents the ScheduleRentMethod
/// </summary>
string ScheduleRentMethod { get; set; }

/// <summary>
/// Represents the IncomeGLAccount
/// </summary>
int IncomeGLAccount { get; set; }

/// <summary>
/// Represents the LossToLeaseMethod
/// </summary>
string LossToLeaseMethod { get; set; }

/// <summary>
/// Represents the PayrollRunType
/// </summary>
string PayrollRunType { get; set; }

/// <summary>
/// Represents the PayrollStartDate
/// </summary>
string PayrollStartDate { get; set; }

/// <summary>
/// Represents the TaxHouseAllowance
/// </summary>
int TaxHouseAllowance { get; set; }

/// <summary>
/// Represents the AdditionalPayPeriods
/// </summary>
string AdditionalPayPeriods { get; set; }

/// <summary>
/// Represents the ModelAssetType
/// </summary>
string ModelAssetType { get; set; }

/// <summary>
/// Represents the AssetType
/// </summary>
string AssetType { get; set; }

/// <summary>
/// Represents the HasWorkflow
/// </summary>
int HasWorkflow { get; set; }

/// <summary>
/// Represents the ParentSiteID
/// </summary>
string ParentSiteID { get; set; }

/// <summary>
/// Represents the LocationID
/// </summary>
string LocationID { get; set; }

/// <summary>
/// Represents the SubPropnID
/// </summary>
string SubPropnID { get; set; }

/// <summary>
/// Represents the IsDefaultSite
/// </summary>
int IsDefaultSite { get; set; }

/// <summary>
/// Represents the OccupancyModel
/// </summary>
string OccupancyModel { get; set; }

/// <summary>
/// Represents the ContractMethod
/// </summary>
string ContractMethod { get; set; }

/// <summary>
/// Represents the CapitalExpenseMethod
/// </summary>
string CapitalExpenseMethod { get; set; }

/// <summary>
/// Represents the HasGLSegments
/// </summary>
int HasGLSegments { get; set; }

/// <summary>
/// Represents the MasterChartID
/// </summary>
int MasterChartID { get; set; }

/// <summary>
/// Represents the PropertyCode
/// </summary>
string PropertyCode { get; set; }

/// <summary>
/// Represents the KioskMethod
/// </summary>
string KioskMethod { get; set; }

/// <summary>
/// Represents the MarketRentPerSF
/// </summary>
string MarketRentPerSF { get; set; }

/// <summary>
/// Represents the TotalSF
/// </summary>
string TotalSF { get; set; }

/// <summary>
/// Represents the KioskRentPerSpace
/// </summary>
string KioskRentPerSpace { get; set; }

/// <summary>
/// Represents the NumberOfKiosks
/// </summary>
string NumberOfKiosks { get; set; }

/// <summary>
/// Represents the ParentBudgetModelID
/// </summary>
int ParentBudgetModelID { get; set; }

/// <summary>
/// Represents the IsDefaultModel
/// </summary>
int IsDefaultModel { get; set; }

/// <summary>
/// Represents the CopyCommentModelName
/// </summary>
int CopyCommentModelName { get; set; }

/// <summary>
/// Represents the CommentDistributedID
/// </summary>
string CommentDistributedID { get; set; }

/// <summary>
/// Represents the ManagementFeeGLAccount
/// </summary>
string ManagementFeeGLAccount { get; set; }

/// <summary>
/// Represents the IsParentDefault
/// </summary>
int IsParentDefault { get; set; }

/// <summary>
/// Represents the CapEffectiveMonth
/// </summary>
string CapEffectiveMonth { get; set; }



		/// <summary>
		/// Represents the Initialize
		/// </summary>
		void Initialize();
	}
}
