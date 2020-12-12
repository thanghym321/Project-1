using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using System.IO;

namespace Project_1_NTAT_10119056_101191.DataAccessLayer
{
    class KhachHangDAL:IKhachHangDAL
    {
        private string filekh = "Data/KhachHang.txt";
        public List<KhachHang> ListKhachHang()
        {
            List<KhachHang> listkh = new List<KhachHang>();
            StreamReader read = File.OpenText(filekh);
            string s = read.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    listkh.Add(new KhachHang(a[0], a[1],int.Parse(a[2]),a[4]));
                }
                s = read.ReadLine();
            }
            read.Close();
            return listkh;
        }
        public void ThemKhachHang(KhachHang kh)
        {
            StreamWriter write = File.AppendText(filekh);
            write.WriteLine();
            write.Write(kh.Makhachhang + "|" + kh.Tenkhachhang + "|" + kh.Sodienthoai + "|" + kh.Diachi);
            write.Close();
        }
        public void CapNhatKhachHang(List<KhachHang> list)
        {
            StreamWriter write = File.CreateText(filekh);
            for (int i = 0; i < list.Count; i++)
            {
                write.WriteLine();
                write.WriteLine(list[i].Makhachhang + "|" + list[i].Tenkhachhang + "|" + list[i].Sodienthoai + "|" + list[i].Diachi);
            }
            write.Close();
        }
    }
}
