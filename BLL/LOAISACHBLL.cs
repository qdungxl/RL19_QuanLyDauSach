using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LOAISACHBLL
    {
        LOAISACHDAL loaisachdal = new LOAISACHDAL();
        public List<LOAISACH> LayToanBoLoaiSach()
        {
            return loaisachdal.LayToanBoLoaiSach();
        }
        public LOAISACH TimLoaiSachTheoMa(string maSach)
        {
            return loaisachdal.TimLoaiSachTheoMa(maSach);
        }
    }
}
