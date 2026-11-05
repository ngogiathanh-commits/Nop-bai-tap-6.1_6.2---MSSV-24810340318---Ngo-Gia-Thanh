using System.Data;
using System.Data.SqlClient;

namespace RetailSystem.DAL
{
    public class NhanVienDAL
    {
        public DataTable GetAllNhanVien()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
