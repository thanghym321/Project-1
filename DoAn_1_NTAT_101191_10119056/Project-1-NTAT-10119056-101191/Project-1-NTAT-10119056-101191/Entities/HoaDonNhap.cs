using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    class HoaDonNhap
    {
        #region Các thành phần dữ liệu
        private string mahoadonnhap, hoten, diachi, ngaynhap, manhanvien;
        private int sdt;
        #endregion

        #region Các thuộc tính
        public string Mahoadonnhap { get => mahoadonnhap; set => mahoadonnhap = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        #endregion

        #region Các thương thức             
        public HoaDonNhap() { }
        public HoaDonNhap(HoaDonNhap hdn)
        {
            this.mahoadonnhap = hdn.mahoadonnhap;
            this.hoten = hdn.hoten;
            this.diachi = hdn.diachi;
            this.ngaynhap = hdn.ngaynhap;
            this.manhanvien = hdn.manhanvien;
            this.sdt = hdn.sdt;
        }
        public HoaDonNhap(string mahoadonnhap, string hoten, string diachi, string ngaynhap, string manhanvien, int sdt)
        {
            this.mahoadonnhap = mahoadonnhap;
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaynhap = ngaynhap;
            this.manhanvien = manhanvien;
            this.sdt = sdt;
        }
        #endregion
    }
}
