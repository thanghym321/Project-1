using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using System.IO;


namespace Project_1_NTAT_10119056_101191.DataAccessLayer
{
    class NhanVienDAL:INhanVienDAL
    {
        private string filenv = "Data/NhanVien.txt";

        public List<NhanVien> ListNhanVien()
        {
            List<NhanVien> listnv = new List<NhanVien>();
            StreamReader read = File.OpenText(filenv);
            string s = read.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    listnv.Add(new NhanVien(a[0], a[1], a[2], a[3], a[4], int.Parse(a[5])));
                }
                s = read.ReadLine();
            }
            read.Close();
            return listnv;
        }
        public void ThemNhanVien(NhanVien nv)
        {
            StreamWriter write = File.AppendText(filenv);
            write.WriteLine();
            write.Write(nv.Manhanvien + "|" + nv.Tennhanvien + "|" + nv.Gioitinh + "|" + nv.Chucvu + "|" + nv.Diachi + "|" + nv.Sodienthoai);
            write.Close();
        }
        public void CapNhatNhanVien(List<NhanVien> list)
        {
            StreamWriter write = File.CreateText(filenv);
            for (int i = 0; i < list.Count; i++)
            {
                write.WriteLine();
                write.WriteLine(list[i].Manhanvien + "|" + list[i].Tennhanvien + "|" + list[i].Gioitinh + "|" + list[i].Chucvu + "|" + list[i].Diachi+ "|" + list[i].Sodienthoai);
            }
            write.Close();
        }
    }
}
