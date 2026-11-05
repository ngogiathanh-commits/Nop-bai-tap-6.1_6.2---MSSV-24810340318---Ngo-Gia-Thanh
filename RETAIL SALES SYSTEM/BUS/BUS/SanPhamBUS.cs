using System.Data;
using RetailSystem.DAL;

namespace RetailSystem.BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAL dal = new SanPhamDAL();

        public DataTable GetAllSanPham() => dal.GetAllSanPham();

        public DataTable TimKiemSanPham(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return dal.GetAllSanPham();
            return dal.TimKiemSanPham(keyword.Trim());
        }
    }
}
