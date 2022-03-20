using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LOAISACH
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public List<SACH> DsSach { get; set; }
        public LOAISACH()
        {
            DsSach = new List<SACH>();
        }
        public override string ToString()
        {
            return TenLoai;
        }
    }
}
