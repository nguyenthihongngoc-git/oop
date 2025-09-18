using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
     // /HoaDonCoGiam ke thua HoaDon
    public class HoaDonCoGiam : HoaDon
    {
        private bool KhachUuTien;
        private int SoLuongGiam = 0;
        private double TongTienGiam = 0.0;

        public HoaDonCoGiam(NhanVien nhanVien, bool uuTien) : base(nhanVien)
        {
            KhachUuTien = uuTien;
        }

        public override void Them(MatHang hang)
        {
            base.Them(hang);
            if (KhachUuTien && hang.LayGiamGia() > 0)
            {
                SoLuongGiam++;
                TongTienGiam += hang.LayGiamGia();
            }
        }

        public override double TongTien()
        {
            double tong = base.TongTien();
            if (KhachUuTien)
                return tong - TongTienGiam;
            return tong;
        }

        public int LaySoLuongGiam() => KhachUuTien ? SoLuongGiam : 0;
        public double LayTongTienGiam() => KhachUuTien ? TongTienGiam : 0.0;
        public double LayPhanTramGiam()
        {
            double truocGiam = base.TongTien();
            return KhachUuTien && truocGiam > 0
                ? (TongTienGiam / truocGiam) * 100
                : 0.0;
        }

        public override void InHoaDon()
        {
            base.InHoaDon();
            if (KhachUuTien)
            {
                Console.WriteLine($"So luong mat hang duoc giam: {LaySoLuongGiam()}");
                Console.WriteLine($"Tong so tien giam: {LayTongTienGiam():C}");
                Console.WriteLine($"Phan tram giam: {LayPhanTramGiam():F2}%");
            }
        }
    }
}
