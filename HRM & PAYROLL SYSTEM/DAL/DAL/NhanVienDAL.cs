using System;
using System.Data;
using System.Data.SqlClient;
using HRMSystem.DTO;

namespace HRMSystem.DAL
{
    public class NhanVienDAL
    {
        public DataTable GetAllNhanVien()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong 
                                 FROM NhanVien nv 
                                 JOIN PhongBan pb ON nv.MaPB = pb.MaPB";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable TimKiemNhanVien(string keyword, int? maPB)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong 
                                 FROM NhanVien nv 
                                 JOIN PhongBan pb ON nv.MaPB = pb.MaPB 
                                 WHERE (nv.HoTen LIKE @Keyword OR nv.CCCD LIKE @Keyword)";

                if (maPB.HasValue && maPB.Value > 0)
                {
                    query += " AND nv.MaPB = @MaPB";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Keyword", "%" + keyword + "%"));
                if (maPB.HasValue && maPB.Value > 0)
                {
                    cmd.Parameters.Add(new SqlParameter("@MaPB", maPB.Value));
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool InsertNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) 
                                 VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", (object)nv.NgaySinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"UPDATE NhanVien 
                                 SET HoTen = @HoTen, NgaySinh = @NgaySinh, CCCD = @CCCD, MaPB = @MaPB, 
                                     LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong 
                                 WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", (object)nv.NgaySinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteNhanVien(int maNV)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
