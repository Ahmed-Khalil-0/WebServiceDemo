using DataAccess.lib.DataAccess.HR;
using DataAccess.lib.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using WebServiceDemo.Autho;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for CalculationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CalculationWebService : System.Web.Services.WebService
    {
       
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public EmployeeModel GetEmployeeByID(int num1)
        {
            HRData hRData = new HRData();
            return hRData.GetEmployeeById(num1);
        }

        [WebMethod]
        public void GetAllEmployee()
        {
            HRData hRData = new HRData();
            JavaScriptSerializer js = new JavaScriptSerializer();

            Context.Response.Write(js.Serialize(hRData.GetAllEmployees()));
        }

        [WebMethod]
        public void Authonticate(string userName, string password)
        {
            bool authonticated = LoginAutho.LoginAuthontication(userName, password);
            if (!authonticated)
                Context.Response.Write("Unauthorized Access"); 
            else
                Context.Response.Write("Authorized Access");

        }
    }
}
