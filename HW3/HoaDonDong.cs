using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class HoaDonDong
    {
        private NhanVien NhanVienBan;
        private List<DongHang> DanhSachDong = new List<DongHang>();
        private bool KhachUuTien;

        public HoaDonDong(NhanVien nhanVien, bool uuTien)
        {
            NhanVienBan = nhanVien;
            KhachUuTien = uuTien;
        }

        public void Them(DongHang dong)
        {
            DanhSachDong.Add(dong);
        }

        public double TongTien()
        {
            double tong = 0.0;
            foreach (var dong in DanhSachDong)
                tong += dong.TongTienDong(KhachUuTien);
            return tong;
        }

        public double TongTienGiam()
        {
            if (!KhachUuTien) return 0.0;
            double giam = 0.0;
            foreach (var dong in DanhSachDong)
                giam += dong.TongTienGiamDong();
            return giam;
        }

        public void InHoaDon()
        {
            Console.WriteLine($"Nhan vien: {NhanVienBan.Ten}");
            foreach (var dong in DanhSachDong)
                Console.WriteLine(dong);
            Console.WriteLine($"Tong tien: {TongTien():C}");
            if (KhachUuTien)
                Console.WriteLine($"Tong giam gia: {TongTienGiam():C}");
        }
    }
}
