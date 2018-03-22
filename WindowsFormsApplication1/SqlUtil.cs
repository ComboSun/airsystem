using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class SqlUtil
    {
        public static void ExcuteSql(string sql)
        {
            SqlConnection conn = new SqlConnection("server=192.168.1.6;database=scz;uid=sa;pwd=flybarrier");
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
        }
    }
}
