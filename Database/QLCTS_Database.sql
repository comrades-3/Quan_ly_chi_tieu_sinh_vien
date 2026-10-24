USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyChiTieuSV')
BEGIN
    CREATE DATABASE QuanLyChiTieuSV;
END
GO

USE QuanLyChiTieuSV;
GO

IF OBJECT_ID('vw_GiaoDich', 'V') IS NOT NULL DROP VIEW vw_GiaoDich;
IF OBJECT_ID('GiaoDich', 'U') IS NOT NULL DROP TABLE GiaoDich;
IF OBJECT_ID('NganSach', 'U') IS NOT NULL DROP TABLE NganSach;
IF OBJECT_ID('TietKiem', 'U') IS NOT NULL DROP TABLE TietKiem;
IF OBJECT_ID('DanhMuc', 'U') IS NOT NULL DROP TABLE DanhMuc;
IF OBJECT_ID('TaiKhoan', 'U') IS NOT NULL DROP TABLE TaiKhoan;
GO

CREATE TABLE TaiKhoan (
    MaTaiKhoan      INT PRIMARY KEY IDENTITY(1,1),
    TenDangNhap     NVARCHAR(50)    NOT NULL UNIQUE,
    MatKhau         NVARCHAR(256)   NOT NULL,           
    HoTen           NVARCHAR(100),
    Email           NVARCHAR(100),
    SoDienThoai     NVARCHAR(15),
    NgaySinh        DATE,
    GioiTinh        NVARCHAR(10),                  
    Lop             NVARCHAR(50),
    MaSoSV          NVARCHAR(20),
    AnhDaiDien      NVARCHAR(255),                      
    NgayTao         DATETIME        DEFAULT GETDATE(),
    TrangThai       BIT             DEFAULT 1            
);
GO

CREATE TABLE DanhMuc (
    MaDanhMuc       INT PRIMARY KEY IDENTITY(1,1),
    TenDanhMuc      NVARCHAR(100)   NOT NULL,
    LoaiDanhMuc     NVARCHAR(5)     NOT NULL CHECK (LoaiDanhMuc IN ('THU', 'CHI')),
    MoTa            NVARCHAR(255),
    LaMacDinh       BIT             DEFAULT 0,
    NgayTao         DATETIME        DEFAULT GETDATE()
);
GO

CREATE TABLE GiaoDich (
    MaGiaoDich      INT PRIMARY KEY IDENTITY(1,1),
    MaTaiKhoan      INT             NOT NULL FOREIGN KEY REFERENCES TaiKhoan(MaTaiKhoan),
    MaDanhMuc       INT             NOT NULL FOREIGN KEY REFERENCES DanhMuc(MaDanhMuc),
    LoaiGiaoDich    NVARCHAR(5)     NOT NULL CHECK (LoaiGiaoDich IN ('THU', 'CHI')),
    SoTien          DECIMAL(18, 0)  NOT NULL CHECK (SoTien > 0),
    NgayGiaoDich    DATE            NOT NULL,
    GhiChu          NVARCHAR(500),
    NgayTao         DATETIME        DEFAULT GETDATE(),
    NgayCapNhat     DATETIME        DEFAULT GETDATE()
);
GO

CREATE TABLE NganSach (
    MaNganSach      INT PRIMARY KEY IDENTITY(1,1),
    MaTaiKhoan      INT             NOT NULL FOREIGN KEY REFERENCES TaiKhoan(MaTaiKhoan),
    Thang           INT             NOT NULL CHECK (Thang BETWEEN 1 AND 12),
    Nam             INT             NOT NULL CHECK (Nam >= 2000),
    SoTienNganSach  DECIMAL(18, 0)  NOT NULL CHECK (SoTienNganSach > 0),
    GhiChu          NVARCHAR(255),
    NgayTao         DATETIME        DEFAULT GETDATE(),
    UNIQUE(MaTaiKhoan, Thang, Nam)  
);
GO

