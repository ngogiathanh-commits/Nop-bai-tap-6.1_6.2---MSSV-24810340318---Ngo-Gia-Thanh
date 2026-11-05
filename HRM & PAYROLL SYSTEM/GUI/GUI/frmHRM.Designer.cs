namespace HRMSystem.GUI
{
    partial class frmHRM
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.nudHeSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nudLuongCoBan = new System.Windows.Forms.NumericUpDown();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHeSo = new System.Windows.Forms.Label();
            this.lblLuongCB = new System.Windows.Forms.Label();
            this.lblPB = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.cboTimPhongBan = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.btnLuuChamCong = new System.Windows.Forms.Button();
            this.btnTaiChamCong = new System.Windows.Forms.Button();
            this.txtThangNam = new System.Windows.Forms.TextBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.btnChotLuong = new System.Windows.Forms.Button();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.tabMain.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongCoBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.tabLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabNhanVien);
            this.tabMain.Controls.Add(this.tabChamCong);
            this.tabMain.Controls.Add(this.tabLuong);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(914, 561);
            this.tabMain.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.btnXoaNV);
            this.tabNhanVien.Controls.Add(this.btnSuaNV);
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.nudHeSoLuong);
            this.tabNhanVien.Controls.Add(this.nudLuongCoBan);
            this.tabNhanVien.Controls.Add(this.cboPhongBan);
            this.tabNhanVien.Controls.Add(this.dtpNgaySinh);
            this.tabNhanVien.Controls.Add(this.txtCCCD);
            this.tabNhanVien.Controls.Add(this.txtHoTen);
            this.tabNhanVien.Controls.Add(this.lblHeSo);
            this.tabNhanVien.Controls.Add(this.lblLuongCB);
            this.tabNhanVien.Controls.Add(this.lblPB);
            this.tabNhanVien.Controls.Add(this.lblCCCD);
            this.tabNhanVien.Controls.Add(this.lblNgaySinh);
            this.tabNhanVien.Controls.Add(this.lblHoTen);
            this.tabNhanVien.Controls.Add(this.cboTimPhongBan);
            this.tabNhanVien.Controls.Add(this.btnTimKiem);
            this.tabNhanVien.Controls.Add(this.txtTimKiem);
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(906, 535);
            this.tabNhanVien.TabIndex = 0;
            this.tabNhanVien.Text = "Hồ Sơ Nhân Viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(810, 115);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(80, 30);
            this.btnXoaNV.TabIndex = 18;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(720, 115);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(80, 30);
            this.btnSuaNV.TabIndex = 17;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(630, 115);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(80, 30);
            this.btnThemNV.TabIndex = 16;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // nudHeSoLuong
            // 
            this.nudHeSoLuong.DecimalPlaces = 2;
            this.nudHeSoLuong.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudHeSoLuong.Location = new System.Drawing.Point(740, 80);
            this.nudHeSoLuong.Name = "nudHeSoLuong";
            this.nudHeSoLuong.Size = new System.Drawing.Size(150, 20);
            this.nudHeSoLuong.TabIndex = 15;
            this.nudHeSoLuong.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // nudLuongCoBan
            // 
            this.nudLuongCoBan.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            this.nudLuongCoBan.Location = new System.Drawing.Point(740, 50);
            this.nudLuongCoBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudLuongCoBan.Name = "nudLuongCoBan";
            this.nudLuongCoBan.Size = new System.Drawing.Size(150, 20);
            this.nudLuongCoBan.TabIndex = 14;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(740, 20);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(150, 21);
            this.cboPhongBan.TabIndex = 13;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(480, 50);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(160, 20);
            this.dtpNgaySinh.TabIndex = 12;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(480, 80);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(160, 20);
            this.txtCCCD.TabIndex = 11;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(480, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 20);
            this.txtHoTen.TabIndex = 10;
            // 
            // lblHeSo
            // 
            this.lblHeSo.AutoSize = true;
            this.lblHeSo.Location = new System.Drawing.Point(660, 83);
            this.lblHeSo.Name = "lblHeSo";
            this.lblHeSo.Size = new System.Drawing.Size(67, 13);
            this.lblHeSo.TabIndex = 9;
            this.lblHeSo.Text = "Hệ số lương:";
            // 
            // lblLuongCB
            // 
            this.lblLuongCB.AutoSize = true;
            this.lblLuongCB.Location = new System.Drawing.Point(660, 53);
            this.lblLuongCB.Name = "lblLuongCB";
            this.lblLuongCB.Size = new System.Drawing.Size(76, 13);
            this.lblLuongCB.TabIndex = 8;
            this.lblLuongCB.Text = "Lương cơ bản:";
            // 
            // lblPB
            // 
            this.lblPB.AutoSize = true;
            this.lblPB.Location = new System.Drawing.Point(660, 23);
            this.lblPB.Name = "lblPB";
            this.lblPB.Size = new System.Drawing.Size(62, 13);
            this.lblPB.TabIndex = 7;
            this.lblPB.Text = "Phòng ban:";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(415, 83);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(39, 13);
            this.lblCCCD.TabIndex = 6;
            this.lblCCCD.Text = "CCCD:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(415, 53);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(415, 23);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 13);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // cboTimPhongBan
            // 
            this.cboTimPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimPhongBan.FormattingEnabled = true;
            this.cboTimPhongBan.Location = new System.Drawing.Point(170, 15);
            this.cboTimPhongBan.Name = "cboTimPhongBan";
            this.cboTimPhongBan.Size = new System.Drawing.Size(150, 21);
            this.cboTimPhongBan.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(330, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(65, 25);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(10, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(150, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(10, 155);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(880, 370);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // tabChamCong
            // 
            this.tabChamCong.Controls.Add(this.btnLuuChamCong);
            this.tabChamCong.Controls.Add(this.btnTaiChamCong);
            this.tabChamCong.Controls.Add(this.txtThangNam);
            this.tabChamCong.Controls.Add(this.lblThangNam);
            this.tabChamCong.Controls.Add(this.dgvChamCong);
            this.tabChamCong.Location = new System.Drawing.Point(4, 22);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabChamCong.Size = new System.Drawing.Size(906, 535);
            this.tabChamCong.TabIndex = 1;
            this.tabChamCong.Text = "Chấm Công Ngắt Kết Nối";
            this.tabChamCong.UseVisualStyleBackColor = true;
            // 
            // btnLuuChamCong
            // 
            this.btnLuuChamCong.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuuChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChamCong.Location = new System.Drawing.Point(310, 10);
            this.btnLuuChamCong.Name = "btnLuuChamCong";
            this.btnLuuChamCong.Size = new System.Drawing.Size(140, 30);
            this.btnLuuChamCong.TabIndex = 4;
            this.btnLuuChamCong.Text = "Lưu Chấm Công";
            this.btnLuuChamCong.UseVisualStyleBackColor = false;
            this.btnLuuChamCong.Click += new System.EventHandler(this.btnLuuChamCong_Click);
            // 
            // btnTaiChamCong
            // 
            this.btnTaiChamCong.Location = new System.Drawing.Point(200, 10);
            this.btnTaiChamCong.Name = "btnTaiChamCong";
            this.btnTaiChamCong.Size = new System.Drawing.Size(100, 30);
            this.btnTaiChamCong.TabIndex = 3;
            this.btnTaiChamCong.Text = "Tải Bảng Công";
            this.btnTaiChamCong.UseVisualStyleBackColor = true;
            this.btnTaiChamCong.Click += new System.EventHandler(this.btnTaiChamCong_Click);
            // 
            // txtThangNam
            // 
            this.txtThangNam.Location = new System.Drawing.Point(90, 15);
            this.txtThangNam.Name = "txtThangNam";
            this.txtThangNam.Size = new System.Drawing.Size(100, 20);
            this.txtThangNam.TabIndex = 2;
            // 
            // lblThangNam
            // 
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Location = new System.Drawing.Point(15, 18);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Size = new System.Drawing.Size(65, 13);
            this.lblThangNam.TabIndex = 1;
            this.lblThangNam.Text = "Tháng/Năm:";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AllowUserToDeleteRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(10, 50);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.Size = new System.Drawing.Size(880, 475);
            this.dgvChamCong.TabIndex = 0;
            // 
            // tabLuong
            // 
            this.tabLuong.Controls.Add(this.btnChotLuong);
            this.tabLuong.Controls.Add(this.dgvBangLuong);
            this.tabLuong.Location = new System.Drawing.Point(4, 22);
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuong.Size = new System.Drawing.Size(906, 535);
            this.tabLuong.TabIndex = 2;
            this.tabLuong.Text = "Tính & Chốt Lương (SqlTransaction)";
            this.tabLuong.UseVisualStyleBackColor = true;
            // 
            // btnChotLuong
            // 
            this.btnChotLuong.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChotLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChotLuong.Location = new System.Drawing.Point(10, 10);
            this.btnChotLuong.Name = "btnChotLuong";
            this.btnChotLuong.Size = new System.Drawing.Size(180, 35);
            this.btnChotLuong.TabIndex = 1;
            this.btnChotLuong.Text = "Chốt Lương Tháng";
            this.btnChotLuong.UseVisualStyleBackColor = false;
            this.btnChotLuong.Click += new System.EventHandler(this.btnChotLuong_Click);
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Location = new System.Drawing.Point(10, 55);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(880, 470);
            this.dgvBangLuong.TabIndex = 0;
            // 
            // frmHRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.tabMain);
            this.Name = "frmHRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Nhân Sự & Tính Lương (HRM & Payroll System)";
            this.Load += new System.EventHandler(this.frmHRM_Load);
            this.tabMain.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongCoBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabChamCong.ResumeLayout(false);
            this.tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.tabLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTimPhongBan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblPB;
        private System.Windows.Forms.Label lblLuongCB;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.NumericUpDown nudLuongCoBan;
        private System.Windows.Forms.NumericUpDown nudHeSoLuong;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.TextBox txtThangNam;
        private System.Windows.Forms.Button btnTaiChamCong;
        private System.Windows.Forms.Button btnLuuChamCong;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Button btnChotLuong;
    }
}