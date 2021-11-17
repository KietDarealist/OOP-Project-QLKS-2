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
        public DANHMUCPHONG phong { get; set; }
        public string ngayThue { get; set; }
        public string ngayDangKyTra { get; set; }

        // foreign key
        public KHACHHANG khachHang { get; set; }

        public THUEPHONG(THUEPHONG hopdong)
        {
            this.idHopDongTP = hopdong.idHopDongTP;
            this.thanhtoan = hopdong.thanhtoan;
            this.nv = hopdong.nv;
            this.phong = hopdong.phong;
            this.ngayThue = hopdong.ngayThue;
            this.ngayDangKyTra = hopdong.ngayDangKyTra;
            this.khachHang = hopdong.khachHang;
        }

        public THUEPHONG(string idHopDongTP, THANHTOANPHONG thanhtoan, NHANVIEN nv,  DANHMUCPHONG phong,
            string ngayThue, string ngayDangKyTra, KHACHHANG khachHang)
        {
            this.idHopDongTP = idHopDongTP;
            this.thanhtoan = thanhtoan;
            this.nv = nv;
            this.phong = phong;
            this.ngayThue = ngayThue;
            this.ngayDangKyTra = ngayDangKyTra;
            this.khachHang = khachHang;
        }
    }
}