CREATE TABLE TietKiem (
    MaTietKiem      INT PRIMARY KEY IDENTITY(1,1),
    MaTaiKhoan      INT FOREIGN KEY REFERENCES TaiKhoan(MaTaiKhoan),
    TenMucTieu      NVARCHAR(100),
    SoTienMucTieu   DECIMAL(18,0),
    SoTienHienCo    DECIMAL(18,0) DEFAULT 0,
    NgayBatDau      DATE,
    NgayKetThuc     DATE,
    TrangThai       NVARCHAR(50) 
);
GO

INSERT INTO DanhMuc (TenDanhMuc, LoaiDanhMuc, MoTa, LaMacDinh) VALUES
(N'Ăn uống',               'CHI', N'Chi phí ăn uống hàng ngày',              1),
(N'Học phí & Sách vở',     'CHI', N'Học phí, sách giáo khoa, văn phòng phẩm',1),
(N'Đi lại',                'CHI', N'Xăng xe, xe buýt, grab...',               1),
(N'Nhà ở / Thuê trọ',      'CHI', N'Tiền thuê phòng, điện nước',              1),
(N'Quần áo',               'CHI', N'Mua sắm quần áo, giày dép',               1),
(N'Giải trí',              'CHI', N'Phim, game, du lịch, cafe...',            1),
(N'Y tế',                  'CHI', N'Thuốc, khám bệnh, sức khỏe',              1),
(N'Điện thoại / Internet', 'CHI', N'Cước điện thoại, internet',               1),
(N'Chi khác',              'CHI', N'Các khoản chi khác',                      1);

INSERT INTO DanhMuc (TenDanhMuc, LoaiDanhMuc, MoTa, LaMacDinh) VALUES
(N'Gia đình hỗ trợ',       'THU', N'Tiền gia đình gửi hàng tháng',           1),
(N'Học bổng',              'THU', N'Học bổng từ trường, tổ chức',             1),
(N'Làm thêm / Part-time',  'THU', N'Thu nhập từ công việc làm thêm',         1),
(N'Thưởng',                'THU', N'Tiền thưởng, quà tặng',                   1),
(N'Thu khác',              'THU', N'Các khoản thu khác',                      1);
GO

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Email, MaSoSV, Lop)
VALUES (
    N'sinhvien01',
    N'123456',
    N'Nguyễn Văn A',
    N'sinhvien01@email.com',
    N'SV001',
    N'CNTT01'
);
GO

INSERT INTO GiaoDich (MaTaiKhoan, MaDanhMuc, LoaiGiaoDich, SoTien, NgayGiaoDich, GhiChu)
VALUES
(1, 10, 'THU', 3000000, '2026-10-01', N'Tiền nhà gửi tháng 10'),
(1, 12, 'THU', 1500000, '2026-10-05', N'Lương làm thêm'),
(1,  1, 'CHI',  150000, '2026-10-02', N'Ăn uống tuần đầu'),
(1,  3, 'CHI',  200000, '2026-10-03', N'Xăng xe cả tuần'),
(1,  4, 'CHI', 1500000, '2026-10-05', N'Tiền phòng tháng 10'),
(1,  1, 'CHI',   80000, '2026-10-10', N'Ăn trưa + tối'),
(1,  6, 'CHI',  100000, '2026-10-15', N'Cafe với bạn bè');
GO

CREATE VIEW vw_GiaoDich AS
SELECT
    gd.MaGiaoDich,
    gd.MaTaiKhoan,
    tk.HoTen,
    gd.MaDanhMuc,
    dm.TenDanhMuc,
    gd.LoaiGiaoDich,
    gd.SoTien,
    gd.NgayGiaoDich,
    gd.GhiChu,
    gd.NgayTao
FROM GiaoDich gd
INNER JOIN TaiKhoan tk ON gd.MaTaiKhoan = tk.MaTaiKhoan
INNER JOIN DanhMuc  dm ON gd.MaDanhMuc  = dm.MaDanhMuc;
GO
