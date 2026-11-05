using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RetailSystem.BUS;
using RetailSystem.DAL;
using RetailSystem.DTO;

namespace RetailSystem.GUI
{
    public partial class frmPOS : Form
    {
        private SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private BaoCaoBUS baoCaoBUS = new BaoCaoBUS();
        private KhachHangDAL khachHangDAL = new KhachHangDAL();
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        private List<ChiTietHoaDonDTO> gioHang = new List<ChiTietHoaDonDTO>();

        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            LoadDataSanPham();
            LoadNhanVien();
            LoadKhachHang();
            CapNhatThongKe();
        }

        private void LoadDataSanPham()
        {
            dgvSanPham.DataSource = sanPhamBUS.GetAllSanPham();
        }

        private void LoadNhanVien()
        {
            DataTable dt = nhanVienDAL.GetAllNhanVien();
            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
        }

        private void LoadKhachHang()
        {
            DataTable dt = khachHangDAL.GetAllKhachHang();

            // Thêm tùy chọn Khách lẻ
            DataRow dr = dt.NewRow();
            dr["MaKH"] = DBNull.Value;
            dr["TenKH"] = "-- Khách lẻ --";
            dt.Rows.InsertAt(dr, 0);

            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = sanPhamBUS.TimKiemSanPham(txtTimKiem.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDataSanPham();
        }

        
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            string maSP = dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();
            string tenSP = dgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString();
            decimal giaBan = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["GiaBan"].Value);
            int soLuong = (int)nudSoLuong.Value;

            var itemInCart = gioHang.FirstOrDefault(x => x.MaSP == maSP);
            if (itemInCart != null)
            {
                itemInCart.SoLuong += soLuong;
            }
            else
            {
                gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    SoLuong = soLuong,
                    DonGia = giaBan
                });
            }

            CapNhatGioHang();
        }

        private void CapNhatGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang;

            decimal tongTien = gioHang.Sum(x => x.ThanhTien);
            lblTongTien.Text = $"{tongTien:N0} VNĐ";

            int diemDukien = (int)(tongTien / 100000);
            lblDiemDuKien.Text = $"+{diemDukien} điểm";
        }

        
        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) return;
            string maSP = dgvGioHang.CurrentRow.Cells["MaSP"].Value.ToString();
            gioHang.RemoveAll(x => x.MaSP == maSP);
            CapNhatGioHang();
        }

       
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên thu ngân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
            int? maKH = null;
            if (cboKhachHang.SelectedValue != null && cboKhachHang.SelectedValue != DBNull.Value)
            {
                maKH = Convert.ToInt32(cboKhachHang.SelectedValue);
            }

            decimal tongTien = gioHang.Sum(x => x.ThanhTien);

            HoaDonDTO hoaDon = new HoaDonDTO
            {
                MaNV = maNV,
                MaKH = maKH,
                TongTien = tongTien
            };

            if (hoaDonBUS.ThanhToanHoaDon(hoaDon, gioHang, out string error))
            {
                MessageBox.Show("Thanh toán thành công và đã cập nhật tồn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gioHang.Clear();
                CapNhatGioHang();
                LoadDataSanPham();
                LoadKhachHang();
                CapNhatThongKe();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Thanh Toán SqlTransaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void CapNhatThongKe()
        {
            lblDoanhThuNgay.Text = $"{baoCaoBUS.GetDoanhThuTrongNgay():N0} VNĐ";
            lblDoanhThuThang.Text = $"{baoCaoBUS.GetDoanhThuTrongThang():N0} VNĐ";

            lstTopSp.Items.Clear();
            List<string> top5 = baoCaoBUS.GetTop5SanPhamBanChay();
            foreach (var item in top5)
            {
                lstTopSp.Items.Add(item);
            }
        }
    }
}
