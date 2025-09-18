using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class MatHang
    {
        public string Ten { get; set; }
        public double Gia { get; set; }
        public double GiamGia { get; set; } // so tien giam gia cho khach uu tien

        public MatHang(string ten, double gia, double giamGia = 0.0)
        {
            Ten = ten;
            Gia = gia;
            GiamGia = giamGia;
        }

        public double LayGia() => Gia;
        public double LayGiamGia() => GiamGia;

        public override string ToString()
        {
            return $"{Ten} - Gia: {Gia:C}, Giam gia: {GiamGia:C}";
        }
    }
}
