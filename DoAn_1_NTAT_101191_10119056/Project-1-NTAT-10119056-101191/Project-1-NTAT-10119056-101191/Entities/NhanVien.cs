using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    class NhanVien
    {
        #region Các thành phần dữ liệu
        private string manhanvien, tennhanvien, gioitinh, chucvu, diachi;
        private int sodienthoai;
        #endregion

        #region Các thuộc tính
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Sodienthoai { get => sodienthoai; set => sodienthoai = value; }

        #endregion

        #region Các thương thức             
        public NhanVien() { }
        public NhanVien(NhanVien nv)
        {
            this.manhanvien = nv.manhanvien;
            this.tennhanvien = nv.tennhanvien;
            this.gioitinh = nv.gioitinh;
            this.chucvu = nv.chucvu;
            this.diachi = nv.diachi;
            this.sodienthoai = nv.sodienthoai;
        }
        public NhanVien(string manhanvien, string tennhanvien, string gioitinh, string chucvu, string diachi, int sodienthoai)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.gioitinh = gioitinh;
            this.chucvu = chucvu;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
        }

        #endregion
    }
}
