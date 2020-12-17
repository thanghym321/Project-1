using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;

namespace Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer
{
    interface ISanPhamBLL
    {
        List<SanPham> ListSanPham();
        void ThemSanPham();
        void SuaSanPham();
        void XoaSanPham(SanPham sp,string masanpham);   
        void TimSanPham(string masanpham);
    }
}
