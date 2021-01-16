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
    public partial class ChonChuVu : Form
    {
        public ChonChuVu()
        {
            InitializeComponent();
        }

        private void BtAdmin_Click(object sender, EventArgs e)
        {
            foAdmin foAdmin = new foAdmin();
            this.Hide();
            foAdmin.ShowDialog();
        }

        private void BtQLKho_Click(object sender, EventArgs e)
        {
            foQLKho foKho = new foQLKho();
            this.Hide();
            foKho.ShowDialog();
        }

        private void BtNhanVien_Click(object sender, EventArgs e)
        {
            foBanHang foBanHang = new foBanHang();
            this.Hide();
            foBanHang.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
