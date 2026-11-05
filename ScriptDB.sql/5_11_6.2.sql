CREATE DATABASE HRMDB;
go

USE HRMDB;
GO

CREATE TABLE PhongBan (
        MaPB INT IDENTITY(1,1) PRIMARY KEY,
        TenPB NVARCHAR(100) NOT NULL,
        MoTa NVARCHAR(255)
    );

CREATE TABLE NhanVien (
        MaNV INT IDENTITY(1,1) PRIMARY KEY,
        HoTen NVARCHAR(100) NOT NULL,
        NgaySinh DATETIME NULL,
        CCCD VARCHAR(20) UNIQUE NOT NULL,
        MaPB INT FOREIGN KEY REFERENCES PhongBan(MaPB),
        LuongCoBan DECIMAL(18,2) NOT NULL CHECK (LuongCoBan > 0),
        HeSoLuong FLOAT DEFAULT 1.0 CHECK (HeSoLuong > 0)
    );

CREATE TABLE BangChamCong (
        MaCong INT IDENTITY(1,1) PRIMARY KEY,
        MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
        ThangNam VARCHAR(7) NOT NULL, -- Định dạng: "11/2026"
        SoNgayCong FLOAT NOT NULL CHECK (SoNgayCong >= 0 AND SoNgayCong <= 31),
        SoGioOT FLOAT DEFAULT 0 CHECK (SoGioOT >= 0),
        CONSTRAINT UQ_ChamCong_NV_Thang UNIQUE (MaNV, ThangNam)
    );

CREATE TABLE BangLuong (
        MaLuong INT IDENTITY(1,1) PRIMARY KEY,
        MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
        ThangNam VARCHAR(7) NOT NULL,
        ThucLinh DECIMAL(18,2) NOT NULL CHECK (ThucLinh >= 0),
        CONSTRAINT UQ_BangLuong_NV_Thang UNIQUE (MaNV, ThangNam)
    );

INSERT INTO PhongBan (TenPB, MoTa) VALUES
    (N'Phòng Nhân Sự', N'Quản lý hồ sơ và chính sách nhân sự'),
    (N'Phòng Kỹ Thuật', N'Phát triển phần mềm và hạ tầng IT'),
    (N'Phòng Kế Toán', N'Quản lý tài chính và dòng tiền');

INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) VALUES
    (N'Nguyễn Văn An', '1992-05-15', '001092000111', 1, 10000000, 1.2),
    (N'Trần Thị Bích', '1995-08-20', '001095000222', 2, 15000000, 1.5),
    (N'Lê Hoàng Cường', '1998-11-10', '001098000333', 2, 12000000, 1.0);
GO