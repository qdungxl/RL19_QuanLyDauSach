using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NHAXUATBANBLL
    {
        NHAXUATBANDAL NXBDAL = new NHAXUATBANDAL();
        /// <summary>
        /// Trả về danh sách nhà xuất bản.
        /// </summary>
        /// <returns></returns>
        public List<NHAXUATBAN> LayToanBoNhaXuatBan()
        {
            return NXBDAL.LayToanBoNhaXuatBan();
        }
        public NHAXUATBAN TimNXBTheoMa(string maNXB)
        {
            return NXBDAL.TimNXBTheoMa(maNXB);
        }
    }
}
