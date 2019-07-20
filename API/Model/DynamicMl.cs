using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.editAndView
{
    public class @DynamicMl
    {
        public Int64? intCusID { set; get; }
        public int? iProfID { set; get; }
        public string @DynamicCategory { get; set; }
        public string @DynamicGroup { get; set; }
        public string @Dynamical { get; set; }
        public string IsCurrentEmployeer { get; set; }
        public string WorkingFromDate { get; set; }
        public string WorkingToDate { get; set; }
        public string CountryWorkingIn { get; set; }
        public string StateWorkingIn { get; set; }
        public string DistrictWorkingIn { get; set; }
        public string CityWorkingIn { get; set; }
        public string OccupationDetails { get; set; }
        public string Income { get; set; }
        public string Currency { get; set; }
        public string Salary { get; set; }
        public string Current@Dynamic { get; set; }
        public string ResidingSince { get; set; }
        public string ArrivingDate { get; set; }
        public string DepartureDate { get; set; }
        public string CompanyName { get; set; }
        public string VisaStatus { get; set; }
        public DataTable dt@Dynamic { get; set; }
        public string AboutYourself { get; set; }
        public int? profGridID { get; set; }
        public int? @DynamicCategoryID { get; set; }
        public int? @DynamicGroupID { get; set; }
        public int? @DynamicID { get; set; }
        public int? CountryID { get; set; }
        public int? StateID { get; set; }
        public int? DistrictID { get; set; }
        public int? CityID { get; set; }
        public int? SalaryCurrency { get; set; }
        public int? VisaTypeID { get; set; }
        public Int64? Cust_@Dynamic_ID { get; set; }
        public bool? reviewstatus { set; get; }

        public Int64? EmpID { get; set; }

        public Int64? Admin { get; set; }

        public string EmpLastModificationDate { get; set; }

        public bool? employment_type { get; set; }
    }
    public class updateCutomer@DynamicdetailsMl
    {

        public long? CustID { get; set; }
        public int? @Dynamiccategory { get; set; }
        public int? @Dynamicgroup { get; set; }
        public int? @Dynamicspecialization { get; set; }
        public string University { get; set; }
        public string College { get; set; }
        public long? Passofyear { get; set; }
        public int? Countrystudyin { get; set; }
        public int? Statestudyin { get; set; }
        public int? Districtstudyin { get; set; }
        public int? CitystudyIn { get; set; }
        public string OtherCity { get; set; }
        public int? Highestdegree { get; set; }
        public string @Dynamicalmerits { get; set; }
        public int? Cust_@Dynamic_ID { get; set; }
        public int? intEduID { get; set; }
    }
}
