using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace DAL
{
    public class DBbase
    {

        //读取配置文件 连接数据库语句
        public static string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        //实例化连接对象 con
        SqlConnection con = new SqlConnection(strCon);

        //检测连接是否打开
        public void chkConnection()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        //执行语句，返回该语句查询的数据行的总数
        public int returnRowCount(string strSQL)
        {
            chkConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
        }

        public DataSet returnData(string selectCommand)
        {
            chkConnection();
            
                SqlDataAdapter da = new SqlDataAdapter(selectCommand, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                return ds;
        }
        
        //执行语句，返回该语句影响的数据行的总数
        public int returnAffectRowCount(string strSQL)
        {
            chkConnection();
            int returnRowCount = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //此处不能再con.Open()
                //调用方法并接收返回数据库所受影响的行数
                returnRowCount = cmd.ExecuteNonQuery();
                return returnRowCount;
            }
            catch (Exception)
            {
                Console.WriteLine("执行错误");
                return 0;
            }
        }
    }
}

