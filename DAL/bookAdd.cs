using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class bookAdd
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();

        public int BookAdd(int bookID, string bookName, string publisher, string publishDate, int publishNum, int words,
                            string publishWay, float pride)
        {
            string strsql = "insert into BookInfo(bookID,bookName,publisher,publishDate,publishNum,words,publishWay,pride) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');";
            strsql = string.Format(strsql,bookID, bookName, publisher, publishDate, publishNum, words, publishWay, pride);
            return db.returnAffectRowCount(strsql);
        }

    }
}
