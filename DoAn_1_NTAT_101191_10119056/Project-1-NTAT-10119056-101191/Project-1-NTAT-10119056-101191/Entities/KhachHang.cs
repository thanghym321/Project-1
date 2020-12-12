using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    class KhachHang
    {
        #region Các thành phần dữ liệu
        private string makhachhang;
        private string tenkhachhang;
        private int sodienthoai;
        private string diachi;
        #endregion

        #region Các thuộc tính
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public int Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        #endregion

        #region Các phương thức
        public KhachHang() { }
        public KhachHang(KhachHang kh)
        {
            this.makhachhang = kh.makhachhang;
            this.tenkhachhang = kh.tenkhachhang;
            this.sodienthoai = kh.sodienthoai;
            this.diachi = kh.diachi;
        }
        public KhachHang(string makhachhang, string tenkhachhang, int sodienthoai, string diachi)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.sodienthoai = sodienthoai;
            this.diachi = diachi;
        }
        #endregion
    }
}
