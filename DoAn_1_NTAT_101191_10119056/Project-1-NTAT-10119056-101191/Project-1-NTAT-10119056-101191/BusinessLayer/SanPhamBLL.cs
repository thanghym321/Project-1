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
        public void ThemSanPham()
        {
            Console.Clear();
            SanPham sp = new SanPham();
            char chon;
            do
            {

                bool ktma = false;
                do
                {
                    do
                    {
                        Console.SetCursorPosition(50, 5);
                        Console.WriteLine("NHẬP THÔNG TIN SẢN PHẨM");
                        Console.SetCursorPosition(50, 8);
                        Console.Write("Nhập mã sản phẩm: "); sp.Masanpham = Console.ReadLine();
                    }while(string.IsNullOrEmpty(sp.Masanpham));
                    foreach(var x in ListSanPham())
                    {
                        if (sp.Masanpham == x.Masanpham)
                        {
                            ktma = true;
                            Console.Clear();
                            Console.SetCursorPosition(50, 25);
                            Console.WriteLine("Mã sản phẩm đã tồn tại");
                            break;
                        }
                        else
                        {
                            ktma = false;
                        }
                    }
                } while (ktma ==true);
                do
                {
                    Console.SetCursorPosition(50, 9);
                    Console.Write("Nhập tên sản phẩm: "); sp.Tensanpham = Console.ReadLine();

                } while (string.IsNullOrEmpty(sp.Tensanpham));
                do
                {
                    Console.SetCursorPosition(50, 10);
                    Console.Write("Nhập loại: "); sp.Loai = Console.ReadLine();

                } while (string.IsNullOrEmpty(sp.Loai));
                do
                {
                    Console.SetCursorPosition(50, 11);
                    Console.Write("Nhập số lượng: "); sp.Soluong = int.Parse(Console.ReadLine());

                } while (sp.Soluong<=0);
                do
                {
                    Console.SetCursorPosition(50, 12);
                    Console.Write("Nhập đơn giá: "); sp.Dongia = int.Parse(Console.ReadLine());

                } while (sp.Dongia<=0);
                Console.SetCursorPosition(50, 25);
                Console.Write("Bạn có muốn nhập tiếp không? C/K: ");
                chon = char.Parse(Console.ReadLine());
                spDAL.ThemSanPham(sp);
                Console.Clear();
            } while (chon == 'c' || chon == 'C');

        }

        public void SuaSanPham()
        {
            Console.Clear();
            FormSanPham spForm = new FormSanPham();
            spForm.Hien();
            Console.SetCursorPosition(37, 28); Console.Write("NHẬP MÃ SẢN PHẨM CẦN SỬA: ");
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
                else
                {
                    Console.SetCursorPosition(45, 25);
                    Console.WriteLine("Không tồn tại mã sản phẩm này");
                }
            }
            if (i < list.Count)
            {            
                SanPham sp = new SanPham(list[i]);
                char kt;
                do
                {
                    Console.Clear();
                    spForm.Sua();
                    ConsoleKeyInfo chon = Console.ReadKey();
                    switch (chon.Key)
                    {
                        case ConsoleKey.F1:
                            {
                                Console.Clear();
                                bool ktma = false;
                                do
                                {
                                    Console.SetCursorPosition(50, 13); Console.WriteLine("NHẬP MÃ SẢN PHẨM MỚI: ");
                                    Console.SetCursorPosition(72, 13);
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
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                break;
                            }
                        case ConsoleKey.F2:
                            {
                                Console.Clear();
                                Console.SetCursorPosition(50, 13); Console.WriteLine("NHẬP TÊN SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(73, 13);
                                string tenmoi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(tenmoi))
                                {
                                    sp.Tensanpham = tenmoi;
                                }
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                break;
                            }
                        case ConsoleKey.F3:
                            {
                                Console.Clear();
                                Console.SetCursorPosition(50, 13); Console.WriteLine("NHẬP LOẠI SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(74, 13);
                                string loaimoi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(loaimoi))
                                {
                                    sp.Loai = loaimoi;
                                }
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                break;
                            }
                        case ConsoleKey.F4:
                            {
                                Console.Clear();
                                Console.SetCursorPosition(50, 13); Console.WriteLine("NHẬP SỐ LƯỢNG SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(78, 13);
                                int soluongmoi = int.Parse(Console.ReadLine());
                                if (soluongmoi > 0)
                                {
                                    sp.Soluong = soluongmoi;
                                }
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                break;
                            }
                        case ConsoleKey.F5:
                            {
                                Console.Clear();
                                Console.SetCursorPosition(50, 13); Console.WriteLine("NHẬP ĐƠN GIÁ SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(77, 13);
                                int giamoi = int.Parse(Console.ReadLine());
                                if (giamoi > 0)
                                {
                                    sp.Dongia = giamoi;
                                }
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                break;
                            }
                        case ConsoleKey.F6:
                            {
                                Console.Clear();
                                bool ktma = false;
                                do
                                {
                                    Console.SetCursorPosition(50, 8); Console.WriteLine("NHẬP MÃ SẢN PHẨM MỚI: ");
                                    Console.SetCursorPosition(72, 8);
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
                                Console.SetCursorPosition(50, 9); Console.WriteLine("NHẬP TÊN SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(73, 9);
                                string tenmoi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(tenmoi))
                                {
                                    sp.Tensanpham = tenmoi;
                                }
                                Console.SetCursorPosition(50, 10); Console.WriteLine("NHẬP LOẠI SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(74, 10);
                                string loaimoi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(loaimoi))
                                {
                                    sp.Loai = loaimoi;
                                }
                                Console.SetCursorPosition(50, 11); Console.WriteLine("NHẬP SỐ LƯỢNG SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(78, 11);
                                int soluongmoi = int.Parse(Console.ReadLine());
                                if (soluongmoi > 0)
                                {
                                    sp.Soluong = soluongmoi;
                                }
                                Console.SetCursorPosition(50, 12); Console.WriteLine("NHẬP ĐƠN GIÁ SẢN PHẨM MỚI: ");
                                Console.SetCursorPosition(77, 12);
                                int giamoi = int.Parse(Console.ReadLine());
                                if (giamoi > 0)
                                {
                                    sp.Dongia = giamoi;
                                }
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                break;
                            }
                        case ConsoleKey.F7:
                            {
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                SuaSanPham();
                                break;
                            }
                        case ConsoleKey.F8:
                            {
                                list.RemoveAt(i);
                                list.Add(sp);
                                spDAL.CapNhatSanPham(list);
                                spForm.Menu();
                                break;
                            }
                    }
                    Console.SetCursorPosition(45, 25);
                    Console.Write("Bạn có muốn sửa tiếp không? C/K: ");
                    kt = char.Parse(Console.ReadLine());
                } while (kt == 'c' || kt == 'C');              
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
                spDAL.CapNhatSanPham(list);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
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
