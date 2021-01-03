using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1_NTAT_10119056_101191.Entities
{
    class NhaCungCap
    {
        #region Các thành phần dữ liệu
        private string manhacungcap, tennhacungcap, diachi;
        private int sodienthoai;
        #endregion

        #region Các thuộc tính
        public string Manhacungcap { get => manhacungcap; set => manhacungcap = value; }
        public string Tennhacungcap { get => tennhacungcap; set => tennhacungcap = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        #endregion

        #region Các phương thức
        public NhaCungCap() { }
        public NhaCungCap(NhaCungCap ncc)
        {
            this.manhacungcap = ncc.manhacungcap;
            this.tennhacungcap = ncc.tennhacungcap;
            this.diachi = ncc.diachi;
            this.sodienthoai = ncc.sodienthoai;
        }
        public NhaCungCap(string manhacungcap, string tennhacungcap, string diachi, int sodienthoai)
        {
            this.manhacungcap = manhacungcap;
            this.tennhacungcap = tennhacungcap;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
        }
        #endregion
    }
}
