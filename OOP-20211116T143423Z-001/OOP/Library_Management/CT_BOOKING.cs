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

        public ICollection<DANHMUCPHONG>  dsPhongDcSuDung { get; set; }

        public CT_BOOKING (CT_BOOKING ct)
        {
            this.booking = ct.booking;
            this.dsPhongDcSuDung = ct.dsPhongDcSuDung;
            this.loaiPhong = ct.loaiPhong;
        }

        public CT_BOOKING(LOAIPHONG loaiPhong, ICollection<DANHMUCPHONG> dsPhongDcSuDung, BOOKING booking)
        {
            this.booking = booking;
            this.loaiPhong = loaiPhong;
            this.dsPhongDcSuDung = dsPhongDcSuDung;
        }

    }
}
