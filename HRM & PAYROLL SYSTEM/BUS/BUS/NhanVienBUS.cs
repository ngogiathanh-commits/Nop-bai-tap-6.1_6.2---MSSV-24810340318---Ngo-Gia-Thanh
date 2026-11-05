using System;
using System.Data;
using System.Data.SqlClient;
using HRMSystem.DAL;
using HRMSystem.DTO;

namespace HRMSystem.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public DataTable GetAllNhanVien() => dal.GetAllNhanVien();

        public DataTable TimKiemNhanVien(string keyword, int? maPB)
        {
            return dal.TimKiemNhanVien(keyword ?? "", maPB);
        }

        public bool ThemNhanVien(NhanVienDTO nv, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(nv.HoTen))
            {
                error = "Họ tên nhân viên không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(nv.CCCD))
            {
                error = "Số CCCD không được để trống!";
                return false;
            }
            if (nv.LuongCoBan <= 0)
            {
                error = "Lương cơ bản phải lớn hơn 0!";
                return false;
            }

            try
            {
                return dal.InsertNhanVien(nv);
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                error = "Số CCCD này đã tồn tại. Vui lòng nhập số CCCD khác!";
                return false;
            }
            catch (Exception ex)
            {
                error = "Không thể thêm nhân viên: " + ex.Message;
                return false;
            }
        }

        public bool SuaNhanVien(NhanVienDTO nv, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(nv.HoTen))
            {
                error = "Họ tên nhân viên không được để trống!";
                return false;
            }

            try
            {
                return dal.UpdateNhanVien(nv);
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                error = "Số CCCD này đã tồn tại ở nhân viên khác. Vui lòng nhập số CCCD khác!";
                return false;
            }
            catch (Exception ex)
            {
                error = "Không thể cập nhật nhân viên: " + ex.Message;
                return false;
            }
        }

        public bool XoaNhanVien(int maNV) => dal.DeleteNhanVien(maNV);
    }
}