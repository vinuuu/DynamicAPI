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
	public class DashBoardController : BaseApiController
	{
		#region Private variables
		IDictionary<object, object> inputObjects = new Dictionary<object, object>();
		IDictionary<object, object> globals = new Dictionary<object, object>();
		IConnectionManager _cm;
		WebApiContext _ApiContext;
		IModelBuilderManager _ModelBuildermanager;
		IModelBuilderDAO _ModelBuilderDAO;
		IModelBuilderDB _ModelBuilderDB;
		#endregion
		#region Constructors
		/// <summary>
		/// Create a basic instance of the Budget model Controller class
		/// </summary>
		public DashBoardController() : base() { }

		/// <summary>
		///  Create a basic instance of the DashBoard Controller for test
		/// </summary>
		/// <param name="ModelBuilderDAO"></param>
		/// <param name="ModelBuilderDB"></param>
		/// <param name="cm"></param>
		/// <param name="ModelBuilderManager"></param>
		/// <param name="ApiContext"></param>
		public DashBoardController(IModelBuilderDAO ModelBuilderDAO, IModelBuilderDB ModelBuilderDB, IConnectionManager cm, IModelBuilderManager ModelBuilderManager, WebApiContext ApiContext)
            : base()
        {
			_cm = cm;
			_IModelBuilderDAO = ModelBuilderDAO;
			_IModelBuilderDB = ModelBuilderDB;
			_IModelBuildermanager = ModelBuilderManager;
			_ApiContext = ApiContext;
		}
		#endregion
		#region Controllers
		#region GetDashBoard

		//  GET: api/budgeting/budgetmodel/DashBoard
		/// <summary>
		/// Get all DashBoard
		/// </summary>
		/// <returns>List of DashBoard</returns>
		[SwaggerResponse(HttpStatusCode.NotFound, Description = "Not found(NOT_FOUND:  Unable to return DashBoard becasue of no records found)")]
		[SwaggerResponse(HttpStatusCode.Unauthorized, Description = "Unauthorized")]
		[SwaggerResponse(HttpStatusCode.InternalServerError, Description = "Internal Server Error")]
		[SwaggerResponse(HttpStatusCode.OK, Description = "List of DashBoard", Type = typeof(IApiResponse<IList<IDashBoard>>))]
		[SwaggerResponseExamples(typeof(IApiResponse<IList<IDashBoard>>), typeof(DashBoardExample))]
		[HttpGet]
		[Route("budgetmodel/setup/DashBoard")]
		public HttpResponseMessage GetDashBoard()
		{
			//When API is called from a test class
			if (ApiContext == null) { ApiContext = _ApiContext; }

			//When API is NOT called from test class
			if (_ModelBuilderDAO == null) { _ModelBuilderDAO = new ModelBuilderDAO(ApiContext, _ModelBuilderDB); }
			if (_cm == null) { _cm = new ConnectionManager(); }
			if (_ModelBuildermanager == null)
			{
				_ModelBuildermanager = new ModelBuilderManager(_cm, _ModelBuilderDAO, ApiContext);
			}
			IDashBoard prototype = new DashBoard();
			//Get DashBoard list from the database
			List<IDashBoard> list = _ModelBuildermanager.GetDashBoard(inputObjects, globals, prototype);

			if (list == null)
			{
				return Request.CreateErrorResponse(HttpStatusCode.NotFound, "NOT_FOUND");
			}

			IApiResponse<List<IDashBoard>> result = new ApiResponse<List<IDashBoard>>();
			result.Records = list;
			result.TotalRecords = list.Count;
			result.MessageId = 200;
			result.MessageText = "Success";
			return Request.CreateResponse<IApiResponse<List<IDashBoard>>>(HttpStatusCode.OK, result);
		}

		#endregion
		#endregion
		#region Documentation Details
		/// <summary>
		/// DashBoard example
		/// </summary>
		public class DashBoardExample : IProvideExamples
		{
			/// <summary>
			/// Example object data used by Swagger to document the output of the webapi method
			/// </summary>
			/// <returns>DashBoard</returns>
			public object GetExamples()
			{
				IApiResponse<List<IDashBoard>> example = new ApiResponse<List<IDashBoard>>();
				example.Records = DashBoard.GetDashBoardExample();
				example.TotalRecords = example.Records.Count;
				return example;
			}
		}
		#endregion
	}
}