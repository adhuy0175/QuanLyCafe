using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;

        public static int DrinkWidth = 70;
        public static int DrinkHeigh = 70;

        public static DrinkDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DrinkDAO();
                return instance;
            }
            private set => instance = value;
        }


        private DrinkDAO() { }


        #region hien thi loai nuoc theo panel

        public List<Drink> LoadDrinkListCF()
        {
            List<Drink> DrinkList = new List<Drink>();


            string query = "select a.manuoc,a.tennuoc,a.maln,a.gianuoc from nuoc a,loainuoc b where b.maln =a.maln and b.maln ='CF'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                DrinkList.Add(drink);
            }

            return DrinkList;
        }

        public List<Drink> LoadDrinkListK()
        {
            List<Drink> DrinkList = new List<Drink>();


            string query = "select a.manuoc,a.tennuoc,a.maln,a.gianuoc from nuoc a,loainuoc b where b.maln =a.maln and b.maln = 'K'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                DrinkList.Add(drink);
            }

            return DrinkList;
        }

        public List<Drink> LoadDrinkListNN()
        {
            List<Drink> DrinkList = new List<Drink>();


            string query = "select a.manuoc,a.tennuoc,a.maln,a.gianuoc from nuoc a,loainuoc b where b.maln =a.maln and b.maln = 'NN'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                DrinkList.Add(drink);

            }

            return DrinkList;
        }

        public List<Drink> LoadDrinkListST()
        {
            List<Drink> DrinkList = new List<Drink>();


            string query = "select a.manuoc,a.tennuoc,a.maln,a.gianuoc from nuoc a,loainuoc b where b.maln =a.maln and b.maln = 'ST'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                DrinkList.Add(drink);
            }

            return DrinkList;
        }



        #endregion
        public List<Drink> LoadDrinkList()
        {
            List<Drink> DrinkList = new List<Drink>();


            string query = "select a.manuoc,a.tennuoc,a.maln,a.gianuoc from nuoc a,loainuoc b where b.maln =a.maln";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                DrinkList.Add(drink);
            }

            return DrinkList;
        }
        public void InsertHoaDon(int IdBill,string MaHang,int SL)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idBill int, @idFood char,@count", new object[] { IdBill, MaHang, SL });
        }


    }   
}

