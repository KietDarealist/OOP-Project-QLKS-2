using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Remove '*' in links
/// Link word theo doi cac mo hinh quan he da xong
/// https://docs.google.com*****/document/d/1o0aLr9lId_d-3c38bLvENN2rfCJo_ggA6UTrBrxJf4c/edit
/// link bai goc
/// http://dulieu.tailieuhoctap.vn*****/books/luan-van-de-tai/luan-van-de-tai-cd-dh/file_goc_784431.pdf
/// </summary>

namespace Library_Management
{
    class Program
    {
        // khai bao danh sach cac thuc the
        public static List<TIENTE> dsTienTe = new List<TIENTE>();
        public static List<KHACHHANG> dsKH = new List<KHACHHANG>();
        public static List<QUOCGIA> dsQG = new List<QUOCGIA>();
        public static List<BOOKING> dsBooking = new List<BOOKING>();
        public static List<NHANVIEN> dsNhanVien = new List<NHANVIEN>();
        public static List<THUEPHONG> dsThuePhong = new List<THUEPHONG>();
        public static List<THANHTOANPHONG> dsThanhToan = new List<THANHTOANPHONG>();
        public static List<LOAIPHONG> dsLoaiPhong = new List<LOAIPHONG>();
        public static List<DANHMUCPHONG> dsPhong = new List<DANHMUCPHONG>();
        public static List<CT_BOOKING> dsChiTietBooking = new List<CT_BOOKING>();
        public static List<THIETBIDICHVU> dsThietBi = new List<THIETBIDICHVU>();
        public static List<TRANGBI> dsTrangBi = new List<TRANGBI>();
        public static List<SUDUNG_DV> dsSuDung = new List<SUDUNG_DV>();

        public static void TaoDSChiTietBooking()
        {
            dsChiTietBooking.Add(new CT_BOOKING(dsLoaiPhong[0], new List<BOOKING>()));
            dsChiTietBooking.Add(new CT_BOOKING(dsLoaiPhong[1], new List<BOOKING>()));
            dsChiTietBooking.Add(new CT_BOOKING(dsLoaiPhong[2], new List<BOOKING>()));
            dsChiTietBooking.Add(new CT_BOOKING(dsLoaiPhong[3], new List<BOOKING>()));
      
            dsChiTietBooking[0].booking.Add(dsBooking[0]);
            dsChiTietBooking[0].booking.Add(dsBooking[1]);
            dsChiTietBooking[0].booking.Add(dsBooking[2]);

            dsChiTietBooking[1].booking.Add(dsBooking[3]);
            dsChiTietBooking[3].booking.Add(dsBooking[4]);








        }

        public static void TaoDSLoaiPhong()
        {
            dsLoaiPhong.Add(new LOAIPHONG("LP01","Phong Tinh Yeu", 500, 2, new List<DANHMUCPHONG>()));
            dsLoaiPhong.Add(new LOAIPHONG("LP02", "Phong Thuong Hang", 500, 6, new List<DANHMUCPHONG>()));
            dsLoaiPhong.Add(new LOAIPHONG("LP03", "Phong Trung Cap", 300, 4, new List<DANHMUCPHONG>()));
            dsLoaiPhong.Add(new LOAIPHONG("LP04", "Phong So Cap", 200, 2, new List<DANHMUCPHONG>()));

        }

