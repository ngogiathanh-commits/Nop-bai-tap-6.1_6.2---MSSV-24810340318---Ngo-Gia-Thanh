using System.Data;
using HRMSystem.DAL;

namespace HRMSystem.BUS
{
    public class LuongBUS
    {
        private LuongDAL dal = new LuongDAL();

        public bool ChotLuongThang(string thangNam, out string errorMessage)
        {
            return dal.ChotLuongThang(thangNam, out errorMessage);
        }

        public DataTable GetBangLuongByThang(string thangNam) => dal.GetBangLuongByThang(thangNam);
    }
}