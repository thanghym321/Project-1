using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;

namespace Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer
{
    interface IKhachHangBLL
    {
        List<KhachHang> ListKhachHang();
        void HienKhachHang();
        void ThemKhachHang();
        void SuaKhachHang();
        void XoaKhachHang();
        void TimKhachHang();
    }
}
