
namespace QuanLyCafe
{
    partial class foQLKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foQLKho));
            this.MngExportImport = new System.Windows.Forms.TabControl();
            this.MngImport = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKhoSL = new System.Windows.Forms.TextBox();
            this.tbKhoId = new System.Windows.Forms.TextBox();
            this.tbKhoPhieuNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btKhoThongKe = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVShift = new System.Windows.Forms.DataGridView();
            this.DgvMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTenHang = new System.Windows.Forms.TextBox();
            this.TxtMaHang = new System.Windows.Forms.TextBox();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.MngExportImport.SuspendLayout();
            this.MngImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShift)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MngExportImport
            // 
            this.MngExportImport.Controls.Add(this.MngImport);
            this.MngExportImport.Controls.Add(this.tabPage1);
            this.MngExportImport.Location = new System.Drawing.Point(12, 12);
            this.MngExportImport.Name = "MngExportImport";
            this.MngExportImport.SelectedIndex = 0;
            this.MngExportImport.ShowToolTips = true;
            this.MngExportImport.Size = new System.Drawing.Size(1288, 664);
            this.MngExportImport.TabIndex = 0;
            // 
            // MngImport
            // 
            this.MngImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MngImport.BackgroundImage")));
            this.MngImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MngImport.Controls.Add(this.panel2);
            this.MngImport.Controls.Add(this.dgvKho);
            this.MngImport.Controls.Add(this.groupBox1);
            this.MngImport.Controls.Add(this.panel1);
            this.MngImport.Location = new System.Drawing.Point(4, 25);
            this.MngImport.Name = "MngImport";
            this.MngImport.Padding = new System.Windows.Forms.Padding(3);
            this.MngImport.Size = new System.Drawing.Size(1280, 635);
            this.MngImport.TabIndex = 0;
            this.MngImport.Text = "Quản lý nhập";
            this.MngImport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(51, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 153);
            this.panel2.TabIndex = 33;
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(553, 16);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(687, 622);
            this.dgvKho.TabIndex = 2;
            this.dgvKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbKhoSL);
            this.groupBox1.Controls.Add(this.tbKhoId);
            this.groupBox1.Controls.Add(this.tbKhoPhieuNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Hàng";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(153, 141);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 24);
            this.tbName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên hàng";
            // 
            // tbKhoSL
            // 
            this.tbKhoSL.Location = new System.Drawing.Point(153, 194);
            this.tbKhoSL.Name = "tbKhoSL";
            this.tbKhoSL.Size = new System.Drawing.Size(180, 24);
            this.tbKhoSL.TabIndex = 5;
            // 
            // tbKhoId
            // 
            this.tbKhoId.Location = new System.Drawing.Point(153, 93);
            this.tbKhoId.Name = "tbKhoId";
            this.tbKhoId.Size = new System.Drawing.Size(180, 24);
            this.tbKhoId.TabIndex = 5;
            // 
            // tbKhoPhieuNhap
            // 
            this.tbKhoPhieuNhap.Location = new System.Drawing.Point(153, 49);
            this.tbKhoPhieuNhap.Name = "tbKhoPhieuNhap";
            this.tbKhoPhieuNhap.Size = new System.Drawing.Size(180, 24);
            this.tbKhoPhieuNhap.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phiếu Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btKhoThongKe);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(7, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 160);
            this.panel1.TabIndex = 0;
            // 
            // btKhoThongKe
            // 
            this.btKhoThongKe.AutoSize = true;
            this.btKhoThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhoThongKe.Location = new System.Drawing.Point(278, 40);
            this.btKhoThongKe.Name = "btKhoThongKe";
            this.btKhoThongKe.Size = new System.Drawing.Size(132, 58);
            this.btKhoThongKe.TabIndex = 2;
            this.btKhoThongKe.Text = "Thống kê";
            this.btKhoThongKe.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 24);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGVShift);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 635);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Tra cứu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGVShift
            // 
            this.dGVShift.AllowUserToAddRows = false;
            this.dGVShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvMaHang,
            this.DgvTenHang,
            this.DgvSoLuong});
            this.dGVShift.Location = new System.Drawing.Point(409, 5);
            this.dGVShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVShift.Name = "dGVShift";
            this.dGVShift.RowHeadersWidth = 51;
            this.dGVShift.RowTemplate.Height = 24;
            this.dGVShift.Size = new System.Drawing.Size(835, 619);
            this.dGVShift.TabIndex = 3;
            // 
            // DgvMaHang
            // 
            this.DgvMaHang.HeaderText = "Mã hàng";
            this.DgvMaHang.MinimumWidth = 6;
            this.DgvMaHang.Name = "DgvMaHang";
            this.DgvMaHang.Width = 110;
            // 
            // DgvTenHang
            // 
            this.DgvTenHang.HeaderText = "Tên Hàng";
            this.DgvTenHang.MinimumWidth = 6;
            this.DgvTenHang.Name = "DgvTenHang";
            this.DgvTenHang.Width = 150;
            // 
            // DgvSoLuong
            // 
            this.DgvSoLuong.HeaderText = "Số Lượng";
            this.DgvSoLuong.MinimumWidth = 6;
            this.DgvSoLuong.Name = "DgvSoLuong";
            this.DgvSoLuong.Width = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtTenHang);
            this.groupBox3.Controls.Add(this.TxtMaHang);
            this.groupBox3.Controls.Add(this.btnAddNV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(397, 619);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(45, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 116);
            this.panel5.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tên hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Mã hàng";
            // 
            // TxtTenHang
            // 
            this.TxtTenHang.Location = new System.Drawing.Point(146, 289);
            this.TxtTenHang.Name = "TxtTenHang";
            this.TxtTenHang.Size = new System.Drawing.Size(129, 24);
            this.TxtTenHang.TabIndex = 38;
            // 
            // TxtMaHang
            // 
            this.TxtMaHang.Location = new System.Drawing.Point(146, 229);
            this.TxtMaHang.Name = "TxtMaHang";
            this.TxtMaHang.Size = new System.Drawing.Size(129, 24);
            this.TxtMaHang.TabIndex = 38;
            // 
            // btnAddNV
            // 
            this.btnAddNV.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddNV.Location = new System.Drawing.Point(219, 382);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(100, 28);
            this.btnAddNV.TabIndex = 37;
            this.btnAddNV.Text = "Tra cứu";
            this.btnAddNV.UseVisualStyleBackColor = true;
            // 
            // foQLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 688);
            this.Controls.Add(this.MngExportImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "foQLKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKHO";
            this.Load += new System.EventHandler(this.QLKHO_Load);
            this.MngExportImport.ResumeLayout(false);
            this.MngImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVShift)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MngExportImport;
        private System.Windows.Forms.TabPage MngImport;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btKhoThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbKhoSL;
        private System.Windows.Forms.TextBox tbKhoId;
        private System.Windows.Forms.TextBox tbKhoPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dGVShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTenHang;
        private System.Windows.Forms.TextBox TxtMaHang;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
    }
}