using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NhanVien nv = new NhanVien("Nguyen Van A");

            MatHang keo = new MatHang("Keo", 1.35, 0.25);
            MatHang sua = new MatHang("Sua", 2.50, 0.0);
            MatHang banh = new MatHang("Banh mi", 1.80, 0.20);

            Console.WriteLine("=== HoaDon (khong giam) ===");
            HoaDon hd = new HoaDon(nv);
            hd.Them(keo);
            hd.Them(sua);
            hd.Them(banh);
            hd.InHoaDon();

            Console.WriteLine("\n=== HoaDonCoGiam (khach uu tien) ===");
            HoaDonCoGiam hdg = new HoaDonCoGiam(nv, true);
            hdg.Them(keo);
            hdg.Them(sua);
            hdg.Them(banh);
            hdg.InHoaDon();

            Console.WriteLine("\n=== HoaDonDong (mo rong voi so luong) ===");
            HoaDonDong hdd = new HoaDonDong(nv, true);
            hdd.Them(new DongHang(keo, 2));
            hdd.Them(new DongHang(sua, 1));
            hdd.Them(new DongHang(banh, 3));
            hdd.InHoaDon();
        }
    }
}
