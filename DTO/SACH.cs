using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SACH
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int DonGia { get; set; }
        public LOAISACH Loai { get; set; }
        public NHAXUATBAN NhaXuatBan { get; set; }
        public override string ToString()
        {
            return TenSach;
        }
    }
}