        public static void TaoDSCacPhong()
        {
            dsPhong.Add(new DANHMUCPHONG("A100","Giuong bi sap","Phong cach lang man",dsLoaiPhong[0]));
            dsPhong.Add(new DANHMUCPHONG("A101", "Bi nghet bon cau", "Phong cach ma quai", dsLoaiPhong[0]));
            dsPhong.Add(new DANHMUCPHONG("A102", "Hoan Hao", "Phong cach hoang gia", dsLoaiPhong[1]));
            dsPhong.Add(new DANHMUCPHONG("A103", "Hu bong den", "Phong cach Tay au", dsLoaiPhong[2]));
            dsPhong.Add(new DANHMUCPHONG("A104", "Hu may lanh", "Phong cach Nga", dsLoaiPhong[2]));
            dsPhong.Add(new DANHMUCPHONG("A105", "Hu ti vi", "Phong cach binh dan", dsLoaiPhong[3]));
            dsPhong.Add(new DANHMUCPHONG("A106", "Giuong bi sap", "Phong cach binh dan", dsLoaiPhong[3]));

            dsLoaiPhong[0].dsCacPhong.Add(dsPhong[0]);
            dsLoaiPhong[0].dsCacPhong.Add(dsPhong[1]);
            dsLoaiPhong[1].dsCacPhong.Add(dsPhong[2]);
            dsLoaiPhong[2].dsCacPhong.Add(dsPhong[3]);
            dsLoaiPhong[2].dsCacPhong.Add(dsPhong[4]);
            dsLoaiPhong[3].dsCacPhong.Add(dsPhong[5]);
            dsLoaiPhong[3].dsCacPhong.Add(dsPhong[6]);

        }

        public static void TaoDSQuocGia()
        {
            dsQG.Add(new QUOCGIA("QG01","Nhat Ban"));
            dsQG.Add(new QUOCGIA("QG02", "Viet Nam"));
            dsQG.Add(new QUOCGIA("QG03", "Phap"));
            dsQG.Add(new QUOCGIA("QG04", "Campuchia"));
            dsQG.Add(new QUOCGIA("QG05", "Bo Dao Nha"));
            dsQG.Add(new QUOCGIA("QG06", "A rap xe ut"));

        }

        public static void TaoDSBooking()
        {
            dsBooking.Add(new BOOKING("BK01",dsKH[0] ,"11/15/2021", "11/15/2021", 100, dsNhanVien[0]));
            dsBooking.Add(new BOOKING("BK02",dsKH[1], "10/20/2021", "11/15/2021", 150, dsNhanVien[0]));
            dsBooking.Add(new BOOKING("BK03",dsKH[2], "10/19/2021", "11/14/2021", 70, dsNhanVien[1]));
            dsBooking.Add(new BOOKING("BK04",dsKH[3], "10/18/2021", "11/13/2021", 80 , dsNhanVien[1]));
            dsBooking.Add(new BOOKING("BK05",dsKH[4], "10/17/2021", "11/12/2021", 90, dsNhanVien[2]));

            dsNhanVien[0].dsBooking.Add(dsBooking[0]);
            dsNhanVien[0].dsBooking.Add(dsBooking[1]);
            dsNhanVien[1].dsBooking.Add(dsBooking[2]);
            dsNhanVien[1].dsBooking.Add(dsBooking[3]);
            dsNhanVien[2].dsBooking.Add(dsBooking[4]);
            



        }

        public static  void TaodsThuePhong()
        {
            dsThuePhong.Add(new THUEPHONG("HD01", null, dsNhanVien[0], dsPhong[0], "11/15/2021", "11/22/2021", dsKH[0]));
            dsThuePhong.Add(new THUEPHONG("HD02", null, dsNhanVien[0], dsPhong[1], "11/15/2021", "11/17/2021", dsKH[1]));
            dsThuePhong.Add(new THUEPHONG("HD03", null, dsNhanVien[1], dsPhong[2], "11/14/2021", "11/16/2021", dsKH[2]));
            dsThuePhong.Add(new THUEPHONG("HD04", null, dsNhanVien[1], dsPhong[3], "11/13/2021", "11/15/2021", dsKH[3]));
            dsThuePhong.Add(new THUEPHONG("HD05", null, dsNhanVien[2], dsPhong[4], "11/12/2021", "11/14/2021", dsKH[4]));

            dsNhanVien[0].dsThuePhong.Add(dsThuePhong[0]);
            dsNhanVien[0].dsThuePhong.Add(dsThuePhong[1]);
            dsNhanVien[1].dsThuePhong.Add(dsThuePhong[2]);
            dsNhanVien[1].dsThuePhong.Add(dsThuePhong[3]);
            dsNhanVien[2].dsThuePhong.Add(dsThuePhong[4]);

        }

