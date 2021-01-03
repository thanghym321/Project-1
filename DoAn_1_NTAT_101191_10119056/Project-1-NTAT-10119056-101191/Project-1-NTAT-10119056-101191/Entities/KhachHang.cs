using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    class KhachHang
    {
        #region Các thành phần dữ liệu
        private string makhachhang, tenkhachhang, diachi;
        private int sodienthoai;
        #endregion

        #region Các thuộc tính
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        #endregion

        #region Các phương thức
        public KhachHang() { }
        public KhachHang(KhachHang kh)
        {
            this.makhachhang = kh.makhachhang;
            this.tenkhachhang = kh.tenkhachhang;
            this.diachi = kh.diachi;
            this.sodienthoai = kh.sodienthoai;
        }
        public KhachHang(string makhachhang, string tenkhachhang, string diachi, int sodienthoai)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
        }
        #endregion
    }
}
