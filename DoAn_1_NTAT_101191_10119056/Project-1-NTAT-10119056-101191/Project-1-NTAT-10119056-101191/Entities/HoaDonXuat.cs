using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    class HoaDonXuat
    {
        #region Các thành phần dữ liệu
        private string mahoadonxuat, tenxe, loaixe;
        private int soluong, dongia, tongtien;
        #endregion

        #region Các thuộc tính
        public string Mahoadonxuat { get => mahoadonxuat; set => mahoadonxuat = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public string Loaixe { get => loaixe; set => loaixe = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        #endregion

        #region Các thương thức             
        public HoaDonXuat() { }
        public HoaDonXuat(HoaDonXuat hdx)
        {
            this.mahoadonxuat = hdx.mahoadonxuat;
            this.tenxe = hdx.tenxe;
            this.loaixe = hdx.loaixe;
            this.soluong = hdx.soluong;
            this.dongia = hdx.dongia;
            this.tongtien = hdx.tongtien;
        }
        public HoaDonXuat(string mahoadonxuat, string tenxe, string loaixe, int soluong, int dongia, int tongtien)
        {
            this.mahoadonxuat = mahoadonxuat;
            this.tenxe = tenxe;
            this.loaixe = loaixe;
            this.soluong = soluong;
            this.dongia = dongia;
            this.tongtien = tongtien;
        }
        #endregion
    }
}
