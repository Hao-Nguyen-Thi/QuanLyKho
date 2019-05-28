create database QL_Kho_NL_CTy_NuocGiaiKhat
on primary
(
	size = 3,
	filegrowth = 1,
	maxsize = 2GB,
	filename = 'D:\CSDL\QL_Kho_NL_CTy_NuocGiaiKhat.mdf',
	name = QL_Kho_NL_CTy_NuocGiaiKhat
)
log on
(
	size = 1,
	filegrowth=10%,
	maxsize = unlimited,
	filename = 'D:\CSDL\QL_Kho_NL_CTy_NuocGiaiKhat.ldf',
	name = QL_Kho_NL_CTy_NuocGiaiKhat_log
)

go

use QL_Kho_NL_CTy_NuocGiaiKhat

create table LoaiHangHoa
(
	MaLoaiHangHoa char(10),
	TenLoaiHangHoa nvarchar(100),
	constraint LoaiHangHoa_pk primary key (MaLoaiHangHoa)
)

Create table Lo
(
	MaLo char(10),
	NgaySanXuat date,
	HanSuDung date,
	SoLuong int,
	constraint Lo_pk primary key (MaLo)
)



create table PhanXuong
(
	MaPhanXuong char(10),
	TenPhanXuong nvarchar(100),
	SoDienThoai dec(11, 0),
	Email char(255),
	constraint PhanXuong_pk primary key (MaPhanXuong)
)

Create table NhanVien
(
	MaNhanVien char(10),
	TenNhanVien nvarchar(100),
	GioiTinh bit,
	NgaySinh date,
	DiaChi nvarchar(250),
	SoDienThoai dec(11, 0),
	Email char(255),
	Luong money,
	NgayBatDauLamViec date,
	constraint NhanVien_pk primary key (MaNhanVien)
)
Create table Kho
(
	MaKho char(10),
	TenKho nvarchar(100),
	MaNhanVien_ThuKho char(10),
	constraint Kho_pk primary key (MaKHo),
	constraint fk_htk1_NhanVien
		foreign key (MaNhanVien_ThuKho)
		references NhanVien (MaNhanVien),
	
)

Create table HangHoa
(
	MaHangHoa char(10),
	TenHangHoa nvarchar(100),
	MaLoaiHangHoa char(10),
	DungTich int,
	QuyCach nvarchar(200),
	SoLuongTon int,
	MaKho char(10),
	MaLo char(10),
	primary key (MaHangHoa),
	constraint fk_htk_LoaiHangHoa
		foreign key (MaLoaiHangHoa)
		references LoaiHangHoa(MaLoaiHangHoa),
	constraint fk_htk_Lo
		foreign key (MaLo)
		references Lo (MaLo),
	constraint fk_htk1_Kho
		foreign key (MaKho)
		references Kho (MaKho)
)

Create table HoaDonNhap
(
	MaHoaDonNhap char(10),
	NgayNhap date,	
	MaPhanXuong char(10),
	MaNhanVienNhap char(10),	
	GhiChu nvarchar(500),
	constraint HoaDonNhap_pk primary key (MaHoaDonNhap),	
	constraint fk_htk_PhanXuong
		foreign key (MaPhanXuong)
		references PhanXuong (MaPhanXuong),
	constraint fk_htk_NhanVien
		foreign key (MaNhanVienNhap)
		references NhanVien (MaNhanVien)
)

create table CT_HoaDonNhap
(
	MaHoaDonNhap char(10),
	MaHangHoa char(10),
	DonGia money,
	MaLo char(10),
	SoLuongNhap int,
	constraint fk_htk1_Lo
		foreign key (MaLo)
		references Lo (MaLo),
	constraint fk_htk_HoaDonNhap 
		foreign key (MaHoaDonNhap)
		references HoaDonNhap (MaHoaDonNhap),
	constraint fk_htk_HangHoa
		foreign key (MaHangHoa)
		references HangHoa (MaHangHoa)
)


Create table NhaPhanPhoi
(
	MaNhaPhanPhoi char(10),
	TenNhaPhanPhoi nvarchar(500),
	LoaiNhaPhanPhoi nvarchar(100),
	DiaChi nvarchar(250),
	SoDienThoai dec(11, 0),	
	constraint NhaPhanPhoi_pk primary key (MaNhaPhanPhoi)
)

Create table HoaDonXuat
(
	MaHoaDonXuat char(10),
	NgayXuat date,
	MaNhanVienXuat char(10),
	MaNhaPhanPhoi char(10),
	GhiChu nvarchar(500),
	Primary key (MaHoaDonXuat),
	constraint fk_htk2_NhanVien
		foreign key (MaNhanVienXuat)
		references NhanVien (MaNhanVien),
	constraint fk_htk_NhaPhanPhoi
		foreign key (MaNhaPhanPhoi)
		references NhaPhanPhoi (MaNhaPhanPhoi),
)

