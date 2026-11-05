using System.Data;
using System.Data.SqlClient;
using HRMSystem.DAL;

namespace HRMSystem.BUS
{
    public class ChamCongBUS
    {
        private ChamCongDAL dal = new ChamCongDAL();

        public DataTable GetBangChamCongByThang(string thangNam, out SqlDataAdapter adapter)
        {
            return dal.GetBangChamCongByThang(thangNam, out adapter);
        }

        public bool SaveChamCongDisconnected(DataTable dtChamCong, SqlDataAdapter adapter)
        {
            return dal.SaveChamCongDisconnected(dtChamCong, adapter);
        }
    }
}
