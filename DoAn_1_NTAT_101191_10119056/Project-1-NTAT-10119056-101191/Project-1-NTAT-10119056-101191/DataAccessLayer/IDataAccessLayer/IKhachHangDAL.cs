using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;

namespace Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer
{
    interface IKhachHangDAL
    {
        List<KhachHang> ListKhachHang();

        void ThemKhachHang(KhachHang kh);

        void CapNhatKhachHang(List<KhachHang> list);
    }
}
