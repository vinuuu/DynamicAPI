using System.Collections.Generic;
using RealPage.OneSite.All.Common.Base.Components;
using RealPage.OneSite.All.Common.Base.DAO;

namespace RealPage.OneSite.Budgeting.BudgetModels.DAO
{
	/// <summary>
	/// Interface for ModelBuilder
	/// </summary>
	public interface IModelBuilderDAO: IDAOBase
	{
		/// <summary>
		/// Connection manager ModelBuilder DAO
		/// </summary>
		IConnectionManager CM { set; }
		/// <summary>
		///  Method used to process GLAccount data
		/// </summary>
		/// <param name="inputObjects">This is the dictionary of arraylists of 
		/// business object transactions specified by the caller. This typically hails
		/// from the web service or page class and simply passed from one object in the
		/// chain to another until it is ereferenced here.</param>
		/// <param name="workingObjects">This is the dictionary where results will be put from
		/// making SQL calls. The WorkingTypes public constants variables should correspond to 
		/// any keys added to this hashtable. It should be anticipated that the object portion
		/// of each hashtable entry be an arraylist of business object transactions.</param>
		/// <param name="globals">This is a dictionary where the keys are intended to hold globally
		/// unique values used to establish relationships between collections of business object
		/// transactions in the inputObjects hashtable. The objects corresponding to each key
		/// are intended to be a instance of the KeyResolver class.</param>
		/// <param name="bots">This is a list of business object transactions. It is used
		/// to interate through a list of transactions to be applied. Each tranaction carries
		/// a request type and action that the DAO logic uses to determine what database object
		/// and database object property is to be used for each SQL call. The DAO is expected to
		/// update the transaction status and to keep track of transaction sequence numbers when
		/// they matter to the caller.</param>
		void ProcessTransactions(IDictionary<object, object> inputObjects, IDictionary<object, object> workingObjects, IDictionary<object, object> globals, IList<IBusinessObjectTransaction> bots);
	}
}