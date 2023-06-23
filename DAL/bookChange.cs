using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class bookChange
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();

        public int BookChange(int bookID, string bookName, string publisher, string publishDate, int publishNum, int words,
                            string publishWay, float pride)
        {
            string strsql = "update BookInfo set bookName='{1}',publisher='{2}',publishDate='{3}',publishNum='{4}',words='{5}',publishWay='{6}',pride='{7}' where bookID='{0}';";
            strsql = string.Format(strsql,bookID.ToString(), bookName.ToString(), publisher.ToString(), publishDate.ToString(), publishNum.ToString(), words.ToString(), publishWay.ToString(), pride.ToString());
            return db.returnAffectRowCount(strsql);
        }
    }
}
