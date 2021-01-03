﻿using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.Entities;

namespace Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer
{
    interface INhaCungCapBLL
    {
        List<NhaCungCap> ListNhaCungCap();
        void HienNhaCungCap();
        void ThemNhaCungCap();
        void SuaNhaCungCap();
        void XoaNhaCungCap();
        void TimNhaCungCap();
    }
}
