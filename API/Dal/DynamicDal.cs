using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Model.commonclass;
using Application.Model.editAndView;
using Application.Service.commonApi;

namespace Application.DAL.editAndView
{
    public class @DynamicDal
    {
        public IDictionary<object, object> customer@Dynamicdetails(long custID, @DynamicSvc svc)
        {
            return svc.customer@Dynamicdetails(custID, spNames.@DynamicDetailsGetSP);
        }

        public IDictionary<object, object> Updatecustomer@Dynamicdetails(personalDetails lt, @DynamicSvc svc)
        {
            return svc.Updatecustomer@Dynamicdetails(lt, spNames.@DynamicDetailsUpdateSP);
        }

        public IDictionary<object, object> Deletecustomer@Dynamicdetails(string sectionName,long custID,long IdnetityID, commonApiSvc svc)
        {
            return svc.DeletecustomerEducationdetails(sectionName, custID,IdnetityID, spNames.@DynamicDetailsDeleteSP);
        }
    }
}
