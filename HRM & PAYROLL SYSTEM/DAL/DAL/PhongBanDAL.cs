using System.Data;
using System.Data.SqlClient;

namespace HRMSystem.DAL
{
    public class PhongBanDAL
    {
        public DataTable GetAllPhongBan()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM PhongBan";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
