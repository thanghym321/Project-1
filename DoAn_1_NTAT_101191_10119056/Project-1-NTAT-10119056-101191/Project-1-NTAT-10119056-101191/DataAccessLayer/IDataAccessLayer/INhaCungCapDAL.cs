using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;

namespace Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer
{
    interface INhaCungCapDAL
    {
        List<NhaCungCap> ListNhaCungCap();

        void ThemNhaCungCap(NhaCungCap ncc);

        void CapNhatNhaCungCap(List<NhaCungCap> list);
    }
}
