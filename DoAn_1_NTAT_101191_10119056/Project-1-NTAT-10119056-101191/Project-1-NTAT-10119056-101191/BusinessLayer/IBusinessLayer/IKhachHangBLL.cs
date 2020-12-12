using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;

namespace Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer
{
    interface IKhachHangBLL
    {
        List<KhachHang> ListKhachHang();
        void ThemKhachHang(KhachHang kh);
        void XoaKhachHang(KhachHang kh, string makhachhang);
        void SuaKhachHang(KhachHang kh, string makhachhang);
        void TimKhachHang(string makhachhang);
    }
}
