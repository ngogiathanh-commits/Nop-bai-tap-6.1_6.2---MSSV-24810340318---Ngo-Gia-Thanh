using System.Collections.Generic;
using RetailSystem.DAL;
using RetailSystem.DTO;

namespace RetailSystem.BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL dal = new HoaDonDAL();

        public bool ThanhToanHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> listChiTiet, out string error)
        {
            error = "";
            if (listChiTiet == null || listChiTiet.Count == 0)
            {
                error = "Giỏ hàng hiện đang trống! Vui lòng chọn ít nhất 1 sản phẩm.";
                return false;
            }

            return dal.ThanhToanHoaDon(hoaDon, listChiTiet, out error);
        }
    }
}