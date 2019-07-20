using RealPage.OneSite.All.Common.DBObjects;
namespace RealPage.OneSite.Budgeting.BudgetModels.DBObjects
{
	/// <summary>
	///	interface of undefinedDB Class
	/// </summary>
	public interface IundefinedDB : IDBObjectBase
	{
		/// <summary>
		/// Query to Select payment
		/// </summary>
		string Getpayment { get; }
	}
}