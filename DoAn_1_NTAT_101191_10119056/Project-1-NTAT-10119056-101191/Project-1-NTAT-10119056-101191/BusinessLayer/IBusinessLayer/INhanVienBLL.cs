using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;

namespace Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer
{
    interface INhanVienBLL
    {
        List<NhanVien> ListNhanVien();
        void HienNhanVien();
        void ThemNhanVien();
        void SuaNhanVien();
        void XoaNhanVien();
        void TimNhanVien();
    }
}
