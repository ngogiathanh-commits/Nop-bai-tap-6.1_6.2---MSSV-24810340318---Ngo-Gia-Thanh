namespace RetailSystem.GUI
{
    partial class frmPOS
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
            this.grpSanPham = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.grpBanHang = new System.Windows.Forms.GroupBox();
            this.lblDiemDuKien = new System.Windows.Forms.Label();
            this.lblDiemTxt = new System.Windows.Forms.Label();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienTxt = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.grpBaoCao = new System.Windows.Forms.GroupBox();
            this.lstTopSp = new System.Windows.Forms.ListBox();
            this.lblTopSpTxt = new System.Windows.Forms.Label();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.lblThangTxt = new System.Windows.Forms.Label();
            this.lblDoanhThuNgay = new System.Windows.Forms.Label();
            this.lblNgayTxt = new System.Windows.Forms.Label();
            this.grpSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grpBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.grpBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSanPham
            // 
            this.grpSanPham.Controls.Add(this.btnLamMoi);
            this.grpSanPham.Controls.Add(this.btnThemVaoGio);
            this.grpSanPham.Controls.Add(this.nudSoLuong);
            this.grpSanPham.Controls.Add(this.btnTimKiem);
            this.grpSanPham.Controls.Add(this.txtTimKiem);
            this.grpSanPham.Controls.Add(this.dgvSanPham);
            this.grpSanPham.Controls.Add(this.lblSoLuong);
            this.grpSanPham.Location = new System.Drawing.Point(12, 12);
            this.grpSanPham.Name = "grpSanPham";
            this.grpSanPham.Size = new System.Drawing.Size(430, 520);
            this.grpSanPham.TabIndex = 0;
            this.grpSanPham.TabStop = false;
            this.grpSanPham.Text = "Danh Sách Sản Phẩm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(360, 20);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(60, 23);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Tải lại";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoGio.Location = new System.Drawing.Point(280, 480);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(140, 30);
            this.btnThemVaoGio.TabIndex = 5;
            this.btnThemVaoGio.Text = "Thêm Vào Giỏ ->";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(205, 485);
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(65, 20);
            this.nudSoLuong.TabIndex = 4;
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(295, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(60, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(10, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(10, 50);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(410, 420);
            this.dgvSanPham.TabIndex = 0;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(145, 488);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // grpBanHang
            // 
            this.grpBanHang.Controls.Add(this.lblDiemDuKien);
            this.grpBanHang.Controls.Add(this.lblDiemTxt);
            this.grpBanHang.Controls.Add(this.btnXoaKhoiGio);
            this.grpBanHang.Controls.Add(this.btnThanhToan);
            this.grpBanHang.Controls.Add(this.lblTongTien);
            this.grpBanHang.Controls.Add(this.lblTongTienTxt);
            this.grpBanHang.Controls.Add(this.cboKhachHang);
            this.grpBanHang.Controls.Add(this.cboNhanVien);
            this.grpBanHang.Controls.Add(this.lblKhachHang);
            this.grpBanHang.Controls.Add(this.lblNhanVien);
            this.grpBanHang.Controls.Add(this.dgvGioHang);
            this.grpBanHang.Location = new System.Drawing.Point(450, 12);
            this.grpBanHang.Name = "grpBanHang";
            this.grpBanHang.Size = new System.Drawing.Size(430, 330);
            this.grpBanHang.TabIndex = 1;
            this.grpBanHang.TabStop = false;
            this.grpBanHang.Text = "Giỏ Hàng & Lập Hóa Đơn (SqlTransaction)";
            // 
            // lblDiemDuKien
            // 
            this.lblDiemDuKien.AutoSize = true;
            this.lblDiemDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDuKien.ForeColor = System.Drawing.Color.Green;
            this.lblDiemDuKien.Location = new System.Drawing.Point(100, 298);
            this.lblDiemDuKien.Name = "lblDiemDuKien";
            this.lblDiemDuKien.Size = new System.Drawing.Size(55, 15);
            this.lblDiemDuKien.TabIndex = 10;
            this.lblDiemDuKien.Text = "+0 điểm";
            // 
            // lblDiemTxt
            // 
            this.lblDiemTxt.AutoSize = true;
            this.lblDiemTxt.Location = new System.Drawing.Point(10, 298);
            this.lblDiemTxt.Name = "lblDiemTxt";
            this.lblDiemTxt.Size = new System.Drawing.Size(91, 13);
            this.lblDiemTxt.TabIndex = 9;
            this.lblDiemTxt.Text = "Tích điểm dự kiến:";
            // 
            // btnXoaKhoiGio
            // 
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(340, 235);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(80, 25);
            this.btnXoaKhoiGio.TabIndex = 8;
            this.btnXoaKhoiGio.Text = "Xóa món";
            this.btnXoaKhoiGio.UseVisualStyleBackColor = true;
            this.btnXoaKhoiGio.Click += new System.EventHandler(this.btnXoaKhoiGio_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(280, 270);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(140, 45);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(100, 270);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(60, 20);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienTxt
            // 
            this.lblTongTienTxt.AutoSize = true;
            this.lblTongTienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTxt.Location = new System.Drawing.Point(10, 272);
            this.lblTongTienTxt.Name = "lblTongTienTxt";
            this.lblTongTienTxt.Size = new System.Drawing.Size(71, 15);
            this.lblTongTienTxt.TabIndex = 5;
            this.lblTongTienTxt.Text = "Tổng tiền:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(260, 22);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(160, 21);
            this.cboKhachHang.TabIndex = 4;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(70, 22);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(115, 21);
            this.cboNhanVien.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(190, 25);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(68, 13);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(10, 25);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(59, 13);
            this.lblNhanVien.TabIndex = 1;
            this.lblNhanVien.Text = "Thu ngân:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(10, 55);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(410, 170);
            this.dgvGioHang.TabIndex = 0;
            // 
            // grpBaoCao
            // 
            this.grpBaoCao.Controls.Add(this.lstTopSp);
            this.grpBaoCao.Controls.Add(this.lblTopSpTxt);
            this.grpBaoCao.Controls.Add(this.lblDoanhThuThang);
            this.grpBaoCao.Controls.Add(this.lblThangTxt);
            this.grpBaoCao.Controls.Add(this.lblDoanhThuNgay);
            this.grpBaoCao.Controls.Add(this.lblNgayTxt);
            this.grpBaoCao.Location = new System.Drawing.Point(450, 348);
            this.grpBaoCao.Name = "grpBaoCao";
            this.grpBaoCao.Size = new System.Drawing.Size(430, 184);
            this.grpBaoCao.TabIndex = 2;
            this.grpBaoCao.TabStop = false;
            this.grpBaoCao.Text = "Báo Cáo Nhanh (ExecuteScalar & SqlDataReader)";
            // 
            // lstTopSp
            // 
            this.lstTopSp.FormattingEnabled = true;
            this.lstTopSp.Location = new System.Drawing.Point(180, 38);
            this.lstTopSp.Name = "lstTopSp";
            this.lstTopSp.Size = new System.Drawing.Size(240, 134);
            this.lstTopSp.TabIndex = 5;
            // 
            // lblTopSpTxt
            // 
            this.lblTopSpTxt.AutoSize = true;
            this.lblTopSpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSpTxt.Location = new System.Drawing.Point(180, 20);
            this.lblTopSpTxt.Name = "lblTopSpTxt";
            this.lblTopSpTxt.Size = new System.Drawing.Size(188, 13);
            this.lblTopSpTxt.TabIndex = 4;
            this.lblTopSpTxt.Text = "Top 5 Sản Phẩm Bán Chạy Nhất:";
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(10, 110);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(48, 15);
            this.lblDoanhThuThang.TabIndex = 3;
            this.lblDoanhThuThang.Text = "0 VNĐ";
            // 
            // lblThangTxt
            // 
            this.lblThangTxt.AutoSize = true;
            this.lblThangTxt.Location = new System.Drawing.Point(10, 90);
            this.lblThangTxt.Name = "lblThangTxt";
            this.lblThangTxt.Size = new System.Drawing.Size(122, 13);
            this.lblThangTxt.TabIndex = 2;
            this.lblThangTxt.Text = "Doanh thu trong tháng:";
            // 
            // lblDoanhThuNgay
            // 
            this.lblDoanhThuNgay.AutoSize = true;
            this.lblDoanhThuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuNgay.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDoanhThuNgay.Location = new System.Drawing.Point(10, 50);
            this.lblDoanhThuNgay.Name = "lblDoanhThuNgay";
            this.lblDoanhThuNgay.Size = new System.Drawing.Size(48, 15);
            this.lblDoanhThuNgay.TabIndex = 1;
            this.lblDoanhThuNgay.Text = "0 VNĐ";
            // 
            // lblNgayTxt
            // 
            this.lblNgayTxt.AutoSize = true;
            this.lblNgayTxt.Location = new System.Drawing.Point(10, 30);
            this.lblNgayTxt.Name = "lblNgayTxt";
            this.lblNgayTxt.Size = new System.Drawing.Size(117, 13);
            this.lblNgayTxt.TabIndex = 0;
            this.lblNgayTxt.Text = "Doanh thu trong ngày:";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 544);
            this.Controls.Add(this.grpBaoCao);
            this.Controls.Add(this.grpBanHang);
            this.Controls.Add(this.grpSanPham);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Bán Hàng & Siêu Thị Mini (Retail Sales System)";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.grpSanPham.ResumeLayout(false);
            this.grpSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grpBanHang.ResumeLayout(false);
            this.grpBanHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.grpBaoCao.ResumeLayout(false);
            this.grpBaoCao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSanPham;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpBanHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTongTienTxt;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoaKhoiGio;
        private System.Windows.Forms.Label lblDiemTxt;
        private System.Windows.Forms.Label lblDiemDuKien;
        private System.Windows.Forms.GroupBox grpBaoCao;
        private System.Windows.Forms.Label lblNgayTxt;
        private System.Windows.Forms.Label lblDoanhThuNgay;
        private System.Windows.Forms.Label lblThangTxt;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.Label lblTopSpTxt;
        private System.Windows.Forms.ListBox lstTopSp;
    }
}