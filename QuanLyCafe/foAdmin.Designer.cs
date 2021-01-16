
using Microsoft.Reporting.WinForms;

namespace QuanLyCafe
{
    partial class foAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foAdmin));
            this.quanLyQuanCafeDataSet1 = new QuanLyCafe.QuanLyQuanCafeDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btUpdateCa = new System.Windows.Forms.Button();
            this.btDeleteCa = new System.Windows.Forms.Button();
            this.btAddCa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dTPGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dTPGioVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdCa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalaries = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTenCa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DgvShifts = new System.Windows.Forms.DataGridView();
            this.ManagingEmployeesTC = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbgioitinh = new System.Windows.Forms.TextBox();
            this.btnNvUpdate = new System.Windows.Forms.Button();
            this.btnNvDelete = new System.Windows.Forms.Button();
            this.btNvAdd = new System.Windows.Forms.Button();
            this.dTPNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNvPhone = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.TbNvId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbNvName = new System.Windows.Forms.TextBox();
            this.MSlb = new System.Windows.Forms.Label();
            this.Admintc = new System.Windows.Forms.TabControl();
            this.DThutc = new System.Windows.Forms.TabPage();
            this.tbDoanhThu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btThongKe = new System.Windows.Forms.Button();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.DtpkfromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShifts)).BeginInit();
            this.ManagingEmployeesTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Admintc.SuspendLayout();
            this.DThutc.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyQuanCafeDataSet1
            // 
            this.quanLyQuanCafeDataSet1.DataSetName = "QuanLyQuanCafeDataSet";
            this.quanLyQuanCafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.DgvShifts);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1634, 631);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Quản lý ca làm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btUpdateCa);
            this.groupBox2.Controls.Add(this.btDeleteCa);
            this.groupBox2.Controls.Add(this.btAddCa);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.dTPGioKetThuc);
            this.groupBox2.Controls.Add(this.dTPGioVaoLam);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbIdCa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbSalaries);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbTenCa);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(397, 625);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý ca làm";
            // 
            // btUpdateCa
            // 
            this.btUpdateCa.ForeColor = System.Drawing.Color.Maroon;
            this.btUpdateCa.Location = new System.Drawing.Point(260, 454);
            this.btUpdateCa.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdateCa.Name = "btUpdateCa";
            this.btUpdateCa.Size = new System.Drawing.Size(100, 28);
            this.btUpdateCa.TabIndex = 38;
            this.btUpdateCa.Text = "Sửa";
            this.btUpdateCa.UseVisualStyleBackColor = true;
            // 
            // btDeleteCa
            // 
            this.btDeleteCa.ForeColor = System.Drawing.Color.Maroon;
            this.btDeleteCa.Location = new System.Drawing.Point(152, 454);
            this.btDeleteCa.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteCa.Name = "btDeleteCa";
            this.btDeleteCa.Size = new System.Drawing.Size(100, 28);
            this.btDeleteCa.TabIndex = 39;
            this.btDeleteCa.Text = "Xóa";
            this.btDeleteCa.UseVisualStyleBackColor = true;
            // 
            // btAddCa
            // 
            this.btAddCa.ForeColor = System.Drawing.Color.Maroon;
            this.btAddCa.Location = new System.Drawing.Point(44, 454);
            this.btAddCa.Margin = new System.Windows.Forms.Padding(4);
            this.btAddCa.Name = "btAddCa";
            this.btAddCa.Size = new System.Drawing.Size(100, 28);
            this.btAddCa.TabIndex = 40;
            this.btAddCa.Text = "Thêm";
            this.btAddCa.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(44, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 116);
            this.panel3.TabIndex = 33;
            // 
            // dTPGioKetThuc
            // 
            this.dTPGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPGioKetThuc.Location = new System.Drawing.Point(120, 281);
            this.dTPGioKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPGioKetThuc.Name = "dTPGioKetThuc";
            this.dTPGioKetThuc.Size = new System.Drawing.Size(156, 24);
            this.dTPGioKetThuc.TabIndex = 15;
            // 
            // dTPGioVaoLam
            // 
            this.dTPGioVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPGioVaoLam.Location = new System.Drawing.Point(120, 239);
            this.dTPGioVaoLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPGioVaoLam.Name = "dTPGioVaoLam";
            this.dTPGioVaoLam.Size = new System.Drawing.Size(156, 24);
            this.dTPGioVaoLam.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giờ kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giờ vào làm";
            // 
            // tbIdCa
            // 
            this.tbIdCa.Location = new System.Drawing.Point(120, 155);
            this.tbIdCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdCa.Name = "tbIdCa";
            this.tbIdCa.Size = new System.Drawing.Size(219, 24);
            this.tbIdCa.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã ca";
            // 
            // tbSalaries
            // 
            this.tbSalaries.Location = new System.Drawing.Point(120, 321);
            this.tbSalaries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalaries.Name = "tbSalaries";
            this.tbSalaries.Size = new System.Drawing.Size(219, 24);
            this.tbSalaries.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Lương";
            // 
            // tbTenCa
            // 
            this.tbTenCa.Location = new System.Drawing.Point(120, 196);
            this.tbTenCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenCa.Name = "tbTenCa";
            this.tbTenCa.Size = new System.Drawing.Size(219, 24);
            this.tbTenCa.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên ca";
            // 
            // DgvShifts
            // 
            this.DgvShifts.AllowUserToAddRows = false;
            this.DgvShifts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShifts.Location = new System.Drawing.Point(411, 6);
            this.DgvShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvShifts.Name = "DgvShifts";
            this.DgvShifts.RowHeadersWidth = 51;
            this.DgvShifts.RowTemplate.Height = 24;
            this.DgvShifts.Size = new System.Drawing.Size(1076, 625);
            this.DgvShifts.TabIndex = 2;
            // 
            // ManagingEmployeesTC
            // 
            this.ManagingEmployeesTC.Controls.Add(this.dgvNV);
            this.ManagingEmployeesTC.Controls.Add(this.groupBox1);
            this.ManagingEmployeesTC.Location = new System.Drawing.Point(4, 25);
            this.ManagingEmployeesTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManagingEmployeesTC.Name = "ManagingEmployeesTC";
            this.ManagingEmployeesTC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManagingEmployeesTC.Size = new System.Drawing.Size(1634, 631);
            this.ManagingEmployeesTC.TabIndex = 2;
            this.ManagingEmployeesTC.Text = "Quản lý nhân viên";
            this.ManagingEmployeesTC.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(408, 6);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(861, 619);
            this.dgvNV.TabIndex = 1;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NV);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.tbgioitinh);
            this.groupBox1.Controls.Add(this.btnNvUpdate);
            this.groupBox1.Controls.Add(this.btnNvDelete);
            this.groupBox1.Controls.Add(this.btNvAdd);
            this.groupBox1.Controls.Add(this.dTPNgayVaoLam);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbNvPhone);
            this.groupBox1.Controls.Add(this.tbPosition);
            this.groupBox1.Controls.Add(this.TbNvId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbNvName);
            this.groupBox1.Controls.Add(this.MSlb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(397, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // tbgioitinh
            // 
            this.tbgioitinh.Location = new System.Drawing.Point(131, 241);
            this.tbgioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbgioitinh.Name = "tbgioitinh";
            this.tbgioitinh.Size = new System.Drawing.Size(219, 24);
            this.tbgioitinh.TabIndex = 34;
            // 
            // btnNvUpdate
            // 
            this.btnNvUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.btnNvUpdate.Location = new System.Drawing.Point(245, 443);
            this.btnNvUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnNvUpdate.Name = "btnNvUpdate";
            this.btnNvUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnNvUpdate.TabIndex = 11;
            this.btnNvUpdate.Text = "Sửa";
            this.btnNvUpdate.UseVisualStyleBackColor = true;
            this.btnNvUpdate.Click += new System.EventHandler(this.btnNvUpdate_Click);
            // 
            // btnNvDelete
            // 
            this.btnNvDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnNvDelete.Location = new System.Drawing.Point(137, 443);
            this.btnNvDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnNvDelete.Name = "btnNvDelete";
            this.btnNvDelete.Size = new System.Drawing.Size(100, 28);
            this.btnNvDelete.TabIndex = 10;
            this.btnNvDelete.Text = "Xóa";
            this.btnNvDelete.UseVisualStyleBackColor = true;
            this.btnNvDelete.Click += new System.EventHandler(this.btnNvDelete_Click);
            // 
            // btNvAdd
            // 
            this.btNvAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btNvAdd.Location = new System.Drawing.Point(29, 443);
            this.btNvAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btNvAdd.Name = "btNvAdd";
            this.btNvAdd.Size = new System.Drawing.Size(100, 28);
            this.btNvAdd.TabIndex = 9;
            this.btNvAdd.Text = "Thêm";
            this.btNvAdd.UseVisualStyleBackColor = true;
            this.btNvAdd.Click += new System.EventHandler(this.btNvAdd_Click);
            // 
            // dTPNgayVaoLam
            // 
            this.dTPNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgayVaoLam.Location = new System.Drawing.Point(131, 320);
            this.dTPNgayVaoLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPNgayVaoLam.Name = "dTPNgayVaoLam";
            this.dTPNgayVaoLam.Size = new System.Drawing.Size(156, 24);
            this.dTPNgayVaoLam.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(45, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 116);
            this.panel1.TabIndex = 33;
            // 
            // tbNvPhone
            // 
            this.tbNvPhone.Location = new System.Drawing.Point(131, 283);
            this.tbNvPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNvPhone.Name = "tbNvPhone";
            this.tbNvPhone.Size = new System.Drawing.Size(156, 24);
            this.tbNvPhone.TabIndex = 6;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(131, 367);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(156, 24);
            this.tbPosition.TabIndex = 8;
            // 
            // TbNvId
            // 
            this.TbNvId.Location = new System.Drawing.Point(131, 155);
            this.TbNvId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbNvId.Name = "TbNvId";
            this.TbNvId.Size = new System.Drawing.Size(219, 24);
            this.TbNvId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(7, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "Ngày vào làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chức vụ";
            // 
            // TbNvName
            // 
            this.TbNvName.Location = new System.Drawing.Point(131, 194);
            this.TbNvName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbNvName.Name = "TbNvName";
            this.TbNvName.Size = new System.Drawing.Size(219, 24);
            this.TbNvName.TabIndex = 2;
            // 
            // MSlb
            // 
            this.MSlb.AutoSize = true;
            this.MSlb.BackColor = System.Drawing.Color.Transparent;
            this.MSlb.ForeColor = System.Drawing.Color.White;
            this.MSlb.Location = new System.Drawing.Point(7, 201);
            this.MSlb.Name = "MSlb";
            this.MSlb.Size = new System.Drawing.Size(58, 18);
            this.MSlb.TabIndex = 0;
            this.MSlb.Text = "Họ tên";
            // 
            // Admintc
            // 
            this.Admintc.Controls.Add(this.DThutc);
            this.Admintc.Controls.Add(this.ManagingEmployeesTC);
            this.Admintc.Controls.Add(this.tabPage1);
            this.Admintc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admintc.Location = new System.Drawing.Point(3, -4);
            this.Admintc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admintc.Name = "Admintc";
            this.Admintc.SelectedIndex = 0;
            this.Admintc.Size = new System.Drawing.Size(1642, 660);
            this.Admintc.TabIndex = 0;
            // 
            // DThutc
            // 
            this.DThutc.BackColor = System.Drawing.Color.Black;
            this.DThutc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DThutc.BackgroundImage")));
            this.DThutc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DThutc.Controls.Add(this.tbDoanhThu);
            this.DThutc.Controls.Add(this.label14);
            this.DThutc.Controls.Add(this.groupBox3);
            this.DThutc.Controls.Add(this.dgvDoanhThu);
            this.DThutc.Location = new System.Drawing.Point(4, 25);
            this.DThutc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DThutc.Name = "DThutc";
            this.DThutc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DThutc.Size = new System.Drawing.Size(1634, 631);
            this.DThutc.TabIndex = 0;
            this.DThutc.Text = "Doanh thu";
            // 
            // tbDoanhThu
            // 
            this.tbDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoanhThu.Location = new System.Drawing.Point(940, 576);
            this.tbDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDoanhThu.Multiline = true;
            this.tbDoanhThu.Name = "tbDoanhThu";
            this.tbDoanhThu.Size = new System.Drawing.Size(283, 46);
            this.tbDoanhThu.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(767, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tổng doanh thu";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btThongKe);
            this.groupBox3.Controls.Add(this.DtpToDate);
            this.groupBox3.Controls.Add(this.DtpkfromDate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(227, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(997, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doanh thu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(688, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 116);
            this.panel2.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Đến ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Từ ngày";
            // 
            // btThongKe
            // 
            this.btThongKe.AutoSize = true;
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.ForeColor = System.Drawing.Color.Black;
            this.btThongKe.Location = new System.Drawing.Point(433, 41);
            this.btThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(127, 37);
            this.btThongKe.TabIndex = 5;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            // 
            // DtpToDate
            // 
            this.DtpToDate.Location = new System.Drawing.Point(123, 66);
            this.DtpToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(283, 24);
            this.DtpToDate.TabIndex = 4;
            // 
            // DtpkfromDate
            // 
            this.DtpkfromDate.Location = new System.Drawing.Point(123, 21);
            this.DtpkfromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpkfromDate.Name = "DtpkfromDate";
            this.DtpkfromDate.Size = new System.Drawing.Size(283, 24);
            this.DtpkfromDate.TabIndex = 3;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(227, 142);
            this.dgvDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(997, 423);
            this.dgvDoanhThu.TabIndex = 2;
            // 
            // foAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 646);
            this.Controls.Add(this.Admintc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "foAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCafeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShifts)).EndInit();
            this.ManagingEmployeesTC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Admintc.ResumeLayout(false);
            this.DThutc.ResumeLayout(false);
            this.DThutc.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyQuanCafeDataSet quanLyQuanCafeDataSet1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl Admintc;
        private System.Windows.Forms.TabPage DThutc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.DateTimePicker DtpkfromDate;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.TabPage ManagingEmployeesTC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox TbNvId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbNvName;
        private System.Windows.Forms.Label MSlb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dTPGioKetThuc;
        private System.Windows.Forms.DateTimePicker dTPGioVaoLam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdCa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSalaries;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTenCa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvShifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPNgayVaoLam;
        private System.Windows.Forms.TextBox tbNvPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDoanhThu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnNvUpdate;
        private System.Windows.Forms.Button btnNvDelete;
        private System.Windows.Forms.Button btNvAdd;
        private System.Windows.Forms.Button btUpdateCa;
        private System.Windows.Forms.Button btDeleteCa;
        private System.Windows.Forms.Button btAddCa;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox tbgioitinh;
    }
}