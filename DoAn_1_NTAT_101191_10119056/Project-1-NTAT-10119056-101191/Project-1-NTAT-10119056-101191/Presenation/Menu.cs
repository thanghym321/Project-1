using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Presenation
{
    class Menu
    {
        public void MenuChinh()
        {
            Console.Clear();
            Console.SetCursorPosition(37, 4); Console.Write("CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG LINH KIỆN MÁY TÍNH");
            Console.SetCursorPosition(37, 5); Console.Write("  --------------------------------------------  ");

            Console.SetCursorPosition(37, 9); Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.SetCursorPosition(37, 10); Console.WriteLine("║                     MENU                     ║");
            Console.SetCursorPosition(37, 11); Console.WriteLine("╠══════╦═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 12); Console.WriteLine("║  F1  ║         QUẢN LÝ SẢN PHẨM              ║");
            Console.SetCursorPosition(37, 13); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 14); Console.WriteLine("║  F2  ║         QUẢN LÝ KHÁCH HÀNG            ║");
            Console.SetCursorPosition(37, 15); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 16); Console.WriteLine("║  F3  ║         QUẢN LÝ NHÂN VIÊN             ║");
            Console.SetCursorPosition(37, 17); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 18); Console.WriteLine("║  F4  ║         QUẢN LÝ HÓA ĐƠN               ║");
            Console.SetCursorPosition(37, 19); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 20); Console.WriteLine("║  F5  ║         QUAY VỀ TRANG MỞ ĐẦU          ║");
            Console.SetCursorPosition(37, 21); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 22); Console.WriteLine("║  F6  ║         THOÁT                         ║");
            Console.SetCursorPosition(37, 23); Console.WriteLine("╚══════╩═══════════════════════════════════════╝");

            ConsoleKeyInfo chon = Console.ReadKey();
            switch (chon.Key)
            {
                case ConsoleKey.F1:
                    {
                        Console.Clear();
                        FormSanPham spForm =new FormSanPham();
                        spForm.MenuSanPham();
                        Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                        Console.ReadKey();
                        break;
                    }
                case ConsoleKey.F2:
                    {
                        Console.Clear();
                        Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                        Console.ReadKey();
                        break;
                    }
                case ConsoleKey.F3:
                    {
                        Console.Clear();
                        Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                        Console.ReadKey();
                        break;
                    }
                case ConsoleKey.F4:
                    {
                        Console.Clear();
                        Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                        Console.ReadKey();
                        break;
                    }
                case ConsoleKey.F5:
                    {
                        Console.Clear();
                        Start t = new Start();
                        t.T();
                        break;
                    }
                case ConsoleKey.F6:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}
