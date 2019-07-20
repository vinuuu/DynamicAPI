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
	public class @DynamicController : BaseApiController
	{
		#region Private variables
		IDictionary<object, object> inputObjects = new Dictionary<object, object>();
		IDictionary<object, object> globals = new Dictionary<object, object>();
		IConnectionManager _cm;
		WebApiContext _ApiContext;
		I@ParentManager _@Parentmanager;
		I@ParentDAO _@ParentDAO;
		I@ParentDB _@ParentDB;
		#endregion
		#region Constructors
		/// <summary>
		/// Create a basic instance of the Budget model Controller class
		/// </summary>
		public @DynamicController() : base() { }

		/// <summary>
		///  Create a basic instance of the @Dynamic Controller for test
		/// </summary>
		/// <param name="@ParentDAO"></param>
		/// <param name="@ParentDB"></param>
		/// <param name="cm"></param>
		/// <param name="@ParentManager"></param>
		/// <param name="ApiContext"></param>
		public @DynamicController(I@ParentDAO @ParentDAO, I@ParentDB @ParentDB, IConnectionManager cm, I@ParentManager @ParentManager, WebApiContext ApiContext)
            : base()
        {
			_cm = cm;
			_I@ParentDAO = @ParentDAO;
			_I@ParentDB = @ParentDB;
			_I@Parentmanager = @ParentManager;
			_ApiContext = ApiContext;
		}
		#endregion
		#region Controllers
		#region Get@Dynamic

		//  GET: api/budgeting/budgetmodel/@Dynamic
		/// <summary>
		/// Get all @Dynamic
		/// </summary>
		/// <returns>List of @Dynamic</returns>
		[SwaggerResponse(HttpStatusCode.NotFound, Description = "Not found(NOT_FOUND:  Unable to return @Dynamic becasue of no records found)")]
		[SwaggerResponse(HttpStatusCode.Unauthorized, Description = "Unauthorized")]
		[SwaggerResponse(HttpStatusCode.InternalServerError, Description = "Internal Server Error")]
		[SwaggerResponse(HttpStatusCode.OK, Description = "List of @Dynamic", Type = typeof(IApiResponse<IList<I@Dynamic>>))]
		[SwaggerResponseExamples(typeof(IApiResponse<IList<I@Dynamic>>), typeof(@DynamicExample))]
		[HttpGet]
		[Route("budgetmodel/setup/@Dynamic")]
		public HttpResponseMessage Get@Dynamic()
		{
			//When API is called from a test class
			if (ApiContext == null) { ApiContext = _ApiContext; }

			//When API is NOT called from test class
			if (_@ParentDAO == null) { _@ParentDAO = new @ParentDAO(ApiContext, _@ParentDB); }
			if (_cm == null) { _cm = new ConnectionManager(); }
			if (_@Parentmanager == null)
			{
				_@Parentmanager = new @ParentManager(_cm, _@ParentDAO, ApiContext);
			}
			I@Dynamic prototype = new @Dynamic();
			//Get @Dynamic list from the database
			List<I@Dynamic> list = _@Parentmanager.Get@Dynamic(inputObjects, globals, prototype);

			if (list == null)
			{
				return Request.CreateErrorResponse(HttpStatusCode.NotFound, "NOT_FOUND");
			}

			IApiResponse<List<I@Dynamic>> result = new ApiResponse<List<I@Dynamic>>();
			result.Records = list;
			result.TotalRecords = list.Count;
			result.MessageId = 200;
			result.MessageText = "Success";
			return Request.CreateResponse<IApiResponse<List<I@Dynamic>>>(HttpStatusCode.OK, result);
		}

		#endregion
		#endregion
		#region Documentation Details
		/// <summary>
		/// @Dynamic example
		/// </summary>
		public class @DynamicExample : IProvideExamples
		{
			/// <summary>
			/// Example object data used by Swagger to document the output of the webapi method
			/// </summary>
			/// <returns>@Dynamic</returns>
			public object GetExamples()
			{
				IApiResponse<List<I@Dynamic>> example = new ApiResponse<List<I@Dynamic>>();
				example.Records = @Dynamic.Get@DynamicExample();
				example.TotalRecords = example.Records.Count;
				return example;
			}
		}
		#endregion
	}
}