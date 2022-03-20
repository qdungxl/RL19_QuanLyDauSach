using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHAXUATBAN
    {
        public string MaNXB { get; set; }
        public string Ten { get; set; }
        public List<SACH> DsSach { get; set; }
        public NHAXUATBAN()
        {
            DsSach = new List<SACH>();
        }
        public override string ToString()
        {
            return Ten;
        }
    }
}
