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
    public class SACHDAL:DATADAL
    {
        public List<SACH> LaySachTheoNhaXuatBan(NHAXUATBAN nxb)
        {
            List<SACH> lsSach = new List<SACH>();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SACH where MaNXB=@manxb";
            command.Parameters.Add("@manxb", SqlDbType.NVarChar).Value = nxb.MaNXB;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SACH sach = new SACH();
                sach.MaSach = reader.GetString(0);
                sach.TenSach = reader.GetString(1);
                sach.DonGia = reader.GetInt32(2);
                sach.Loai = new LOAISACH() { MaLoai = reader.GetString(3) };
                sach.NhaXuatBan = nxb;
                lsSach.Add(sach);
            }
            reader.Close();
            return lsSach;
        }
        public List<SACH> LaySachTheoLoaiSach(LOAISACH loaiSach)
        {
            List<SACH> lsSach = new List<SACH>();
            openconn();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SACH where MaLoai=@maloai";
            command.Parameters.Add("@maloai", SqlDbType.NVarChar).Value = loaiSach.MaLoai;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SACH sach = new SACH();
                sach.MaSach = reader.GetString(0);
                sach.TenSach = reader.GetString(1);
                sach.DonGia = reader.GetInt32(2);
                sach.Loai = loaiSach;
                sach.NhaXuatBan = new NHAXUATBAN() { MaNXB = reader.GetString(4) };
                lsSach.Add(sach);
            }
            reader.Close();
            return lsSach;       
        }
    }
}
