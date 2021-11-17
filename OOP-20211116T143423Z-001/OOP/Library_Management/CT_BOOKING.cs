using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class CT_BOOKING
    {
        public List<BOOKING> booking { get; set; }
        public LOAIPHONG loaiPhong { get; set; }

        public int soLuong { get; set; }

        public CT_BOOKING (CT_BOOKING ct)
        {
            this.booking = ct.booking;
            this.soLuong = ct.soLuong;
            this.loaiPhong = ct.loaiPhong;
        }

        public CT_BOOKING(LOAIPHONG loaiPhong, List<BOOKING> booking)
        {
            this.booking = booking;
            this.loaiPhong = loaiPhong;
            this.soLuong = booking.Count;
        }

    }
}
