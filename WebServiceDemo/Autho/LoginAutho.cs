using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using DataAccess.lib.DataAccess.Autho;
using DataAccess.lib.Internal.Models;

namespace WebServiceDemo.Autho
{
    public static class LoginAutho
    {
        public static bool LoginAuthontication(string userName, string password)
        {
            Login login = new Login();
            MembershipModel membership = login.CheckAuthontication(userName);

            //if the user exists generate token and send it back.
            if (membership == null)
                return false;

            return true;
        }
    }
}