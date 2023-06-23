using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class bookSearch
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();

        //书籍查询的方法
        public int bookSearchNumber(int bookID, string bookName, string publisher, string publishDate, int publishNum, int words, 
            string publishWay ,float pride )
        {
            string strsql = "select * from BookInfo";
            if (bookID != 0) strsql+=" intersect select * from BookInfo where bookID = '" + bookID + "'";
            if (bookName.Length!=0) strsql += " intersect select * from BookInfo where bookName = '" + bookName + "'";
            if (publisher.Length != 0) strsql += " intersect select * from BookInfo where publisher = '" + publisher + "'";
            if (publishDate.Length != 0) strsql += " intersect select * from BookInfo where publishDate = '" + publishDate + "'";
            if (publishNum != 0) strsql += " intersect select * from BookInfo where publishNum = '" + publishNum + "'";
            if (words != 0) strsql += " intersect select * from BookInfo where words = '" + words + "'";
            if (publishWay.Length != 0) strsql += " intersect select * from BookInfo where publishWay = '" + publishWay + "'";
            if (pride != 0) strsql += " intersect select * from BookInfo where pride = '" + pride + "'";

            return db.returnRowCount(strsql);
        }
        //查找所有书籍
        public int bookSearchAllNumber(int bookID, string bookName, string publisher, string publishDate, int publishNum, int words,
            string publishWay, float pride)
        {
            string strsql = "select * from BookInfo ";
            return db.returnRowCount(strsql);
        }
        //书籍查询的结果
        public DataSet bookSearchReasault(int bookID, string bookName, string publisher, string publishDate, int publishNum, int words,
            string publishWay, float pride)
        {
            string strsql = "select * from BookInfo";
            if (bookID != 0) strsql += " intersect select * from BookInfo where bookID = '" + bookID + "'";
            if (bookName.Length != 0) strsql += " intersect select * from BookInfo where bookName = '" + bookName + "'";
            if (publisher.Length != 0) strsql += " intersect select * from BookInfo where publisher = '" + publisher + "'";
            if (publishDate.Length != 0) strsql += " intersect select * from BookInfo where publishDate = '" + publishDate + "'";
            if (publishNum != 0) strsql += " intersect select * from BookInfo where publishNum = '" + publishNum + "'";
            if (words != 0) strsql += " intersect select * from BookInfo where words = '" + words + "'";
            if (publishWay.Length != 0) strsql += " intersect select * from BookInfo where publishWay = '" + publishWay + "'";
            if (pride != 0) strsql += " intersect select * from BookInfo where pride = '" + pride + "'";

            /*string strsql = "select * from BookInfo where bookID = '" + bookID + "'"
                + " select * from BookInfo where bookName = '" + bookName + "'"
                + "  select * from BookInfo where  publisher = '" + publisher + "'" + " select * from BookInfo where  publishDate = '" + publishDate + "'" + " select * from BookInfo where  publishNum = '" + publishNum + "'"
                + " select * from BookInfo where  words = '" + words + "'" + " select * from BookInfo where  publishWay = '" + publishWay + "'" + " select * from BookInfo where  pride = '" + pride + "'"
                ;*/

            return db.returnData(strsql);
        }

        public DataSet Flash(int bookID, string bookName, string publisher, string publishDate, int publishNum, int words,
            string publishWay, float pride)
        {
            string strsql = "select * from BookInfo";

            return db.returnData(strsql);
        }
    }
}
