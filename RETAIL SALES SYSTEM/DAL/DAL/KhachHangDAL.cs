using System.Data;
using System.Data.SqlClient;

namespace RetailSystem.DAL
{
    public class KhachHangDAL
    {
        public DataTable GetAllKhachHang()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}