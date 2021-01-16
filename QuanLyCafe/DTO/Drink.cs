using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Drink
    {
        public Drink(string maNuoc, string name, string loaiNuoc, int gia)
        {
            this.MaNuoc = maNuoc;
            this.Name = name;
            this.Loai = loaiNuoc;
            this.Gia = gia;
        }

        public Drink(DataRow row)
        {
            this.MaNuoc = row["MaNuoc"].ToString();
            this.Name = row["TenNuoc"].ToString();
            this.Loai = row["MaLN"].ToString();
            this.Gia = Convert.ToInt32(row["GiaNuoc"]);
        }

        private int gia;

        private string LoaiNuoc;

        public string Loai
        {
            get { return LoaiNuoc; }
            set { LoaiNuoc = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string maNuoc;

        

        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public string MaNuoc { get => maNuoc; set => maNuoc = value; }
    }
}

