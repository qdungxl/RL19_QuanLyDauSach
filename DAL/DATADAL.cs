using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DATADAL
    {
        string sqlconn = @"Data Source=QUOCDUNGSURFACE\SQLEXPRESS01;Initial Catalog=CSDL_BTRL19_QuanLyDauSach;Integrated Security=True";
        protected SqlConnection conn = null;
        public void openconn()
        {
            if (conn == null)
                conn = new SqlConnection(sqlconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void closeconn()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
