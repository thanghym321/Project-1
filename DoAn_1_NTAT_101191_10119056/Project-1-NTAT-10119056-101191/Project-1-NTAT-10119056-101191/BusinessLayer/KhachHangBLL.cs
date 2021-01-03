using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using Project_1_NTAT_10119056_101191.DataAccessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;

namespace Project_1_NTAT_10119056_101191.BusinessLayer
{
    class KhachHangBLL : IKhachHangBLL
    {
        private IKhachHangDAL khDAL = new KhachHangDAL();
        public List<KhachHang> ListKhachHang()
        {
            return khDAL.ListKhachHang();
        }
        public void HienKhachHang()
        {
            List<KhachHang> list = ListKhachHang();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                    DANH SÁCH KHÁCH HÀNG                                              ║");
            Console.WriteLine("╠═══════════════╦══════════════════════════════════╦═══════════════════════════════════════════════╦═══════════════════╣");
            Console.WriteLine("║ MÃ KHÁCH HÀNG ║          TÊN KHÁCH HÀNG          ║                    ĐỊA CHỈ                    ║   SỐ ĐIỆN THOẠI   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("║               ║                                  ║                                               ║                   ║");
            Console.WriteLine("╚═══════════════╩══════════════════════════════════╩═══════════════════════════════════════════════╩═══════════════════╝");
            int i = 5;

            foreach (var x in list)
            {
                Console.SetCursorPosition(7, i); Console.Write(x.Makhachhang);
                Console.SetCursorPosition(20, i); Console.Write(x.Tenkhachhang);
                Console.SetCursorPosition(55, i); Console.Write(x.Diachi);
                Console.SetCursorPosition(105, i); Console.Write(x.Sodienthoai);
                i++;
            }
        }
        public void ThemKhachHang()
        {
            Console.SetCursorPosition(40, 13);
            Console.Write("Nhập số khách hàng cần nhập: "); int sokh = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < sokh; i++)
            {
                Console.Clear();
                KhachHang kh = new KhachHang();
                bool ktma = false;
                do
                {
                    do
                    {
                        Console.SetCursorPosition(48, 5);
                        Console.WriteLine("NHẬP THÔNG TIN KHÁCH HÀNG");
                        Console.SetCursorPosition(48, 8);
                        Console.Write("Nhập mã khách hàng  : "); kh.Makhachhang = Console.ReadLine();
                    } while (string.IsNullOrEmpty(kh.Makhachhang));
                    foreach (var x in ListKhachHang())
                    {
                        if (kh.Makhachhang == x.Makhachhang)
                        {
                            ktma = true;
                            Console.Clear();
                            Console.SetCursorPosition(48, 25);
                            Console.WriteLine("Mã khách hàng đã tồn tại!");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(48, 25);
                            Console.WriteLine("Nhập mã khách hàng thành công!");
                            ktma = false;
                        }
                    }
                } while (ktma == true);
                do
                {
                    Console.SetCursorPosition(48, 9);
                    Console.Write("Nhập tên khách hàng : "); kh.Tenkhachhang = Console.ReadLine();

                } while (string.IsNullOrEmpty(kh.Tenkhachhang));
                do
                {
                    Console.SetCursorPosition(48, 10);
                    Console.Write("Nhập địa chỉ        : "); kh.Diachi = Console.ReadLine();

                } while (string.IsNullOrEmpty(kh.Diachi));
                do
                {
                    Console.SetCursorPosition(48, 11);
                    Console.Write("Nhập số điện thoại  : "); kh.Sodienthoai = int.Parse(Console.ReadLine());

                } while (kh.Sodienthoai == 10);
                khDAL.ThemKhachHang(kh);
            }
        }
        public void SuaKhachHang()
        {
            HienKhachHang();
            Console.SetCursorPosition(35, 28); Console.Write("Nhập mã khách hàng cần sửa: ");
            string makhachhang = Console.ReadLine();
            int i = 0;
            List<KhachHang> list = ListKhachHang();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Makhachhang == makhachhang)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                KhachHang kh = new KhachHang(list[i]);
                Console.Clear();

