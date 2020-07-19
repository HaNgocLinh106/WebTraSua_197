create database WebTraSua_217
use WebTraSua_217
go
create table QuanTriVien
(
UserName int identity(1,1) primary key,
Email char(50),
Pass char(10),
PhanQuyen char(10),
)

 create table NguoiDung
 (
 MaNguoiDung int identity(1,1) primary key,
 TenNguoiDung nvarchar(250),
 SDT char(10),
 DiaChi nvarchar(500),
 UserName char(250),
 Pass char(10),
 )
  create table PhanHoi
 (
 MaPhanHoi int identity(1,1) primary key,
 TenNguoiPhanHoi nvarchar(250),
 NoiDung nvarchar(500),
 NgayPhanHoi datetime,
 )

create table DanhMuc
(
MaDanhMuc bigint identity(1,1) primary key,
TenDanhMuc nvarchar(250),
MetaTitle varchar(50),
) 

create table SanPham
(
MaSanPham bigint identity(1,1) primary key,
TenSanPham nvarchar(100),
MetaTitle varchar(50),
DonGia int,
LinkAnhSP nvarchar(20),
MoTa nvarchar(500),
TrangThai bit,
MaDanhMuc bigint references DanhMuc(MaDanhMuc),
)

create table Size
(
MaSize int identity(1,1) primary key,
MaSanPham bigint references SanPham(MaSanPham),
Size nvarchar(10),
Gia int
)

create table Topping
(
MaTopping int identity(1,1) primary key,
Topping nvarchar(100),
DonGia int
)

create table Duong
(
MaDuong int identity(1,1) primary key,
Duong nvarchar(10)
)
create table Da
(
MaDa int identity(1,1) primary key,
Da nvarchar(10)
)
create table GioHang 
 (
 MaGioHang bigint identity(1,1) primary key,
 NgayThang date,
 HinhThucThanhToan nvarchar(250),
 TenNguoiDung nvarchar(250),
 SDT char(10),
 DiaChi nvarchar(500),
 )

 create table ChiTietGioHang
 (
 MaChiTietGioHang bigint identity(1,1) primary key,
 MaGioHang bigint references GioHang(MaGioHang),
 MaSanPham bigint references SanPham(MaSanPham),
 Duong nvarchar(10),
 Da nvarchar(10),
 Topping nvarchar(100),
 DonGia int,
 SoLuong int,
 )
