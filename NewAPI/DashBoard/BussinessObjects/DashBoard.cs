using System;
using System.Collections.Generic;
using RealPage.OneSite.All.Common.BusinessObjects;
using RealPage.OneSite.All.Common.BusinessObjects.Attributes;

namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects
{
	/// <summary>
	/// Used to Manage DashBoard
	/// <summary>
	public class DashBoard : BusinessObjectBase, IDashBoard
	{
		#region Private variables
		private PropertyAttributes _distributedID;
private PropertyAttributes _pSiteID;
private PropertyAttributes _propertyName;
private PropertyAttributes _budgetYear;
private PropertyAttributes _startMonth;
private PropertyAttributes _budgetModelID;
private PropertyAttributes _budgetModelName;
private PropertyAttributes _budgetType;
private PropertyAttributes _state;
private PropertyAttributes _stateDate;
private PropertyAttributes _stateUser;
private PropertyAttributes _stateBy;
private PropertyAttributes _status;
private PropertyAttributes _statusDate;
private PropertyAttributes _statusBy;
private PropertyAttributes _isFinal;
private PropertyAttributes _currentSequence;
private PropertyAttributes _hasProjection;
private PropertyAttributes _suppressZeros;
private PropertyAttributes _noOfPeriods;
private PropertyAttributes _source;
private PropertyAttributes _leaseRenewalMethod;
private PropertyAttributes _incomeModel;
private PropertyAttributes _scheduleRentMethod;
private PropertyAttributes _incomeGLAccount;
private PropertyAttributes _lossToLeaseMethod;
private PropertyAttributes _payrollRunType;
private PropertyAttributes _payrollStartDate;
private PropertyAttributes _taxHouseAllowance;
private PropertyAttributes _additionalPayPeriods;
private PropertyAttributes _modelAssetType;
private PropertyAttributes _assetType;
private PropertyAttributes _hasWorkflow;
private PropertyAttributes _parentSiteID;
private PropertyAttributes _locationID;
private PropertyAttributes _subPropnID;
private PropertyAttributes _isDefaultSite;
private PropertyAttributes _occupancyModel;
private PropertyAttributes _contractMethod;
private PropertyAttributes _capitalExpenseMethod;
private PropertyAttributes _hasGLSegments;
private PropertyAttributes _masterChartID;
private PropertyAttributes _propertyCode;
private PropertyAttributes _kioskMethod;
private PropertyAttributes _marketRentPerSF;
private PropertyAttributes _totalSF;
private PropertyAttributes _kioskRentPerSpace;
private PropertyAttributes _numberOfKiosks;
private PropertyAttributes _parentBudgetModelID;
private PropertyAttributes _isDefaultModel;
private PropertyAttributes _copyCommentModelName;
private PropertyAttributes _commentDistributedID;
private PropertyAttributes _managementFeeGLAccount;
private PropertyAttributes _isParentDefault;
private PropertyAttributes _capEffectiveMonth;

		#endregion

		#region Constructors
		/// <summary>
		/// Create a basic instance of the DashBoard class
		/// <summary>
		public DashBoard()
		{
		}
		/// <summary>
		/// Create a basic instance of the DashBoard class
		/// <summary>
		/// <param name="env">A reference to an initialized Environment class</param>
		public DashBoard(IEnvironment env) : base(env)
		{
		}
		/// <summary>
		/// Create a basic instance of the DashBoard class
		/// <summary>
		/// <param name="bob">A reference to an initialized Business Object</param>
		public DashBoard(BusinessObjectBase bob) : base(bob)
		{
		}
		#endregion

		/// <summary>
		/// Use this to shove any PropertyAttributes based properties into the properties collection
		/// <summary>
		public override void Initialize()
		{
			base.Initialize();
			_distributedID = GetPropertyAttributes("DistributedID") 
_pSiteID = GetPropertyAttributes("PSiteID") 
_propertyName = GetPropertyAttributes("PropertyName") 
_budgetYear = GetPropertyAttributes("BudgetYear") 
_startMonth = GetPropertyAttributes("StartMonth") 
_budgetModelID = GetPropertyAttributes("BudgetModelID") 
_budgetModelName = GetPropertyAttributes("BudgetModelName") 
_budgetType = GetPropertyAttributes("BudgetType") 
_state = GetPropertyAttributes("State") 
_stateDate = GetPropertyAttributes("StateDate") 
_stateUser = GetPropertyAttributes("StateUser") 
_stateBy = GetPropertyAttributes("StateBy") 
_status = GetPropertyAttributes("Status") 
_statusDate = GetPropertyAttributes("StatusDate") 
_statusBy = GetPropertyAttributes("StatusBy") 
_isFinal = GetPropertyAttributes("IsFinal") 
_currentSequence = GetPropertyAttributes("CurrentSequence") 
_hasProjection = GetPropertyAttributes("HasProjection") 
_suppressZeros = GetPropertyAttributes("SuppressZeros") 
_noOfPeriods = GetPropertyAttributes("NoOfPeriods") 
_source = GetPropertyAttributes("Source") 
_leaseRenewalMethod = GetPropertyAttributes("LeaseRenewalMethod") 
_incomeModel = GetPropertyAttributes("IncomeModel") 
_scheduleRentMethod = GetPropertyAttributes("ScheduleRentMethod") 
_incomeGLAccount = GetPropertyAttributes("IncomeGLAccount") 
_lossToLeaseMethod = GetPropertyAttributes("LossToLeaseMethod") 
_payrollRunType = GetPropertyAttributes("PayrollRunType") 
_payrollStartDate = GetPropertyAttributes("PayrollStartDate") 
_taxHouseAllowance = GetPropertyAttributes("TaxHouseAllowance") 
_additionalPayPeriods = GetPropertyAttributes("AdditionalPayPeriods") 
_modelAssetType = GetPropertyAttributes("ModelAssetType") 
_assetType = GetPropertyAttributes("AssetType") 
_hasWorkflow = GetPropertyAttributes("HasWorkflow") 
_parentSiteID = GetPropertyAttributes("ParentSiteID") 
_locationID = GetPropertyAttributes("LocationID") 
_subPropnID = GetPropertyAttributes("SubPropnID") 
_isDefaultSite = GetPropertyAttributes("IsDefaultSite") 
_occupancyModel = GetPropertyAttributes("OccupancyModel") 
_contractMethod = GetPropertyAttributes("ContractMethod") 
_capitalExpenseMethod = GetPropertyAttributes("CapitalExpenseMethod") 
_hasGLSegments = GetPropertyAttributes("HasGLSegments") 
_masterChartID = GetPropertyAttributes("MasterChartID") 
_propertyCode = GetPropertyAttributes("PropertyCode") 
_kioskMethod = GetPropertyAttributes("KioskMethod") 
_marketRentPerSF = GetPropertyAttributes("MarketRentPerSF") 
_totalSF = GetPropertyAttributes("TotalSF") 
_kioskRentPerSpace = GetPropertyAttributes("KioskRentPerSpace") 
_numberOfKiosks = GetPropertyAttributes("NumberOfKiosks") 
_parentBudgetModelID = GetPropertyAttributes("ParentBudgetModelID") 
_isDefaultModel = GetPropertyAttributes("IsDefaultModel") 
_copyCommentModelName = GetPropertyAttributes("CopyCommentModelName") 
_commentDistributedID = GetPropertyAttributes("CommentDistributedID") 
_managementFeeGLAccount = GetPropertyAttributes("ManagementFeeGLAccount") 
_isParentDefault = GetPropertyAttributes("IsParentDefault") 
_capEffectiveMonth = GetPropertyAttributes("CapEffectiveMonth") 

		}

		#region Serializable properties
         /// <summary>
/// Represents the DistributedID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int DistributedID 
{ 
get { return (int)_distributedID.Value; } 
set { _distributedID.Value = value; } 
}

/// <summary>
/// Represents the PSiteID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int PSiteID 
{ 
get { return (int)_pSiteID.Value; } 
set { _pSiteID.Value = value; } 
}

/// <summary>
/// Represents the PropertyName 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string PropertyName 
{ 
get { return (string)_propertyName.Value; } 
set { _propertyName.Value = value; } 
}

/// <summary>
/// Represents the BudgetYear 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int BudgetYear 
{ 
get { return (int)_budgetYear.Value; } 
set { _budgetYear.Value = value; } 
}

/// <summary>
/// Represents the StartMonth 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string StartMonth 
{ 
get { return (string)_startMonth.Value; } 
set { _startMonth.Value = value; } 
}

/// <summary>
/// Represents the BudgetModelID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int BudgetModelID 
{ 
get { return (int)_budgetModelID.Value; } 
set { _budgetModelID.Value = value; } 
}

/// <summary>
/// Represents the BudgetModelName 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string BudgetModelName 
{ 
get { return (string)_budgetModelName.Value; } 
set { _budgetModelName.Value = value; } 
}

/// <summary>
/// Represents the BudgetType 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string BudgetType 
{ 
get { return (string)_budgetType.Value; } 
set { _budgetType.Value = value; } 
}

/// <summary>
/// Represents the State 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string State 
{ 
get { return (string)_state.Value; } 
set { _state.Value = value; } 
}

/// <summary>
/// Represents the StateDate 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string StateDate 
{ 
get { return (string)_stateDate.Value; } 
set { _stateDate.Value = value; } 
}

/// <summary>
/// Represents the StateUser 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int StateUser 
{ 
get { return (int)_stateUser.Value; } 
set { _stateUser.Value = value; } 
}

/// <summary>
/// Represents the StateBy 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string StateBy 
{ 
get { return (string)_stateBy.Value; } 
set { _stateBy.Value = value; } 
}

/// <summary>
/// Represents the Status 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string Status 
{ 
get { return (string)_status.Value; } 
set { _status.Value = value; } 
}

/// <summary>
/// Represents the StatusDate 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string StatusDate 
{ 
get { return (string)_statusDate.Value; } 
set { _statusDate.Value = value; } 
}

/// <summary>
/// Represents the StatusBy 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string StatusBy 
{ 
get { return (string)_statusBy.Value; } 
set { _statusBy.Value = value; } 
}

/// <summary>
/// Represents the IsFinal 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int IsFinal 
{ 
get { return (int)_isFinal.Value; } 
set { _isFinal.Value = value; } 
}

/// <summary>
/// Represents the CurrentSequence 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int CurrentSequence 
{ 
get { return (int)_currentSequence.Value; } 
set { _currentSequence.Value = value; } 
}

/// <summary>
/// Represents the HasProjection 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int HasProjection 
{ 
get { return (int)_hasProjection.Value; } 
set { _hasProjection.Value = value; } 
}

/// <summary>
/// Represents the SuppressZeros 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int SuppressZeros 
{ 
get { return (int)_suppressZeros.Value; } 
set { _suppressZeros.Value = value; } 
}

/// <summary>
/// Represents the NoOfPeriods 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int NoOfPeriods 
{ 
get { return (int)_noOfPeriods.Value; } 
set { _noOfPeriods.Value = value; } 
}

/// <summary>
/// Represents the Source 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string Source 
{ 
get { return (string)_source.Value; } 
set { _source.Value = value; } 
}

/// <summary>
/// Represents the LeaseRenewalMethod 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string LeaseRenewalMethod 
{ 
get { return (string)_leaseRenewalMethod.Value; } 
set { _leaseRenewalMethod.Value = value; } 
}

/// <summary>
/// Represents the IncomeModel 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string IncomeModel 
{ 
get { return (string)_incomeModel.Value; } 
set { _incomeModel.Value = value; } 
}

/// <summary>
/// Represents the ScheduleRentMethod 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string ScheduleRentMethod 
{ 
get { return (string)_scheduleRentMethod.Value; } 
set { _scheduleRentMethod.Value = value; } 
}

/// <summary>
/// Represents the IncomeGLAccount 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int IncomeGLAccount 
{ 
get { return (int)_incomeGLAccount.Value; } 
set { _incomeGLAccount.Value = value; } 
}

/// <summary>
/// Represents the LossToLeaseMethod 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string LossToLeaseMethod 
{ 
get { return (string)_lossToLeaseMethod.Value; } 
set { _lossToLeaseMethod.Value = value; } 
}

/// <summary>
/// Represents the PayrollRunType 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string PayrollRunType 
{ 
get { return (string)_payrollRunType.Value; } 
set { _payrollRunType.Value = value; } 
}

/// <summary>
/// Represents the PayrollStartDate 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string PayrollStartDate 
{ 
get { return (string)_payrollStartDate.Value; } 
set { _payrollStartDate.Value = value; } 
}

/// <summary>
/// Represents the TaxHouseAllowance 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int TaxHouseAllowance 
{ 
get { return (int)_taxHouseAllowance.Value; } 
set { _taxHouseAllowance.Value = value; } 
}

/// <summary>
/// Represents the AdditionalPayPeriods 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string AdditionalPayPeriods 
{ 
get { return (string)_additionalPayPeriods.Value; } 
set { _additionalPayPeriods.Value = value; } 
}

/// <summary>
/// Represents the ModelAssetType 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string ModelAssetType 
{ 
get { return (string)_modelAssetType.Value; } 
set { _modelAssetType.Value = value; } 
}

/// <summary>
/// Represents the AssetType 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string AssetType 
{ 
get { return (string)_assetType.Value; } 
set { _assetType.Value = value; } 
}

/// <summary>
/// Represents the HasWorkflow 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int HasWorkflow 
{ 
get { return (int)_hasWorkflow.Value; } 
set { _hasWorkflow.Value = value; } 
}

/// <summary>
/// Represents the ParentSiteID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string ParentSiteID 
{ 
get { return (string)_parentSiteID.Value; } 
set { _parentSiteID.Value = value; } 
}

/// <summary>
/// Represents the LocationID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string LocationID 
{ 
get { return (string)_locationID.Value; } 
set { _locationID.Value = value; } 
}

/// <summary>
/// Represents the SubPropnID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string SubPropnID 
{ 
get { return (string)_subPropnID.Value; } 
set { _subPropnID.Value = value; } 
}

/// <summary>
/// Represents the IsDefaultSite 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int IsDefaultSite 
{ 
get { return (int)_isDefaultSite.Value; } 
set { _isDefaultSite.Value = value; } 
}

/// <summary>
/// Represents the OccupancyModel 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string OccupancyModel 
{ 
get { return (string)_occupancyModel.Value; } 
set { _occupancyModel.Value = value; } 
}

/// <summary>
/// Represents the ContractMethod 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string ContractMethod 
{ 
get { return (string)_contractMethod.Value; } 
set { _contractMethod.Value = value; } 
}

/// <summary>
/// Represents the CapitalExpenseMethod 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string CapitalExpenseMethod 
{ 
get { return (string)_capitalExpenseMethod.Value; } 
set { _capitalExpenseMethod.Value = value; } 
}

/// <summary>
/// Represents the HasGLSegments 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int HasGLSegments 
{ 
get { return (int)_hasGLSegments.Value; } 
set { _hasGLSegments.Value = value; } 
}

/// <summary>
/// Represents the MasterChartID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int MasterChartID 
{ 
get { return (int)_masterChartID.Value; } 
set { _masterChartID.Value = value; } 
}

/// <summary>
/// Represents the PropertyCode 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string PropertyCode 
{ 
get { return (string)_propertyCode.Value; } 
set { _propertyCode.Value = value; } 
}

/// <summary>
/// Represents the KioskMethod 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string KioskMethod 
{ 
get { return (string)_kioskMethod.Value; } 
set { _kioskMethod.Value = value; } 
}

/// <summary>
/// Represents the MarketRentPerSF 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string MarketRentPerSF 
{ 
get { return (string)_marketRentPerSF.Value; } 
set { _marketRentPerSF.Value = value; } 
}

/// <summary>
/// Represents the TotalSF 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string TotalSF 
{ 
get { return (string)_totalSF.Value; } 
set { _totalSF.Value = value; } 
}

/// <summary>
/// Represents the KioskRentPerSpace 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string KioskRentPerSpace 
{ 
get { return (string)_kioskRentPerSpace.Value; } 
set { _kioskRentPerSpace.Value = value; } 
}

/// <summary>
/// Represents the NumberOfKiosks 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string NumberOfKiosks 
{ 
get { return (string)_numberOfKiosks.Value; } 
set { _numberOfKiosks.Value = value; } 
}

/// <summary>
/// Represents the ParentBudgetModelID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int ParentBudgetModelID 
{ 
get { return (int)_parentBudgetModelID.Value; } 
set { _parentBudgetModelID.Value = value; } 
}

/// <summary>
/// Represents the IsDefaultModel 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int IsDefaultModel 
{ 
get { return (int)_isDefaultModel.Value; } 
set { _isDefaultModel.Value = value; } 
}

/// <summary>
/// Represents the CopyCommentModelName 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int CopyCommentModelName 
{ 
get { return (int)_copyCommentModelName.Value; } 
set { _copyCommentModelName.Value = value; } 
}

/// <summary>
/// Represents the CommentDistributedID 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string CommentDistributedID 
{ 
get { return (string)_commentDistributedID.Value; } 
set { _commentDistributedID.Value = value; } 
}

/// <summary>
/// Represents the ManagementFeeGLAccount 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string ManagementFeeGLAccount 
{ 
get { return (string)_managementFeeGLAccount.Value; } 
set { _managementFeeGLAccount.Value = value; } 
}

/// <summary>
/// Represents the IsParentDefault 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public int IsParentDefault 
{ 
get { return (int)_isParentDefault.Value; } 
set { _isParentDefault.Value = value; } 
}

/// <summary>
/// Represents the CapEffectiveMonth 
/// </summary> 
[XmlAttributeBehavior 
(PropertyAttributes.PropertyType.Serializable 
, PropertyAttributes.ValueBehavior.SimpleGetterSetter 
)] 
public string CapEffectiveMonth 
{ 
get { return (string)_capEffectiveMonth.Value; } 
set { _capEffectiveMonth.Value = value; } 
}

		
		#endregion

		#region Examples
		/// <summary>
		/// Used to get an example of the DashBoard object with test data
		/// </summary>
		/// <returns>List of DashBoard Model with test data</returns>
		public static List<IDashBoard> GetDashBoardExample()
		{
			List<IDashBoard> list = new List<IDashBoard>();
			IDashBoard DashBoard = new DashBoard()
			{"DistributedID":69,"PSiteID":1192563,"PropertyName":"Meadow Bay","BudgetYear":2012,"StartMonth":"January","BudgetModelID":23,"BudgetModelName":"2012 Meadow Bay","BudgetType":"Budget","State":"Checked-out","StateDate":"12/1/2014  1:07:00 PM","StateUser":10426511,"StateBy":"NULL","Status":"Submitted","StatusDate":"12/1/2014  1:01:43 PM","StatusBy":"NULL","IsFinal":0,"CurrentSequence":1,"HasProjection":1,"SuppressZeros":0,"NoOfPeriods":12,"Source":"OneSite","LeaseRenewalMethod":"Unit type","IncomeModel":"Unit type","ScheduleRentMethod":"None","IncomeGLAccount":4010,"LossToLeaseMethod":"Worksheet","PayrollRunType":"Bi-weekly","PayrollStartDate":"1/13/2012  12:00:00 AM","TaxHouseAllowance":0,"AdditionalPayPeriods":"6,11","ModelAssetType":"Budget - Conventional","AssetType":"Conventional","HasWorkflow":1,"ParentSiteID":"NULL","LocationID":"NULL","SubPropnID":"NULL","IsDefaultSite":1,"OccupancyModel":"Worksheet","ContractMethod":"Worksheet","CapitalExpenseMethod":"Worksheet","HasGLSegments":0,"MasterChartID":18,"PropertyCode":"NULL","KioskMethod":"NULL","MarketRentPerSF":"NULL","TotalSF":"NULL","KioskRentPerSpace":"NULL","NumberOfKiosks":"NULL","ParentBudgetModelID":0,"IsDefaultModel":1,"CopyCommentModelName":0,"CommentDistributedID":"NULL","ManagementFeeGLAccount":"NULL","IsParentDefault":1,"CapEffectiveMonth":"January"};
			list.Add(DashBoard);
			return list;
		}
		#endregion
	}
}
