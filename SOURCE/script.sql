USE [SeasonalFoods]
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        QL_NguoiDung.TenDangNhap, QL_NguoiDung.MatKhau
FROM            QL_NguoiDung INNER JOIN
                         QL_NguoiDungNhomNguoiDung ON QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap

GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScalarQuery]
AS
	SET NOCOUNT ON;
SELECT        QL_NguoiDung.TenDangNhap, QL_NguoiDung.MatKhau
FROM            QL_NguoiDung INNER JOIN
                         QL_NguoiDungNhomNguoiDung ON QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap
WHERE        (QL_NguoiDung.TenDangNhap = N'QL_NguoiDungNhomNguoiDung')

GO
/****** Object:  UserDefinedFunction [dbo].[getHangHoa]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[getHangHoa]()
returns @kq table(
	MASP char(10), MALOAI char(10),TENSP nvarchar(50),GIA_BAN float, GIAMGIA float, GIA_BAN_1 float,
	DVT nvarchar(20), SOLUONG int 
)
as
begin
	insert into @kq
	select bg.MASP, MALOAI, TENSP, GIA_BAN, ISNULL(GIAMGIA, 0) AS GIAMGIA, (GIA_BAN - 0.01* ISNULL(GIAMGIA, 0)*GIA_BAN) as GIA_BAN_1, DVT, SOLUONG
	 from 
	(select hh.*, bg.GIA_BAN from HANGHOA hh, BANG_GIA bg where hh.MASP = bg.MASP and hh.HIDDEN = 1
	and NGAYBD = (select MAX(NGAYBD) from BANG_GIA where MASP = bg.MASP))  bg
	left join 
	(select * from KHUYEN_MAI
	where GETDATE() between NGAYBD_KM and NGAYKT_KM) km
	on bg.MASP = km.MASP
	return
end
GO
/****** Object:  UserDefinedFunction [dbo].[getHangHoa_Loai]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[getHangHoa_Loai](@maLoai char(10))
returns @kq table (
	MASP char(10), TENSP nvarchar(50),GIA_BAN float, GIAMGIA float, GIA_BAN_1 float,
	DVT nvarchar(20), SOLUONG int 
)
as
begin
	if(@maLoai = '')
	begin
		insert into @kq
		select MASP, TENSP, GIA_BAN, GIAMGIA, GIA_BAN_1, DVT, SOLUONG from getHangHoa()
	end
	else
	begin
		insert into @kq
		select MASP, TENSP, GIA_BAN, GIAMGIA, GIA_BAN_1, DVT, SOLUONG from getHangHoa()	where MALOAI = @maLoai or MASP = @maLoai or TENSP like @maLoai
	end
	return
end
GO
/****** Object:  UserDefinedFunction [dbo].[getPhanQuyen]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[getPhanQuyen](@manv char(10))
returns @kq table(maMH nvarchar(50))
as
begin
insert into @kq

	select DISTINCT PHAN_QUYEN.MaManHinh from TAI_KHOAN, NGUOIDUNG_NHOM_ND, NHOM_NGUOI_DUNG, PHAN_QUYEN
	where TAI_KHOAN.TENDN = NGUOIDUNG_NHOM_ND.TenDangNhap 
			and NGUOIDUNG_NHOM_ND.MaNhomNguoiDung = NHOM_NGUOI_DUNG.MaNhom
			and NHOM_NGUOI_DUNG.MaNhom = PHAN_QUYEN.MaNhomNguoiDung and TAI_KHOAN.MANV = @manv

return
end
GO
/****** Object:  UserDefinedFunction [dbo].[getQuyen_Nhom]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[getQuyen_Nhom](@maNhom varchar(20))
returns @kq table (MaManHinh nvarchar(50),TenManHinh nvarchar(50), Quyen int)
as
begin
insert into @kq
select MaManHinh, TenManHinh, (case when MaManHinh = b.mh  then 1 else 0 end) as Quyen from
(
select mh.MaManHinh, TenManHinh, MaNhomNguoiDung, pq.MaManHinh as mh from MAN_HINH mh left join PHAN_QUYEN pq
on mh.MaManHinh = pq.MaManHinh and pq.MaNhomNguoiDung = @maNhom
) as b left join NHOM_NGUOI_DUNG
on b.MaNhomNguoiDung = NHOM_NGUOI_DUNG.MaNhom
return
end

GO
/****** Object:  UserDefinedFunction [dbo].[getTaiKhoan_Nhom]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[getTaiKhoan_Nhom](@maNhom varchar(20))
returns @kq table (MANV char(10), TENNV nvarchar(50), Thuoc int)
as
begin
insert into @kq
--select NV.MANV, NV.TENNV, sum(case when NV.TENDN = NGUOIDUNG_NHOM_ND.TenDangNhap then 1 else 0 end) as Thuoc
--from NGUOIDUNG_NHOM_ND, (select TAI_KHOAN.TENDN, NHANVIEN.MANV, NHANVIEN.TENNV from NHANVIEN, TAI_KHOAN where NHANVIEN.MANV = TAI_KHOAN.MANV) as NV
--where NGUOIDUNG_NHOM_ND.MaNhomNguoiDung = @maNhom
--group by NV.MANV, NV.TENNV
--order by NV.MANV
select MANV, TENNV, (case when TENDN = TenDangNhap then 1 else 0 end) as Thuoc from 
(select * from (select NHANVIEN.MANV, TENNV, TENDN from NHANVIEN, TAI_KHOAN where NHANVIEN.MANV = TAI_KHOAN.MANV) as a left join NGUOIDUNG_NHOM_ND
on a.TENDN = NGUOIDUNG_NHOM_ND.TenDangNhap and NGUOIDUNG_NHOM_ND.MaNhomNguoiDung = @maNhom) as b left join (select * from NHOM_NGUOI_DUNG) as c
on b.MaNhomNguoiDung = c.MaNhom
return
end

GO
/****** Object:  Table [dbo].[BANG_GIA]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANG_GIA](
	[MASP] [char](10) NOT NULL,
	[NGAYBD] [datetime] NOT NULL,
	[GIA_BAN] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIET_HD]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIET_HD](
	[MAHD] [nchar](10) NOT NULL,
	[MASP] [char](10) NOT NULL,
	[SL_MUA] [int] NOT NULL,
 CONSTRAINT [PK_CHITIET_HD] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANH_MUC_SP]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANH_MUC_SP](
	[MALOAI] [char](10) NOT NULL,
	[HIDDEN] [int] NULL CONSTRAINT [DF_DANH_MUC_SP_HIDDEN]  DEFAULT ((1)),
	[TENLOAI] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MASP] [char](10) NOT NULL,
	[MALOAI] [char](10) NULL,
	[SOLUONG] [int] NULL,
	[DVT] [nvarchar](20) NULL,
	[HIDDEN] [int] NULL CONSTRAINT [DF_HANGHOA_HIDDEN]  DEFAULT ((1)),
	[TENSP] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOA_DON]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOA_DON](
	[MAHD] [nchar](10) NOT NULL,
	[MAKH] [char](10) NOT NULL,
	[MANV] [char](10) NOT NULL,
	[NGAYLAP] [datetime] NOT NULL,
	[TONGTIEN] [float] NOT NULL,
	[GIAMGIA] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[MAKH] [char](10) NOT NULL,
	[TENKH] [nvarchar](50) NOT NULL,
	[DIACHI] [varchar](100) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[TICHLUY] [int] NULL CONSTRAINT [DF_KHACH_HANG_TICHLUY]  DEFAULT ((0)),
	[EMAIL] [nchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHUYEN_MAI]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHUYEN_MAI](
	[MASP] [char](10) NOT NULL,
	[NGAYBD_KM] [datetime] NOT NULL,
	[NGAYKT_KM] [datetime] NULL,
	[GIAMGIA] [float] NULL,
 CONSTRAINT [PK_KHUYEN_MAI_1] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC,
	[NGAYBD_KM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LO_HANG]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LO_HANG](
	[MALO] [char](10) NOT NULL,
	[MASP] [char](10) NOT NULL,
	[MAPN] [char](10) NOT NULL,
	[NGAYSX] [datetime] NULL,
	[HANSD] [datetime] NULL,
	[SOLUONGNHAP] [int] NULL,
	[SOLUONG_TRENQUAY] [int] NULL,
	[DONGIA_NHAP] [float] NULL,
 CONSTRAINT [PK_LO_HANG_1] PRIMARY KEY CLUSTERED 
(
	[MALO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MAN_HINH]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAN_HINH](
	[MaManHinh] [nvarchar](50) NOT NULL,
	[TenManHinh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DM_] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG_NHOM_ND]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG_NHOM_ND](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MaNhomNguoiDung] [varchar](20) NOT NULL,
 CONSTRAINT [PK_QL_NguoiDungNhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [char](10) NOT NULL,
	[TENNV] [nvarchar](50) NOT NULL,
	[CHUCVU] [varchar](50) NOT NULL,
	[PHAI_NV] [int] NOT NULL,
	[DIACHI_NV] [varchar](100) NOT NULL,
	[EMAIL] [nchar](20) NOT NULL,
	[NGAY_SINH] [datetime] NULL,
	[LUONG] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOM_NGUOI_DUNG]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOM_NGUOI_DUNG](
	[MaNhom] [varchar](20) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_QL_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHAN_QUYEN]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHAN_QUYEN](
	[MaNhomNguoiDung] [varchar](20) NOT NULL,
	[MaManHinh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QL_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [char](10) NOT NULL,
	[MADDH] [char](10) NULL,
	[NGAYLAP_PN] [datetime] NULL,
	[TONGTIEN_PN] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAI_KHOAN]    Script Date: 16/12/2019 10:01:16 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAI_KHOAN](
	[TENDN] [varchar](50) NOT NULL,
	[MANV] [char](10) NOT NULL,
	[MATKHAU] [char](20) NOT NULL,
	[HOATDONG] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP1       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), 20000)
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP2       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), 15000)
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP3       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), 10000)
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP4       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), 10000)
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP1       ', CAST(N'2018-12-01 00:00:00.000' AS DateTime), 25000)
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP2       ', CAST(N'2018-12-01 00:00:00.000' AS DateTime), 20000)
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP3       ', CAST(N'2018-12-01 00:00:00.000' AS DateTime), 15000)
INSERT [dbo].[BANG_GIA] ([MASP], [NGAYBD], [GIA_BAN]) VALUES (N'SP4       ', CAST(N'2018-12-01 00:00:00.000' AS DateTime), 15000)
INSERT [dbo].[CHITIET_HD] ([MAHD], [MASP], [SL_MUA]) VALUES (N'HD1       ', N'SP2       ', 1)
INSERT [dbo].[CHITIET_HD] ([MAHD], [MASP], [SL_MUA]) VALUES (N'HD1       ', N'SP3       ', 1)
INSERT [dbo].[CHITIET_HD] ([MAHD], [MASP], [SL_MUA]) VALUES (N'HD2       ', N'SP1       ', 2)
INSERT [dbo].[CHITIET_HD] ([MAHD], [MASP], [SL_MUA]) VALUES (N'HD2       ', N'SP2       ', 1)
INSERT [dbo].[DANH_MUC_SP] ([MALOAI], [HIDDEN], [TENLOAI]) VALUES (N'LOAI1     ', 1, N'Trái Cây')
INSERT [dbo].[DANH_MUC_SP] ([MALOAI], [HIDDEN], [TENLOAI]) VALUES (N'LOAI2     ', 1, N'Rau Củ')
INSERT [dbo].[HANGHOA] ([MASP], [MALOAI], [SOLUONG], [DVT], [HIDDEN], [TENSP]) VALUES (N'SP1       ', N'LOAI1     ', 98, N'Kg', 1, N'Táo')
INSERT [dbo].[HANGHOA] ([MASP], [MALOAI], [SOLUONG], [DVT], [HIDDEN], [TENSP]) VALUES (N'SP2       ', N'LOAI1     ', 48, N'Kg', 1, N'ỔI')
INSERT [dbo].[HANGHOA] ([MASP], [MALOAI], [SOLUONG], [DVT], [HIDDEN], [TENSP]) VALUES (N'SP3       ', N'LOAI2     ', 49, N'100g', 1, N'Nấm kim châm')
INSERT [dbo].[HANGHOA] ([MASP], [MALOAI], [SOLUONG], [DVT], [HIDDEN], [TENSP]) VALUES (N'SP4       ', N'LOAI2     ', 50, N'11000', 1, N'Rau mồng tơi')
INSERT [dbo].[HOA_DON] ([MAHD], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [GIAMGIA]) VALUES (N'HD1       ', N'KH1       ', N'NV1       ', CAST(N'2019-12-11 00:00:00.000' AS DateTime), 25000, 0)
INSERT [dbo].[HOA_DON] ([MAHD], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [GIAMGIA]) VALUES (N'HD2       ', N'KH1       ', N'NV1       ', CAST(N'2019-12-11 00:00:00.000' AS DateTime), 53000, 0)
INSERT [dbo].[KHACH_HANG] ([MAKH], [TENKH], [DIACHI], [SDT], [TICHLUY], [EMAIL]) VALUES (N'KH1       ', N'Khách vãng lai', N'0', N'0', 0, N'0                                                 ')
INSERT [dbo].[KHACH_HANG] ([MAKH], [TENKH], [DIACHI], [SDT], [TICHLUY], [EMAIL]) VALUES (N'KH2       ', N'Tôn Võ Thủy Tiên', N'TP.HCM', N'1826371236', 123, N'thuytien@gmail.com                                ')
INSERT [dbo].[KHACH_HANG] ([MAKH], [TENKH], [DIACHI], [SDT], [TICHLUY], [EMAIL]) VALUES (N'KH3       ', N'Đại', N'HCM', N'0732467', 0, N'@mail                                             ')
INSERT [dbo].[KHACH_HANG] ([MAKH], [TENKH], [DIACHI], [SDT], [TICHLUY], [EMAIL]) VALUES (N'KH4       ', N'Hiếu Nhỏ', N'? Tr?n', N'023748', 0, N'@mail                                             ')
INSERT [dbo].[KHACH_HANG] ([MAKH], [TENKH], [DIACHI], [SDT], [TICHLUY], [EMAIL]) VALUES (N'KH5       ', N'Công', N'12aas', N'011123', 0, N't@gmail.com                                       ')
INSERT [dbo].[KHUYEN_MAI] ([MASP], [NGAYBD_KM], [NGAYKT_KM], [GIAMGIA]) VALUES (N'SP1       ', CAST(N'2019-01-02 00:00:00.000' AS DateTime), CAST(N'2020-01-01 00:00:00.000' AS DateTime), 5)
INSERT [dbo].[KHUYEN_MAI] ([MASP], [NGAYBD_KM], [NGAYKT_KM], [GIAMGIA]) VALUES (N'SP2       ', CAST(N'2019-01-02 00:00:00.000' AS DateTime), CAST(N'2019-05-01 00:00:00.000' AS DateTime), 3)
INSERT [dbo].[LO_HANG] ([MALO], [MASP], [MAPN], [NGAYSX], [HANSD], [SOLUONGNHAP], [SOLUONG_TRENQUAY], [DONGIA_NHAP]) VALUES (N'LO1       ', N'SP1       ', N'PN1       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), CAST(N'2019-01-15 00:00:00.000' AS DateTime), 100, 100, 15000)
INSERT [dbo].[LO_HANG] ([MALO], [MASP], [MAPN], [NGAYSX], [HANSD], [SOLUONGNHAP], [SOLUONG_TRENQUAY], [DONGIA_NHAP]) VALUES (N'LO2       ', N'SP2       ', N'PN1       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), CAST(N'2019-01-12 00:00:00.000' AS DateTime), 100, 50, 12000)
INSERT [dbo].[LO_HANG] ([MALO], [MASP], [MAPN], [NGAYSX], [HANSD], [SOLUONGNHAP], [SOLUONG_TRENQUAY], [DONGIA_NHAP]) VALUES (N'LO4       ', N'SP4       ', N'PN1       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), CAST(N'2019-01-10 00:00:00.000' AS DateTime), 100, 50, 7000)
INSERT [dbo].[LO_HANG] ([MALO], [MASP], [MAPN], [NGAYSX], [HANSD], [SOLUONGNHAP], [SOLUONG_TRENQUAY], [DONGIA_NHAP]) VALUES (N'LO5       ', N'SP3       ', N'PN1       ', CAST(N'2019-01-01 00:00:00.000' AS DateTime), CAST(N'2019-01-10 00:00:00.000' AS DateTime), 100, 50, 5000)
INSERT [dbo].[MAN_HINH] ([MaManHinh], [TenManHinh]) VALUES (N'frmBH', N'Form bán hàng')
INSERT [dbo].[MAN_HINH] ([MaManHinh], [TenManHinh]) VALUES (N'frmDM_KH', N'Form danh mục khách hàng')
INSERT [dbo].[MAN_HINH] ([MaManHinh], [TenManHinh]) VALUES (N'frmDM_MH', N'Form danh mục mặt hàng')
INSERT [dbo].[MAN_HINH] ([MaManHinh], [TenManHinh]) VALUES (N'frmDM_NV', N'Form danh mục nhân viên')
INSERT [dbo].[MAN_HINH] ([MaManHinh], [TenManHinh]) VALUES (N'frmHD', N'Form thống kê thu nhập')
INSERT [dbo].[NGUOIDUNG_NHOM_ND] ([TenDangNhap], [MaNhomNguoiDung]) VALUES (N'1', N'N1')
INSERT [dbo].[NGUOIDUNG_NHOM_ND] ([TenDangNhap], [MaNhomNguoiDung]) VALUES (N'1', N'N2')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [CHUCVU], [PHAI_NV], [DIACHI_NV], [EMAIL], [NGAY_SINH], [LUONG]) VALUES (N'NV1       ', N'Kiều Hữu Thành', N'ban hang', 0, N'tphcm', N'email@              ', CAST(N'1998-01-01 00:00:00.000' AS DateTime), 6000000)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [CHUCVU], [PHAI_NV], [DIACHI_NV], [EMAIL], [NGAY_SINH], [LUONG]) VALUES (N'NV2       ', N'nguyen van be             ', N'nhap kho         ', 1, N'ha noi     ', N'email@              ', CAST(N'1998-01-02 00:00:00.000' AS DateTime), 6000000)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [CHUCVU], [PHAI_NV], [DIACHI_NV], [EMAIL], [NGAY_SINH], [LUONG]) VALUES (N'NV3       ', N'nguyen van c', N'ke toan', 1, N'da nang', N'email@              ', CAST(N'1998-01-01 00:00:00.000' AS DateTime), 6000000)
INSERT [dbo].[NHOM_NGUOI_DUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'N1', N'Bán hàng', N'Bán hàng')
INSERT [dbo].[NHOM_NGUOI_DUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'N2', N'Kho hàng', N'Quản lý kho hàng')
INSERT [dbo].[NHOM_NGUOI_DUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'N3', N'Thống kê', N'Thống kê')
INSERT [dbo].[PHAN_QUYEN] ([MaNhomNguoiDung], [MaManHinh]) VALUES (N'N1', N'frmBH')
INSERT [dbo].[PHAN_QUYEN] ([MaNhomNguoiDung], [MaManHinh]) VALUES (N'N1', N'frmHD')
INSERT [dbo].[PHAN_QUYEN] ([MaNhomNguoiDung], [MaManHinh]) VALUES (N'N2', N'frmBH')
INSERT [dbo].[PHAN_QUYEN] ([MaNhomNguoiDung], [MaManHinh]) VALUES (N'N2', N'frmDM_MH')
INSERT [dbo].[PHAN_QUYEN] ([MaNhomNguoiDung], [MaManHinh]) VALUES (N'N3', N'frmHD')
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MADDH], [NGAYLAP_PN], [TONGTIEN_PN]) VALUES (N'PN1       ', N'DHH1      ', CAST(N'2019-01-02 00:00:00.000' AS DateTime), 3900000)
INSERT [dbo].[TAI_KHOAN] ([TENDN], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'1                   ', N'NV1       ', N'1                   ', 1)
INSERT [dbo].[TAI_KHOAN] ([TENDN], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'2                   ', N'NV2       ', N'2                   ', 1)
INSERT [dbo].[TAI_KHOAN] ([TENDN], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'3                   ', N'NV3       ', N'3                   ', 1)
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_BANG_GIA]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[BANG_GIA] ADD  CONSTRAINT [PK_BANG_GIA] PRIMARY KEY NONCLUSTERED 
(
	[MASP] ASC,
	[NGAYBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_DANH_MUC_SP]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[DANH_MUC_SP] ADD  CONSTRAINT [PK_DANH_MUC_SP] PRIMARY KEY NONCLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_HANGHOA]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[HANGHOA] ADD  CONSTRAINT [PK_HANGHOA] PRIMARY KEY NONCLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_HOA_DON]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[HOA_DON] ADD  CONSTRAINT [PK_HOA_DON] PRIMARY KEY NONCLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_KHACH_HANG]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[KHACH_HANG] ADD  CONSTRAINT [PK_KHACH_HANG] PRIMARY KEY NONCLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_NHANVIEN]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [PK_NHANVIEN] PRIMARY KEY NONCLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_PHIEUNHAP]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[PHIEUNHAP] ADD  CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY NONCLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_TAI_KHOAN]    Script Date: 16/12/2019 10:01:16 SA ******/
