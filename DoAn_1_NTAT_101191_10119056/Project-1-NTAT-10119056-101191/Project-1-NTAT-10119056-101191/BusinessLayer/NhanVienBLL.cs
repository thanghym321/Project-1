using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using Project_1_NTAT_10119056_101191.DataAccessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;

namespace Project_1_NTAT_10119056_101191.BusinessLayer
{
    class NhanVienBLL:INhanVienBLL
    {
        private INhanVienDAL nvDAL = new NhanVienDAL();
        public List<NhanVien> ListNhanVien()
        {
            return nvDAL.ListNhanVien();
        }
        public void HienNhanVien()
        {
            List<NhanVien> list = ListNhanVien();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                    DANH SÁCH SẢN PHẨM                                                ║");
            Console.WriteLine("╠════════════════╦═══════════════════════════╦═══════════╦═════════════╦═══════════════════════════════╦═══════════════╣");
            Console.WriteLine("║  MÃ NHÂN VIÊN  ║       TÊN NHÂN VIÊN       ║ GIỚI TÍNH ║   CHỨC VỤ   ║            ĐỊA CHỈ            ║ SỐ ĐIỆN THOẠI ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("║                ║                           ║           ║             ║                               ║               ║");
            Console.WriteLine("╚════════════════╩═══════════════════════════╩═══════════╩═════════════╩═══════════════════════════════╩═══════════════╝");
            int i = 5;

            foreach (var x in list)
            {
                Console.SetCursorPosition(8, i); Console.Write(x.Manhanvien);
                Console.SetCursorPosition(23, i); Console.Write(x.Tennhanvien);
                Console.SetCursorPosition(50, i); Console.Write(x.Gioitinh);
                Console.SetCursorPosition(61, i); Console.Write(x.Chucvu);
                Console.SetCursorPosition(76, i); Console.Write(x.Diachi);
                Console.SetCursorPosition(107, i); Console.Write(x.Sodienthoai);
                i++;
            }
        }
        public void ThemNhanVien()
        {
            Console.SetCursorPosition(42, 13);
            Console.Write("Nhập số nhân viên cần nhập: "); int sonv = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < sonv; i++)
            {
                Console.Clear();
                NhanVien nv = new NhanVien();
                bool ktma = false;
                do
                {
                    do
                    {
                        Console.SetCursorPosition(50, 5);
                        Console.WriteLine("NHẬP THÔNG TIN NHÂN VIÊN");
                        Console.SetCursorPosition(50, 8);
                        Console.Write("Nhập mã nhân viên  : "); nv.Manhanvien = Console.ReadLine();
                    } while (string.IsNullOrEmpty(nv.Manhanvien));
                    foreach (var x in ListNhanVien())
                    {
                        if (nv.Manhanvien == x.Manhanvien)
                        {
                            ktma = true;
                            Console.Clear();
                            Console.SetCursorPosition(50, 25);
                            Console.WriteLine("Mã nhân viên đã tồn tại!");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(50, 25);
                            Console.WriteLine("Nhập mã nhân viên thành công!");
                            ktma = false;
                        }
                    }
                } while (ktma == true);
                do
                {
                    Console.SetCursorPosition(50, 9);
                    Console.Write("Nhập tên nhân viên : "); nv.Tennhanvien = Console.ReadLine();

                } while (string.IsNullOrEmpty(nv.Tennhanvien));
                do
                {
                    Console.SetCursorPosition(50, 10);
                    Console.Write("Nhập giới tính     : "); nv.Gioitinh = Console.ReadLine();

                } while (string.IsNullOrEmpty(nv.Gioitinh));
                do
                {
                    Console.SetCursorPosition(50, 11);
                    Console.Write("Nhập chức vụ       : "); nv.Chucvu = Console.ReadLine();

                } while (string.IsNullOrEmpty(nv.Chucvu));
                do
                {
                    Console.SetCursorPosition(50, 12);
                    Console.Write("Nhập địa chỉ       : "); nv.Diachi = Console.ReadLine();

                } while (string.IsNullOrEmpty(nv.Diachi));
                do
                {
                    Console.SetCursorPosition(50, 13);
                    Console.Write("Nhập số diện thoại : "); nv.Sodienthoai =int.Parse(Console.ReadLine());

                } while (nv.Sodienthoai == 10);
                nvDAL.ThemNhanVien(nv);
            }
        }
        public void SuaNhanVien()
        {
            HienNhanVien();
            Console.SetCursorPosition(37, 28); Console.Write("Nhập mã nhân viên cần sửa: ");
            string manhanvien = Console.ReadLine();
            int i = 0;
            List<NhanVien> list = ListNhanVien();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Manhanvien == manhanvien)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                NhanVien nv = new NhanVien(list[i]);
                Console.Clear();

