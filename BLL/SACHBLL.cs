using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SACHBLL
    {
        SACHDAL sachDal = new SACHDAL();
        public List<SACH> LaySachTheoNhaXuatBan(NHAXUATBAN nxb)
        {
            return sachDal.LaySachTheoNhaXuatBan(nxb);
        }
        public List<SACH> LaySachTheoLoaiSach(LOAISACH loaiSach)
        {
            return sachDal.LaySachTheoLoaiSach(loaiSach);
        }
        
    }
}
