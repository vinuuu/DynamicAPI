using System.Collections.Generic;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using RealPage.OneSite.Budgeting.BudgetModels.BusinessObjects;
using RealPage.OneSite.Budgeting.BudgetModels.BusinessLogic;
using RealPage.OneSite.Common.Base;
using RealPage.OneSite.Budgeting.BudgetModels.DAO;
using RealPage.OneSite.Budgeting.BudgetModels.DBObjects;
using RealPage.OneSite.All.Common.Base.DAO;
using Swashbuckle.Swagger.Annotations;
using RealPage.OneSite.Common.Swagger;
namespace RealPage.API.OneSite.Budgeting.Controllers.BudgetModel
{
	/// <summary>
	/// Used to manage operations on Budget model such as Create, Delete, Update, get list of Budget model etc
	/// </summary>
	public class searchController : BaseApiController
	{
		#region Private variables
		IDictionary<object, object> inputObjects = new Dictionary<object, object>();
		IDictionary<object, object> globals = new Dictionary<object, object>();
		IConnectionManager _cm;
		WebApiContext _ApiContext;
		IundefinedManager _undefinedmanager;
		IundefinedDAO _undefinedDAO;
		IundefinedDB _undefinedDB;
		#endregion
		#region Constructors
		/// <summary>
		/// Create a basic instance of the Budget model Controller class
		/// </summary>
		public searchController() : base() { }

		/// <summary>
		///  Create a basic instance of the search Controller for test
		/// </summary>
		/// <param name="undefinedDAO"></param>
		/// <param name="undefinedDB"></param>
		/// <param name="cm"></param>
		/// <param name="undefinedManager"></param>
		/// <param name="ApiContext"></param>
		public searchController(IundefinedDAO undefinedDAO, IundefinedDB undefinedDB, IConnectionManager cm, IundefinedManager undefinedManager, WebApiContext ApiContext)
            : base()
        {
			_cm = cm;
			_IundefinedDAO = undefinedDAO;
			_IundefinedDB = undefinedDB;
			_Iundefinedmanager = undefinedManager;
			_ApiContext = ApiContext;
		}
		#endregion
		#region Controllers
		#region Getsearch

		//  GET: api/budgeting/budgetmodel/search
		/// <summary>
		/// Get all search
		/// </summary>
		/// <returns>List of search</returns>
		[SwaggerResponse(HttpStatusCode.NotFound, Description = "Not found(NOT_FOUND:  Unable to return search becasue of no records found)")]
		[SwaggerResponse(HttpStatusCode.Unauthorized, Description = "Unauthorized")]
		[SwaggerResponse(HttpStatusCode.InternalServerError, Description = "Internal Server Error")]
		[SwaggerResponse(HttpStatusCode.OK, Description = "List of search", Type = typeof(IApiResponse<IList<Isearch>>))]
		[SwaggerResponseExamples(typeof(IApiResponse<IList<Isearch>>), typeof(searchExample))]
		[HttpGet]
		[Route("budgetmodel/setup/search")]
		public HttpResponseMessage Getsearch()
		{
			//When API is called from a test class
			if (ApiContext == null) { ApiContext = _ApiContext; }

			//When API is NOT called from test class
			if (_undefinedDAO == null) { _undefinedDAO = new undefinedDAO(ApiContext, _undefinedDB); }
			if (_cm == null) { _cm = new ConnectionManager(); }
			if (_undefinedmanager == null)
			{
				_undefinedmanager = new undefinedManager(_cm, _undefinedDAO, ApiContext);
			}
			Isearch prototype = new search();
			//Get search list from the database
			List<Isearch> list = _undefinedmanager.Getsearch(inputObjects, globals, prototype);

			if (list == null)
			{
				return Request.CreateErrorResponse(HttpStatusCode.NotFound, "NOT_FOUND");
			}

			IApiResponse<List<Isearch>> result = new ApiResponse<List<Isearch>>();
			result.Records = list;
			result.TotalRecords = list.Count;
			result.MessageId = 200;
			result.MessageText = "Success";
			return Request.CreateResponse<IApiResponse<List<Isearch>>>(HttpStatusCode.OK, result);
		}

		#endregion
		#endregion
		#region Documentation Details
		/// <summary>
		/// search example
		/// </summary>
		public class searchExample : IProvideExamples
		{
			/// <summary>
			/// Example object data used by Swagger to document the output of the webapi method
			/// </summary>
			/// <returns>search</returns>
			public object GetExamples()
			{
				IApiResponse<List<Isearch>> example = new ApiResponse<List<Isearch>>();
				example.Records = search.GetsearchExample();
				example.TotalRecords = example.Records.Count;
				return example;
			}
		}
		#endregion
	}
}