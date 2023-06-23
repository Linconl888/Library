using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class bookDelete
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();

        public int BookDelete(int bookID)
        {
            string strsql = "delete from bookinfo where bookID='{0}'";
            strsql = string.Format(strsql,bookID);
            return db.returnAffectRowCount(strsql);
        }
    }
}
