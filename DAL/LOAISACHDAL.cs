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
    public class LOAISACHDAL:DATADAL
    {
        public List<LOAISACH> LayToanBoLoaiSach()
        {
            List<LOAISACH> dsLS = new List<LOAISACH>();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from LOAISACH";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LOAISACH ls = new LOAISACH();
                ls.MaLoai = reader.GetString(0);
                ls.TenLoai = reader.GetString(1);
                dsLS.Add(ls);
            }
            reader.Close();
            return dsLS;
        }
        public LOAISACH TimLoaiSachTheoMa(string maSach)
        {
            LOAISACH ls = new LOAISACH();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from LOAISACH where MaLoai = @ma";
            command.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maSach;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ls.MaLoai = reader.GetString(0);
                ls.TenLoai = reader.GetString(1);
            }           
            reader.Close();
            return ls;
        }
    }
}
