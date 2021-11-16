using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class LOAIPHONG
    {
        public string idLoaiPhong { get; set; }
        public string tenLoaiPhong { get; set; }
        public int giaThue { get; set; }
        public int soNguoiToiDa { get; set; }

        //1 loai phong co nhieu phong
        public ICollection<DANHMUCPHONG> dsCacPhong { get; set; }


        public LOAIPHONG (LOAIPHONG lp)
        {
            this.idLoaiPhong = lp.idLoaiPhong;
            this.tenLoaiPhong = lp.idLoaiPhong;
            this.giaThue = lp.giaThue;
            this.soNguoiToiDa = lp.soNguoiToiDa;
            this.dsCacPhong = dsCacPhong;
        }
        public LOAIPHONG(string idLoaiPhong, string tenLoaiPhong,int giaThue,int soNguoiToiDa, ICollection<DANHMUCPHONG> dsCacPhong)
        {
            this.idLoaiPhong = idLoaiPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.giaThue = giaThue;
            this.soNguoiToiDa = soNguoiToiDa;
            this.dsCacPhong = dsCacPhong;
        }
    }
}
