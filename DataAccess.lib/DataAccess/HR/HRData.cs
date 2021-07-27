using DataAccess.lib.Internal;
using DataAccess.lib.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.lib.DataAccess.HR
{
    public class HRData
    {
        public List<EmployeeModel> GetEmployeeById(int id)
        {
            SQLDataAccess sql = new SQLDataAccess();
            return sql.LoadData<EmployeeModel, int>("dbo.spEmployeeLookUp", id, "DefaultConnection");
        }
    }
}
