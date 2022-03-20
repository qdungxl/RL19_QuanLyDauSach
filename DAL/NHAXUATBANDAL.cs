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
    public class NHAXUATBANDAL:DATADAL
    {
        /// <summary>
        /// Trả về danh sách nhà xuất bản.
        /// </summary>
        /// <returns></returns>
        public List<NHAXUATBAN> LayToanBoNhaXuatBan()
        {
            List<NHAXUATBAN> lsNXB = new List<NHAXUATBAN>();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from NHAXUATBAN";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NHAXUATBAN nxb = new NHAXUATBAN();
                nxb.MaNXB = reader.GetString(0);
                nxb.Ten = reader.GetString(1);
                lsNXB.Add(nxb);
            }
            reader.Close();
            return lsNXB;
        }
        public NHAXUATBAN TimNXBTheoMa(string maNXB)
        {
            NHAXUATBAN nxb = new NHAXUATBAN();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from NHAXUATBAN where MaNXB=@ma";
            command.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maNXB;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                nxb.MaNXB = reader.GetString(0);
                nxb.Ten = reader.GetString(1);
            }
            reader.Close();
            return nxb;
        }
    }
}
