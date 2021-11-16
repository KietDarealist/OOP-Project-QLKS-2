using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class CT_BOOKING
    {
        public BOOKING booking { get; set; }
        public LOAIPHONG loaiPhong { get; set; }

        public int soLuong { get; set; }

        public CT_BOOKING (CT_BOOKING ct)
        {
            this.booking = ct.booking;
            this.loaiPhong = ct.loaiPhong;
        }

        public CT_BOOKING(BOOKING booking, LOAIPHONG loaiPhong, int soLuong)
        {
            this.booking = booking;
            this.loaiPhong = loaiPhong;
        }

    }
}
