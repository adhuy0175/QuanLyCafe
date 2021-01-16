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
    public partial class foQLKho : Form
    {
        public foQLKho()
        {
            InitializeComponent();
        }

        private void QLKHO_Load(object sender, EventArgs e)
        {
            loadKho();
        }
        public void loadKho()
        {
            string query = "select * from chitietphieunhapkho";
            dgvKho.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvKho.Rows[e.RowIndex];
            tbKhoPhieuNhap.Text = row.Cells[0].Value.ToString();
            tbKhoId.Text = row.Cells[1].Value.ToString();
            tbName.Text = row.Cells[2].Value.ToString();
            tbKhoSL.Text = row.Cells[3].Value.ToString();
        }
    }
}
