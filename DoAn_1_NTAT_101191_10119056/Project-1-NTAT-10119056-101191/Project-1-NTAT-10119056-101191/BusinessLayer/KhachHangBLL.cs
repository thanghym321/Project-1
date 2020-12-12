using Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using System;
using System.Collections.Generic;

namespace Project_1_NTAT_10119056_101191.BusinessLayer
{
    class KhachHangBLL:IKhachHangBLL
    {
        private IKhachHangDAL khDAL = new KhachHangDAL();

        public List<KhachHang> ListKhachHang()
        {
            return khDAL.ListKhachHang();
        }
        public void ThemKhachHang(KhachHang kh)
        {
            if (!string.IsNullOrEmpty(kh.Makhachhang))
            {
                khDAL.ThemKhachHang(kh);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }

        public void SuaKhachHang(KhachHang sp, string makhachhang)
        {
            int i;
            List<KhachHang> list = khDAL.ListKhachHang();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Makhachhang == makhachhang)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(sp);
                khDAL.CapNhatKhachHang(list);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }

        public void XoaKhachHang(KhachHang sp, string makhachhang)
        {
            int i;
            List<KhachHang> list = khDAL.ListKhachHang();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Makhachhang == makhachhang)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                khDAL.CapNhatKhachHang(list);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }

        public void TimKhachHang(string makhachhang)
        {
            int i;
            List<KhachHang> list = khDAL.ListKhachHang();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Makhachhang == makhachhang)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.WriteLine(list[i].Makhachhang + "\t" + list[i].Tenkhachhang + "\t" + list[i].Sodienthoai + "\t" + list[i].Diachi);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }
    }
}
