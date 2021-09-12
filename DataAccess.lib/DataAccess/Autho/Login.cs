using DataAccess.lib.Internal;
using DataAccess.lib.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.lib.DataAccess.Autho
{
    public class Login
    {
        public MembershipModel CheckAuthontication(string userName)
        {
            SQLDataAccess sql = new SQLDataAccess();
            return sql.LoadData<MembershipModel, dynamic>("dbo.spMembershipAuth", new { UserName = userName }, "DefaultConnection").FirstOrDefault();
        }
    }
}