                Console.SetCursorPosition(37, 9); Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.SetCursorPosition(37, 10); Console.WriteLine("║              SỬA THÔNG TIN SẢN PHẨM          ║");
                Console.SetCursorPosition(37, 11); Console.WriteLine("╠══════╦═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 12); Console.WriteLine("║  F1  ║              SỬA MÃ                   ║");
                Console.SetCursorPosition(37, 13); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 14); Console.WriteLine("║  F2  ║              SỬA TÊN                  ║");
                Console.SetCursorPosition(37, 15); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 16); Console.WriteLine("║  F3  ║              SỬA GIỚI TÍNH            ║");
                Console.SetCursorPosition(37, 17); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 18); Console.WriteLine("║  F4  ║              SỬA CHỨC VỤ              ║");
                Console.SetCursorPosition(37, 19); Console.WriteLine("╠══════╩═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 20); Console.WriteLine("║  F5  ║              SỬA ĐỊA CHỈ              ║");
                Console.SetCursorPosition(37, 21); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 22); Console.WriteLine("║  F6  ║              SỬA SỐ ĐIỆN THOẠI        ║");
                Console.SetCursorPosition(37, 23); Console.WriteLine("╠══════╬═══════════════════════════════════════╣");
                Console.SetCursorPosition(37, 24); Console.WriteLine("║  F7  ║              SỬA TẤT CẢ               ║");
                Console.SetCursorPosition(37, 25); Console.WriteLine("╚══════╩═══════════════════════════════════════╝");

                ConsoleKeyInfo chon = Console.ReadKey();
                switch (chon.Key)
                {
                    case ConsoleKey.F1:
                        {
                            Console.Clear();
                            bool ktma = false;
                            do
                            {
                                Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN NHÂN VIÊN ĐANG SỬA");
                                Console.SetCursorPosition(50, 3); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                                Console.SetCursorPosition(50, 4); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                                Console.SetCursorPosition(50, 5); Console.Write("Giới tính     : " + nv.Gioitinh);
                                Console.SetCursorPosition(50, 6); Console.Write("Chức vụ       : " + nv.Chucvu);
                                Console.SetCursorPosition(50, 7); Console.Write("Địa chỉ       : " + nv.Diachi);
                                Console.SetCursorPosition(50, 8); Console.Write("Số điện thoại : " + nv.Sodienthoai);
                                Console.SetCursorPosition(50, 13); Console.Write("Nhập mã nhân viên mới: ");
                                string mamoi = Console.ReadLine();
                                foreach (var x in ListNhanVien())
                                {
                                    if (mamoi == x.Manhanvien)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(50, 25);
                                        Console.WriteLine("Mã nhân viên đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        nv.Manhanvien = mamoi;
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            break;
                        }
                    case ConsoleKey.F2:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN NHÂN VIÊN ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                            Console.SetCursorPosition(50, 5); Console.Write("Giới tính     : " + nv.Gioitinh);
                            Console.SetCursorPosition(50, 6); Console.Write("Chức vụ       : " + nv.Chucvu);
                            Console.SetCursorPosition(50, 7); Console.Write("Địa chỉ       : " + nv.Diachi);
                            Console.SetCursorPosition(50, 8); Console.Write("Số điện thoại : " + nv.Sodienthoai);

                            Console.SetCursorPosition(50, 13); Console.Write("Nhập tên nhân viên mới: ");
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                nv.Tennhanvien = tenmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F3:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN NHÂN VIÊN ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                            Console.SetCursorPosition(50, 5); Console.Write("Giới tính     : " + nv.Gioitinh);
                            Console.SetCursorPosition(50, 6); Console.Write("Chức vụ       : " + nv.Chucvu);
                            Console.SetCursorPosition(50, 7); Console.Write("Địa chỉ       : " + nv.Diachi);
                            Console.SetCursorPosition(50, 8); Console.Write("Số điện thoại : " + nv.Sodienthoai);

                            Console.SetCursorPosition(50, 13); Console.Write("Nhập giới tính mới: ");
                            string gtmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(gtmoi))
                            {
                                nv.Gioitinh = gtmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F4:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN NHÂN VIÊN ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                            Console.SetCursorPosition(50, 5); Console.Write("Giới tính     : " + nv.Gioitinh);
                            Console.SetCursorPosition(50, 6); Console.Write("Chức vụ       : " + nv.Chucvu);
                            Console.SetCursorPosition(50, 7); Console.Write("Địa chỉ       : " + nv.Diachi);
                            Console.SetCursorPosition(50, 8); Console.Write("Số điện thoại : " + nv.Sodienthoai);

                            Console.SetCursorPosition(50, 13); Console.Write("Nhập chức vụ mới: ");
                            string chucvumoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(chucvumoi))
                            {
                                nv.Chucvu = chucvumoi;
                            }
                            break;
                        }
                    case ConsoleKey.F5:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN NHÂN VIÊN ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                            Console.SetCursorPosition(50, 5); Console.Write("Giới tính     : " + nv.Gioitinh);
                            Console.SetCursorPosition(50, 6); Console.Write("Chức vụ       : " + nv.Chucvu);
                            Console.SetCursorPosition(50, 7); Console.Write("Địa chỉ       : " + nv.Diachi);
                            Console.SetCursorPosition(50, 8); Console.Write("Số điện thoại : " + nv.Sodienthoai);

                            Console.SetCursorPosition(50, 13); Console.Write("Nhập địa chỉ mới: ");
                            string dcmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(dcmoi))
                            {
                                nv.Diachi = dcmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F6:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN NHÂN VIÊN ĐANG SỬA");
                            Console.SetCursorPosition(50, 3); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                            Console.SetCursorPosition(50, 4); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                            Console.SetCursorPosition(50, 5); Console.Write("Giới tính     : " + nv.Gioitinh);
                            Console.SetCursorPosition(50, 6); Console.Write("Chức vụ       : " + nv.Chucvu);
                            Console.SetCursorPosition(50, 7); Console.Write("Địa chỉ       : " + nv.Diachi);
                            Console.SetCursorPosition(50, 8); Console.Write("Số điện thoại : " + nv.Sodienthoai);

                            Console.SetCursorPosition(50, 13); Console.Write("Nhập số điện thoại mới: ");
                            int sdtmoi = int.Parse(Console.ReadLine());
                            if (sdtmoi ==10)
                            {
                                nv.Sodienthoai = sdtmoi;
                            }
                            break;
                        }
                    case ConsoleKey.F7:
                        {
                            Console.Clear();
                            bool ktma = false;
                            do
                            {


                                Console.SetCursorPosition(50, 2); Console.Write("THÔNG TIN NHÂN VIÊN ĐANG SỬA");
                                Console.SetCursorPosition(50, 3); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                                Console.SetCursorPosition(50, 4); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                                Console.SetCursorPosition(50, 5); Console.Write("Giới tính     : " + nv.Gioitinh);
                                Console.SetCursorPosition(50, 6); Console.Write("Chức vụ       : " + nv.Chucvu);
                                Console.SetCursorPosition(50, 7); Console.Write("Địa chỉ       : " + nv.Diachi);
                                Console.SetCursorPosition(50, 8); Console.Write("Số điện thoại : " + nv.Sodienthoai);
                                Console.SetCursorPosition(50, 13); Console.Write("Nhập mã sản phẩm mới  : ");
                                string mamoi = Console.ReadLine();
                                foreach (var x in ListNhanVien())
                                {
                                    if (mamoi == x.Manhanvien)
                                    {
                                        Console.Clear();
                                        ktma = true;
                                        Console.SetCursorPosition(50, 25);
                                        Console.WriteLine("Mã nhân viên đã tồn tại");
                                        break;
                                    }
                                    else
                                    {
                                        nv.Manhanvien = mamoi;
                                        ktma = false;
                                    }
                                }
                            } while (ktma == true);
                            Console.SetCursorPosition(50, 14); Console.Write("Nhập tên nhân viên mới : ");
                            string tenmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(tenmoi))
                            {
                                nv.Tennhanvien = tenmoi;
                            }
                            Console.SetCursorPosition(50, 15); Console.Write("Nhập giới tính mới     : ");
                            string gtmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(gtmoi))
                            {
                                nv.Gioitinh = gtmoi;
                            }
                            Console.SetCursorPosition(50, 16); Console.Write("Nhập chức vụ mới     : ");
                            string chucvumoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(chucvumoi))
                            {
                                nv.Chucvu = chucvumoi;
                            }
                            Console.SetCursorPosition(50, 17); Console.Write("Nhập địa chỉ mới      : ");
                            string dcmoi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(dcmoi))
                            {
                                nv.Diachi = dcmoi;
                            }
                            Console.SetCursorPosition(50, 17); Console.Write("Nhập số điện thoại mới : ");
                            int sdtmoi = int.Parse(Console.ReadLine());
                            if (sdtmoi == 10)
                            {
                                nv.Sodienthoai = sdtmoi;
                            }
                            break;
                        }
                }
                Console.Clear();
                Console.SetCursorPosition(45, 9); Console.Write("THÔNG TIN NHÂN VIÊN ĐÃ SỬA");
                Console.SetCursorPosition(45, 10); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                Console.SetCursorPosition(45, 11); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                Console.SetCursorPosition(45, 12); Console.Write("Giới tính     : " + nv.Gioitinh);
                Console.SetCursorPosition(45, 13); Console.Write("Chức vụ       : " + nv.Chucvu);
                Console.SetCursorPosition(45, 14); Console.Write("Địa chỉ       : " + nv.Diachi);
                Console.SetCursorPosition(45, 14); Console.Write("Số điện thoại : " + nv.Sodienthoai);
                list.RemoveAt(i);
                list.Add(nv);
                nvDAL.CapNhatNhanVien(list);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(45, 13);
                Console.Write("Không tồn tại mã nhân viên này");
            }
        }
        public void XoaNhanVien()
        {
            HienNhanVien();
            Console.SetCursorPosition(37, 28); Console.Write("Nhập mã nhân viên cần xóa: ");
            string manhanvien = Console.ReadLine();
            int i = 0;
            List<NhanVien> list = ListNhanVien();
            for (i = 0; i < list.Count; ++i)
            {
                if (list[i].Manhanvien == manhanvien)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 13);
                Console.Write("Đã xóa nhân viên");
                list.RemoveAt(i);
                nvDAL.CapNhatNhanVien(list);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(45, 13);
                Console.Write("Không tồn tại mã nhân viên này");
            }
        }
        public void TimNhanVien()
        {
            Console.SetCursorPosition(45, 13); Console.Write("Nhập mã nhân viên cần tìm: ");
            string manhanvien = Console.ReadLine();
            int i;
            List<NhanVien> list = ListNhanVien();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Manhanvien == manhanvien)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.Clear();
                NhanVien nv = new NhanVien(list[i]);
                Console.SetCursorPosition(45, 9); Console.Write("THÔNG TIN NHÂN VIÊN CẦN TÌM");
                Console.SetCursorPosition(45, 10); Console.Write("Mã nhân viên  : " + nv.Manhanvien);
                Console.SetCursorPosition(45, 11); Console.Write("Tên nhân viên : " + nv.Tennhanvien);
                Console.SetCursorPosition(45, 12); Console.Write("Giới tính     : " + nv.Gioitinh);
                Console.SetCursorPosition(45, 13); Console.Write("Chức vụ       : " + nv.Chucvu);
                Console.SetCursorPosition(45, 14); Console.Write("Địa chỉ       : " + nv.Diachi);
                Console.SetCursorPosition(45, 15); Console.Write("Số điện thoại : " + nv.Sodienthoai);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(45, 13);
                Console.WriteLine("Không tồn tại mã nhân viên này");
            }
        }
    }
}
