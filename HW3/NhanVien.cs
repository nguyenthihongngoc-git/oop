using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class NhanVien
    {
        public string Ten { get; set; }

        public NhanVien(string ten)
        {
            Ten = ten;
        }

        public override string ToString()
        {
            return $"Employee: {Ten}";
        }
    }
}
