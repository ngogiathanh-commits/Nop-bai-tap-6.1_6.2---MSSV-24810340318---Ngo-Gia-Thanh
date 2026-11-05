using System.Data;
using System.Data.SqlClient;

namespace HRMSystem.DAL
{
    public class ChamCongDAL
    {
        private SqlDataAdapter adapter;

       
        public DataTable GetBangChamCongByThang(string thangNam, out SqlDataAdapter outAdapter)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
            
                string initQuery = @"INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT)
                                     SELECT nv.MaNV, @ThangNam, 22, 0 
                                     FROM NhanVien nv
                                     WHERE NOT EXISTS (
                                         SELECT 1 FROM BangChamCong c WHERE c.MaNV = nv.MaNV AND c.ThangNam = @ThangNam
                                     )";
                SqlCommand cmdInit = new SqlCommand(initQuery, conn);
                cmdInit.Parameters.AddWithValue("@ThangNam", thangNam);
                cmdInit.ExecuteNonQuery();
            }

            
            SqlConnection adapterConn = DatabaseConnection.GetConnection();
            string query = @"SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT 
                            FROM BangChamCong 
                            WHERE ThangNam = @ThangNam";
            SqlCommand cmdSelect = new SqlCommand(query, adapterConn);
            cmdSelect.Parameters.AddWithValue("@ThangNam", thangNam);

            adapter = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            outAdapter = adapter;
            return dt;
        }

     
        public bool SaveChamCongDisconnected(DataTable dtChamCong, SqlDataAdapter activeAdapter)
        {
            if (dtChamCong == null || activeAdapter == null) return false;

            SqlCommandBuilder builder = new SqlCommandBuilder(activeAdapter);
            activeAdapter.Update(dtChamCong);
            return true;
        }
    }
}
