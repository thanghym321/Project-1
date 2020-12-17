using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;
using Project_1_NTAT_10119056_101191.BusinessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer;

namespace Project_1_NTAT_10119056_101191.Presenation
{
    class FormSanPham
    {
        private SanPhamBLL spBLL = new SanPhamBLL();
        public void Hien()
        {
            Console.Clear();
            List<SanPham> list = spBLL.ListSanPham();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                    DANH SÁCH SẢN PHẨM                                                ║");
            Console.WriteLine("╠═════════════════╦═══════════════════════════════════════════════════╦════════════════╦═════════════╦═════════════════╣");
            Console.WriteLine("║   MÃ SẢN PHẨM   ║                  TÊN SẢN PHẨM                     ║      LOẠI      ║   SỐ LƯỢNG  ║     ĐƠN GIÁ     ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("║                 ║                                                   ║                ║             ║                 ║");
            Console.WriteLine("╚═════════════════╩═══════════════════════════════════════════════════╩════════════════╩═════════════╩═════════════════╝");
            int i = 5;
            
            foreach (var sp in list)
            {
                    Console.SetCursorPosition(7, i); Console.WriteLine(sp.Masanpham);
                    Console.SetCursorPosition(22, i); Console.WriteLine(sp.Tensanpham);
                    Console.SetCursorPosition(75, i); Console.WriteLine(sp.Loai);
                    Console.SetCursorPosition(93, i); Console.WriteLine(sp.Soluong);
                    Console.SetCursorPosition(107, i); Console.WriteLine(sp.Dongia);
                i++;
            }
        }
        public void Sua()
        {
            Console.SetCursorPosition(37, 5); Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.SetCursorPosition(37, 6); Console.WriteLine("║              SỬA THÔNG TIN SẢN PHẨM          ║");
            Console.SetCursorPosition(37, 7); Console.WriteLine("╠══════╦═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 8); Console.WriteLine("║  F1  ║              SỬA MÃ                   ║");
            Console.SetCursorPosition(37, 9); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 10); Console.WriteLine("║  F2  ║              SỬA TÊN                  ║");
            Console.SetCursorPosition(37, 11); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 12); Console.WriteLine("║  F3  ║              SỬA LOẠI                 ║");
            Console.SetCursorPosition(37, 13); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 14); Console.WriteLine("║  F4  ║              SỬA SỐ LƯỢNG             ║");
            Console.SetCursorPosition(37, 15); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 16); Console.WriteLine("║  F5  ║              SỬA ĐƠN GIÁ              ║");
            Console.SetCursorPosition(37, 17); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 18); Console.WriteLine("║  F6  ║              SỬA TẤT CẢ               ║");
            Console.SetCursorPosition(37, 19); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 20); Console.WriteLine("║  F7  ║              QUAY LẠI                 ║");
            Console.SetCursorPosition(37, 21); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
            Console.SetCursorPosition(37, 22); Console.WriteLine("║  F8  ║         QUAY LẠI MENU SẢN PHẨM        ║");
            Console.SetCursorPosition(37, 23); Console.WriteLine("╚══════╩═══════════════════════════════════════╝");
        }
        public void Xoa()
        {
            Console.Clear();
            Hien();
            Console.SetCursorPosition(37, 27); Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.SetCursorPosition(37, 28); Console.WriteLine("║     NHẬP MÃ SẢN PHẨM CẦN XÓA:               ║");
            Console.SetCursorPosition(37, 29); Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.SetCursorPosition(73, 28); 
            string masanpham;
            masanpham = Console.ReadLine();
            int i = 0;
            List<SanPham> list = spBLL.ListSanPham();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Masanpham == masanpham)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                SanPham sp = new SanPham(list[i]);
                spBLL.XoaSanPham(sp,masanpham);
            }
            else
            {
                Console.WriteLine("Không tồn tại mã sản phẩm này");
            }

        }
        public void TimSanPham()
        {
            Console.Clear();
            Console.Write("Nhập mã sản phẩm cần tìm: "); string masanpham = Console.ReadLine();
            spBLL.TimSanPham(masanpham);
        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Menu menu = new Menu();
                Console.SetCursorPosition(37, 8); Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.SetCursorPosition(37, 9); Console.WriteLine("║                QUẢN LÝ SẢN PHẨM                ║");
                Console.SetCursorPosition(37, 10); Console.WriteLine("╠══════╦═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 11); Console.WriteLine("║  F1  ║             HIỂN THỊ SẢN PHẨM           ║");
                Console.SetCursorPosition(37, 12); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 13); Console.WriteLine("║  F2  ║             NHẬP SẢN PHẨM               ║");
                Console.SetCursorPosition(37, 14); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 15); Console.WriteLine("║  F3  ║             SỬA SẢN PHẨM                ║");
                Console.SetCursorPosition(37, 16); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 17); Console.WriteLine("║  F4  ║             XÓA SẢN PHẨM                ║");
                Console.SetCursorPosition(37, 18); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 19); Console.WriteLine("║  F5  ║             TÌM KIẾM SẢN PHẨM           ║");
                Console.SetCursorPosition(37, 20); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 21); Console.WriteLine("║  F6  ║             THỐNG KÊ SẢN PHẨM           ║");
                Console.SetCursorPosition(37, 22); Console.WriteLine("╠══════╬═════════════════════════════════════════╣");
                Console.SetCursorPosition(37, 23); Console.WriteLine("║  F7  ║             QUAY LẠI                    ║");
                Console.SetCursorPosition(37, 24); Console.WriteLine("╚══════╩═════════════════════════════════════════╝");

                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        {
                            Hien();
                            Console.SetCursorPosition(1, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            spBLL.ThemSanPham();
                            Hien();
                            Console.SetCursorPosition(1, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            spBLL.SuaSanPham();
                            Hien();
                            Console.SetCursorPosition(1, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F4:
                        {
                            Xoa();
                            Hien();
                            Console.SetCursorPosition(1, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F5:
                        {
                            TimSanPham();
                            Console.SetCursorPosition(1, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F6:
                        {
                            break;
                        }
                    case ConsoleKey.F7:
                        {
                            menu.MenuChinh();
                            break;
                        }
                }
            } while (true);
        }
    }
}
