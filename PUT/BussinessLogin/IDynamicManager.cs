using System.Collections.Generic;
using RealPage.OneSite.Common.Base;
using RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects;
using RealPage.OneSite.All.Common.BusinessObjects;

namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessLogic
{
	/// <summary>
	///  Provides the interface for @Dynamic Manager 
	/// </summary>
	public interface I@ParentManager : IBaseManager
	{
		/// <summary>
		///  to update  @Dynamic  list
		/// </summary>
		/// <param name="inputObjects">This is the dictionary of arraylists of 
		/// business object transactions specified by the caller. This typically hails
		/// from the web service or page class and simply passed from one object in the
		/// chain to another until it is referenced here.</param>
		/// <param name="globals">This is a dictionary where the keys are intended to hold globally
		/// unique values used to establish relationships between collections of business object
		/// transactions in the inputObjects dictionary. The objects corresponding to each key
		/// are intended to be a instance of the KeyResolver class.</param>
		/// <param name="prototype">@Dynamic object</param>
		/// <returns>Save status</returns>
		Response Update@Dynamic(IDictionary<object, object> inputObjects, IDictionary<object, object> globals, @Dynamic prototype);
	}
}