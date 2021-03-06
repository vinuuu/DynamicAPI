﻿using System.Collections.Generic;
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
using RealPage.OneSite.All.Common.BusinessObjects;
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
		I@ParentManager _I@Parentmanager;
		I@ParentDAO _I@ParentDAO;
		I@ParentDB _I@ParentDB;
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
		#region Update@Dynamic
		/// PUT: api/budgeting/@Parentmodel/@Dynamic
		/// <summary>
		/// Updating of @Dynamic details
		/// </summary>
		/// <remarks>Updating of @Dynamic details</remarks>
		/// <param name="@Dynamic">@Dynamic details</param>
		/// <returns>Response with a Success message</returns>
		[SwaggerResponse(HttpStatusCode.BadRequest, Description = "Bad request(INVALID_PARAM: when @Dynamic object is invalid)")]
		[SwaggerResponse(HttpStatusCode.Unauthorized, Description = "Unauthorized")]
		[SwaggerResponse(HttpStatusCode.InternalServerError, Description = "Internal Server Error")]
		[SwaggerResponse(HttpStatusCode.OK, Description = "Response with a Success Message", Type = typeof(IApiResponse))]
		[SwaggerResponseExamples(typeof(IApiResponse), typeof(ApiResponse.ApiResponseExample))]
		[HttpPut]
		[Route("budgetmodel/setup/@DynamicUpdate")]
		public HttpResponseMessage Update@Dynamic([FromBody] @Dynamic @Dynamic)
		{
			//When API is called from a test class
			if (ApiContext == null) { ApiContext = _ApiContext; }

			//When API is NOT called from test class
			if (_I@ParentDAO == null) { _I@ParentDAO = new @ParentDAO(ApiContext, _I@ParentDB); }
			if (_cm == null) { _cm = new ConnectionManager(); }
			if (_I@Parentmanager == null)
			{
				_I@Parentmanager = new @ParentManager(_cm, _I@ParentDAO, ApiContext);
			}

			Response resp = _I@Parentmanager.Update@Dynamic(inputObjects, globals,@Dynamic);
			if (resp.ReasonFailed != "")
			{
				IApiResponse response = new ApiResponse();
				response.MessageText = resp.ReasonFailed;
				response.MessageId = resp.ID;
				return Request.CreateResponse(HttpStatusCode.BadRequest, response);
			}

			IApiResponse apiResponse = new ApiResponse();
			apiResponse.MessageId = resp.ID;
			apiResponse.MessageText = "Success";
			return Request.CreateResponse(HttpStatusCode.OK, apiResponse);
		}
		#endregion
		#endregion
	}
}