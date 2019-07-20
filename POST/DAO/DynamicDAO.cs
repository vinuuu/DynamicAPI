using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

using RealPage.OneSite.All.Common.Base.DAO;
using RealPage.OneSite.All.Common.Base.Components;
using RealPage.OneSite.Budgeting.BudgetModels.DBObjects;
using RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects;
using RPComponents = RealPage.OneSite.All.Common.Base.Components;
using RealPage.OneSite.Common.Base;



namespace RealPage.OneSite.Budgeting.BudgetModels.DAO
{
	/// <summary>
	/// DAO for @Dynamic
	/// </summary>
	public class @ParentDAO : DAOBase, I@ParentDAO
	{
		private I@ParentDB _DB;
		private IDictionary<string, string> _context;
		#region  Public new classes
		/// <summary>
		/// BudgetModel Request Types
		/// </summary>
		public new class RequestTypes
		{
			/// <summary>
			/// Request type for @Dynamic
			/// </summary>
			public const int @Dynamic = 0;

		}

		/// <summary>
		/// BudgetModel Working Types
		/// </summary>
		public new class WorkingTypes
		{
			/// <summary>
			/// Working type for Response
			/// </summary>
			public const String Response = "@DynamicResponse";
			/// <summary>
			/// Working type for SequenceList
			/// </summary>
			public const String SequenceList = "@DynamicSequenceList";
			/// <summary>
			/// Working type for Exception
			/// </summary>
			public const String Exception = "@DynamicException";
			/// <summary>
			/// Working type for @Dynamic
			/// </summary>
			public const String @Dynamic = "@Dynamic";

		}
		#endregion
		#region Constructors

		/// <summary>
		/// Create a basic instance of the BudgetModel DAO class
		/// </summary>
		/// <param name="context"></param>
		/// <param name="db"></param>
		public @ParentDAO(WebApiContext context, I@ParentDB db)
		{
			// testing
			_context = context.TraceContext;
			if (!_context.Keys.Contains("CurrentDAO")) { _context.Add("CurrentDAO", this.GetType().FullName); }
			_DB = db;
		}

		#endregion
		#region Public Properties

		/// <summary>
		/// Connection manager
		/// </summary>
		public IConnectionManager CM
		{
			set { base.CM = value; }
		}

		#endregion

		#region Public override methods

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
		/// Insert the transaction status and to keep track of transaction sequence numbers when
		/// they matter to the caller.</param>
		public override void ProcessTransactions
			(
			IDictionary<object, object> inputObjects
			, IDictionary<object, object> workingObjects
			, IDictionary<object, object> globals
			, IList<RPComponents.IBusinessObjectTransaction> bots
			)
		{
			SqlConnection connection = GetConnection();
			SqlTransaction transaction = GetTransaction();
			int seq = 0;
			IList<int> al = new List<int>();
			foreach (RPComponents.BusinessObjectTransaction bot in bots)
			{
				RPComponents.Action action = bot.Action;

				Hashtable parameters = new Hashtable();

				I@ParentDB DB = new @ParentDB(bot.BusinessObject, parameters);

				switch (bot.RequestType)
				{
						case RequestTypes.@Dynamic:
						switch (action.Value)
						{
							case RPComponents.Action.Insert:
								seq = Insert@Dynamic
									(
									 workingObjects
									, bot
									, connection
									, transaction
									, parameters
									, DB
									);

								if (!workingObjects.ContainsKey(@ParentDAO.WorkingTypes.SequenceList))
								{
									workingObjects.Add(@ParentDAO.WorkingTypes.SequenceList, new List<int>());
								}
								al = workingObjects[@ParentDAO.WorkingTypes.SequenceList] as List<int>;
								al.Add(seq);
								break;
				}
			}
		}

		#endregion

		#region Private methods
		#region Insert@Dynamic

		private int Insert@Dynamic
		(
			IDictionary<object, object> workingObjects,
			RPComponents.IBusinessObjectTransaction bot,
			SqlConnection connection,
			SqlTransaction transaction,
			Hashtable parameters,
			I@ParentDB db
		)
		{
			String query = db.Insert@Dynamic;
			db.SetNullParameters();
			db.SetParameters(query);
			int sequence = 0;

			sequence =
			HandleResponse
				(
				workingObjects
				, WorkingTypes.Response
				, bot
				, connection
				, transaction
				, query
				, parameters
				, db
				, "Unknown error while Update/Insert @Dynamic details."
				);
			return sequence;
		}

		#endregion
		#endregion
		
	}
}
