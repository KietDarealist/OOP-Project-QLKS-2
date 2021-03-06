using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class NHANVIEN
    {
       // NHANVIEN(idNV, HoTen , NgaySinh, GioiTinh, queQuan,
       //         SoDienThoai , ChucVu, Luong, MatKhau)

        public string idNV { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string queQuan { get; set; }
        public string sdt { get; set; }
        public string chucVu { get; set; }
        public int luong { get; set; }
        public string matKhau { get; set; }

        //1 Nhan Vien co the co nhieu booking
        public ICollection<BOOKING> dsBooking;
        //1 Nhan vien co the lam nhieu hop dong
        public ICollection<THUEPHONG> dsThuePhong;
        //1 Nhan vien co the lap nhieu hoa don
        public ICollection<THANHTOANPHONG> dsThanhToan;

        public NHANVIEN(NHANVIEN nv)
        {
            this.idNV = nv.idNV;
            this.hoTen = nv.hoTen;
            this.ngaySinh = nv.ngaySinh;
            this.gioiTinh = nv.gioiTinh;
            this.queQuan = nv.queQuan;
            this.sdt = nv.sdt;
            this.chucVu = nv.chucVu;
            this.luong = nv.luong;
            this.matKhau = nv.matKhau;
            this.dsBooking = nv.dsBooking;
            this.dsThuePhong = nv.dsThuePhong;
            this.dsThanhToan = nv.dsThanhToan;
        }


        public NHANVIEN(string idNV, string hoTen,
        string ngaySinh, string gioiTinh, string queQuan,
        string sdt, string chucVu, int luong, string matKhau,
        ICollection<BOOKING> dsBooking, ICollection<THUEPHONG> dsThuePhong,
        ICollection<THANHTOANPHONG> dsThanhToan)
        {
            this.idNV = idNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.queQuan = queQuan;
            this.sdt = sdt;
            this.chucVu = chucVu;
            this.luong = luong;
            this.matKhau = matKhau;
            this.dsBooking = dsBooking;
            this.dsThuePhong = dsThuePhong;
            this.dsThanhToan =dsThanhToan;
        }
      
    }
}
