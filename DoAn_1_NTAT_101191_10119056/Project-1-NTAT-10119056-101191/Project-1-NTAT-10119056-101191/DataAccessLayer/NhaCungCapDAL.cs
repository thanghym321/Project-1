using System;
using System.Collections.Generic;
using System.Text;
using Project_1_NTAT_10119056_101191.DataAccessLayer.IDataAccessLayer;
using Project_1_NTAT_10119056_101191.Entities;
using System.IO;


namespace Project_1_NTAT_10119056_101191.DataAccessLayer
{
    class NhaCungCapDAL:INhaCungCapDAL
    {
        private string filencc = "Data/NhaCungCap.txt";

        public List<NhaCungCap> ListNhaCungCap()
        {
            List<NhaCungCap> listncc = new List<NhaCungCap>();
            StreamReader read = File.OpenText(filencc);
            string s = read.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    listncc.Add(new NhaCungCap(a[0], a[1], a[2], int.Parse(a[3])));
                }
                s = read.ReadLine();
            }
            read.Close();
            return listncc;
        }
        public void ThemNhaCungCap(NhaCungCap ncc)
        {
            StreamWriter write = File.AppendText(filencc);
            write.WriteLine();
            write.Write(ncc.Manhacungcap + "|" + ncc.Tennhacungcap + "|" + ncc.Diachi + "|" + ncc.Sodienthoai);
            write.Close();
        }
        public void CapNhatNhaCungCap(List<NhaCungCap> list)
        {
            StreamWriter write = File.CreateText(filencc);
            for (int i = 0; i < list.Count; i++)
            {
                write.WriteLine();
                write.WriteLine(list[i].Manhacungcap + "|" + list[i].Tennhacungcap + "|" + list[i].Diachi + "|" + list[i].Sodienthoai);
            }
            write.Close();
        }
    }
}
