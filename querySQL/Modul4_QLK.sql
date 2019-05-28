

use [QL_Kho_NL_CTy_NuocGiaiKhat]
go

---Lô hàng hóa---
create proc USP_GetallLo            
as
begin
    select * from   [dbo].[Lo]
end
go

---
create proc USP_InsertLo
           @maLo char(10),
           @ngaysanxuat date,
           @hansudung date,
           @soluong int
as
begin 
      insert dbo.Lo (MaLo,NgaySanXuat, HanSuDung, SoLuong)
      values (@maLo ,@ngaysanxuat, @hansudung, @soluong)
end
select *from [dbo].[Lo]

---
create proc USP_UpdateLo
            @ma char(10),
			@ngaysanxuat date,
            @hansudung date,
            @soluong int			
as
begin
    Update dbo.Lo 
	set    NgaySanXuat=@ngaysanxuat, HanSuDung=@hansudung, SoLuong=@soluong 
	where  MaLo=@ma
end
go

-----
create proc   USP_DeleteLo
            @ma char(10)
as
begin
    delete from dbo.Lo 
	       where MaLo=@ma
end
go

-----
create proc USP_SearchLo
            @search nvarchar(100)
as
begin
  select * from  dbo.Lo 
           where MaLo like N'%' + @search + '%'
                 or HanSuDung like N'%' + @search + '%'
                 or HanSuDung like N'%' + @search + '%'
                 or SoLuong like N'%' + @search + '%'
end
go


---Nhà Phân Phối---
create proc USP_GetallNhaPhanPhoi
           
as
begin
   select *from [dbo].[NhaPhanPhoi]
end
go

-----
create proc USP_InsertNPP
           @manpp char(10),
           @ten nvarchar(100),
           @sdt	decimal	,
           @loai nvarchar(50),
           @diachi nvarchar(50)
as
begin
    insert dbo.NhaPhanPhoi (MaNhaPhanPhoi,TenNhaPhanPhoi,SoDienThoai,LoaiNhaPhanPhoi,DiaChi)
    values (@manpp, @ten, @sdt, @loai, @diachi)
end

select *from [dbo].[NhaPhanPhoi]

-----
create proc  USP_UpdateNhaPhanPhoi
            @Ma char(10),
			@Ten nvarchar(50),
			@sdt	decimal	,
			@Diachi nvarchar(50),
			@Loai nvarchar(50)
as
begin
     Update dbo.NhaPhanPhoi 
	 set    TenNhaPhanPhoi=@Ten, SoDienThoai=@sdt, DiaChi=@Diachi, LoaiNhaPhanPhoi=@loai 
	 where  MaNhaPhanPhoi=@Ma
end
go

--
create proc USP_DeleteNhaPhanPhoi
           @ma char(10)
as
begin
     Delete from  dbo.NhaPhanPhoi 
	        where MaNhaPhanPhoi=@ma
end
go

-----
create proc USP_SearchNhaPhanPhoi
           @search nvarchar(100)
as
begin
Select * from dbo.NhaPhanphoi 
         where MaNhaPhanPhoi like N'%' + @search + '%'
            or TenNhaPhanPhoi like N'%' + @search + '%'
            or SoDienThoai like N'%' + @search + '%'
            or LoaiNhaPhanPhoi like N'%' + @search + '%'
            or DiaChi like N'%' + @search + '%'
end
go

----- Hàng hóa--

create proc USP_GetallHangHoa 
           @mahh char(10),
           @tenhh nvarchar(100),
           @malhh char(10),
           @dungtich int,
           @quycach nvarchar(100),
		   @soluongton int,
		   @malo char (10),
		   @makho char (10)         
as
begin
    select Mahanghoa, lhh.MaLoaiHangHoa, tenhanghoa, dungtich, quycach, soluongton, k.makho, l.malo
    from   hanghoa hh, loaihanghoa lhh , kho k, lo l
    where  hh.maloaihanghoa=lhh.maloaihanghoa and hh.makho=k.makho and l.malo=hh.malo
   
    insert into USP_GetallHangHoa(mahh, tenhh, malhh, dungtich, quycach, soluongton, makho, malo)
    values      (@mahh,@tenhh, @malhh, @dungtich,  @quycach, @soluongton, @malo, @makho)
