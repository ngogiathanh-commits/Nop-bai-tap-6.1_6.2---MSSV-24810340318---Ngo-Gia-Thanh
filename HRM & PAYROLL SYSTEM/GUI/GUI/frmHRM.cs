using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HRMSystem.BUS;
using HRMSystem.DAL;
using HRMSystem.DTO;

namespace HRMSystem.GUI
{
    public partial class frmHRM : Form
    {
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private ChamCongBUS ccBUS = new ChamCongBUS();
        private LuongBUS luongBUS = new LuongBUS();
        private PhongBanDAL pbDAL = new PhongBanDAL();

        private SqlDataAdapter activeCCAdapter;
        private DataTable dtChamCong;
        private int selectedMaNV = -1;

        public frmHRM()
        {
            InitializeComponent();
        }

        private void frmHRM_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
            LoadPhongBan();
            txtThangNam.Text = DateTime.Now.ToString("MM/yyyy");
            LoadBangChamCong();
            LoadBangLuong();
        }

        private void LoadDataNhanVien()
        {
            dgvNhanVien.DataSource = nvBUS.GetAllNhanVien();
        }

        private void LoadPhongBan()
        {
            DataTable dt = pbDAL.GetAllPhongBan();

            cboPhongBan.DataSource = dt;
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";

         
            DataTable dtSearch = dt.Copy();
            DataRow dr = dtSearch.NewRow();
            dr["MaPB"] = 0;
            dr["TenPB"] = "-- Tất cả phòng ban --";
            dtSearch.Rows.InsertAt(dr, 0);

            cboTimPhongBan.DataSource = dtSearch;
            cboTimPhongBan.DisplayMember = "TenPB";
            cboTimPhongBan.ValueMember = "MaPB";
        }

        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            int? maPB = Convert.ToInt32(cboTimPhongBan.SelectedValue);
            dgvNhanVien.DataSource = nvBUS.TimKiemNhanVien(keyword, maPB);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                CCCD = txtCCCD.Text.Trim(),
                MaPB = Convert.ToInt32(cboPhongBan.SelectedValue),
                LuongCoBan = nudLuongCoBan.Value,
                HeSoLuong = (double)nudHeSoLuong.Value
            };

            if (nvBUS.ThemNhanVien(nv, out string error))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (selectedMaNV == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVienDTO nv = new NhanVienDTO
            {
                MaNV = selectedMaNV,
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                CCCD = txtCCCD.Text.Trim(),
                MaPB = Convert.ToInt32(cboPhongBan.SelectedValue),
                LuongCoBan = nudLuongCoBan.Value,
                HeSoLuong = (double)nudHeSoLuong.Value
            };

            if (nvBUS.SuaNhanVien(nv, out string error))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (selectedMaNV == -1) return;

            if (MessageBox.Show("Xác nhận xóa hồ sơ nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nvBUS.XoaNhanVien(selectedMaNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNhanVien();
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                selectedMaNV = Convert.ToInt32(row.Cells["MaNV"].Value);
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboPhongBan.SelectedValue = row.Cells["MaPB"].Value;
                nudLuongCoBan.Value = Convert.ToDecimal(row.Cells["LuongCoBan"].Value);
                nudHeSoLuong.Value = Convert.ToDecimal(row.Cells["HeSoLuong"].Value);
            }
        }

        
        private void btnTaiChamCong_Click(object sender, EventArgs e)
        {
            LoadBangChamCong();
        }

        private void LoadBangChamCong()
        {
            string thangNam = txtThangNam.Text.Trim();
            dtChamCong = ccBUS.GetBangChamCongByThang(thangNam, out activeCCAdapter);
            dgvChamCong.DataSource = dtChamCong;
        }

        private void btnLuuChamCong_Click(object sender, EventArgs e)
        {
            if (ccBUS.SaveChamCongDisconnected(dtChamCong, activeCCAdapter))
            {
                MessageBox.Show("Đã lưu bảng chấm công ngắt kết nối về SQL Server thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu chấm công thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnChotLuong_Click(object sender, EventArgs e)
        {
            string thangNam = txtThangNam.Text.Trim();
            if (MessageBox.Show($"Xác nhận chốt lương cho tháng {thangNam}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (luongBUS.ChotLuongThang(thangNam, out string error))
                {
                    MessageBox.Show($"Chốt lương tháng {thangNam} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBangLuong();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi Chốt Lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBangLuong()
        {
            string thangNam = txtThangNam.Text.Trim();
            dgvBangLuong.DataSource = luongBUS.GetBangLuongByThang(thangNam);
        }
    }
}
