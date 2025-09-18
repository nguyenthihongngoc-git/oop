using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    // Mo rong: Dòng Hàng
    public class DongHang
    {
        public MatHang Hang { get; private set; }
        public int SoLuong { get; private set; }

        public DongHang(MatHang hang, int soLuong)
        {
            Hang = hang;
            SoLuong = soLuong;
        }

        public void DatSoLuong(int soLuong) => SoLuong = soLuong;
        public int LaySoLuong() => SoLuong;
        public void DatMatHang(MatHang hang) => Hang = hang;
        public MatHang LayMatHang() => Hang;

        public double TongTienDong(bool uuTien)
        {
            if (uuTien)
                return (Hang.Gia - Hang.GiamGia) * SoLuong;
            else
                return Hang.Gia * SoLuong;
        }

        public double TongTienGiamDong()
        {
            return Hang.GiamGia * SoLuong;
        }

        public override string ToString()
        {
            return $"{Hang.Ten} x{SoLuong} - Don gia: {Hang.Gia:C}, Giam gia: {Hang.GiamGia:C}";
        }
    }
}
