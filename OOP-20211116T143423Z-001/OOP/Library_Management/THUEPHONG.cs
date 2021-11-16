using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class THUEPHONG
    {
        public string idHopDongTP { get; set; }
        public THANHTOANPHONG thanhtoan { get; set; }
        public NHANVIEN nv { get; set; }
        public string maPhong { get; set; }
        public string ngayThue { get; set; }
        public string ngayDangKyTra { get; set; }

        // foreign key
        public KHACHHANG khachHang { get; set; }

        public THUEPHONG(THUEPHONG hopdong)
        {
            this.idHopDongTP = hopdong.idHopDongTP;
            this.thanhtoan = hopdong.thanhtoan;
            this.nv = hopdong.nv;
            this.maPhong = hopdong.maPhong;
            this.ngayThue = hopdong.ngayThue;
            this.ngayDangKyTra = hopdong.ngayDangKyTra;
            this.khachHang = hopdong.khachHang;
        }

        public THUEPHONG(string idHopDongTP, THANHTOANPHONG thanhtoan, NHANVIEN nv, string maPhong,
            string ngayThue, string ngayDangKyTra, KHACHHANG khachHang)
        {
            this.idHopDongTP = idHopDongTP;
            this.thanhtoan = thanhtoan;
            this.nv = nv;
            this.maPhong = maPhong;
            this.ngayThue = ngayThue;
            this.ngayDangKyTra = ngayDangKyTra;
            this.khachHang = khachHang;
        }
    }
}
