CREATE DATABASE student1
USE student1

CREATE TABLE NHANVIEN(
	MaNv INT IDENTITY(1,1) PRIMARY KEY,
	HoTen NVARCHAR(30) NOT NULL,
	PhongBan NVARCHAR(50) NOT NULL,
	ChucVu NVARCHAR(30) NOT NULL,
	Luong DECIMAL(10,0) NOT NULL
)
INSERT INTO dbo.NHANVIEN
        (HoTen, PhongBan, ChucVu, Luong )
VALUES  ( N'Hà Nhật Huy', -- HoTen - nvarchar(30)
          N'Phòng sản xuất', -- PhongBan - nvarchar(50)
          N'Nhân viên', -- ChucVu - nvarchar(30)
          4600000  -- Luong - decimal
          )
-- Sắp xếp họ tên tăng dần
CREATE PROC SapXep_HoTenTangDan
AS
BEGIN
	SELECT *
	FROM dbo.NHANVIEN
    ORDER BY HoTen ASC
END

EXEC SapXep_HoTenTangDan
-- lương tăng dần
CREATE PROC SapXep_LuongTangDan
AS
BEGIN
	SELECT *
	FROM dbo.NHANVIEN
    ORDER BY Luong ASC
END
-- lương giảm dần
ALTER PROC SapXep_LuongGiamDan
AS
BEGIN
	SELECT *
	FROM dbo.NHANVIEN
    ORDER BY Luong DESC
END

-- Tổng nhân viên
CREATE PROC TongNhanVien
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.NHANVIEN
END
