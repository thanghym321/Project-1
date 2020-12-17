using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    class NhanVien
    {
        #region Các thành phần dữ liệu
        private string manhanvien, hoten, gioitinh, chucvu;
        private int cmnd, namsinh, sdt;
        #endregion

        #region Các thuộc tính
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        #endregion

        #region Các thương thức             
        public NhanVien() { }
        public NhanVien(NhanVien nv)
        {
            this.manhanvien = nv.manhanvien;
            this.hoten = nv.hoten;
            this.gioitinh = nv.gioitinh;
            this.chucvu = nv.chucvu;
            this.cmnd = nv.cmnd;
            this.namsinh = nv.namsinh;
            this.sdt = nv.sdt;
        }

        public NhanVien(string manhanvien, string hoten, string gioitinh, string chucvu, int cmnd, int namsinh, int sdt)
        {
            this.manhanvien = manhanvien;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.chucvu = chucvu;
            this.cmnd = cmnd;
            this.namsinh = namsinh;
            this.sdt = sdt;
        }
        #endregion
    }
}