end

--
create proc USP_InsertHangHoa
           @mahh char(10),
           @tenhh nvarchar(100),
           @malhh char(10),
           @dungtich int,
           @quycach nvarchar(100),
		   @soluongton int,
		   @malo char (10),
		   @makho char (10)

as
begin
    select Mahanghoa, lhh.MaLoaiHangHoa, tenhanghoa, dungtich, quycach, soluongton, k.makho, l.malo
    from   hanghoa hh, loaihanghoa lhh , kho k, lo l
    where  hh.maloaihanghoa=lhh.maloaihanghoa and hh.makho=k.makho and l.malo=hh.malo
    
	insert into dbo.HangHoa (MaHangHoa, TenHangHoa, MaLoaiHangHoa, DungTich, QuyCach, SoLuongTon, MaLo, MaKho)
    values      (@mahh,@tenhh, @malhh, @dungtich, @soluongton, @quycach, @malo, @makho)
end

--
create proc USP_UpdateHangHoa
           @mahh char(10),
           @tenhh nvarchar(100),
           @malhh char(10),
           @dungtich int,
           @quycach nvarchar(100),
		   @soluongton int,
		   @malo char (10),
		   @makho char (10)
as
begin 
    select Mahanghoa, lhh.MaLoaiHangHoa, tenhanghoa, dungtich, quycach, soluongton, k.makho, l.malo
    from   hanghoa hh, loaihanghoa lhh , kho k, lo l
    where  hh.maloaihanghoa=lhh.maloaihanghoa and hh.makho=k.makho and l.malo=hh.malo
   
    Update dbo.HangHoa 
	set    TenHangHoa=@tenhh, MaLoaiHangHoa=@malhh, DungTich=@dungtich, QuyCach=@quycach, SoLuongTon=@soluongton, MaLo=@malo, MaKho=@makho
    where  MaHangHoa=@mahh
end

--
create proc USP_DeleteHangHoa
           @mahh char(10)
as
begin
     Delete from  dbo.HangHoa 
	        where MahangHoa=@mahh
end
go

--
create proc USP_SearchHangHoa
           @search nvarchar(100)
as
begin
select * from hanghoa
         where MaHangHoa like N'%' + @search + '%'
            or TenHangHoa like N'%' + @search + '%'
            or MaLoaiHangHoa like N'%' + @search + '%'
            or MaLo like N'%' + @search + '%'
            or MaKho like N'%' + @search + '%'
			or QuyCach like N'%' + @search + '%'
		    or DungTich like N'%' + @search + '%'
		    or SoLuongTon like N'%' + @search + '%'
		
end


-- Loại Hàng hóa
create proc USP_GetallLHH
           
as
begin
   select *from [dbo].[LoaiHangHoa]
end
go

-----
create proc USP_InsertLHH
           @malhh char(10),
           @tenlhh nvarchar(100)
as
begin
    insert dbo.LoaiHangHoa(MaLoaihangHoa,TenLoaiHangHoa)
    values (@malhh, @tenlhh)
end

select *from [dbo].[LoaiHangHoa]

-----
create proc  USP_UpdateLHH
            @Malhh char(10),
			@Tenlhh nvarchar(50)
as
begin
     Update dbo.LoaiHangHoa 
	 set    TenLoaiHangHoa=@Tenlhh
	 where  MaLoaiHangHoa=@Malhh
end
go

--
create proc USP_DeleteLHH
           @malhh char(10)
as
begin
     Delete from dbo.LoaiHangHoa 
	        where MaLoaiHangHoa=@malhh
end
go

-----
create proc USP_SearchLHH
           @search nvarchar(100)
as
begin
Select * from  dbo.LoaiHangHoa 
         where MaLoaiHangHoa like N'%' + @search + '%'
            or TenLoaiHangHoa like N'%' + @search + '%'
end
go

--Phân xưởng
create proc USP_GetallPX         
as
begin
   select *from [dbo].[PhanXuong]
end
go

