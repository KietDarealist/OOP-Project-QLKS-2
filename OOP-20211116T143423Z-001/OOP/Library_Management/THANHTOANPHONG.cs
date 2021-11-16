using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class THANHTOANPHONG
    {
        public string idThanhToan { get; set; }
        public THUEPHONG hopdong { get; set; }
        public NHANVIEN nv { get; set; }
        public string ngayThanhToan { get; set; }
        public int tienPhong { get; set; }
        public int tienDichVu { get; set; }

        public THANHTOANPHONG (THANHTOANPHONG ttp)
        {
            this.idThanhToan = ttp.idThanhToan;
            this.hopdong = ttp.hopdong;
            this.nv = ttp.nv;
            this.ngayThanhToan = ttp.ngayThanhToan;
            this.tienPhong = ttp.tienPhong;
            this.tienDichVu = ttp.tienDichVu;

        }

        public THANHTOANPHONG(string idThanhToan, THUEPHONG hopdong, NHANVIEN nv, string ngayThanhToan, int tienPhong, int tienDichVu)
        {
            this.idThanhToan = idThanhToan;
            this.hopdong = hopdong;
            this.nv = nv;
            this.ngayThanhToan = ngayThanhToan;
            this.tienPhong =tienPhong;
            this.tienDichVu = tienDichVu;

        }

    }
}
