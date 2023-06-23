using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class userAccess
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();

        //用户登录的方法
        public int userLogin(string name, string psw)
        {
            string strsql = "select * from UserInfo where username = '" + name + "' and userpwd = '" + psw + "'";
            return db.returnRowCount(strsql);
        }
    }
}

