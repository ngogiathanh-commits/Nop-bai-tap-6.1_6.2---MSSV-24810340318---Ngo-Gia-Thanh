using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMSystem.DAL
{
    public class LuongDAL
    {
        
        public bool ChotLuongThang(string thangNam, out string errorMessage)
        {
            errorMessage = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                  
                    string sqlSelect = @"SELECT c.MaNV, nv.LuongCoBan, nv.HeSoLuong, c.SoNgayCong, c.SoGioOT 
                                         FROM BangChamCong c 
                                         JOIN NhanVien nv ON c.MaNV = nv.MaNV 
                                         WHERE c.ThangNam = @ThangNam";
                    SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn, tran);
                    cmdSelect.Parameters.AddWithValue("@ThangNam", thangNam);

                    SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        tran.Rollback();
                        errorMessage = $"Chưa có dữ liệu chấm công cho tháng {thangNam}!";
                        return false;
                    }

                  
                    foreach (DataRow row in dt.Rows)
                    {
                        int maNV = Convert.ToInt32(row["MaNV"]);
                        decimal luongCoBan = Convert.ToDecimal(row["LuongCoBan"]);
                        double heSo = Convert.ToDouble(row["HeSoLuong"]);
                        double soNgayCong = Convert.ToDouble(row["SoNgayCong"]);
                        double soGioOT = Convert.ToDouble(row["SoGioOT"]);

                       
                        decimal thucLinh = Convert.ToDecimal(((double)luongCoBan * heSo / 22.0) * soNgayCong + (soGioOT * 50000.0));
                        if (thucLinh < 0) thucLinh = 0;

                        
                        string sqlUpsert = @"
                            IF EXISTS (SELECT 1 FROM BangLuong WHERE MaNV = @MaNV AND ThangNam = @ThangNam)
                                UPDATE BangLuong SET ThucLinh = @ThucLinh WHERE MaNV = @MaNV AND ThangNam = @ThangNam
                            ELSE
                                INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) VALUES (@MaNV, @ThangNam, @ThucLinh)";

                        SqlCommand cmdUpsert = new SqlCommand(sqlUpsert, conn, tran);
                        cmdUpsert.Parameters.AddWithValue("@MaNV", maNV);
                        cmdUpsert.Parameters.AddWithValue("@ThangNam", thangNam);
                        cmdUpsert.Parameters.AddWithValue("@ThucLinh", thucLinh);
                        cmdUpsert.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = "Lỗi chốt lương SqlTransaction: " + ex.Message;
                    return false;
                }
            }
        }

        public DataTable GetBangLuongByThang(string thangNam)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT l.MaLuong, l.MaNV, nv.HoTen, pb.TenPB, l.ThangNam, l.ThucLinh 
                                 FROM BangLuong l 
                                 JOIN NhanVien nv ON l.MaNV = nv.MaNV 
                                 JOIN PhongBan pb ON nv.MaPB = pb.MaPB 
                                 WHERE l.ThangNam = @ThangNam";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ThangNam", thangNam);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
