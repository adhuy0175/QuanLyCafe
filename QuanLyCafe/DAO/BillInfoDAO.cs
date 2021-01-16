using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO();return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }


        private BillInfoDAO() { }

        public List<ChiTietBill> LoadListBillInfo(int id)
        {
            List<ChiTietBill> BillInfoList = new List<ChiTietBill>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ChiTiethoadon where MaHd = " + id);

            foreach (DataRow item in data.Rows)
            {
                ChiTietBill info = new ChiTietBill(item);
                BillInfoList.Add(info);
            }

            return BillInfoList;
        }
        public void InsertBillInfo(int idBill,string idFood,int count)
        {
            string query = string.Format("USP_InsertInfoBill {0},{1},{2}", idBill, idFood, count);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void InsertMaxIdBill()
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertNextBill");
        }
        public void updateBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_UpdateBill @idBill", new object[] { id });
        }
        public int getMaxBillId()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(mahd) from hoadon");

            }
            catch (Exception)
            {

                return 1;
            }
        }
    }
}

