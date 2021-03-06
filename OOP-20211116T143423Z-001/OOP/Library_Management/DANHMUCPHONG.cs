using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class DANHMUCPHONG
    {
        public string idPhong { get; set; }
        public string tinhTrang { get; set; }
        public string dacDiem { get; set; }
    
        // 1 phong thuoc ve 1 loai phong
        public LOAIPHONG loaiPhong { get; set; }

        public DANHMUCPHONG (DANHMUCPHONG dmp)
        {
            this.idPhong = dmp.idPhong;
            this.tinhTrang = dmp.tinhTrang;
            this.dacDiem = dmp.dacDiem;
            this.loaiPhong = dmp.loaiPhong;
        }

        public DANHMUCPHONG (string idPhong, string tinhTrang, string dacDiem, LOAIPHONG loaiPhong)
        {
            this.idPhong = idPhong;
            this.tinhTrang = tinhTrang;
            this.dacDiem = dacDiem;
            this.loaiPhong = loaiPhong;
        }

    }
}
