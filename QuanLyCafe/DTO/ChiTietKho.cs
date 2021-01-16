using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class ChiTietKho
    {
        private string maPhieuNhap;
        private string maSp;
        private int sLSp;
        private int donGia;

        public ChiTietKho(string maPhieuNhap,string maSp,int sL,int donGia) 
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.MaSp = maSp;
            this.SLSp = sL;
            this.DonGia = donGia;
        }
        public ChiTietKho(DataRow row)
        {
            this.MaPhieuNhap = row["soPhieuNhap"].ToString() ;
            this.MaSp =row["maSp"].ToString() ;
            this.SLSp = Convert.ToInt32(row["Soluongsp"]);
            this.DonGia =Convert.ToInt32(row["donGia"] );
        }
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string MaSp { get => maSp; set => maSp = value; }
        public int SLSp { get => sLSp; set => sLSp = value; }
        public int DonGia { get => donGia; set => donGia = value; }
    }
}
