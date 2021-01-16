using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class MenuDAO
    {
        
            private static MenuDAO instance;

            public static MenuDAO Instance
            {
                get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
                private set { MenuDAO.instance = value; }
            }

            private MenuDAO() { }

            public List<Menus> GetListMenu(int id)
            {
                List<Menus> listMenu = new List<Menus>();
            //lay danh sach chi tiet bill theo id hoa don 
                string query = "select distinct n.tennuoc , h.SoLuongNuoc,n.GiaNuoc,h.SoLuongNuoc*n.GiaNuoc as total from dbo.ChiTietHoaDon h,loainuoc l, nuoc n,hoadon hd where n.MaNuoc = h.manuoc and h.mahd = "+id;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Menus menu = new Menus(item);
                    listMenu.Add(menu);
                }

                return listMenu;
            }
        }
    }

