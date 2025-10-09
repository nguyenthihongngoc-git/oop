using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamahaMotor.motor.yamaha;

namespace YamahaMotor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yamaha app = new Yamaha();
            app.ShowMenu();
            Console.WriteLine("Thoát chương trình. Tạm biệt!");
        }
    }
}
