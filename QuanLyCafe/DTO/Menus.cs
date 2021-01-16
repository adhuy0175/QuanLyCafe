using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Menus
    {
        private string drinkName;
        private int tongMon;
        private float price;
        private int totalPrice;

        public Menus(string Name,int tongMon,float price,int total = 0)
        {
            this.drinkName = Name;
            this.tongMon = tongMon;
            this.price = price;
            this.totalPrice = total;
        }

        public Menus() { }

        public Menus(DataRow row)
        {
            this.drinkName = row["tennuoc"].ToString();
            this.tongMon = Convert.ToInt32(row["soluongnuoc"]);
            this.price = Convert.ToInt32(row["gianuoc"]);
            this.totalPrice = Convert.ToInt32(row["total"]);
        }

        public string DrinkName { get => drinkName; set => drinkName = value; }
        public int TongMon { get => tongMon; set => tongMon = value; }
        public float Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
