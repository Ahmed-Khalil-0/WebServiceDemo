using DataAccess.lib.DataAccess.HR;
using DataAccess.lib.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace WebAPIDemo.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public string Get()
        {
            HRData hRData = new HRData();
            JavaScriptSerializer js = new JavaScriptSerializer();

            return js.Serialize(hRData.GetAllEmployees());
        }

        public EmployeeModel Get(int id)
        {
            HRData hRData = new HRData();
            return hRData.GetEmployeeById(id);
        }

        public void Post([FromBody]EmployeeModel employee)
        {
            HRData hRData = new HRData();
            hRData.AddEmployee(employee);
        }

        public void Delete(int id)
        {
            HRData hRData = new HRData();
            hRData.DeleteEmployee(id);
        }
    }
}
