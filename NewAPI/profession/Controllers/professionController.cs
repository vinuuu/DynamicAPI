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

namespace Application.Controllers.editAndView
{
    [RoutePrefix("kaakateeya/profession")]
    
   
    //private ApiContext _ApiContext = null;
    public class professionController : ApiController
    {
        public professionDal dal = new professionDal();
        public professionSvc svc = new professionSvc();
        [AllowAnonymous]
        [HttpGet]
        [Route("GetDetails/{CustID}")]
        public HttpResponseMessage customerprofessiondetails([FromUri]long CustID)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            List<professionMl> lst = new List<professionMl>();
            IApiResponse<List<professionMl>>result = new ApiResponse<List<professionMl>>();
            try
            {
                IDictionary<object, object> workingObjects = new Dictionary<object, object>();
                workingObjects = dal.customerprofessiondetails(CustID, svc);
                lst = (List<professionMl>)workingObjects["response"];
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
        public HttpResponseMessage Updatecustomerprofessiondetails([FromBody]professionSave mobj)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            int? status = 0;
            List<professionMl> ltprofessions = new List<professionMl>();
            ltprofessions.Add(mobj.lt);
            IApiResponse<int?> result = new ApiResponse<int?>();
            try
            {
                dtTableValues = Commonclass.returnListDatatable(createprofessiondataTable(), ltprofessions);
                IDictionary<object, object> workingObjects = new Dictionary<object, object>();
                workingObjects = dal.Updatecustomerprofessiondetails(mobj.lt, svc);
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
        [Route("DeleteDetails")]
        //getCustomerSectionsDeletions
        public HttpResponseMessage Deletecustomerprofessiondetails([FromBody]professionSave mobj)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            int? status = 0;
            List<professionMl> ltprofessions = new List<professionMl>();
            ltprofessions.Add(mobj.lt);
            IApiResponse<int?> result = new ApiResponse<int?>();
            try
            {
                dtTableValues = Commonclass.returnListDatatable(createprofessiondataTable(), ltprofessions);
                IDictionary<object, object> workingObjects = new Dictionary<object, object>();
                workingObjects = dal.Updatecustomerprofessiondetails(mobj.lt, svc);
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
        public class professionSave {  
                public professionMl lt { get; set; }
                public personalDetails pl { get; set; }
               
        }
        public DataTable dtTableValues { get; set; }
        public class personalDetails
        {
            int custId { get; set; }
        }
        public static DataTable createprofessiondataTable()
        {
            DataTable dtprofessiondetails = new DataTable();
            dtprofessiondetails.Columns.Add("CustID");
            dtprofessiondetails.Columns.Add("professioncategory");
            dtprofessiondetails.Columns.Add("professiongroup");
            dtprofessiondetails.Columns.Add("professionspecialization");
            dtprofessiondetails.Columns.Add("University");
            dtprofessiondetails.Columns.Add("College");
            dtprofessiondetails.Columns.Add("Passofyear");
            dtprofessiondetails.Columns.Add("Countrystudyin");
            dtprofessiondetails.Columns.Add("Statestudyin");
            dtprofessiondetails.Columns.Add("Districtstudyin");
            dtprofessiondetails.Columns.Add("CitystudyIn");
            dtprofessiondetails.Columns.Add("OtherCity");
            dtprofessiondetails.Columns.Add("Highestdegree");
            dtprofessiondetails.Columns.Add("professionalmerits");
            dtprofessiondetails.Columns.Add("Cust_profession_ID");
            dtprofessiondetails.Columns.Add("intEduID");
            return dtprofessiondetails;

        }


    }

        #endregion
    }