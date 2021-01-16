
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;
namespace QuanLyCafe.DAO
{
    public class NvDAO
    {
        private static NvDAO instance;

        public static NvDAO Instance
        {
            get 
            { 
                if (instance == null) 
                    instance = new NvDAO(); 
                return instance; 
            }
           private set => instance = value; }


        private NvDAO() { }

        public List<NhanVien> LoadNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from nhanvien");
            foreach (DataRow datas in data.Rows)
            {
                NhanVien table = new NhanVien(datas);
                nhanViens.Add(table);
            }
            return nhanViens;
        }
        public bool InsertNV(string MaNV, string TenNV, string gioiTinh, string sdt, string maChucVu)
        {
            string query = string.Format("INSERT dbo.NhanVien  ( MaNV,TenNV,GioiTinh,SDT,MaChucVu)VALUES  ( '{0}', N'{1}', '{2}','{3}','{4}')", MaNV, TenNV, gioiTinh, sdt, maChucVu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        

        public bool UpdateNV(string MaNV, string TenNV, string gioiTinh, string sdt, string maChucVu)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET MaNV='{0}' , TenNV=N'{1}' ,GioiTinh='{2}',sdt='{3}',machucvu='{4}'", MaNV, TenNV, gioiTinh, sdt, maChucVu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteByIdNV(string id)
        {
            string query = string.Format("Delete Nhanvien where MaNV = N'{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable GetListNV()
        {
            return DataProvider.Instance.ExecuteQuery("select * from Nhanvien");
        }
    }

}   

    

