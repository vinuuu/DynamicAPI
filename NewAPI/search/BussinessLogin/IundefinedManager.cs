using System.Collections.Generic;
using RealPage.OneSite.Common.Base;
using RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects;

namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessLogic
{
	/// <summary>
	///  Provides the interface for search Manager 
	/// </summary>
	public interface IundefinedManager : IBaseManager
	{
		/// <summary>
		///  Get search  list
		/// </summary>
		/// <param name="inputObjects">This is the dictionary of arraylists of 
		/// business object transactions specified by the caller. This typically hails
		/// from the web service or page class and simply passed from one object in the
		/// chain to another until it is referenced here.</param>
		/// <param name="globals">This is a dictionary where the keys are intended to hold globally
		/// unique values used to establish relationships between collections of business object
		/// transactions in the inputObjects dictionary. The objects corresponding to each key
		/// are intended to be a instance of the KeyResolver class.</param>
		/// <param name="prototype">search object</param>
		/// <returns>List of searchs</returns>
		List<Isearch> Getsearch(IDictionary<object, object> inputObjects, IDictionary<object, object> globals, Isearch prototype);
	}
}