using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RetailSystem.DTO;

namespace RetailSystem.DAL
{
    public class HoaDonDAL
    {
        public bool ThanhToanHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> listChiTiet, out string error)
        {
            error = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    
                    string sqlHD = @"INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) 
                                     VALUES (GETDATE(), @MaNV, @MaKH, @TongTien);
                                     SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdHD = new SqlCommand(sqlHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@MaNV", hoaDon.MaNV);
                    cmdHD.Parameters.AddWithValue("@MaKH", (object)hoaDon.MaKH ?? DBNull.Value);
                    cmdHD.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);

                    int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

                    
                    foreach (var item in listChiTiet)
                    {
                        
                        string sqlCheckTon = "SELECT SoLuongTon FROM SanPham WHERE MaSP = @MaSP";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheckTon, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@MaSP", item.MaSP);
                        object tonObj = cmdCheck.ExecuteScalar();
                        int tonHienTai = tonObj != null ? Convert.ToInt32(tonObj) : 0;

                        if (tonHienTai < item.SoLuong)
                        {
                            
                            tran.Rollback();
                            error = $"Sản phẩm '{item.TenSP}' (Mã: {item.MaSP}) không đủ tồn kho! (Còn tồn: {tonHienTai}, Cần bán: {item.SoLuong})";
                            return false;
                        }

                        
                        string sqlCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) 
                                         VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                        cmdCT.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", item.DonGia);
                        cmdCT.ExecuteNonQuery();

                        
                        string sqlTruTon = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP";
                        SqlCommand cmdTru = new SqlCommand(sqlTruTon, conn, tran);
                        cmdTru.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdTru.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdTru.ExecuteNonQuery();
                    }

                    
                    if (hoaDon.MaKH.HasValue)
                    {
                        int diemCong = (int)(hoaDon.TongTien / 100000);
                        if (diemCong > 0)
                        {
                            string sqlDiem = "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @Diem WHERE MaKH = @MaKH";
                            SqlCommand cmdDiem = new SqlCommand(sqlDiem, conn, tran);
                            cmdDiem.Parameters.AddWithValue("@Diem", diemCong);
                            cmdDiem.Parameters.AddWithValue("@MaKH", hoaDon.MaKH.Value);
                            cmdDiem.ExecuteNonQuery();
                        }
                    }

                    
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi hệ thống SqlTransaction: " + ex.Message;
                    return false;
                }
            }
        }
    }
}
