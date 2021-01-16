using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class ChiTietBill
    {
        private int maHD;
        private string maNuoc;
        private int soLuongNuoc;

        public ChiTietBill(int maHD, string maNuoc, int soLuongNuoc)
        {
            this.maHD = MaHD;
            this.maNuoc = MaNuoc;      
            this.soLuongNuoc = SoLuongNuoc;
        }

        public ChiTietBill(DataRow row)
        {
            this.MaHD = Convert.ToInt32(row["MaHD"]);
            this.MaNuoc = row["MaNuoc"].ToString();
            this.SoLuongNuoc =Convert.ToInt32(row["SoLuongNuoc"]);
        }


        public int MaHD { get => maHD; set => maHD = value; }
        public string MaNuoc { get => maNuoc; set => maNuoc = value; }
        public int SoLuongNuoc { get => soLuongNuoc; set => soLuongNuoc = value; }
    }
}
