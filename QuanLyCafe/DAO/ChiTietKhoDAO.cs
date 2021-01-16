using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    
        public class ChiTietKhoDAO
        {
            private static ChiTietKhoDAO instance;

            public static ChiTietKhoDAO Instance
            {
                get
                {
                    if (instance == null)
                        instance = new ChiTietKhoDAO();
                    return instance;
                }
                private set => instance = value;
            }


            public ChiTietKhoDAO() { }
        public List<ChiTietKho> chiTietKhoD()
        {
            List<ChiTietKho> chiTietKho = new List<ChiTietKho>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from chitietphieunhapkho");
            foreach (DataRow datas in data.Rows)
            {
                ChiTietKho table = new ChiTietKho(datas);
                chiTietKho.Add(table);
            }
            return chiTietKho;
        }
    }
}
