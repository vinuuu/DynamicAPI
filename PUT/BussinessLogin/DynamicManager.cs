using System;
using System.Collections.Generic;
using RealPage.OneSite.All.Common.Base.DAO;
using RealPage.OneSite.Common.Base;
using RealPage.OneSite.Data;
using RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects;
using RealPage.OneSite.Budgeting.BudgetModels.DAO;
using RealPage.OneSite.All.Common.Base.Components;
using RPComponents = RealPage.OneSite.All.Common.Base.Components;
using RealPage.OneSite.All.Common.BusinessObjects;


namespace RealPage.OneSite.Budgeting.BudgetModels.BusinessLogic
{
	/// <summary>
	/// @Dynamic Manager provides methods to manage @Dynamic and its details
	/// </summary>
	public class @ParentManager : BaseManager, I@ParentManager
	{
		#region Private variables
		private I@ParentDAO _dao;
		private IConnectionManager _cm;
		#endregion
		#region Constructors

		/// <summary>
		/// Create a basic instance of the BudgetModel Manager class
		/// </summary>
		/// <param name="cm">A reference to an initialized Connection Manager</param>
		/// <param name="dao">A reference to an initialized Roles DAO</param>
		/// <param name="context">A reference to an initialized Web API Context</param>
		public @ParentManager(IConnectionManager cm, I@ParentDAO dao, WebApiContext context)
            : base(context)
        {
			_cm = cm;
			_dao = dao;
		}

		#endregion
		#region Public Methods
		#region Update@Dynamic
		/// <summary>
		/// To Update @Dynamic details
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
		public Response Update@Dynamic(IDictionary<object, object> inputObjects, IDictionary<object, object> globals, @Dynamic prototype)
		{
			IDictionary<object, object> workingObjects = new Dictionary<object, object>();
			try
			{
				_cm.Init(base.Env, base.Server);
				_cm.Connect(DBEntity.PMC, base.PmcID, base.SiteID, base.UserID);
				_dao.CM = _cm;
				_cm.BeginTransaction();
				
				IBusinessObjectTransaction bot = new BusinessObjectTransaction();
				bot.BusinessObject = prototype;
				bot.RequestType = @ParentDAO.RequestTypes.@Dynamic;
				bot.Action = new RPComponents.Action(RPComponents.Action.Update);
				_dao.ProcessTransactions(inputObjects, globals, workingObjects, bot);
				_cm.Commit();
				IDictionary<object, object> response = workingObjects[@ParentDAO.WorkingTypes.Response] as Dictionary<object, object>;
				List<int> al = workingObjects[@ParentDAO.WorkingTypes.SequenceList] as List<int>;
				string seq = al[0].ToString();
				Response rp = response[seq] as Response;
				return rp;
			}
			catch (Exception e)
			{
				_cm.Rollback();
				throw new Exception(e.Message + " in " + e.Source + " " + e.StackTrace);
			}
			finally
			{
				_cm.Disconnect();
			}
		}
		#endregion
		#endregion
	}
}