                Console.SetCursorPosition(37, 9); Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.SetCursorPosition(37, 10); Console.WriteLine("║              SỬA THÔNG TIN KHÁCH HÀNG        ║");
                Console.SetCursorPosition(37, 11); Console.WriteLine("╠══════╦═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 12); Console.WriteLine("║  F1  ║              SỬA MÃ                   ║");
                Console.SetCursorPosition(37, 13); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 14); Console.WriteLine("║  F2  ║              SỬA TÊN                  ║");
                Console.SetCursorPosition(37, 15); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 16); Console.WriteLine("║  F3  ║              SỬA ĐỊA CHỈ              ║");
                Console.SetCursorPosition(37, 17); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 18); Console.WriteLine("║  F4  ║              SỬA SỐ ĐIỆN THOẠI        ║");
                Console.SetCursorPosition(37, 19); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 20); Console.WriteLine("║  F5  ║              SỬA TẤT CẢ               ║");
                Console.SetCursorPosition(37, 21); Console.WriteLine("╚══════╩═══════════════════════════════════════╝");

                ConsoleKeyInfo chon = Console.ReadKey();
                switch (chon.Key)
                {
                    case ConsoleKey.F1:
                        {
                            Console.Clear();
                            bool ktma = false;
                            do
                            {
                                Console.SetCursorPosition(48, 2); Console.Write("THÔNG TIN KHÁCH HÀNG ĐANG SỬA");
                                Console.SetCursorPosition(48, 3); Console.Write("Mã Khách hàng  : " + kh.Makhachhang);
                                Console.SetCursorPosition(48, 4); Console.Write("Tên khách hàng : " + kh.Tenkhachhang);
                                Console.SetCursorPosition(48, 5); Console.Write("Địa chỉ        : " + kh.Diachi);
                                Console.SetCursorPosition(48, 6); Console.Write("Số điện thoại  : " + kh.Sodienthoai);
                                Console.SetCursorPosition(48, 13); Console.Write("Nhập mã khách hàng mới: ");
                                string mamoi = Console.ReadLine();
                                foreach (var x in ListKhachHang())
                                {
                                    if (mamoi == x.Makhachhang)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(48, 25);
                                        Console.WriteLine("Mã khách hàng đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        kh.Makhachhang = mamoi;
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(48, 2); Console.Write("THÔNG TIN KHÁCH HÀNG ĐANG SỬA");
                            Console.SetCursorPosition(48, 3); Console.Write("Mã Khách hàng  : " + kh.Makhachhang);
                            Console.SetCursorPosition(48, 4); Console.Write("Tên khách hàng : " + kh.Tenkhachhang);
                            Console.SetCursorPosition(48, 5); Console.Write("Địa chỉ        : " + kh.Diachi);
                            Console.SetCursorPosition(48, 6); Console.Write("Số điện thoại  : " + kh.Sodienthoai);

                            Console.SetCursorPosition(48, 13); Console.Write("Nhập tên khách hàng mới: ");
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                kh.Tenkhachhang = tenmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(48, 2); Console.Write("THÔNG TIN KHÁCH HÀNG ĐANG SỬA");
                            Console.SetCursorPosition(48, 3); Console.Write("Mã Khách hàng  : " + kh.Makhachhang);
                            Console.SetCursorPosition(48, 4); Console.Write("Tên khách hàng : " + kh.Tenkhachhang);
                            Console.SetCursorPosition(48, 5); Console.Write("Địa chỉ        : " + kh.Diachi);
                            Console.SetCursorPosition(48, 6); Console.Write("Số điện thoại  : " + kh.Sodienthoai);

                            Console.SetCursorPosition(48, 13); Console.Write("Nhập địa chỉ mới   : ");
                            string diachimoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(diachimoi))
                            {
                                kh.Diachi = diachimoi;
                            }
                            break;
                        }
                    case ConsoleKey.F4:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(48, 2); Console.Write("THÔNG TIN KHÁCH HÀNG ĐANG SỬA");
                            Console.SetCursorPosition(48, 3); Console.Write("Mã Khách hàng  : " + kh.Makhachhang);
                            Console.SetCursorPosition(48, 4); Console.Write("Tên khách hàng : " + kh.Tenkhachhang);
                            Console.SetCursorPosition(48, 5); Console.Write("Địa chỉ        : " + kh.Diachi);
                            Console.SetCursorPosition(48, 6); Console.Write("Số điện thoại  : " + kh.Sodienthoai);

                            Console.SetCursorPosition(48, 13); Console.Write("Nhập số điện thoại mới: ");
                            int sdtmoi = int.Parse(Console.ReadLine());
                            if (sdtmoi == 10)
                            {
                                kh.Sodienthoai = sdtmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F5:
                        {
                            Console.Clear();
                            bool ktma = false;
                            do
                            {
                                Console.SetCursorPosition(48, 2); Console.Write("THÔNG TIN KHÁCH HÀNG ĐANG SỬA");
                                Console.SetCursorPosition(48, 3); Console.Write("Mã Khách hàng  : " + kh.Makhachhang);
                                Console.SetCursorPosition(48, 4); Console.Write("Tên khách hàng : " + kh.Tenkhachhang);
                                Console.SetCursorPosition(48, 5); Console.Write("Địa chỉ        : " + kh.Diachi);
                                Console.SetCursorPosition(48, 6); Console.Write("Số điện thoại  : " + kh.Sodienthoai);

                                Console.SetCursorPosition(48, 13); Console.Write("Nhập mã khách hàng mới: ");
                                string mamoi = Console.ReadLine();

                                foreach (var x in ListKhachHang())
                                {
                                    if (mamoi == x.Makhachhang)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(48, 25);
                                        Console.WriteLine("Mã khách hàng đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        kh.Makhachhang = mamoi;
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            Console.SetCursorPosition(48, 14); Console.Write("Nhập tên khách hàng mới: ");
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                kh.Tenkhachhang = tenmoi;
                            }
                            Console.SetCursorPosition(48, 15); Console.Write("Nhập địa chỉ mới: ");
                            string diachimoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(diachimoi))
                            {
                                kh.Diachi = diachimoi;
                            }
                            Console.SetCursorPosition(48, 16); Console.Write("Nhập số điện thoại mới: ");
                            int sdtmoi = int.Parse(Console.ReadLine());
                            if (sdtmoi == 10)
                            {
                                kh.Sodienthoai = sdtmoi;
                            }
                            break;
                        }
                }
                Console.Clear();
                Console.SetCursorPosition(43, 9); Console.Write("THÔNG TIN KHÁCH HÀNG ĐÃ SỬA");
                Console.SetCursorPosition(43, 10); Console.Write("Mã khách hàng  : " + kh.Makhachhang);
                Console.SetCursorPosition(43, 11); Console.Write("Tên khách hàng : " + kh.Tenkhachhang);
                Console.SetCursorPosition(43, 12); Console.Write("Địa chỉ        : " + kh.Diachi);
                Console.SetCursorPosition(43, 13); Console.Write("Số điện thoại  : " + kh.Sodienthoai);
                list.RemoveAt(i);
                list.Add(kh);
                khDAL.CapNhatKhachHang(list);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(43, 13);
                Console.Write("Không tồn tại mã khách hàng này");
            }
        }
        public void XoaKhachHang()
        {
            HienKhachHang();
            Console.SetCursorPosition(35, 28); Console.Write("Nhập mã khách hàng cần xóa: ");
            string makhachhang = Console.ReadLine();
            int i = 0;
            List<KhachHang> list = ListKhachHang();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Makhachhang == makhachhang)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(48, 13);
                Console.Write("Đã xóa khách hàng");
                list.RemoveAt(i);
                khDAL.CapNhatKhachHang(list);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(43, 13);
                Console.Write("Không tồn tại mã khách hàng này");
            }
        }
        public void TimKhachHang()
        {
            Console.SetCursorPosition(43, 13); Console.Write("Nhập mã khách hàng cần tìm: ");
            string makhachhang = Console.ReadLine();
            int i;
            List<KhachHang> list = ListKhachHang();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Makhachhang == makhachhang)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.Clear();
                KhachHang kh = new KhachHang(list[i]);
                Console.SetCursorPosition(43, 9); Console.Write("THÔNG TIN KHÁCH HÀNG CẦN TÌM");
                Console.SetCursorPosition(43, 10); Console.Write("Mã khách hàng  : " + kh.Makhachhang);
                Console.SetCursorPosition(43, 11); Console.Write("Tên khách hàng : " + kh.Tenkhachhang);
                Console.SetCursorPosition(43, 12); Console.Write("Địa chỉ        : " + kh.Diachi);
                Console.SetCursorPosition(43, 13); Console.Write("Số điện thoại  : " + kh.Sodienthoai);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(43, 13);
                Console.WriteLine("Không tồn tại mã khách hàng này");
            }
        }
    }
}
