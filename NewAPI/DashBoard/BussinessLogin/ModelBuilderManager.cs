using System.Collections.Generic;
using RealPage.OneSite.All.Common.Base.DAO;
using RealPage.OneSite.Common.Base;
using RealPage.OneSite.Data;
using RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects;
using RealPage.OneSite.Budgeting.BudgetModels.DAO;
using RPComponents = RealPage.OneSite.All.Common.Base.Components;


namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessLogic
{
	/// <summary>
	/// DashBoard Manager provides methods to manage DashBoard and its details
	/// </summary>
	public class ModelBuilderManager : BaseManager, IModelBuilderManager
	{
		#region Private variables
		private IModelBuilderDAO _dao;
		private IConnectionManager _cm;
		#endregion
		#region Constructors

		/// <summary>
		/// Create a basic instance of the BudgetModel Manager class
		/// </summary>
		/// <param name="cm">A reference to an initialized Connection Manager</param>
		/// <param name="dao">A reference to an initialized Roles DAO</param>
		/// <param name="context">A reference to an initialized Web API Context</param>
		public ModelBuilderManager(IConnectionManager cm, IModelBuilderDAO dao, WebApiContext context)
            : base(context)
        {
			_cm = cm;
			_dao = dao;
		}

		#endregion
		#region Public Methods
		/// <summary>
		///  Get DashBoard  list
		/// </summary>
		/// <param name="inputObjects">This is the dictionary of arraylists of 
		/// business object transactions specified by the caller. This typically hails
		/// from the web service or page class and simply passed from one object in the
		/// chain to another until it is referenced here.</param>
		/// <param name="globals">This is a dictionary where the keys are intended to hold globally
		/// unique values used to establish relationships between collections of business object
		/// transactions in the inputObjects dictionary. The objects corresponding to each key
		/// are intended to be a instance of the KeyResolver class.</param>
		/// <param name="prototype">DashBoard object</param>
		/// <returns>List of DashBoard</returns>
		public List<IDashBoard> GetDashBoard(IDictionary<object, object> inputObjects, IDictionary<object, object> globals, IDashBoard prototype)
		{
			IDictionary<object, object> workingObjects = new Dictionary<object, object>();
			try
			{
				_cm.Init(base.Env, base.Server);
				_cm.Connect(DBEntity.PMC, base.PmcID, base.SiteID, base.UserID);
				_dao.CM = _cm;
				RPComponents.IBusinessObjectTransaction bot = new RPComponents.BusinessObjectTransaction();
				IList<RPComponents.IBusinessObjectTransaction> bots = new List<RPComponents.IBusinessObjectTransaction>();
				bot.BusinessObject = prototype;
				bot.RequestType = ModelBuilderDAO.RequestTypes.DashBoard;
				bot.Action = new RPComponents.Action(RPComponents.Action.Select);
				bots.Add(bot);
				_dao.ProcessTransactions(inputObjects, workingObjects, globals, bots);
			}
			finally
			{
				_cm.Disconnect();
			}
			List<IDashBoard> list = (List<IDashBoard>)workingObjects[ModelBuilderDAO.WorkingTypes.DashBoard];
			return list;
		}
		#endregion
	}
}