create table CT_HoaDonXuat
(
	MaHoaDonXuat char(10),
	MaHangHoa char(10),
	MaLo char(10),
	SoLuongXuat int,
	constraint fk_htk2_HoaDonXuat
		foreign key (MaHoaDonXuat)
		references HoaDonXuat (MaHoaDonXuat),
	constraint fk_htk3_HangHoa
		foreign key (MaHangHoa)
		references HangHoa (MaHangHoa),
	constraint fk_htk3_Lo
		foreign key (MaLo)
		references Lo (MaLo),
)

insert into LoaiHangHoa (MaLoaiHangHoa, TenLoaiHangHoa)
	Values
		('NTK0125476', N'Nước tinh khiết'),
		('NEHQ565046',N'Nước ép hoa quả'),
		('NTL5156453',N'Nước tăng lực'),
		('STTC321149',N'Sinh tố trái cây'),
		('TGC1131514',N'Trà giảm cân');

insert into NhaPhanPhoi (MaNhaPhanPhoi, TenNhaPhanPhoi, DiaChi, SoDienThoai, LoaiNhaPhanPhoi)
	values
		('NPP0000001', N'Công Ty TNHH Nước Giải Khát Hà Nội', N'Số 42 Võ Ngọc Quận, P. 6, TP. Tân An, Long An', 02723827010, N'Công ty TNHH'),
		('NPP0000002', N'Công Ty TNHH Thực Phẩm Và Nước Giải Khát Cao Cấp Quang Lợi', N'Số 8, Đại Lộ Thống Nhất, KCN Sóng Thần 2, Phường Dĩ An, TX Dĩ An, Bình Dương', 02743784688, N'Công ty TNHH'),
		('NPP0000003', N'Thực phẩm sạch Sóc Bay', N'Lô 11 - BT04, KĐT Mới Cầu Bươu, X. Tân Triều, H. Thanh Trì, Hà Nội', 02420230808, N'Đại lý phân phối'),
		('NPP0000004', N'Công Ty Cổ Phần Thương Mại Dịch Vụ Sản Xuất An Lạc', N'C10, 39 Khu Nhà Ở Tại Phân Khu 18A, Đường Nguyễn Hữu Thọ, X. Phước Kiến, H. Nhà Bè, Tp. Hồ Chí Minh (TPHCM)', 02836209955, N'Công ty cổ phần'),
		('NPP0000005', N'Công Ty TNHH Một Thành Viên Thực Phẩm Và Nước Giải Khát Nam Việt', N'994/1C Đường Nguyễn Thị Minh Khai, KP Tân Thắng, P. Tân Bình, TX. Dĩ An, Bình Dương', 02743800118, N'Công ty TNHH');

insert into PhanXuong (MaPhanXuong, TenPhanXuong, SoDienThoai, Email)
	Values 
		('PXU0000001', N'Phân xưởng sản xuất nước tinh khiết', 0245054589, 'NTK_px1@gmail.com'),
		('PXU0000002', N'Phân xưởng sản xuất nước ép hoa quả', 0281551564, 'NEHQ_px2@gmail.com'),
		('PXU0000003', N'Phân xưởng sản xuất nước tăng lực', 0242597521, 'NTL_px3@gmail.com'),
		('PXU0000004', N'Phân xưởng sản xuất sinh tố trái cây', 0281156466, 'STRC_px4@gmail.com'),
		('PXU0000005', N'Phân xưởng sản xuất trà giảm cân', 0245879963, 'TGC_px5@gmail.com');

insert into Lo (MaLo, NgaySanXuat, HanSuDung, SoLuong)
	Values
		('LOX0000001', '2019-01-26', '2020-01-26', 1500),
		('LOX0000002', '2019-02-13', '2020-02-13', 2500),
		('LOX0000003', '2019-02-26', '2020-02-26', 3200),
		('LOX0000004', '2019-01-25', '2020-01-25', 1800),
		('LOX0000005', '2019-02-27', '2020-02-27', 1200);

insert into NhanVien (MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, SoDienThoai, Email, Luong, NgayBatDauLamViec)
	values
		('NV00000001', N'Trần Quang Khải', 1, '1987-01-12', N'Chiến Thắng, Tiên Lữ, Hưng Yên', 0987462668, 'khaitq0411@gmail.com', 2500, '2014-10-08'),
		('NV00000002', N'Hoàng Tuấn Minh', 1, '1989-10-07', N'247 Xuân Thủy, Cầu Giấy, Hà Nội', 0989745124, 'tuanminh1989@gmail.com', 2700, '2014-01-12'),
		('NV00000003', N'Lê Thị Minh Anh', 0, '1985-01-15', N'Dân Chủ, Kim Sơn, Ninh Bình', 0945464489, 'minhanh1501@yahoo.com', 2500, '2015-10-17'),
		('NV00000004', N'Cao Lệ Quyên', 0, '1989-12-08', N'Văn Cẩm, Hưng Hà, Thái Bình', 0625651515,'hachudd@gmail.com', 2500, '2017-10-14'),
		('NV00000005', N'Nguyễn Tuấn Hùng', 1, '1988-02-08', N'Thị xã Phú Thọ, Phú Thọ', 0355488989, 'tuanhung11@gmail.com', 2450, '2017-05-19');

