using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using Project_1_NTAT_10119056_101191.DataAccessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;
using Project_1_NTAT_10119056_101191.Presenation;

namespace Project_1_NTAT_10119056_101191.BusinessLayer
{
    class SanPhamBLL : ISanPhamBLL
    {
        private ISanPhamDAL spDAL = new SanPhamDAL();
        public List<SanPham> ListSanPham()
        {
            return spDAL.ListSanPham();
        }
        public void HienSanPham()
        {
            List<SanPham> list = ListSanPham();
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
        public void ThemSanPham()
        {
            int sosp;
            Console.SetCursorPosition(45, 5);
            Console.Write("Nhập số sản phẩm cần nhập: "); sosp = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < sosp; i++)
            {
                Console.Clear();
                SanPham sp = new SanPham();
                bool ktma = false;
                do
                {
                    do
                    {
                        Console.SetCursorPosition(50, 5);
                        Console.WriteLine("NHẬP THÔNG TIN SẢN PHẨM");
                        Console.SetCursorPosition(50, 8);
                        Console.Write("Nhập mã sản phẩm  : "); sp.Masanpham = Console.ReadLine();
                    } while (string.IsNullOrEmpty(sp.Masanpham));
                    foreach (var x in ListSanPham())
                    {
                        if (sp.Masanpham == x.Masanpham)
                        {
                            ktma = true;
                            Console.Clear();
                            Console.SetCursorPosition(50, 25);
                            Console.WriteLine("Mã sản phẩm đã tồn tại!");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(50, 25);
                            Console.WriteLine("Nhập mã sản phẩm thành công!");
                            ktma = false;
                        }
                    }
                } while (ktma == true);
                do
                {
                    Console.SetCursorPosition(50, 9);
                    Console.Write("Nhập tên sản phẩm : "); sp.Tensanpham = Console.ReadLine();

                } while (string.IsNullOrEmpty(sp.Tensanpham));
                do
                {
                    Console.SetCursorPosition(50, 10);
                    Console.Write("Nhập loại         : "); sp.Loai = Console.ReadLine();

                } while (string.IsNullOrEmpty(sp.Loai));
                do
                {
                    Console.SetCursorPosition(50, 11);
                    Console.Write("Nhập số lượng     : "); sp.Soluong = int.Parse(Console.ReadLine());

                } while (sp.Soluong <= 0);
                do
                {
                    Console.SetCursorPosition(50, 12);
                    Console.Write("Nhập đơn giá      : "); sp.Dongia = int.Parse(Console.ReadLine());

                } while (sp.Dongia <= 0);
                spDAL.ThemSanPham(sp);
            }
        }
        public void SuaSanPham()
        {
            HienSanPham();
            Console.SetCursorPosition(37, 28); Console.Write("Nhập mã sản phẩm cần sửa: ");
            string masanpham;
            masanpham = Console.ReadLine();
            int i = 0;
            List<SanPham> list = ListSanPham();
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
                Console.Clear();

                Console.SetCursorPosition(37, 9); Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.SetCursorPosition(37, 10); Console.WriteLine("║              SỬA THÔNG TIN SẢN PHẨM          ║");
                Console.SetCursorPosition(37, 11); Console.WriteLine("╠══════╦═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 12); Console.WriteLine("║  F1  ║              SỬA MÃ                   ║");
                Console.SetCursorPosition(37, 13); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 14); Console.WriteLine("║  F2  ║              SỬA TÊN                  ║");
                Console.SetCursorPosition(37, 15); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 16); Console.WriteLine("║  F3  ║              SỬA LOẠI                 ║");
                Console.SetCursorPosition(37, 17); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 18); Console.WriteLine("║  F4  ║              SỬA SỐ LƯỢNG             ║");
                Console.SetCursorPosition(37, 19); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 20); Console.WriteLine("║  F5  ║              SỬA ĐƠN GIÁ              ║");
                Console.SetCursorPosition(37, 21); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 22); Console.WriteLine("║  F6  ║              SỬA TẤT CẢ               ║");
                Console.SetCursorPosition(37, 23); Console.WriteLine("╚══════╩═══════════════════════════════════════╝");

                ConsoleKeyInfo chon = Console.ReadKey();
                switch (chon.Key)
                {
                    case ConsoleKey.F1:
                        {
                            Console.Clear();
                            bool ktma = false;
                            do
                            {
                                Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN SẢN PHẨM ĐANG SỬA");
                                Console.SetCursorPosition(50, 3); Console.Write("Mã       : " + sp.Masanpham);
                                Console.SetCursorPosition(50, 4); Console.Write("Tên      : " + sp.Tensanpham);
                                Console.SetCursorPosition(50, 5); Console.Write("Loại     : " + sp.Loai);
                                Console.SetCursorPosition(50, 6); Console.Write("Số lượng : " + sp.Soluong);
                                Console.SetCursorPosition(50, 7); Console.Write("Đơn giá  : " + sp.Dongia);
                                Console.SetCursorPosition(50, 13); Console.Write("Nhập mã sản phẩm mới: ");
                                string mamoi = Console.ReadLine();
                                foreach (var x in ListSanPham())
                                {
                                    if (mamoi == x.Masanpham)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(50, 25);
                                        Console.WriteLine("Mã sản phẩm đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        if (!string.IsNullOrEmpty(mamoi))
                                        {
                                            sp.Masanpham = mamoi;
                                        }
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN SẢN PHẨM ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã       : " + sp.Masanpham);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên      : " + sp.Tensanpham);
                            Console.SetCursorPosition(50, 5); Console.Write("Loại     : " + sp.Loai);
                            Console.SetCursorPosition(50, 6); Console.Write("Số lượng : " + sp.Soluong);
                            Console.SetCursorPosition(50, 7); Console.Write("Đơn giá  : " + sp.Dongia);

                            Console.SetCursorPosition(50, 13); Console.WriteLine("Nhập tên sản phẩm mới: ");
                            Console.SetCursorPosition(73, 13);
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
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN SẢN PHẨM ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã       : " + sp.Masanpham);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên      : " + sp.Tensanpham);
                            Console.SetCursorPosition(50, 5); Console.Write("Loại     : " + sp.Loai);
                            Console.SetCursorPosition(50, 6); Console.Write("Số lượng : " + sp.Soluong);
                            Console.SetCursorPosition(50, 7); Console.Write("Đơn giá  : " + sp.Dongia);

                            Console.SetCursorPosition(50, 13); Console.WriteLine("Nhập loại sản phẩm mới: ");
                            Console.SetCursorPosition(74, 13);
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
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN SẢN PHẨM ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã       : " + sp.Masanpham);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên      : " + sp.Tensanpham);
                            Console.SetCursorPosition(50, 5); Console.Write("Loại     : " + sp.Loai);
                            Console.SetCursorPosition(50, 6); Console.Write("Số lượng : " + sp.Soluong);
                            Console.SetCursorPosition(50, 7); Console.Write("Đơn giá  : " + sp.Dongia);

                            Console.SetCursorPosition(45, 13); Console.WriteLine("Nhập số lượng sản phẩm mới: ");
                            Console.SetCursorPosition(78, 13);
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
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN SẢN PHẨM ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã       : " + sp.Masanpham);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên      : " + sp.Tensanpham);
                            Console.SetCursorPosition(50, 5); Console.Write("Loại     : " + sp.Loai);
                            Console.SetCursorPosition(50, 6); Console.Write("Số lượng : " + sp.Soluong);
                            Console.SetCursorPosition(50, 7); Console.Write("Đơn giá  : " + sp.Dongia);

                            Console.SetCursorPosition(45, 13); Console.WriteLine("Nhập đơn giá sản phẩm mới: ");
                            Console.SetCursorPosition(77, 13);
                            int giamoi = int.Parse(Console.ReadLine());
                            if (giamoi > 0)
                            {
                                sp.Dongia = giamoi;
                            }
                            break;
                        }
                    case ConsoleKey.F6:
                        {
                            Console.Clear();
                            bool ktma = false;
                            do
                            {
                                Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN SẢN PHẨM ĐANG SỬA");
                                Console.SetCursorPosition(50, 3); Console.Write("Mã       : " + sp.Masanpham);
                                Console.SetCursorPosition(50, 4); Console.Write("Tên      : " + sp.Tensanpham);
                                Console.SetCursorPosition(50, 5); Console.Write("Loại     : " + sp.Loai);
                                Console.SetCursorPosition(50, 6); Console.Write("Số lượng : " + sp.Soluong);
                                Console.SetCursorPosition(50, 7); Console.Write("Đơn giá  : " + sp.Dongia);

                                Console.SetCursorPosition(50, 13); Console.Write("Nhập mã sản phẩm mới: ");
                                string mamoi = Console.ReadLine();

                                foreach (var x in ListSanPham())
                                {
                                    if (mamoi == x.Masanpham)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(50, 25);
                                        Console.WriteLine("Mã sản phẩm đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        if (!string.IsNullOrEmpty(mamoi))
                                        {
                                            sp.Masanpham = mamoi;
                                        }
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            Console.SetCursorPosition(50, 14); Console.Write("Nhập tên sản phẩm mới: ");
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                sp.Tensanpham = tenmoi;
                            }
                            Console.SetCursorPosition(50, 15); Console.Write("Nhập loại sản phẩm mới: ");
                            string loaimoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(loaimoi))
                            {
                                sp.Loai = loaimoi;
                            }
                            Console.SetCursorPosition(50, 16); Console.Write("Nhập số lượng sản phẩm mới: ");
                            int soluongmoi = int.Parse(Console.ReadLine());
                            if (soluongmoi > 0)
                            {
                                sp.Soluong = soluongmoi;
                            }
                            Console.SetCursorPosition(50, 17); Console.Write("Nhập đơn giá sản phẩm mới: ");
                            int giamoi = int.Parse(Console.ReadLine());
                            if (giamoi > 0)
                            {
                                sp.Dongia = giamoi;
                            }
                            break;
                        }
                }
                Console.Clear();
                Console.SetCursorPosition(50, 9); Console.Write("THÔNG TIN SẢN PHẨM ĐÃ SỬA");
                Console.SetCursorPosition(50, 10); Console.Write("Mã       : " + sp.Masanpham);
                Console.SetCursorPosition(50, 11); Console.Write("Tên      : " + sp.Tensanpham);
                Console.SetCursorPosition(50, 12); Console.Write("Loại     : " + sp.Loai);
                Console.SetCursorPosition(50, 13); Console.Write("Số lượng : " + sp.Soluong);
                Console.SetCursorPosition(50, 14); Console.Write("Đơn giá  : " + sp.Dongia);
                list.RemoveAt(i);
                list.Add(sp);
                spDAL.CapNhatSanPham(list);

            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(45, 13);
                Console.WriteLine("Không tồn tại mã sản phẩm này");
            }
        }
        public void XoaSanPham(SanPham sp,string masanpham)
        {
            int i;
            List<SanPham> list = spDAL.ListSanPham();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Masanpham == masanpham)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(sp);
                spDAL.CapNhatSanPham(list);
            }
            else
            {
                Console.SetCursorPosition(45, 25);
                Console.WriteLine("Không tồn tại mã sản phẩm này");
            }
        }

        public void TimSanPham(string masanpham)
        {
            int i;
            List<SanPham> list = spDAL.ListSanPham();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Masanpham == masanpham)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.WriteLine(list[i].Masanpham + "\t" + list[i].Tensanpham + "\t" + list[i].Loai + "\t" + list[i].Soluong + "\t" + list[i].Dongia);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }
    }
}