        public static void TaodsThanhToan()
        {
            dsThanhToan.Add(new THANHTOANPHONG("TT01", dsThuePhong[0], dsNhanVien[0], "11/15/2021", 800, 40));
            dsThanhToan.Add(new THANHTOANPHONG("TT02", dsThuePhong[1], dsNhanVien[0], "11/15/2021", 200, 50));
            dsThanhToan.Add(new THANHTOANPHONG("TT03", dsThuePhong[2], dsNhanVien[1], "11/14/2021", 210, 50));
            dsThanhToan.Add(new THANHTOANPHONG("TT04", dsThuePhong[3], dsNhanVien[1], "11/14/2021", 220, 60));
            dsThanhToan.Add(new THANHTOANPHONG("TT05", dsThuePhong[4], dsNhanVien[2], "11/11/2021", 230, 60));

            dsNhanVien[0].dsThanhToan.Add(dsThanhToan[0]);
            dsNhanVien[0].dsThanhToan.Add(dsThanhToan[1]);
            dsNhanVien[1].dsThanhToan.Add(dsThanhToan[2]);
            dsNhanVien[1].dsThanhToan.Add(dsThanhToan[3]);
            dsNhanVien[2].dsThanhToan.Add(dsThanhToan[4]);

            dsThuePhong[0].thanhtoan = dsThanhToan[0];
            dsThuePhong[1].thanhtoan = dsThanhToan[1];
            dsThuePhong[2].thanhtoan = dsThanhToan[2];
            
            dsThuePhong[4].thanhtoan = dsThanhToan[4];
        }


