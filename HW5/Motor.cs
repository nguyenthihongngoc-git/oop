using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    // 2. Lớp Motor
    public class Motor : IMotor
    {
        public string code { get; set; }
        public string name { get; set; }
        public double capacity { get; set; }
        public int num { get; set; }

        // Constructor
        public Motor(string code, string name, double capacity, int num)
        {
            this.code = code;
            this.name = name;
            this.capacity = capacity;
            this.num = num;
        }

        // Phương thức inputInfor()
        public virtual void inputInfor()
        {
            Console.WriteLine("Nhập mã xe: ");
            code = Console.ReadLine();
            Console.WriteLine("Nhập tên loại xe: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập dung tích xi lanh: ");
            capacity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập kiểu truyền lực: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        // Phương thức displayInfor()
        public virtual void displayInfor()
        {
            Console.WriteLine($"Mã xe: {code}");
            Console.WriteLine($"Tên loại xe: {name}");
            Console.WriteLine($"Dung tích xi lanh: {capacity}");
            Console.WriteLine($"Kiểu truyền lực: {num}");
        }

        // Phương thức changeInfor()
        public void changeInfor()
        {
            Console.WriteLine("Nhập thông tin mới cho xe: ");
            inputInfor();
        }
    }
}
