using System.Data.SqlClient;

namespace HRMSystem.DAL
{
    public class DatabaseConnection
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HRMDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
