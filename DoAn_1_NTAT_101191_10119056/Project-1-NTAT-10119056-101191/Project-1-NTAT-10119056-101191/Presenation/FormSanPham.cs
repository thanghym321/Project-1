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
        public void Nhap()
        {
            Console.Clear();
            SanPham sp = new SanPham();
            char chon;
            do
            {
                Console.WriteLine("NHẬP THÔNG TIN SẢN PHẨM");
                do
                {
                    Console.Write("Nhập mã sản phẩm: "); sp.Masanpham = Console.ReadLine();

                } while (string.IsNullOrEmpty(sp.Masanpham));
                do
                {
                    Console.Write("Nhập tên sản phẩm: "); sp.Tensanpham = Console.ReadLine();

                } while (string.IsNullOrEmpty(sp.Tensanpham));
                do
                {
                    Console.Write("Nhập loại: "); sp.Loai = Console.ReadLine();

                } while (string.IsNullOrEmpty(sp.Masanpham));
                do
                {
                    Console.Write("Nhập số lượng: "); sp.Soluong = int.Parse(Console.ReadLine());

                } while (string.IsNullOrEmpty(sp.Masanpham));
                do
                {
                    Console.Write("Nhập đơn giá: "); sp.Dongia = int.Parse(Console.ReadLine());

                } while (string.IsNullOrEmpty(sp.Masanpham));

                Console.Write("Bạn có muốn nhập tiếp không? C/K: ");
                chon = char.Parse(Console.ReadLine());
                spBLL.ThemSanPham(sp);
            } while (chon=='c'|| chon=='C');

        }
        public void Hien()
        {
            Console.Clear();
            List<SanPham> list = spBLL.ListSanPham();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                    DANH SÁCH SẢN PHẨM                                                ║");
            Console.WriteLine("╠═══════╦═════════════════════════════════════════════════════════════════╦════════════╦═════════════╦═════════════════╣");
            Console.WriteLine("║  STT  ║   MÃ SẢN PHẨM   ║                  TÊN SẢN PHẨM                 ║    LOẠI    ║   SỐ LƯỢNG  ║     ĐƠN GIÁ     ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("║       ║                 ║                                               ║            ║             ║                 ║");
            Console.WriteLine("╚═══════╩═════════════════╩═══════════════════════════════════════════════╩════════════╩═════════════╩═════════════════╝");
            int i = 5;
            
            foreach (var sp in list)
            {
                    Console.SetCursorPosition(16, i); Console.WriteLine(sp.Masanpham);
                    Console.SetCursorPosition(30, i); Console.WriteLine(sp.Tensanpham);
                    Console.SetCursorPosition(79, i); Console.WriteLine(sp.Loai);
                    Console.SetCursorPosition(93, i); Console.WriteLine(sp.Soluong);
                    Console.SetCursorPosition(107, i); Console.WriteLine(sp.Dongia);
                i++;
            }
        }
        public void Sua()
        {
            Console.Clear();
            Hien();
<<<<<<< HEAD
            string masanpham;
=======
>>>>>>> 41d6eb4dab078cbb363386122560df750bf3c7c7
            Console.SetCursorPosition(37, 27); Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.SetCursorPosition(37, 28); Console.WriteLine("║     NHẬP MÃ SẢN PHẨM CẦN SỬA:               ║");
            Console.SetCursorPosition(37, 29); Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.SetCursorPosition(73, 28);
<<<<<<< HEAD

            masanpham = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
=======
            string masanpham;
            masanpham = Console.ReadLine();     
            int i = 0;
            List<SanPham> list = spBLL.ListSanPham();
            for (i = 0; i < list.Count; ++i)
>>>>>>> 41d6eb4dab078cbb363386122560df750bf3c7c7
            {
                if (list[i].Masanpham == masanpham) break;
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(37, 7); Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.SetCursorPosition(37, 8); Console.WriteLine("║              SỬA THÔNG TIN SẢN PHẨM          ║");
                Console.SetCursorPosition(37, 9); Console.WriteLine("╠══════╦═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 10); Console.WriteLine("║  F1  ║              SỬA MÃ                   ║");
                Console.SetCursorPosition(37, 11); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 12); Console.WriteLine("║  F2  ║              SỬA TÊN                  ║");
                Console.SetCursorPosition(37, 13); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 14); Console.WriteLine("║  F3  ║              SỬA LOẠI                 ║");
                Console.SetCursorPosition(37, 15); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 16); Console.WriteLine("║  F4  ║              SỬA SỐ LƯỢNG             ║");
                Console.SetCursorPosition(37, 17); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 18); Console.WriteLine("║  F5  ║              SỬA ĐƠN GIÁ              ║");
                Console.SetCursorPosition(37, 19); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 20); Console.WriteLine("║  F6  ║              QUAY LẠI                 ║");
                Console.SetCursorPosition(37, 21); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 22); Console.WriteLine("║  F7  ║         QUAY LẠI MENU SẢN PHẨM        ║");
                Console.SetCursorPosition(37, 23); Console.WriteLine("╚══════╩═══════════════════════════════════════╝");

                SanPham sp = new SanPham(list[i]);
                ConsoleKeyInfo chon = Console.ReadKey();
                switch (chon.Key)
                {
                    case ConsoleKey.F1:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(45, 12); Console.WriteLine("╔══════════════════════════════╗");
                            Console.SetCursorPosition(45, 13); Console.WriteLine("║ NHẬP MÃ SẢN PHẨM MỚI:        ║");
                            Console.SetCursorPosition(45, 14); Console.WriteLine("╚══════════════════════════════╝");
                            Console.SetCursorPosition(70, 13);
                            string mamoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(mamoi))
                            {
                                sp.Masanpham = mamoi;
                            }
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(27, 12); Console.WriteLine("╔══════════════════════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(27, 13); Console.WriteLine("║ NHẬP TÊN SẢN PHẨM MỚI:                                           ║");
                            Console.SetCursorPosition(27, 14); Console.WriteLine("╚══════════════════════════════════════════════════════════════════╝");
                            Console.SetCursorPosition(52, 13);
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                sp.Tensanpham = tenmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(38, 12); Console.WriteLine("╔════════════════════════════════════════════╗");
                            Console.SetCursorPosition(38, 13); Console.WriteLine("║ NHẬP LOẠI SẢN PHẨM MỚI:                    ║");
                            Console.SetCursorPosition(38, 14); Console.WriteLine("╚════════════════════════════════════════════╝");
                            Console.SetCursorPosition(65, 13);
                            string loaimoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(loaimoi))
                            {
                                sp.Loai = loaimoi;
                            }
                            break;
                        }
                    case ConsoleKey.F4:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(45, 12); Console.WriteLine("╔═══════════════════════════════════════════╗");
                            Console.SetCursorPosition(45, 13); Console.WriteLine("║ NHẬP SỐ LƯỢNG SẢN PHẨM MỚI:               ║");
                            Console.SetCursorPosition(45, 14); Console.WriteLine("╚═══════════════════════════════════════════╝");
                            Console.SetCursorPosition(75, 13);
                            int soluongmoi = int.Parse(Console.ReadLine());
                            if (soluongmoi > 0)
                            {
                                sp.Soluong = soluongmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F5:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(37, 12); Console.WriteLine("╔════════════════════════════════════════════╗");
                            Console.SetCursorPosition(37, 13); Console.WriteLine("║ NHẬP ĐƠN GIÁ SẢN PHẨM MỚI:                 ║");
                            Console.SetCursorPosition(37, 14); Console.WriteLine("╚════════════════════════════════════════════╝");
                            Console.SetCursorPosition(67, 13);
                            int giamoi = int.Parse(Console.ReadLine());
                            if (giamoi > 0)
                            {
                                sp.Dongia = giamoi;
                            }
                            break;
                        }
                    case ConsoleKey.F6:
                        {
                            Sua();
                            break;
                        }
                    case ConsoleKey.F7:
                        {
                            Menu();
                            break;
                        }

                }
                spBLL.SuaSanPham(sp,masanpham);
            }
            else
            {
                Console.WriteLine("Không tồn tại mã sản phẩm này");
            }
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
<<<<<<< HEAD
            for (i = 0; i < list.Count; i++)
=======
            List<SanPham> list = spBLL.ListSanPham();
            for (i = 0; i < list.Count; ++i)
>>>>>>> 41d6eb4dab078cbb363386122560df750bf3c7c7
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
                            Nhap();
                            Hien();
                            Console.SetCursorPosition(1, 27);
                            Console.WriteLine("Nhấn một phím bất kỳ để tiếp tục...");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            Sua();
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
