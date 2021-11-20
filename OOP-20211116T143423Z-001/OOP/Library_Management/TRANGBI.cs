using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class TRANGBI
    {
        public LOAIPHONG lp { get; set; }
        public THIETBIDICHVU thietbi { get; set; }
        public int soluong { get; set; }


        public TRANGBI(TRANGBI tb)
        {
            this.lp = tb.lp;
            this.thietbi = tb.thietbi;
            this.soluong = tb.soluong;
        }

        public TRANGBI(LOAIPHONG lp, THIETBIDICHVU
            thietbi, int soluong)
        {
            this.lp = lp;
            this.thietbi = thietbi;
            this.soluong = soluong;
        }
    }
}
