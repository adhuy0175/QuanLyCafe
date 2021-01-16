using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCafe
{
    public partial class foBanHang : Form
    {
        public foBanHang()
        {
            InitializeComponent();


            showListBill(1);
        }

        void showListBill(int id)
        {
            lvThanhToan.Items.Clear();
            List<Menus> listBillInfo = MenuDAO.Instance.GetListMenu(id);

            float MainPrice = 0;

            //add du lieu vao table chi tiet hoa don 
            foreach (Menus item in listBillInfo)
            {
                ListViewItem listViewItem = new ListViewItem(item.DrinkName.ToString());
                listViewItem.SubItems.Add(item.TongMon.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                MainPrice += item.TotalPrice;
                lvThanhToan.Items.Add(listViewItem);
            }
            //chuyen doi tien te sang nuoc viet nam -- en-US my~ 
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TbMainTotal.Text = MainPrice.ToString("c", cultureInfo);
        }
        #region tai loai nuoc len 
        private void LoadDrinkNN()
        {

            flMenu.Controls.Clear();
            List<Drink> DrinkList = DrinkDAO.Instance.LoadDrinkListNN();
            foreach (Drink item in DrinkList)
            {

                Button btn = new Button() { Width = DrinkDAO.DrinkWidth, Height = DrinkDAO.DrinkHeigh };

                btn.Text = item.Name + Environment.NewLine + item.Gia;
                flMenu.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Tag = item;
            }
            
        }

        

        private void Btn_Click(object sender, EventArgs e)
        {
            string IdBill = ((sender as Button).Tag as Drink).MaNuoc;
            int SLNuoc = (int)(nuSLMon.Value);
            BillInfoDAO.Instance.InsertBillInfo(1, IdBill, SLNuoc);
            showListBill(1);
        }

        private void LoadDrinkK()
        {
            flMenu.Controls.Clear();
            List<Drink> DrinkList = DrinkDAO.Instance.LoadDrinkListK();
            foreach (Drink item in DrinkList)
            {

                Button btnK = new Button() { Width = DrinkDAO.DrinkWidth, Height = DrinkDAO.DrinkHeigh };
                btnK.Text = item.Name + Environment.NewLine + item.Gia;
                flMenu.Controls.Add(btnK);
            }
        }


        private void LoadDrinkCF()
        {
            flMenu.Controls.Clear();
            List<Drink> DrinkList = DrinkDAO.Instance.LoadDrinkListCF();
            foreach (Drink item in DrinkList)
            {

                Button btn = new Button() { Width = DrinkDAO.DrinkWidth, Height = DrinkDAO.DrinkHeigh };

                btn.Text = item.Name + Environment.NewLine + item.Gia;

                flMenu.Controls.Add(btn);
            }
        }

        private void LoadDrinkST()
        {
            flMenu.Controls.Clear();
            List<Drink> DrinkList = DrinkDAO.Instance.LoadDrinkListST();
            foreach (Drink item in DrinkList)
            {

                Button btn = new Button() { Width = DrinkDAO.DrinkWidth, Height = DrinkDAO.DrinkHeigh };

                btn.Text = item.Name + Environment.NewLine + item.Gia;
                lvThanhToan.Controls.Add(btn);
                flMenu.Controls.Add(btn);
            }
        }

        #endregion





        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foAdmin af = new foAdmin();
            this.Hide();
            af.ShowDialog();
            this.Show();
        }


        private void quaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foQLKho qlk = new foQLKho();
            this.Hide();
            qlk.ShowDialog();
            this.Show();
        }


        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foThongTinNhanVien1 fo = new foThongTinNhanVien1();
            fo.ShowDialog();
        }



        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            foLogin foLogin = new foLogin();
            foLogin.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            foLogin foLogin = new foLogin();
            foLogin.Show();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            Bills thanhtoan = new Bills();
            thanhtoan.ShowDialog();
        }

        private void btCafe_Click(object sender, EventArgs e)
        {
            LoadDrinkCF();
        }

        private void btNn_Click(object sender, EventArgs e)
        {
            LoadDrinkNN();
        }

        private void BtKem_Click(object sender, EventArgs e)
        {

            LoadDrinkK();
        }

        private void BtSinhTo_Click(object sender, EventArgs e)
        {
            LoadDrinkST();
        }

        

        private void foBanHang_Load(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }


    }
