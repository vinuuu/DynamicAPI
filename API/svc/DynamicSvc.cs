using Application.Model.editAndView;
using Application.Service;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL.editAndView
{
    public class @DynamicSvc
    {
        public IDictionary<object, object> customer@Dynamicdetails(long custID, string spName)
        {
            var dapperParam = new DynamicParameters();
            dapperParam.Add("@CustomerID", custID);
            List<@DynamicMl> response = new List<@DynamicMl>();
            using (IDbConnection conn = SQLHelper.GetSQLConnection())
            {
                var reader = conn.Query<@DynamicMl>(spName, param: dapperParam, commandType: CommandType.StoredProcedure);

                if (reader != null)
                {
                    response = reader.ToList();
                }
            }

            IDictionary<object, object> workingObjects = new Dictionary<object, object>();
            workingObjects.Add("response", response);
            return workingObjects;
        }      

        public IDictionary<object, object> Updatecustomer@Dynamicdetails(personalDetails lt, string spName)
        {
            var dapperParam = new DynamicParameters();
            dapperParam.Add("@CustID", lt.intCusID);
            dapperParam.Add("@EmpID", lt.EmpID);
            dapperParam.Add("@IsReViewed", lt.Admin);
            dapperParam.Add("@dt@Dynamicdetails",lt.dtTableValues,dbType: DbType.Object);
            dapperParam.Add("@Status", dbType: DbType.Int32, direction: ParameterDirection.Output, size: 5000);

            int? status = 0;
            using (IDbConnection conn = SQLHelper.GetSQLConnection())
            {
                var reader = conn.QueryMultiple(spName, param: dapperParam, commandType: CommandType.StoredProcedure);
                status = dapperParam.Get<int?>("@Status");
            }

            IDictionary<object, object> workingObjects = new Dictionary<object, object>();
            workingObjects.Add("response", status);
            return workingObjects;
        }
    }
}
