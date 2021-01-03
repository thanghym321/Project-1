using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using Project_1_NTAT_10119056_101191.DataAccessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;

namespace Project_1_NTAT_10119056_101191.BusinessLayer
{
    class NhaCungCapBLL : INhaCungCapBLL
    {
        private INhaCungCapDAL nccDAL =new NhaCungCapDAL();
        public List<NhaCungCap> ListNhaCungCap()
        {
            return nccDAL.ListNhaCungCap();
        }
        public void HienNhaCungCap()
        {
            List<NhaCungCap> list = ListNhaCungCap();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                    DANH SÁCH NHÀ CUNG CẤP                                            ║");
            Console.WriteLine("╠═════════════════╦══════════════════════════════════╦═════════════════════════════════════════════╦═══════════════════╣");
            Console.WriteLine("║ MÃ NHÀ CUNG CẤP ║         TÊN NHÀ CUNG CẤP         ║                   ĐỊA CHỈ                   ║   SỐ ĐIỆN THOẠI   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("║                 ║                                  ║                                             ║                   ║");
            Console.WriteLine("╚═════════════════╩══════════════════════════════════╩═════════════════════════════════════════════╩═══════════════════╝");
            int i = 5;

            foreach (var x in list)
            {
                Console.SetCursorPosition(7, i); Console.Write(x.Manhacungcap);
                Console.SetCursorPosition(22, i); Console.Write(x.Tennhacungcap);
                Console.SetCursorPosition(57, i); Console.Write(x.Diachi);
                Console.SetCursorPosition(105, i); Console.Write(x.Sodienthoai);
                i++;
            }
        }
        public void ThemNhaCungCap()
        {
            Console.SetCursorPosition(38, 13);
            Console.Write("Nhập số nhà cung cấp cần nhập: "); int soncc = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < soncc; i++)
            {
                Console.Clear();
                NhaCungCap ncc = new NhaCungCap();
                bool ktma = false;
                do
                {
                    do
                    {
                        Console.SetCursorPosition(46, 5);
                        Console.WriteLine("NHẬP THÔNG TIN NHÀ CUNG CẤP");
                        Console.SetCursorPosition(46, 8);
                        Console.Write("Nhập mã nhà cung cấp  : "); ncc.Manhacungcap = Console.ReadLine();
                    } while (string.IsNullOrEmpty(ncc.Manhacungcap));
                    foreach (var x in ListNhaCungCap())
                    {
                        if (ncc.Manhacungcap == x.Manhacungcap)
                        {
                            ktma = true;
                            Console.Clear();
                            Console.SetCursorPosition(46, 25);
                            Console.WriteLine("Mã nhà cung cấp đã tồn tại!");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(46, 25);
                            Console.WriteLine("Nhập mã nhà cung cấp thành công!");
                            ktma = false;
                        }
                    }
                } while (ktma == true);
                do
                {
                    Console.SetCursorPosition(46, 9);
                    Console.Write("Nhập tên nhà cung cấp : "); ncc.Tennhacungcap = Console.ReadLine();

                } while (string.IsNullOrEmpty(ncc.Tennhacungcap));
                do
                {
                    Console.SetCursorPosition(46, 10);
                    Console.Write("Nhập địa chỉ          : "); ncc.Diachi = Console.ReadLine();

                } while (string.IsNullOrEmpty(ncc.Diachi));
                do
                {
                    Console.SetCursorPosition(46, 11);
                    Console.Write("Nhập số điện thoại    : "); ncc.Sodienthoai = int.Parse(Console.ReadLine());

                } while (ncc.Sodienthoai == 10);
                nccDAL.ThemNhaCungCap(ncc);
            }
        }
        public void SuaNhaCungCap()
        {
            HienNhaCungCap();
            Console.SetCursorPosition(33, 28); Console.Write("Nhập mã nhà cung cấp cần sửa: ");
            string manhacungcap = Console.ReadLine();
            int i = 0;
            List<NhaCungCap> list = ListNhaCungCap();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Manhacungcap == manhacungcap)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                NhaCungCap ncc = new NhaCungCap(list[i]);
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
                                Console.SetCursorPosition(46, 2); Console.Write("THÔNG TIN NHÀ CUNG CẤP ĐANG SỬA");
                                Console.SetCursorPosition(46, 3); Console.Write("Mã nhà cung cấp  : " + ncc.Manhacungcap);
                                Console.SetCursorPosition(46, 4); Console.Write("Tên nhà cung cấp : " + ncc.Tennhacungcap);
                                Console.SetCursorPosition(46, 5); Console.Write("Địa chỉ          : " + ncc.Diachi);
                                Console.SetCursorPosition(46, 6); Console.Write("Số điện thoại    : " + ncc.Sodienthoai);
                                Console.SetCursorPosition(46, 13); Console.Write("Nhập mã nhà cung cấp mới: ");
                                string mamoi = Console.ReadLine();
                                foreach (var x in ListNhaCungCap())
                                {
                                    if (mamoi == x.Manhacungcap)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(46, 25);
                                        Console.WriteLine("Mã nhà cung cấp đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        ncc.Manhacungcap = mamoi;
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(46, 2); Console.Write("THÔNG TIN NHÀ CUNG CẤP ĐANG SỬA");
                            Console.SetCursorPosition(46, 3); Console.Write("Mã nhà cung cấp  : " + ncc.Manhacungcap);
                            Console.SetCursorPosition(46, 4); Console.Write("Tên nhà cung cấp : " + ncc.Tennhacungcap);
                            Console.SetCursorPosition(46, 5); Console.Write("Địa chỉ          : " + ncc.Diachi);
                            Console.SetCursorPosition(46, 6); Console.Write("Số điện thoại    : " + ncc.Sodienthoai);

                            Console.SetCursorPosition(46, 13); Console.Write("Nhập tên nhà cung cấp mới: ");
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                ncc.Tennhacungcap = tenmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(46, 2); Console.Write("THÔNG TIN NHÀ CUNG CẤP ĐANG SỬA");
                            Console.SetCursorPosition(46, 3); Console.Write("Mã nhà cung cấp  : " + ncc.Manhacungcap);
                            Console.SetCursorPosition(46, 4); Console.Write("Tên nhà cung cấp : " + ncc.Tennhacungcap);
                            Console.SetCursorPosition(46, 5); Console.Write("Địa chỉ          : " + ncc.Diachi);
                            Console.SetCursorPosition(46, 6); Console.Write("Số điện thoại    : " + ncc.Sodienthoai);

                            Console.SetCursorPosition(46, 13); Console.Write("Nhập địa chỉ mới   : ");
                            string diachimoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(diachimoi))
                            {
                                ncc.Diachi = diachimoi;
                            }
                            break;
                        }
                    case ConsoleKey.F4:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(46, 2); Console.Write("THÔNG TIN NHÀ CUNG CẤP ĐANG SỬA");
                            Console.SetCursorPosition(46, 3); Console.Write("Mã nhà cung cấp  : " + ncc.Manhacungcap);
                            Console.SetCursorPosition(46, 4); Console.Write("Tên nhà cung cấp : " + ncc.Tennhacungcap);
                            Console.SetCursorPosition(46, 5); Console.Write("Địa chỉ          : " + ncc.Diachi);
                            Console.SetCursorPosition(46, 6); Console.Write("Số điện thoại    : " + ncc.Sodienthoai);