        public static void TaoDSNhanVien()
        {
            dsNhanVien.Add(new NHANVIEN("NV01", "Doan Chan Hung", "01/01/2002", "Nam", "Thu Duc", "0818180226", "Tiep Tan", 500, "chanhung@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV02", "Vo Huynh Nhat Anh", "02/01/2002", "Nam", "Thu Duc", "0818180225", "Tiep Tan", 510, "nhatanh@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV03", "Le Van Hien", "03/01/2002", "Nam", "Dak Lak", "0818180224", "Tiep Tan", 520, "vanhien@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV04", "Nguyen Thanh Dien", "04/01/2002", "Nam", "Sa Dec", "0818180223", "Tiep Tan", 530, "thanhdien@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV05", "Tran Quoc Sieu", "05/01/2002", "Nam", "HCM", "0818180222", "Tiep Tan",540, "sieutran@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));

            dsNhanVien.Add(new NHANVIEN("NV06", "Vo Phuong Tram", "06/01/2002", "Nu", "Binh Thuan", "0818180221", "Le Tan", 400, "tramphuong@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV07", "Ha Qua Kieu Anh", "07/01/2002", "Nu", "Ninh Thuan", "0818180220", "Le Tan", 410, "kieuanh@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV08", "Phong My Uyen", "08/01/2002", "Nu", "Nha Trang", "0818180219", "Phuc vu phong", 420, "myuyen@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV09", "Nguyen Phuong Ngan", "09/01/2002", "Nu", "Da Lat", "0818180218", "Phuc vu phong", 430, "phuongngan@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));
            dsNhanVien.Add(new NHANVIEN("NV10", "Tran Mai Huyen", "10/01/2002", "Nu", "Thu Duc", "0818180217", "Ke toan", 440, "huyenmai@123", new List<BOOKING>(), new List<THUEPHONG>(), new List<THANHTOANPHONG>()));

        }

        public static void TaoDSTienTe()
        {
            // 5 loai tien te ( 0 -> 4 )
            dsTienTe.Add(new TIENTE("TT01", "Dollar", 22, "15-11-2020"));
            dsTienTe.Add(new TIENTE("TT02", "Euro", 25, "13-11-2018"));
            dsTienTe.Add(new TIENTE("TT03", "Ruppee", 15, "25-1-2021"));
            dsTienTe.Add(new TIENTE("TT04", "Nhan Dan Te", 5, "19-7-2019"));
            dsTienTe.Add(new TIENTE("TT05", "Bang Anh", 19, "17-4-2020"));
            
        }

        public static void TaoDSKhachHang()
        {
            // tao thong tin khach hang
            dsKH.Add(new KHACHHANG("KH01", "Quoc Phong", "56789", "01/22/2002", "Nam", "HCM", "03486725", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH02", "Tuan Kiet", "12345", "08/24/2003", "Nam", "London", "03497264", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH03", "Amee", "34867", "08/25/2002", "Nu", "Ha Noi", "02487913", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH04", "Ngoc Trinh", "56788", "05/22/2000", "Nu", "Long An", "034826751", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH05", "Gia Bao", "34821", "07/23/1999", "Nam", "Cu Chi", "09123487", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH06", "Quoc Phong", "31846", "04/02/2001", "Nam", "Truong Sa", "08348367", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH07", "Bich Phuong", "27915", "11/15/1986", "Nam", "Hoang Sa", "01784528", new List<TIENTE>(), new List<QUOCGIA>()));
            dsKH.Add(new KHACHHANG("KH08", "Quoc Phong", "91872", "12/09/1995", "Nam", "Tay Bac", "06172308", new List<TIENTE>(), new List<QUOCGIA>()));
            // them cac loai tien te ma khach hang su dung
            dsKH[0].tienTeSuDung.Add(dsTienTe[0]);
            dsKH[0].tienTeSuDung.Add(dsTienTe[4]);
            dsKH[1].tienTeSuDung.Add(dsTienTe[2]);
            dsKH[2].tienTeSuDung.Add(dsTienTe[1]);
            dsKH[3].tienTeSuDung.Add(dsTienTe[0]);
            dsKH[3].tienTeSuDung.Add(dsTienTe[3]);
            dsKH[4].tienTeSuDung.Add(dsTienTe[4]);
            dsKH[4].tienTeSuDung.Add(dsTienTe[3]);
            dsKH[5].tienTeSuDung.Add(dsTienTe[3]);
            dsKH[6].tienTeSuDung.Add(dsTienTe[1]);
            dsKH[6].tienTeSuDung.Add(dsTienTe[3]);
            dsKH[7].tienTeSuDung.Add(dsTienTe[0]);
            dsKH[7].tienTeSuDung.Add(dsTienTe[2]);
            // them Quoc Tich 
            dsKH[0].dsQuocTich.Add(dsQG[0]);
            dsKH[0].dsQuocTich.Add(dsQG[2]);
            dsKH[1].dsQuocTich.Add(dsQG[1]);
            dsKH[2].dsQuocTich.Add(dsQG[4]);
            dsKH[2].dsQuocTich.Add(dsQG[0]);
            dsKH[3].dsQuocTich.Add(dsQG[5]);
            dsKH[4].dsQuocTich.Add(dsQG[2]);
            dsKH[4].dsQuocTich.Add(dsQG[4]);
            dsKH[5].dsQuocTich.Add(dsQG[0]);
            dsKH[6].dsQuocTich.Add(dsQG[3]);
            dsKH[6].dsQuocTich.Add(dsQG[5]);
            dsKH[7].dsQuocTich.Add(dsQG[4]);

        }

        public static void TaoDSThietBi()
        {
            dsThietBi.Add(new THIETBIDICHVU("TB01", "Tu Lanh", 500));
            dsThietBi.Add(new THIETBIDICHVU("TB02", "May Say", 100));
            dsThietBi.Add(new THIETBIDICHVU("TB03", "Ti Vi", 300));
            dsThietBi.Add(new THIETBIDICHVU("TB04", "Bon Tam", 700));
            dsThietBi.Add(new THIETBIDICHVU("TB05", "Lo nuong", 400));
        }

        public static void TaoDSTrangBi()
        {
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[0], dsThietBi[0], 2));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[0], dsThietBi[1], 1));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[0], dsThietBi[2], 3));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[0], dsThietBi[3], 1));



            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[1], dsThietBi[0], 2));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[1], dsThietBi[1], 2));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[1], dsThietBi[2], 3));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[1], dsThietBi[3], 2));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[1], dsThietBi[4], 2));



            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[2], dsThietBi[0], 1));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[2], dsThietBi[1], 1));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[2], dsThietBi[2], 1));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[2], dsThietBi[3], 1));


            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[3], dsThietBi[0], 1));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[3], dsThietBi[1], 1));
            dsTrangBi.Add(new TRANGBI(dsLoaiPhong[3], dsThietBi[2], 1));
        }

        public static void TaoDSSuDung()
        {
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[0], dsThietBi[0], "11/22/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[0], dsThietBi[1], "11/22/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[0], dsThietBi[2], "11/22/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[0], dsThietBi[3], "11/22/2021", 1));

            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[1], dsThietBi[0], "11/17/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[1], dsThietBi[1], "11/17/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[1], dsThietBi[2], "11/17/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[1], dsThietBi[3], "11/17/2021", 1));


            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[2], dsThietBi[0], "11/16/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[2], dsThietBi[1], "11/16/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[2], dsThietBi[2], "11/16/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[2], dsThietBi[3], "11/16/2021", 1));

            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[3], dsThietBi[0], "11/15/2021", 1));
  
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[4], dsThietBi[0], "11/15/2021", 1));
            dsSuDung.Add(new SUDUNG_DV(dsThuePhong[4], dsThietBi[1], "11/15/2021", 1));
            
        }

   

        



        //Lay ra danh sach booking theo tung nhan vien
        public static void Linq01()
        {
            var bookingGroups =
                from b in dsBooking
                group b by b.nv.idNV into newBooking
                select new { NhanVien = newBooking.Key, Bookings = newBooking };

            Console.WriteLine("Truy van Linq01\n");
           
            foreach(var g in bookingGroups)
            {
                Console.WriteLine("Nhung booking thuc hien boi: {0} ", g.NhanVien);
                foreach(var b in g.Bookings)
                {
                    Console.WriteLine("Ma Booking: {0} \t Ho ten khach hang: {1} \t Thanh Pho: {2}",b.idBooking, b.kh.hoTen, b.kh.thanhPho);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("---------------------------------------------------");
        }

        //Chon ra danh sach cac hop dong o khong qua 2 ngay
        public static void Linq02()
        {
            var hopDongs =
                from h in dsThuePhong
                where Convert.ToDateTime(h.ngayDangKyTra).Day - Convert.ToDateTime(h.ngayThue).Day <= 2
                select h;

            Console.WriteLine("Truy van Linq02\n");

            Console.WriteLine("Nhung hop dong co thoi gian thue khong qua 2 ngay");
        
            foreach(var h in hopDongs)
            {
                Console.WriteLine("- Hop Dong: {0} - Nhan Vien: {1} \nKhachHang: {5} - Ma Phong: {2} - Ngay thue {3} - Ngay Tra {4}",
                    h.idHopDongTP, h.nv.idNV, h.phong.idPhong, h.ngayThue, h.ngayDangKyTra, h.khachHang.hoTen);            
            }
            Console.WriteLine("---------------------------------------------------");

        }

        //In ra tong so tien duoc tips cua moi nhan vien
        public static void Linq03()
        {
            var tipsNhanVien =
                 from nhanvien in dsNhanVien
                 from thanhtoan in dsThanhToan
                 where thanhtoan.nv.idNV == nhanvien.idNV
                 select new { idNV = nhanvien.idNV, tienDichVu = thanhtoan.tienDichVu };
           var groupingNhanVien =
                from nv in tipsNhanVien
                group nv by nv.idNV into newNV
                select new { NhanVien = newNV.Key, TongTips = newNV.Sum(nv => nv.tienDichVu) };

            Console.WriteLine("Truy van Linq03");

            Console.WriteLine("\nTong so tien duoc tips cua moi nhan vien");

                foreach(var g in groupingNhanVien)
                { 
                Console.WriteLine("Nhan Vien {0} - Tong tips: {1}", g.NhanVien, g.TongTips);
                }

            Console.WriteLine("---------------------------------------------------");

        }

        //Chon ra quoc gia booking nhieu nhat
        public static void Linq04()
        {
            var bookingsGroup =
                from bk in dsBooking
                from quoctich in bk.kh.dsQuocTich
                group bk by quoctich.tenNuoc into newbk
                select new { nuoc = newbk.Key, bookings = newbk };

            Console.WriteLine("Truy van Linq04\n");

            foreach (var b in bookingsGroup)
            {
                Console.WriteLine("Quoc gia: {0}", b.nuoc);
                foreach (var bk in b.bookings)
                {
                    Console.WriteLine("- Booking ID: {0}, Ten Khach Hang: {1}, Ngay Booking: {2}", bk.idBooking, bk.kh.hoTen, bk.ngayDangKy);
                }
                Console.Write("\n");
            }

            Console.WriteLine("---------------------------------------------------");

        }

        //Sap xep danh sach  booking theo thu tu tu dang ky som nhat den tre nhat
        public static void Linq05()
        {
            var sortedBookingsByRegisterDay =
                from b in dsBooking
                orderby Convert.ToDateTime(b.ngayDangKy)
                select b;

            var sortedBookingsByReceivedDay =
                from b in dsBooking
                orderby Convert.ToDateTime(b.ngayNhan)
                select b;

            Console.WriteLine("Truy van Linq05\n");


            Console.WriteLine("Sap xep danh sach Booking theo ngay dang ky: ");
            foreach (var s in sortedBookingsByRegisterDay)
            {
                Console.WriteLine("Booking ID: {0} - Ten Khach Hang: {1} - Ngay dang ky: {2}", s.idBooking, s.kh.hoTen, s.ngayDangKy);
            }

            Console.WriteLine("\nSap xep danh sach Booking theo ngay nhan phong: ");
            foreach (var s in sortedBookingsByReceivedDay)
            {
                Console.WriteLine("Booking ID: {0} - Ten Khach Hang: {1} - Ngay nhan: {2}", s.idBooking, s.kh.hoTen, s.ngayNhan);
            }
            Console.WriteLine("---------------------------------------------------");

        }

        //Sap xep cac loai phong theo thu tu duoc dat it den duoc dat nhieu nhat
        public static void Linq06()
        {
            var groupedDsCacPhong =
                from d in dsChiTietBooking
                group d by d.loaiPhong into newCTBooking
                select new { LoaiPhong = newCTBooking.Key, ChiTiet = newCTBooking };


            var sortedDSCacPhong =
                from g in groupedDsCacPhong
                from soluong in g.ChiTiet
                orderby soluong.booking.Count
                select g;

            Console.WriteLine("Truy van Linq06\n");

            foreach(var s in sortedDSCacPhong)
            {
                Console.WriteLine("Loai Phong: {0}", s.LoaiPhong.tenLoaiPhong);
                foreach (var c in s.ChiTiet)
                {
                    Console.WriteLine("So Luong Dat: {0} ", c.booking.Count);
                }
            }

            Console.WriteLine("---------------------------------------------------");

        }

        //In ra danh sach nhung hop dong da thanh toan tien truoc ngay tra phong
        public static void Linq07()
        {
            var payedBeforeLeaveContracts =
                from d in dsThanhToan
                where Convert.ToDateTime(d.ngayThanhToan) <= Convert.ToDateTime(d.hopdong.ngayDangKyTra)
                select d;

            var notPayedBeforeLeaveContracts =
                from d in dsThuePhong
                where d.thanhtoan == null
                select d;

            Console.WriteLine("Truy van Linq07\n");


            Console.WriteLine("Danh sach nhung phong da thanh toan truoc ngay tra: ");
            foreach (var p in payedBeforeLeaveContracts)
                Console.WriteLine("ID Hop Dong: {0} - Ma Phong: {1}  - Ngay tra phong: {2} - Ngay thanh toan: {3}", p.hopdong.idHopDongTP, p.hopdong.phong.idPhong, p.hopdong.ngayDangKyTra, p.ngayThanhToan);


            Console.WriteLine("\nDanh sach nhung phong chua thanh toan: ");
            foreach (var n in notPayedBeforeLeaveContracts)
                Console.WriteLine("ID Hop Dong: {0} - Ma Phong: {1} - Loai Phong: {2}  - Ngay Tra Phong: {3} - Ngay thanh toan: {4}", n.idHopDongTP, n.phong.idPhong, n.phong.loaiPhong.tenLoaiPhong, n.ngayDangKyTra, "Unknown");

            Console.WriteLine("---------------------------------------------------");
        }

        //In ra danh sach nhan vien va khach hang trong khach san
        public static void Linq08()
        {
            var customersInfo =
                from d in dsKH
                select new { Ten = d.hoTen, GioiTinh = d.gioiTinh };

            var employeesInfo =
                from e in dsNhanVien
                
                select new { Ten = e.hoTen, GioiTinh = e.gioiTinh };

            var allCustomersAndEmpoyeesInfo = customersInfo.Concat(employeesInfo);

            Console.WriteLine("Truy van Linq08\n");

            Console.WriteLine("Danh sach nhan vien va khach hang o khach san: ");
            foreach(var a in allCustomersAndEmpoyeesInfo)
            {
                Console.WriteLine("Ho va ten: {0} \t Gioi tinh: {1}", a.Ten, a.GioiTinh);
            }

            Console.WriteLine("---------------------------------------------------");

        }

        //In ra thong tin nhan vien nhom boi so lan booking
        public static void Linq09()
        {
            var groupNVByBookingTimes =
                 from n in dsNhanVien
                 group n by n.dsBooking.Count into newNV
                 select new { SoLan = newNV.Key, ChiTiet = newNV };

            Console.WriteLine("Truy van Linq09\n");

           foreach(var g in groupNVByBookingTimes)
            {
                Console.WriteLine("So lan: {0}", g.SoLan);
                foreach (var i in g.ChiTiet)
                {
                    Console.WriteLine("MSNV: {0} \t Ten Nhan Vien {1}", i.idNV, i.hoTen);
                    foreach (var b in  i.dsBooking)
                    {
                        Console.WriteLine("ID Booking: {0} - Ngay Booking: {1} - Ten khach hang: {2}", b.idBooking, b.ngayDangKy, b.kh.hoTen);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------");
        }


        //In ra ten (khong bao gom ho) danh sach nv theo gioi tinh va theo que quan
        public static void Linq10()
        {
            var groupNVByGender =
            from d in dsNhanVien
            group d by d.gioiTinh into newNV
            select new { GioiTinh = newNV.Key, ChiTiet = newNV };

            var groupNVByHomeTown =
            from d in dsNhanVien
            group d by d.queQuan into newNV
            select new { QueQuan = newNV.Key, ChiTiet = newNV };


            Console.WriteLine("Truy van Linq10\n");

            Console.WriteLine("Danh sach nhan vien theo gioi tinh: ");

            foreach(var g in groupNVByGender)
            {
                Console.WriteLine("Gioi tinh: {0}", g.GioiTinh);
                foreach (var c in g.ChiTiet)
                {
                    Console.WriteLine("Ten: {0} ", c.hoTen.Split(' ').Reverse().First());
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nDanh sach nhan vien theo que quan: ");
            foreach (var g in groupNVByHomeTown)
            {
                Console.WriteLine("Que quan: {0}", g.QueQuan);
                foreach (var c in g.ChiTiet)
                {
                    Console.WriteLine("Ten: {0} ", c.hoTen.Split(' ').Reverse().First());
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------");
        }

        public static void Linq11()
        {
            // lambda
            foreach (var a in dsLoaiPhong)
            {
                Console.WriteLine("Loai phong: {0}", a.tenLoaiPhong);
                foreach (var b in a.dsCacPhong)
                {
                    Console.WriteLine(b.idPhong);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            //Tạo các danh sách
            TaoDSQuocGia();
            TaoDSLoaiPhong();
            TaoDSCacPhong();
            TaoDSTienTe();
            TaoDSNhanVien();
            TaoDSKhachHang();
            TaoDSBooking();
            TaodsThuePhong();
            TaodsThanhToan();
            TaoDSThietBi();
            TaoDSTrangBi();
            TaoDSSuDung();
            TaoDSChiTietBooking();

            //Kiet
            Linq01();    
            Linq02();   
            Linq03();    
            Linq04();   
            Linq05();    
            Linq06();    
            Linq07();    
            Linq08();   
            Linq09();    
            Linq10();



            //Phong
            //Linq11();   


            Console.ReadKey();

        }
    }
}
