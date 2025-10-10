using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor
{
    // 5. Lớp Yamaha
    public class Yamaha
    {
        private List<Motor> motors = new List<Motor>();

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1. Input 2. Display 3. Sort 4. Search 5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Input();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Sort();
                        break;
                    case 4:
                        Search();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Chọn không hợp lệ!");
                        break;
                }
            }
        }

        // Nhập thông tin xe, yêu cầu nhập tối thiểu 3 xe Jupiter và 3 xe Serius
        private void Input()
        {
            Console.WriteLine("Nhập thông tin cho Jupiter và Serius");

            // Nhập tối thiểu 3 xe Jupiter
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Nhập thông tin cho Jupiter thứ {i + 1}:");
                Jupiter jupiter = new Jupiter("J" + (i + 1), "Jupiter", 125, 5, 12);  // Thêm thông tin mặc định
                jupiter.inputInfor();  // Gọi phương thức nhập thông tin
                motors.Add(jupiter);  // Thêm vào danh sách xe
            }

            // Nhập tối thiểu 3 xe Serius
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Nhập thông tin cho Serius thứ {i + 1}:");
                Serius serius = new Serius("S" + (i + 1), "Serius", 150, 6, 24);  // Thêm thông tin mặc định
                serius.inputInfor();  // Gọi phương thức nhập thông tin
                motors.Add(serius);  // Thêm vào danh sách xe
            }
        }

        // Hiển thị thông tin xe
        private void Display()
        {
            foreach (var motor in motors)
            {
                motor.displayInfor();
                Console.WriteLine("------------------------------");
            }
        }

        // Sắp xếp theo thời gian bảo hành
        private void Sort()
        {
            var sortedMotors = motors.OrderBy(m => m is Jupiter j ? j.warranty : (m is Serius s ? s.warranty : 0)).ToList();

            Console.WriteLine("Thông tin sau khi sắp xếp theo thời gian bảo hành:");
            foreach (var motor in sortedMotors)
            {
                motor.displayInfor();
                Console.WriteLine("------------------------------");
            }
        }

        // Tìm kiếm xe theo tên "Serius"
        private void Search()
        {
            var searchResults = motors.Where(m => m is Serius).ToList();

            Console.WriteLine("Các xe có tên là 'Serius':");
            foreach (var motor in searchResults)
            {
                motor.displayInfor();
                Console.WriteLine("------------------------------");
            }
        }
    }
}