insert into Kho(MaKho, TenKho, MaNhanVien_ThuKho)
	Values
		('KHO0000001', N'Kho nước tinh khiết', 'NV00000001'),
		('KHO0000002', N'Kho nước ép hoa quả', 'NV00000005'),
		('KHO0000003', N'Kho nước tăng lực', 'NV00000003'),
		('KHO0000004', N'Kho sinh tố trái cây', 'NV00000002'),
		('KHO0000005', N'Kho trà giảm cân', 'NV00000004');

insert into HangHoa (MaHangHoa, TenHangHoa, MaLoaiHangHoa, DungTich, QuyCach, SoLuongTon, MaLo)
	Values
		('HAH0000001', N'Nước tinh khiết Queen', 'NTK0125476', 200, N'Chai nhựa hình bầu dục', 15000 , 'LOX0000004'),
		('HAH0000002', N'Nước ép hoa quả hảo hạng Tigerking', 'NEHQ565046', 180, N'Chai thủy tinh', 10000, 'LOX0000001'),
		('HAH0000003', N'Nước tăng lực Redbull', 'NTL5156453', 250, N'Lon', 15000, 'LOX0000003'),
		('HAH0000004', N'Sinh tố trái cây hốn hợp Bee', 'STTC321149', 100, N'Chai nhựa trong màu', 12500, 'LOX0000005'),
		('HAH0000005', N'Trà giảm cân Sky ', 'TGC1131514', 180, N'Hộp giấy chất lượng cao', 14000, 'LOX0000002');
insert into HoaDonNhap (MaHoaDonNhap, NgayNhap, MaPhanXuong,MaNhanVienNhap,GhiChu)
	Values
		('HĐO0000001', '2019-02-28', 'PXU0000002', 'NV00000005', N' '),
		('HĐO0000002', '2019-02-27', 'PXU0000003', 'NV00000003', N' '),
		('HĐO0000003', '2019-02-27', 'PXU0000005', 'NV00000001', N' '),
		('HĐO0000004', '2019-02-28', 'PXU0000004', 'NV00000004', N' '),
		('HĐO0000005', '2019-02-27', 'PXU0000001', 'NV00000002', N' ');

insert into CT_HoaDonNhap(MaHoaDonNhap,MaHangHoa, MaLo, SoLuongNhap)
	values
		( 'HĐO0000001','HAH0000001','LOX0000004', 1000),
		( 'HĐO0000001','HAH0000005','LOX0000002', 950),
		( 'HĐO0000001','HAH0000004','LOX0000005', 1200),
		( 'HĐO0000001','HAH0000002','LOX0000001', 1250),
		( 'HĐO0000001','HAH0000003','LOX0000003', 1000);

insert into HoaDonXuat (MaHoaDonXuat, NgayXuat, MaNhanVienXuat, MaNhaPhanPhoi, GhiChu)
	values
		('HDX0000001', '2019-02-28', 'NV00000001', 'NPP0000001', N' '),
		('HDX0000002', '2019-02-28', 'NV00000002', 'NPP0000003', N' '),
		('HDX0000003', '2019-02-27', 'NV00000003', 'NPP0000001', N' '),
		('HDX0000004', '2019-02-27', 'NV00000005', 'NPP0000004', N' '),
		('HDX0000005', '2019-02-28', 'NV00000004', 'NPP0000004', N' ');
insert into CT_HoaDonXuat (MaHoaDonXuat, MaHangHoa, MaLo, SoLuongXuat)
	values
		('HDX0000004', 'HAH0000003', 'LOX0000003',  900),
		('HDX0000004', 'HAH0000005', 'LOX0000002',  700),
		('HDX0000004', 'HAH0000004', 'LOX0000005',  800),
		('HDX0000004', 'HAH0000002', 'LOX0000001',  900),
		('HDX0000004', 'HAH0000001', 'LOX0000004',  900);

--Nghiệp vụ thay đổi thông tin của nhà phân phối

--1.Thực hiện kiểm tra nhà phân phối
select*from NhaPhanPhoi
select MaNhaPhanPhoi, TenNhaPhanPhoi, DiaChi, SoDienThoai, LoaiNhaPhanPhoi
from NhaPhanPhoi
Where MaNhaPhanPhoi='NPP0000001'

select*from NhaPhanPhoi
select MaNhaPhanPhoi, TenNhaPhanPhoi, DiaChi, SoDienThoai, LoaiNhaPhanPhoi
from NhaPhanPhoi
Where MaNhaPhanPhoi='NPP0000002'

--2. Khi nhà phân phối thay đổi thông tin liên lạc, ví dụ số điện thoại, địa chỉ của nhà phân phối 
--chúng ta cần cập nhật lại thông tin đã bị thay đổi của nhà phân phối đó.

Update NhaPhanPhoi
set SoDienThoai='0988762288'
WHERE MaNhaPhanPhoi='NPP0000001'

Update NhaPhanPhoi
set DiaChi=N'KCN Yên Phong, Bắc Ninh'
WHERE MaNhaPhanPhoi='NPP0000002'