-----
create proc USP_InsertPX
           @mapx char(10),
           @ten nvarchar(100),
           @sdt	decimal	,
           @email nvarchar(50)
as
begin
    insert dbo.PhanXuong(MaPhanXuong,TenPhanXuong,SoDienThoai,Email)
    values (@mapx, @ten, @sdt, @email)
end

select *from [dbo].[PhanXuong]

-----
create proc USP_UpdatePX
            @Ma char(10),
			@Ten nvarchar(50),
			@sdt	decimal	,
			@email nvarchar(50)
as
begin
     Update dbo.PhanXuong
	 set    TenPhanXuong=@Ten, SoDienThoai=@sdt, Email=@email
	 where  MaPhanXuong=@Ma
end
go

--
create proc USP_DeletePX
           @ma char(10)
as
begin
     Delete from  dbo.PhanXuong 
	        where MaPhanXuong=@ma
end
go

-----
create proc USP_SearchPX
           @search nvarchar(100)
as
begin
Select * from dbo.PhanXuong 
         where MaPhanXuong like N'%' + @search + '%'
            or TenPhanXuong like N'%' + @search + '%'
            or SoDienThoai like N'%' + @search + '%'
            or Email like N'%' + @search + '%'
            
end
go

---Nhân viên
create proc USP_GetallNV         
as
begin
   select *from [dbo].[NhanVien]
end
go

-----
create proc USP_InsertNV
           @ma char(10),
	       @ten nvarchar(100),
	       @gt int,
	       @ns date,
	       @dc nvarchar(250),
	       @sdt dec(11, 0),
	       @email char(255),
	       @luong int	      
as
begin
    insert dbo.NhanVien(MaNhanVien,TenNhanVien,GioiTinh,NgaySinh, DiaChi, SoDienThoai,Email,Luong)
    values (@ma, @ten, @gt, @ns, @dc, @sdt, @email, @luong)
end

select *from [dbo].[NhanVien]

---
create proc USP_UpdateNV
           @ma char(10),
	       @ten nvarchar(100),
	       @gt int,
	       @ns date,
	       @dc nvarchar(250),
	       @sdt dec(11, 0),
	       @email char(255),
	       @luong int
as
begin
     Update dbo.NhanVien
	 set    TenNhanVien=@Ten, SoDienThoai=@sdt, Email=@email, gioitinh=@gt, ngaysinh=@ns, diachi=@dc, luong=@luong
	 where  MaNhanVien=@Ma
end
go

--
create proc USP_DeleteNV
            @ma char(10)
as
begin
     Delete from dbo.NhanVien 
	        where MaNhanVien=@ma
end
go

-----
create proc USP_SearchNV
           @search nvarchar(100)
as
begin
Select * from dbo.NhanVien 
         where MaNhanVien like N'%' + @search + '%'
            or TenNhanVien like N'%' + @search + '%'
            or SoDienThoai like N'%' + @search + '%'
            or Email like N'%' + @search + '%'
            or gioitinh like N'%' + @search + '%'
			or ngaysinh like N'%' + @search + '%'
			or luong like N'%' + @search + '%'
			or diachi like N'%' + @search + '%'
end
go

--Kiểm tra hàng hóa
create proc USP_Getall_KiemTraHangHoa
            @mahh char(10),
            @tenhh nvarchar(100),
            @malhh char(10),
            @dungtich int,
            @quycach nvarchar(100),
		    @soluongton int,
		    @malo char (10),
		    @makho char (10)
as
begin
     select Mahanghoa, lhh.MaLoaiHangHoa, tenhanghoa, dungtich, quycach, soluongton, k.makho, l.malo
     from   hanghoa hh, loaihanghoa lhh , kho k, lo l
     where  hh.maloaihanghoa=lhh.maloaihanghoa and hh.makho=k.makho and l.malo=hh.malo

     insert into USP_Getall_KiemTraHangHoa(mahh, tenhh, malhh, dungtich, quycach, soluongton, makho, malo)
     values      (@mahh,@tenhh, @malhh, @dungtich, @soluongton, @quycach, @malo, @makho)
end


--Fix
create proc USP_Getall_HH
           
as
begin
   select *from [dbo].[HangHoa]
end
go










