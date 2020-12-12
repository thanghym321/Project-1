using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using System.IO;

namespace Project_1_NTAT_10119056_101191.DataAccessLayer
{
    class SanPhamDAL : ISanPhamDAL
    {
        private string filesp = "Data/SanPham.txt";

        public List<SanPham> ListSanPham()
        {
            List<SanPham> listsp = new List<SanPham>();
            StreamReader read = File.OpenText(filesp);
            string s = read.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    listsp.Add(new SanPham(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                }
                s = read.ReadLine();
            }
            read.Close();
            return listsp;
        }
        public void ThemSanPham(SanPham sp)
        {
            StreamWriter ghi = File.AppendText(filesp);
            ghi.WriteLine();
            ghi.Write(sp.Masanpham + "|" + sp.Tensanpham + "|" + sp.Loai + "|" + sp.Soluong + "|" + sp.Dongia);
            ghi.Close();
        }
        public void CapNhatSanPham(List<SanPham> list)
        {
            StreamWriter write = File.CreateText(filesp);
            for(int i = 0; i < list.Count; i++)
            {
                write.WriteLine();
                write.WriteLine(list[i].Masanpham + "|" + list[i].Tensanpham + "|" + list[i].Loai + "|" + list[i].Soluong + "|" + list[i].Dongia);
            }
            write.Close();
        }
    }
}
