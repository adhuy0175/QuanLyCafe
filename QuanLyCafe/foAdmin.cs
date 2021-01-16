using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCafe
{
    public partial class foAdmin : Form
    {
        BindingSource NvList = new BindingSource();

        public foAdmin()
        {
            InitializeComponent();
            Loads();


        }
        public void Loads()
        {
            dgvNV.DataSource = NvList;
            NvListLoad();
            ShowDoanhThu();
            ShowCaLam();
            //AddNVBinding();
        }
        public bool InsertNV(string MaNV, string TenNV, string gioiTinh, string sdt, string maChucVu)
        {
            return NvDAO.Instance.InsertNV(MaNV, TenNV, gioiTinh, sdt, maChucVu);
        }
        public bool DeleteNV(string id)
        {
            return NvDAO.Instance.DeleteByIdNV(id);
        }
        #region MyRegion
        //private void LoadAccountList()
        //{
        //    string connectionString = @"Data Source=MSI\HUY;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        //    SqlConnection connection = new SqlConnection(connectionString);
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="ShiftID"></param>
        ///// <returns></returns>
        //private int ShiftsRow(string ShiftID)
        //{
        //    for (int i = 0; i < DgvShifts.Rows.Count; i++) // when there is a row appear !?
        //    {
        //        if (DgvShifts.Rows[i].Cells[0].Value.ToString() == ShiftID) // 
        //        {

        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="SelectRow"></param>

        //private void InsertUpdateRow(int SelectRow)
        //{
        //    DgvShifts.Rows[SelectRow].Cells[0].Value = tbIdCa.Text;
        //    DgvShifts.Rows[SelectRow].Cells[1].Value = tbTenCa.Text;
        //    dtgvQLNV.Rows[SelectRow].Cells[2].Value = TbNvName.Text;
        //    dtgvQLNV.Rows[SelectRow].Cells[3].Value = rbMen.Checked ? "Nam" : "Nữ";
        //    DgvShifts.Rows[SelectRow].Cells[4].Value = dTPGioVaoLam.Text;
        //    DgvShifts.Rows[SelectRow].Cells[5].Value = dTPGioKetThuc.Text;
        //    dtgvQLNV.Rows[SelectRow].Cells[6].Value = tbNvPhone.Text;
        //    DgvShifts.Rows[SelectRow].Cells[7].Value = double.Parse(tbSalaries.Text).ToString();
        //}
        //////////////////////
        ///// <summary>
        ///// /
        ///// </summary>
        ///// <param name="EmployeeID"></param>
        ///// <returns></returns>


        //private int EmployeesRow(string EmployeeID)
        //{
        //    for (int i = 0; i < dtgvQLNV.Rows.Count; i++)
        //    {
        //        if (dtgvQLNV.Rows[i].Cells[0].Value.ToString() == EmployeeID)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        //private void InsertUpade(int SelectRow)
        //{
        //    dtgvQLNV.Rows[SelectRow].Cells[0].Value = TbNvId.Text;
        //    dtgvQLNV.Rows[SelectRow].Cells[1].Value = TbNvName.Text;
        //    dtgvQLNV.Rows[SelectRow].Cells[2].Value = TbNvDate1.Text;
        //    dtgvQLNV.Rows[SelectRow].Cells[3].Value = rbMen.Checked ? "Nam" : "Nữ";
        //    dtgvQLNV.Rows[SelectRow].Cells[4].Value = tbNvPhone.Text;
        //    dtgvQLNV.Rows[SelectRow].Cells[5].Value = dTPNgayVaoLam.Value.ToString();
        //    dtgvQLNV.Rows[SelectRow].Cells[6].Value = tbPosition.Text;
        //}
        //private void btnUpdateNV_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // declare select row variable
        //        int selectRow = EmployeesRow(TbNvId.Text);
        //        if (selectRow != -1) // if there is no row to select, then return to -1
        //        {
        //            InsertUpade(selectRow);// select some row
        //            MessageBox.Show("Update information successful!", "Notification", MessageBoxButtons.OK);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
        //private void btnAddNV_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        if (TbNvId.Text == "" || TbNvName.Text == "" || TbNvDate1.Text == "" || tbNvPhone.Text == "")
        //            throw new Exception("Please fill in employees information!!");


        //        // check if it is a phone number
        //        #region Checking phone number
        //        uint Sdt = 0;
        //        if (uint.TryParse(tbNvPhone.Text, out Sdt))
        //        {

        //        }
        //        else
        //        {
        //            // MessageBox.Show("Khong phai la so dt");
        //            throw new Exception("Please input correct Phone number!");
        //        }
        //        #endregion

        //        // check if phone number > 10
        //        tbNvPhone.MaxLength = 10;


        //        int selectRow = EmployeesRow(TbNvId.Text);
        //        if (selectRow == -1)
        //        {
        //            selectRow = dtgvQLNV.Rows.Add();
        //            InsertUpade(selectRow);
        //            MessageBox.Show("Add information successful!", "Notification", MessageBoxButtons.OK);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private void btnDelNV_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int selectRow = EmployeesRow(TbNvId.Text);
        //        if (selectRow == -1)
        //        {
        //            throw new Exception("Cannot find any employee id to delete!");
        //        }
        //        else
        //        {
        //            DialogResult dr = MessageBox.Show("Do you want to delete this employee ?", "YES/NO", MessageBoxButtons.YesNo);
        //            if (dr == DialogResult.Yes)
        //            {
        //                dtgvQLNV.Rows.RemoveAt(selectRow);
        //                MessageBox.Show("Delete employee successful!", "Notification", MessageBoxButtons.OK);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //private void dgvTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        // Represent a rows in Dgv of Employee
        //        DataGridViewRow row = this.dtgvQLNV.Rows[e.RowIndex];
        //        // ... select the row will show back to the input information !
        //        TbNvId.Text = row.Cells[0].Value.ToString();
        //        TbNvName.Text = row.Cells[1].Value.ToString();
        //        TbNvDate1.Text = row.Cells[2].Value.ToString();
        //        if (row.Cells[3].Value.ToString() == "Nam")
        //        {
        //            rbMen.Checked = true;
        //        }
        //        else if (row.Cells[3].Value.ToString() == "Nữ")
        //        {
        //            rbGirl.Checked = true;
        //        }
        //        tbNvPhone.Text = row.Cells[4].Value.ToString();
        //        dTPNgayVaoLam.Text = row.Cells[5].Value.ToString();
        //        tbPosition.Text = row.Cells[6].Value.ToString();

        //    }
        //}

        //private void Admin_Load(object sender, EventArgs e)
        //{



        //}

        //// Quan Ly Ca lam....
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnAddCa_Click(object sender, EventArgs e)
        //{

        //    if (tbIdCa.Text == "" || tbTenCa.Text == "" || tbSalaries.Text == "")
        //        throw new Exception("Please fill in information!");

        //    int selectRow = ShiftsRow(tbIdCa.Text);
        //    if (selectRow == -1)
        //    {
        //        selectRow = DgvShifts.Rows.Add();
        //        dtgvQLNV.Rows.Add();
        //        InsertUpdateRow(selectRow);
        //        MessageBox.Show("Add information successful!", "Notification", MessageBoxButtons.OK);
        //    }

        //}

        //private void btnUpdateCa_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int selectRow = ShiftsRow(tbIdCa.Text);
        //        if (selectRow != -1)
        //        {
        //            InsertUpdateRow(selectRow);
        //            //InsertUpade(selectRow);
        //            MessageBox.Show("Update information successful!", "Nofication", MessageBoxButtons.OK);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void DgvShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.DgvShifts.Rows[e.RowIndex];
        //        tbIdCa.Text = row.Cells[0].Value.ToString();
        //        tbTenCa.Text = row.Cells[1].Value.ToString();
        //        dTPGioVaoLam.Text = row.Cells[4].Value.ToString();
        //        dTPGioKetThuc.Text = row.Cells[5].Value.ToString();
        //        tbSalaries.Text = row.Cells[7].Value.ToString();
        //    }
        //}

        //private void btnDelCa_Click(object sender, EventArgs e)
        //{
        //    int selectRow = ShiftsRow(tbIdCa.Text);
        //    if (selectRow == -1)
        //    {
        //        throw new Exception("Cannot find any employee's shifts to delete!");
        //    }
        //    else
        //    {
        //        DialogResult dr = MessageBox.Show("Hmm...Are you sure want to delete this employee's shifts?", "YES/NO", MessageBoxButtons.YesNo);
        //        if (dr == DialogResult.Yes)
        //        {
        //            DgvShifts.Rows.RemoveAt(selectRow);
        //            MessageBox.Show("Delete employee's shifts successful!", "Notification", MessageBoxButtons.OK);
        //        }
        //    }
        //}
        #endregion
        #region them xoa sua
        //public void AddNV(string MaNV, string TenNV, string gioiTinh, DateTime ngayvaolam, string sdt, string maChucVu)
        //{
        //    string Manv = TbNvId.Text;
        //    string Tennv = TbNvName.Text;
        //    string gioitinh = tbgioitinh.Text;
        //    DateTime Ngayvaolam = dTPNgayVaoLam.Value;
        //    string Sdt = tbNvPhone.Text;
        //    string MaChucVu = tbPosition.Text;

        //    if (InsertNV(Manv, Tennv, gioitinh, Ngayvaolam, Sdt, MaChucVu))
        //    {
        //        MessageBox.Show("Thêm tài khoản thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm tài khoản thất bại");
        //    }

        //}

        //void EditAccount(string userName, string displayName, int type)
        //{
        //    if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
        //    {
        //        MessageBox.Show("Cập nhật tài khoản thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Cập nhật tài khoản thất bại");
        //    }

        //    LoadAccount();
        //}

        //void DeleteAccount(string userName)
        //{
        //    if (loginAccount.UserName.Equals(userName))
        //    {
        //        MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
        //        return;
        //    }
        //    if (AccountDAO.Instance.DeleteAccount(userName))
        //    {
        //        MessageBox.Show("Xóa tài khoản thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Xóa tài khoản thất bại");
        //    }

        //    LoadAccount();
        //}

        #endregion
        public void NvListLoad()
        {
            NvList.DataSource = NvDAO.Instance.GetListNV();
        }

        public void ShowCaLam()
        {
            string query = "select * from calamviec";
            DgvShifts.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        
        public void ShowDoanhThu()
        {
            string query = "select * from hoadon";
            string query1 = "select sum(tongtien) from hoadon ";
            dgvDoanhThu.DataSource = DataProvider.Instance.ExecuteQuery(query);
            tbDoanhThu.Text = DataProvider.Instance.ExecuteScalar(query1).ToString();
        }

        private void btNvAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Manv = TbNvId.Text;
                string Tennv = TbNvName.Text;
                string gioitinh = tbgioitinh.Text;
                string Sdt = tbNvPhone.Text;
                string MaChucVu = tbPosition.Text;

                if (InsertNV(Manv, Tennv, gioitinh, Sdt, MaChucVu))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            NvListLoad();
        }
       
        private void btnNvDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string Manv = TbNvId.Text;
            if (NvDAO.Instance.DeleteByIdNV(Manv))
            {
                MessageBox.Show("Xoá NV  thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xóa NV");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            NvListLoad();
        }

        private int GetSelectedRows (string id)
        {
            for (int i = 0; i < dgvNV.Rows.Count; i++)
            {
                if (dgvNV.Rows[i].Cells[0].Value.ToString() ==id)
                {
                    return i;
                }
                
            }
            return -1;
        }
        private void btnNvUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                int selectRow = GetSelectedRows(TbNvId.Text);
                string id = TbNvId.Text;
                string Tennv = TbNvName.Text;
                string gioitinh = tbgioitinh.Text;
                string Sdt = tbNvPhone.Text;
                string MaChucVu = tbPosition.Text;
                if (selectRow != -1)
                {
                    NvDAO.Instance.UpdateNV(id, Tennv, gioitinh, Sdt, MaChucVu);

                    MessageBox.Show("Update information successful!", "Nofication", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            NvListLoad();
        }

        private void NV(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvNV.Rows[e.RowIndex];
            TbNvId.Text = row.Cells[0].Value.ToString();
            TbNvName.Text = row.Cells[1].Value.ToString();
            tbgioitinh.Text = row.Cells[2].Value.ToString();
            tbNvPhone.Text = row.Cells[3].Value.ToString();
            tbPosition.Text= row.Cells[4].Value.ToString();
        }
    }
}