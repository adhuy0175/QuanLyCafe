using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class BillsDAO
    {
        private static BillsDAO instance;

        public static BillsDAO Instance
        {
            get { if (instance == null) instance = new BillsDAO(); return BillsDAO.instance; }
            private set { BillsDAO.instance = value; }
        }

        private BillsDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetBillID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM hoadon WHERE Mahd =" + id );

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }

            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @IdBill", new object[] { id });
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
        public void UpdateBillSource()
        {
            DataProvider.Instance.ExecuteNonQuery("");
        }
    }
}

