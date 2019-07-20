using RealPage.OneSite.All.Common.DBObjects;
namespace RealPage.OneSite.Budgeting.BudgetModels.DBObjects
{
	/// <summary>
	///	interface of ModelBuilderDB Class
	/// </summary>
	public interface IModelBuilderDB : IDBObjectBase
	{
		/// <summary>
		/// Query to Select DashBoard
		/// </summary>
		string GetDashBoard { get; }
	}
}