using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.BusinessLayer.IBusinessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using Project_1_NTAT_10119056_101191.DataAccessLayer;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;

namespace Project_1_NTAT_10119056_101191.BusinessLayer
{
    class SanPhamBLL : ISanPhamBLL
    {
        private ISanPhamDAL spDAL = new SanPhamDAL();

        public List<SanPham> ListSanPham()
        {
            return spDAL.ListSanPham();
        }
        public void ThemSanPham(SanPham sp)
        {
            if (!string.IsNullOrEmpty(sp.Masanpham))
            {
                spDAL.ThemSanPham(sp);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }

        public void SuaSanPham(SanPham sp,string masanpham)
        {
            int i;
            List<SanPham> list = spDAL.ListSanPham();
            for (i = 0; i <list.Count ; i++)
            {
                if (list[i].Masanpham == masanpham)
                {
                    break;
                }
            }
            if (i<list.Count)
            {
                list.RemoveAt(i);
                list.Add(sp);
                spDAL.CapNhatSanPham(list);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }

        public void XoaSanPham(SanPham sp,string masanpham)
        {
            int i;
            List<SanPham> list = spDAL.ListSanPham();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Masanpham == masanpham)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                list.RemoveAt(i);
                spDAL.CapNhatSanPham(list);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }

        public void TimSanPham(string masanpham)
        {
            int i;
            List<SanPham> list = spDAL.ListSanPham();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Masanpham == masanpham)
                {
                    break;
                }
            }
            if (i < list.Count)
            {
                Console.WriteLine(list[i].Masanpham + "\t" + list[i].Tensanpham + "\t" + list[i].Loai + "\t" + list[i].Soluong + "\t" + list[i].Dongia);
            }
            else
            {
                Console.WriteLine("Dữ liệu sai");
            }
        }
    }
}
