using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace BLL
{
    public class userAccess
    {
        DAL.userAccess d_userAccess = new DAL.userAccess();

        public int userLogin(Model.userInfo m_userInfo)
        {
            return d_userAccess.userLogin(m_userInfo.username, m_userInfo.psw);
        }
    }
}
