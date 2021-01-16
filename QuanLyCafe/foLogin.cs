using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCafe
{
    public partial class foLogin : Form
    {
        public foLogin()
        {
            InitializeComponent();
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }


        private void SigninBttn_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            //kiem tra dang nhap 
            if (Login(userName, password))
            {
                ChonChuVu mn = new ChonChuVu();
                this.Hide();
                mn.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!");
            }
                
           
            
        }
        // class for login and checking Username, password
        //bool Login(string Username, string password)
        //{
        //    // return username and password
        //    return AccountDAO.Instance.Login(Username, password);
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you really want to exit?", "Warning" ,MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void CheckToShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
            if (!CheckToShowPass.Checked)

                txtPassword.UseSystemPasswordChar = false;

            else
                txtPassword.UseSystemPasswordChar = true;

        }

        private void foLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
