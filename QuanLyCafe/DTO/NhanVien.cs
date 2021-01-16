using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class NhanVien
    {
        private string maNV;
        private string teNV;
        private string gioiTinh;
        private DateTime ngayVaoLam;
        private string sDT;
        private string maChucVu;

        public NhanVien() { }


        public NhanVien(string maNv, string tenNv,string gioiTinh,DateTime ngayVaoLam,string sDT,string maChucVu)
        {
            this.MaNV = maNv;
            this.TeNV = tenNv;
            this.GioiTinh = gioiTinh;
           this.NgayVaoLam = ngayVaoLam;
            this.SDT = sDT;
            this.MaChucVu = maChucVu;
        }

        public NhanVien(DataRow row)
        {
            this.MaNV = row["Manv"].ToString();
            this.TeNV = row["TenNV"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString(); ;
            this.NgayVaoLam = (DateTime)row["ngayVaoLam"];
            this.SDT = row["SDT"].ToString();
            this.MaChucVu = row["maChucVu"].ToString();
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TeNV { get => teNV; set => teNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
    } 
}
