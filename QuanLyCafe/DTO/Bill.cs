using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Bill
    {
        private int id;
        private string maNV;
        private int tongTien;
        private int SLhangTong;

        public Bill(int id, string maNV, int tongTien, int SLhangTong)
        {
            this.id = Id;
            this.maNV = MaNV;
            this.tongTien = TongTien;
            this.SLhangTong = SLhangTong1;
        }

        public Bill(DataRow row)
        {
            this.Id = Convert.ToInt32(row["MaHD"]);
            this.MaNV = row["MaNV"].ToString();
            this.TongTien = Convert.ToInt32(row["TongTien"]);
            this.SLhangTong1 = Convert.ToInt32(row["SLHang"]);
        }

        public int Id { get => id; set => id = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int SLhangTong1 { get => SLhangTong; set => SLhangTong = value; }
    }
}
