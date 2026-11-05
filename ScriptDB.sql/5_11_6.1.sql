CREATE DATABASE QLSS;
GO

USE QLSS;
GO

CREATE TABLE NhanVien (
        MaNV INT IDENTITY(1,1) PRIMARY KEY,
        TenNV NVARCHAR(100) NOT NULL,
        SoDienThoai VARCHAR(15) UNIQUE,
        ChucVu NVARCHAR(50) DEFAULT N'Thu ngân'
);

CREATE TABLE KhachHang (
        MaKH INT IDENTITY(1,1) PRIMARY KEY,
        TenKH NVARCHAR(100) NOT NULL,
        DienThoai VARCHAR(15) UNIQUE,
        DiemTichLuy INT DEFAULT 0 CHECK (DiemTichLuy >= 0)
);

CREATE TABLE SanPham (
        MaSP VARCHAR(20) PRIMARY KEY,
        TenSP NVARCHAR(150) NOT NULL,
        GiaBan DECIMAL(18,2) NOT NULL CHECK (GiaBan > 0),
        SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0)
);

CREATE TABLE HoaDon (
        MaHD INT IDENTITY(1,1) PRIMARY KEY,
        NgayLap DATETIME DEFAULT GETDATE(),
        MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
        MaKH INT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
        TongTien DECIMAL(18,2) DEFAULT 0
);

CREATE TABLE ChiTietHoaDon (
        MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD),
        MaSP VARCHAR(20) FOREIGN KEY REFERENCES SanPham(MaSP),
        SoLuong INT NOT NULL CHECK (SoLuong > 0),
        DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
        PRIMARY KEY (MaHD, MaSP)
);

INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES
    (N'Nguyễn Văn Quản Lý', '0901111222', N'Quản lý'),
    (N'Trần Thị Thu Ngân', '0903333444', N'Thu ngân');

INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES
    (N'Lê Văn Khách B VIP', '0988888888', 10),
    (N'Pham Thị Thân Thiết', '0977777777', 5);

INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES
    ('SP001', N'Sữa tươi Vinamilk 1L', 35000, 100),
    ('SP002', N'Mì Hảo Hảo Tôm Chua Cay', 4500, 500),
    ('SP003', N'Bánh Chocopie hộp 12 cái', 55000, 50),
    ('SP004', N'Nước khoáng Lavie 500ml', 6000, 200),
    ('SP005', N'Cà phê hòa tan G7 3in1', 68000, 80),
    ('SP006', N'Dầu ăn Simply 1L', 62000, 40);
GO