using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Presenation
{
    class Start
    {
        public void T()
        {
            Console.SetCursorPosition(40, 1); Console.Write("TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN");
            Console.SetCursorPosition(40, 2); Console.Write("        KHOA CÔNG NGHỆ THÔNG TIN        ");
            Console.SetCursorPosition(40, 3); Console.Write("          --------------------          ");

            Console.SetCursorPosition(35, 5); Console.Write("CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG LINH KIỆN MÁY TÍNH");
            Console.SetCursorPosition(35, 6); Console.Write("  --------------------------------------------  ");

            Console.SetCursorPosition(40, 8); Console.Write("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(40, 9); Console.Write("█                                    █");
            Console.SetCursorPosition(40, 10); Console.Write("█           ▄ ▀▄     ▄               █");
            Console.SetCursorPosition(40, 11); Console.Write("█          ▀ ▀      ▀                █");
            Console.SetCursorPosition(40, 12); Console.Write("█   █▀▀▄  ▄▀▀▀▄   ▄▀▀▄  █▄  █   ▄█   █");
            Console.SetCursorPosition(40, 13); Console.Write("█  ■█■ █  █   █   █▄▄█  █ █ █    █   █");
            Console.SetCursorPosition(40, 14); Console.Write("█   █▄▄▀  ▀▄▄▄▀   █  █  █  ▀█   ▄█▄  █");
            Console.SetCursorPosition(40, 15); Console.Write("█                                    █");
            Console.SetCursorPosition(40, 16); Console.Write("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");

            Console.SetCursorPosition(40, 20); Console.Write("Giảng viên hướng dẫn : Ngô Thanh Huyền");
            Console.SetCursorPosition(40, 22); Console.Write("Sinh Viên Thực Hiện  : Nguyễn Trần Anh Thắng");
            Console.SetCursorPosition(40, 24); Console.Write("Lớp                  : 101191");

            Console.SetCursorPosition(85, 27); Console.Write("Nhấn phím Enter để tiếp tục");
            Console.SetCursorPosition(85, 28); Console.Write("Nhấn phím bất kỳ để thoát");
            ConsoleKeyInfo chon = Console.ReadKey();
            switch (chon.Key)
            {
                case ConsoleKey.Enter:
                    {
                        Console.Clear();
                        Menu t = new Menu();
                        t.MenuChinh();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }

        }
    }
}
