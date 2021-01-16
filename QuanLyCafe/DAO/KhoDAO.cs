using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    class KhoDAO
    {
       
            private static KhoDAO instance;

            public static KhoDAO Instance
            {
                get
                {
                    if (instance == null)
                        instance = new KhoDAO();
                    return instance;
                }
                private set => instance = value;
            }


            public KhoDAO() { }

            public List<Kho> LoadKho()
            {
                List<Kho> Kho = new List<Kho>();
                DataTable data = DataProvider.Instance.ExecuteQuery("select * from Hang");
                foreach (DataRow datas in data.Rows)
                {
                    Kho table = new Kho(datas);
                    Kho.Add(table);
                }
                return Kho;
            }
            public bool InsertKho(string masp, string tensp , int soluong)
            {
                string query = string.Format("INSERT [dbo].Hang ([MaHang], [TenHang] , NgayNhapKho,[soluongtonkho]) VALUES (N'{0}', N'{1}', GETDATE(),'{2}')", masp, tensp, soluong);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            public bool UpdateKho(string masp, string tensp, int soluong)
            {
                string query = string.Format("UPDATE dbo.Hang SET TenHang=N'{0}' ,NgayNhapKho=GETDATE(),soluongtonkho='{1}' Where MaHang=N'{2}'", tensp,soluong,masp);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            public bool DeleteKho(string masp)
            {
                string query = string.Format("Delete Hang where MaHang = N'{0}'", masp);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
        public DataTable GetListKho()
                {
                    return DataProvider.Instance.ExecuteQuery("select * from Hang");
                }

    }
}
