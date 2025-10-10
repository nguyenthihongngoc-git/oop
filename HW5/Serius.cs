using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    // 4. Lớp Serius (Kế thừa từ Motor)
    public class Serius : Motor
    {
        public int warranty { get; set; }  // Thêm thuộc tính warranty

        public Serius(string code, string name, double capacity, int num, int warranty)
            : base(code, name, capacity, num)
        {
            this.warranty = warranty;
        }

        // Override phương thức inputInfor()
        public override void inputInfor()
        {
            base.inputInfor();
            Console.WriteLine("Nhập thời gian bảo hành (tháng): ");
            warranty = Convert.ToInt32(Console.ReadLine());
        }

        // Override phương thức displayInfor()
        public override void displayInfor()
        {
            base.displayInfor();
            Console.WriteLine($"Thời gian bảo hành: {warranty} tháng");
        }
    }
}
