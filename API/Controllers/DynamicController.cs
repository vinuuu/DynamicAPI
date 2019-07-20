using Application.Common.Base;
using Application.Model.editAndView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.DAL.editAndView;
using Application.Model.commonclass;
using System.Data;
using Application.Service.commonApi;

namespace Application.Controllers.editAndView
{
    [RoutePrefix("kaakateeya/@Dynamic")]
    
   
    //private ApiContext _ApiContext = null;
    public class @DynamicController : ApiController
    {
        public @DynamicDal dal = new @DynamicDal();
        public @DynamicSvc svc = new @DynamicSvc();
        public commonApiSvc commonSVC = new commonApiSvc();
        [AllowAnonymous]
        [HttpGet]
        [Route("GetDetails/{CustID}")]
        public HttpResponseMessage customer@Dynamicdetails([FromUri]long CustID)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            List<@DynamicMl> lst = new List<@DynamicMl>();
            IApiResponse<List<@DynamicMl>>result = new ApiResponse<List<@DynamicMl>>();
            try
            {
                IDictionary<object, object> workingObjects = new Dictionary<object, object>();
                workingObjects = dal.customer@Dynamicdetails(CustID, svc);
                lst = (List<@DynamicMl>)workingObjects["response"];
                if (lst != null && lst.Count>0)
                {
                    result.TotalRecords = 1;
                    result.Records = lst;
                    result.MessageId = 0;
                    result.MessageText = Context.successtext;
                    result.StatusCode = HttpStatusCode.OK;
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    result.TotalRecords = 1;
                    result.Records = lst;
                    result.MessageId = 0;
                    result.MessageText = Context.datanotfound;
                    result.StatusCode = HttpStatusCode.OK;
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
            }
            catch (Exception ex)
            {
                result.TotalRecords = 1;
                result.Records = lst;
                result.MessageId = 0;
                result.MessageText = ex.Message;
                result.StatusCode = HttpStatusCode.InternalServerError;
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("UpdateDetails")]
        public HttpResponseMessage Updatecustomer@Dynamicdetails([FromBody]@DynamicSave mobj)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            int? status = 0;
            List<updateCutomer@DynamicdetailsMl> lt@Dynamics = new List<updateCutomer@DynamicdetailsMl>();
            lt@Dynamics.Add(mobj.customer@Dynamic);
            IApiResponse<int?> result = new ApiResponse<int?>();
            try
            {
                mobj.customerpersonaldetails.dtTableValues = Commonclass.returnListDatatable(create@DynamicdataTable(), lt@Dynamics);
                IDictionary<object, object> workingObjects = new Dictionary<object, object>();
                workingObjects = dal.Updatecustomer@Dynamicdetails(mobj.customerpersonaldetails, svc);
                status = (int?)workingObjects["response"];
                if (status==1)
                {

                    result.TotalRecords = 1;
                    result.Records = status;
                    result.MessageId = 0;
                    result.MessageText = Context.successtext;
                    result.StatusCode = HttpStatusCode.OK;
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    result.TotalRecords = 1;
                    result.Records = status;
                    result.MessageId = 0;
                    result.MessageText = Context.datanotfound;
                    result.StatusCode = HttpStatusCode.OK;
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
            }
            catch (Exception ex)
            {
                result.TotalRecords = 1;
                result.Records = status;
                result.MessageId = 0;
                result.MessageText = ex.Message;
                result.StatusCode = HttpStatusCode.InternalServerError;
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("DeleteDetails/section/{sectionName}/Custid/{Custid}/IdentityID/{IdentityID}")]
        //getCustomerSectionsDeletions
        public HttpResponseMessage Deletecustomer@Dynamicdetails(string sectionName, long custID, long IdnetityID)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            int? status = 0;

            IApiResponse<int?> result = new ApiResponse<int?>();
            try
            {
                IDictionary<object, object> workingObjects = new Dictionary<object, object>();
                workingObjects = dal.Deletecustomer@Dynamicdetails(sectionName, custID, IdnetityID, commonSVC);
                status = (int?)workingObjects["response"];
                if (status == 1)
                {

                    result.TotalRecords = 1;
                    result.Records = status;
                    result.MessageId = 0;
                    result.MessageText = Context.successtext;
                    result.StatusCode = HttpStatusCode.OK;
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    result.TotalRecords = 1;
                    result.Records = status;
                    result.MessageId = 0;
                    result.MessageText = Context.datanotfound;
                    result.StatusCode = HttpStatusCode.OK;
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
            }
            catch (Exception ex)
            {
                result.TotalRecords = 1;
                result.Records = status;
                result.MessageId = 0;
                result.MessageText = ex.Message;
                result.StatusCode = HttpStatusCode.InternalServerError;
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
        #region privateMethods
        public class @DynamicSave {  
                public updateCutomer@DynamicdetailsMl customer@Dynamic { get; set; }
                public personalDetails customerpersonaldetails { get; set; }
               
        }
        
        public static DataTable create@DynamicdataTable()
        {
            DataTable dt@Dynamicdetails = new DataTable();
            dt@Dynamicdetails.Columns.Add("CustID");
            dt@Dynamicdetails.Columns.Add("@Dynamiccategory");
            dt@Dynamicdetails.Columns.Add("@Dynamicgroup");
            dt@Dynamicdetails.Columns.Add("@Dynamicspecialization");
            dt@Dynamicdetails.Columns.Add("University");
            dt@Dynamicdetails.Columns.Add("College");
            dt@Dynamicdetails.Columns.Add("Passofyear");
            dt@Dynamicdetails.Columns.Add("Countrystudyin");
            dt@Dynamicdetails.Columns.Add("Statestudyin");
            dt@Dynamicdetails.Columns.Add("Districtstudyin");
            dt@Dynamicdetails.Columns.Add("CitystudyIn");
            dt@Dynamicdetails.Columns.Add("OtherCity");
            dt@Dynamicdetails.Columns.Add("Highestdegree");
            dt@Dynamicdetails.Columns.Add("@Dynamicalmerits");
            dt@Dynamicdetails.Columns.Add("Cust_@Dynamic_ID");
            dt@Dynamicdetails.Columns.Add("intEduID");
            return dt@Dynamicdetails;

        }


    }

        #endregion
    }

