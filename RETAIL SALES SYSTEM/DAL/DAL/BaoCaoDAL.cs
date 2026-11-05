using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RetailSystem.DAL
{
    public class BaoCaoDAL
    {
        
        public decimal GetDoanhThuTrongNgay()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

    
        public decimal GetDoanhThuTrongThang()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE MONTH(NgayLap) = MONTH(GETDATE()) AND YEAR(NgayLap) = YEAR(GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        
        public List<string> GetTop5SanPhamBanChay()
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT TOP 5 sp.TenSP, SUM(ct.SoLuong) AS TongDaBan 
                                 FROM ChiTietHoaDon ct 
                                 JOIN SanPham sp ON ct.MaSP = sp.MaSP 
                                 GROUP BY sp.TenSP 
                                 ORDER BY TongDaBan DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tenSP = reader["TenSP"].ToString();
                    int tongBan = Convert.ToInt32(reader["TongDaBan"]);
                    list.Add($"{tenSP} - Đã bán: {tongBan}");
                }
            }
            return list;
        }
    }
}