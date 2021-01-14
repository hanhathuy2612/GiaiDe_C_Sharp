CREATE DATABASE VATLIEUDATA

USE VATLIEUDATA
GO

CREATE TABLE VatLieu(
	MaVL INT IDENTITY(1,1) PRIMARY KEY,
	TenVL NVARCHAR(100) NOT NULL,
	DonVi NVARCHAR(100) NOT NULL,
	GiaNhap DECIMAL(10,0) NOT NULL,
	GiaBan DECIMAL(10,0),
	FileAnh VARCHAR(MAX),
	GhiChu NVARCHAR(100),
	SoLuong INT
)
GO

INSERT INTO dbo.VatLieu
        (
          TenVL ,
          DonVi ,
          GiaNhap ,
          GiaBan ,
          FileAnh ,
          GhiChu ,
          SoLuong
        )
VALUES  (
          N'Xẻng' , -- TenVL - nvarchar(100)
          N'vnd' , -- DonVi - nvarchar(100)
          15000 , -- GiaNhap - decimal
          12000 , -- GiaBan - decimal
          'h1.png' , -- FileAnh - varchar(max)
          N'Hàng chất lượng cao' , -- GhiChu - nvarchar(100)
          100  -- SoLuong - int
        )

SELECT * FROM dbo.VatLieu