                            Console.SetCursorPosition(46, 13); Console.Write("Nhập số điện thoại mới: ");
                            int sdtmoi = int.Parse(Console.ReadLine());
                            if (sdtmoi == 10)
                            {
                                ncc.Sodienthoai = sdtmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F5:
                        {
                            Console.Clear();
                            bool ktma = false;
                            do
                            {
                                Console.SetCursorPosition(46, 2); Console.Write("THÔNG TIN NHÀ CUNG CẤP ĐANG SỬA");
                                Console.SetCursorPosition(46, 3); Console.Write("Mã nhà cung cấp  : " + ncc.Manhacungcap);
                                Console.SetCursorPosition(46, 4); Console.Write("Tên nhà cung cấp : " + ncc.Tennhacungcap);
                                Console.SetCursorPosition(46, 5); Console.Write("Địa chỉ          : " + ncc.Diachi);
                                Console.SetCursorPosition(46, 6); Console.Write("Số điện thoại    : " + ncc.Sodienthoai);

                                Console.SetCursorPosition(46, 13); Console.Write("Nhập mã nhà cung cấp mới: ");
                                string mamoi = Console.ReadLine();

                                foreach (var x in ListNhaCungCap())
                                {
                                    if (mamoi == x.Manhacungcap)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(46, 25);
                                        Console.WriteLine("Mã nhà cung cấp đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        ncc.Manhacungcap = mamoi;
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            Console.SetCursorPosition(46, 14); Console.Write("Nhập tên nhà cung cấp mới: ");
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                ncc.Tennhacungcap = tenmoi;
                            }
                            Console.SetCursorPosition(46, 15); Console.Write("Nhập địa chỉ mới: ");
                            string diachimoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(diachimoi))
                            {
                                ncc.Diachi = diachimoi;
                            }
                            Console.SetCursorPosition(46, 16); Console.Write("Nhập số điện thoại mới: ");
                            int sdtmoi = int.Parse(Console.ReadLine());
                            if (sdtmoi == 10)
                            {
                                ncc.Sodienthoai = sdtmoi;
                            }
                            break;
                        }
                }
                Console.Clear();
                Console.SetCursorPosition(41, 9); Console.Write("THÔNG TIN NHÀ CUNG CẤP ĐÃ SỬA");
                Console.SetCursorPosition(41, 10); Console.Write("Mã nhà cung cấp  : " + ncc.Manhacungcap);
                Console.SetCursorPosition(41, 11); Console.Write("Tên nhà cung cấp : " + ncc.Tennhacungcap);
                Console.SetCursorPosition(41, 12); Console.Write("Địa chỉ          : " + ncc.Diachi);
                Console.SetCursorPosition(41, 13); Console.Write("Số điện thoại    : " + ncc.Sodienthoai);
                list.RemoveAt(i);
                list.Add(ncc);
                nccDAL.CapNhatNhaCungCap(list);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(41, 13);
                Console.Write("Không tồn tại mã nhà cung cấp này");
            }
        }
        public void XoaNhaCungCap()
        {
            HienNhaCungCap();
            Console.SetCursorPosition(33, 28); Console.Write("Nhập mã nhà cung cấp cần xóa: ");
            string manhacungcap = Console.ReadLine();
            int i = 0;
            List<NhaCungCap> list = ListNhaCungCap();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Manhacungcap == manhacungcap)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(46, 13);
                Console.Write("Đã xóa nhà cung cấp");
                list.RemoveAt(i);
                nccDAL.CapNhatNhaCungCap(list);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(41, 13);
                Console.Write("Không tồn tại mã nhà cung cấp này");
            }
        }
        public void TimNhaCungCap()
        {
            Console.SetCursorPosition(41, 13); Console.Write("Nhập mã nhà cung cấp cần tìm: ");
            string manhacungcap = Console.ReadLine();
            int i;
            List<NhaCungCap> list = ListNhaCungCap();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Manhacungcap == manhacungcap)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.Clear();
                NhaCungCap ncc = new NhaCungCap(list[i]);
                Console.SetCursorPosition(41, 9); Console.Write("THÔNG TIN NHÀ CUNG CẤP CẦN TÌM");
                Console.SetCursorPosition(41, 10); Console.Write("Mã nhà cung cấp  : " + ncc.Manhacungcap);
                Console.SetCursorPosition(41, 11); Console.Write("Tên nhà cung cấp : " + ncc.Tennhacungcap);
                Console.SetCursorPosition(41, 12); Console.Write("Địa chỉ          : " + ncc.Diachi);
                Console.SetCursorPosition(41, 13); Console.Write("Số điện thoại    : " + ncc.Sodienthoai);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(41, 13);
                Console.WriteLine("Không tồn tại mã nhà cung cấp này");
            }
        }
    }
}
