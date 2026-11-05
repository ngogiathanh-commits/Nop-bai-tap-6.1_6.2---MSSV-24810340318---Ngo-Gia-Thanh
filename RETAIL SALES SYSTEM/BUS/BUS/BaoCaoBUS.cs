using System.Collections.Generic;
using RetailSystem.DAL;

namespace RetailSystem.BUS
{
    public class BaoCaoBUS
    {
        private BaoCaoDAL dal = new BaoCaoDAL();

        public decimal GetDoanhThuTrongNgay() => dal.GetDoanhThuTrongNgay();
        public decimal GetDoanhThuTrongThang() => dal.GetDoanhThuTrongThang();
        public List<string> GetTop5SanPhamBanChay() => dal.GetTop5SanPhamBanChay();
    }
}