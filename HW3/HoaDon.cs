using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class HoaDon
    {
        protected NhanVien NhanVienBan;
        protected List<MatHang> DanhSachHang = new List<MatHang>();

        public HoaDon(NhanVien nhanVien)
        {
            NhanVienBan = nhanVien;
        }

        public virtual void Them(MatHang hang)
        {
            DanhSachHang.Add(hang);
        }

        public virtual double TongTien()
        {
            double tong = 0.0;
            foreach (var hang in DanhSachHang)
                tong += hang.LayGia();
            return tong;
        }

        public virtual void InHoaDon()
        {
            Console.WriteLine($"Nhan vien: {NhanVienBan.Ten}");
            foreach (var hang in DanhSachHang)
                Console.WriteLine(hang);
            Console.WriteLine($"Tong tien: {TongTien():C}");
        }
    }
}
