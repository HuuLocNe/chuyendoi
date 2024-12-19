using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChuyenDoi
{
    public class LichSuChuyenDoi
    {
        public double GiaTri { get; set; }
        public string DonViNguon { get; set; }
        public string DonViDich { get; set; }
        public double KetQua { get; set; }
        public DateTime ThoiGian { get; set; }

        public LichSuChuyenDoi()
        {
            GiaTri = 0;
            DonViNguon = " ";
            DonViDich = " ";
            KetQua = 0;
            ThoiGian = DateTime.Now;
        }
        public LichSuChuyenDoi(double giaTri, string donViNguon, string donViDich, double ketQua)
        {
            GiaTri = giaTri;
            DonViNguon = donViNguon;
            DonViDich = donViDich;
            KetQua = ketQua;
            ThoiGian = DateTime.Now;
        }
    }
}