ALTER TABLE [dbo].[TAI_KHOAN] ADD  CONSTRAINT [PK_TAI_KHOAN] PRIMARY KEY NONCLUSTERED 
(
	[TENDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BANG_GIA]  WITH CHECK ADD  CONSTRAINT [FK_BANG_GIA_RELATIONS_HANGHOA] FOREIGN KEY([MASP])
REFERENCES [dbo].[HANGHOA] ([MASP])
GO
ALTER TABLE [dbo].[BANG_GIA] CHECK CONSTRAINT [FK_BANG_GIA_RELATIONS_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HD_HANGHOA] FOREIGN KEY([MASP])
REFERENCES [dbo].[HANGHOA] ([MASP])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_CHITIET_HD_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HD_HOA_DON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOA_DON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_CHITIET_HD_HOA_DON]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_DANH_MUC_SP] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[DANH_MUC_SP] ([MALOAI])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_DANH_MUC_SP]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_KHACH_HANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACH_HANG] ([MAKH])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_KHACH_HANG]
GO
ALTER TABLE [dbo].[HOA_DON]  WITH CHECK ADD  CONSTRAINT [FK_HOA_DON_RELATIONS_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOA_DON] CHECK CONSTRAINT [FK_HOA_DON_RELATIONS_NHANVIEN]
GO
ALTER TABLE [dbo].[KHUYEN_MAI]  WITH CHECK ADD  CONSTRAINT [FK_KHUYEN_MAI_HANGHOA] FOREIGN KEY([MASP])
REFERENCES [dbo].[HANGHOA] ([MASP])
GO
ALTER TABLE [dbo].[KHUYEN_MAI] CHECK CONSTRAINT [FK_KHUYEN_MAI_HANGHOA]
GO
ALTER TABLE [dbo].[LO_HANG]  WITH CHECK ADD  CONSTRAINT [FK_LO_HANG_HANGHOA] FOREIGN KEY([MASP])
REFERENCES [dbo].[HANGHOA] ([MASP])
GO
ALTER TABLE [dbo].[LO_HANG] CHECK CONSTRAINT [FK_LO_HANG_HANGHOA]
GO
ALTER TABLE [dbo].[LO_HANG]  WITH CHECK ADD  CONSTRAINT [FK_LO_HANG_RELATIONS_PHIEUNHA] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
GO
ALTER TABLE [dbo].[LO_HANG] CHECK CONSTRAINT [FK_LO_HANG_RELATIONS_PHIEUNHA]
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOM_ND]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_NHOM_ND_NHOM_NGUOI_DUNG] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[NHOM_NGUOI_DUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOM_ND] CHECK CONSTRAINT [FK_NGUOIDUNG_NHOM_ND_NHOM_NGUOI_DUNG]
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOM_ND]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_NHOM_ND_TAI_KHOAN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAI_KHOAN] ([TENDN])
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOM_ND] CHECK CONSTRAINT [FK_NGUOIDUNG_NHOM_ND_TAI_KHOAN]
GO
ALTER TABLE [dbo].[PHAN_QUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHAN_QUYEN_MAN_HINH] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[MAN_HINH] ([MaManHinh])
GO
ALTER TABLE [dbo].[PHAN_QUYEN] CHECK CONSTRAINT [FK_PHAN_QUYEN_MAN_HINH]
GO
ALTER TABLE [dbo].[PHAN_QUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHAN_QUYEN_NHOM_NGUOI_DUNG] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[NHOM_NGUOI_DUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[PHAN_QUYEN] CHECK CONSTRAINT [FK_PHAN_QUYEN_NHOM_NGUOI_DUNG]
GO
ALTER TABLE [dbo].[TAI_KHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAI_KHOA_RELATIONS_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[TAI_KHOAN] CHECK CONSTRAINT [FK_TAI_KHOA_RELATIONS_NHANVIEN]
GO
