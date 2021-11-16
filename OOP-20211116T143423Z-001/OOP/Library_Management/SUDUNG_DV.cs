using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class SUDUNG_DV
    {
        public THUEPHONG tp { get; set; }
        public THIETBIDICHVU thietbi { get; set; }
        public string ngaySuDung { get; set; }
        public int soLuong { get; set; }

        public SUDUNG_DV(SUDUNG_DV dv)
        {
            this.tp = tp;
            this.thietbi = thietbi;
            this.ngaySuDung = ngaySuDung;
            this.soLuong = soLuong;
        }

        public SUDUNG_DV(THUEPHONG tp, THIETBIDICHVU thietbi,
            string ngaySuDung, int soLuong)
        {
            this.tp = tp;
            this.thietbi = thietbi;
            this.ngaySuDung = ngaySuDung;
            this.soLuong = soLuong;
        }
    }
}
