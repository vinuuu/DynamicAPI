using RealPage.OneSite.All.Common.BusinessObjects;

namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects
{
	/// <summary>
	/// Interface for abc
	/// </summary>
	public interface I@Dynamic : IBusinessObjectBase
{

		/// <summary>
		/// Represents the BudgetModelID
		/// </summary>
		int BudgetModelID { get; set; }

		/// <summary>
		/// Represents the PSiteID
		/// </summary>
		int PSiteID { get; set; }

		/// <summary>
		/// Represents the BudgetYear
		/// </summary>
		int BudgetYear { get; set; }

		/// <summary>
		/// Represents the BudgetType
		/// </summary>
		string BudgetType { get; set; }

		/// <summary>
		/// Represents the PropertyName
		/// </summary>
		string PropertyName { get; set; }

		/// <summary>
		/// Represents the ModelName
		/// </summary>
		string ModelName { get; set; }
		/// <summary>
		/// Represents the LastModifiedDate
		/// </summary>
		string LastModifiedDate { get; set; }

		/// <summary>
		/// Represents the Initialize
		/// </summary>
		void Initialize();
	}
}
