using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    public class SanPham
    {
        #region Các thành phần dữ liệu
        private string masanpham, tensanpham, loai;
        private int soluong, dongia;
        #endregion

        #region Các thuộc tính
        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Loai { get => loai; set => loai = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        #endregion

        #region Các thương thức             
        public SanPham() { }

        public SanPham(SanPham sp)
        {
            this.masanpham = sp.masanpham;
            this.tensanpham = sp.tensanpham;
            this.loai = sp.loai;
            this.soluong = sp.soluong;
            this.dongia = sp.dongia;
        }
        public SanPham(string masanpham, string tensanpham, string loai, int soluong, int dongia)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.loai = loai;
            this.soluong = soluong;
            this.dongia = dongia;
        }
        #endregion
    }
}
