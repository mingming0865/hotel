--CREATE DATABASE QLTP
--GO
--USE [QLTP]
--GO
/****** Object:  Table [dbo].[Phong]    Script Date: 11/06/2016 21:31:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaP] [nvarchar](5) NOT NULL,
	[TenP] [nvarchar](255) NOT NULL,
	[LoaiP] [nvarchar](25) NOT NULL,
	[GiaP] [int] NOT NULL,
	[Tinhtrang] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T101', N'PT101', N'Đơn thường', 300000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T102', N'PT102', N'Đơn thường', 300000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T103', N'PT103', N'Đơn thường', 300000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T104', N'PT104', N'Đơn thường', 300000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T201', N'PT201', N'Đôi thường', 400000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T202', N'PT202', N'Đôi thường', 400000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T203', N'PT203', N'Đôi thường', 400000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T204', N'PT204', N'Đôi thường', 400000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T301', N'PT301', N'Ba thường', 500000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T302', N'PT302', N'Ba thường', 500000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T303', N'PT303', N'Ba thường', 500000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T304', N'PT304', N'Ba thường', 500000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V101', N'PV101', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V102', N'PV102', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V103', N'PV103', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V104', N'PV104', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V201', N'PV201', N'VIP đôi', 800000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V202', N'PV202', N'VIP đôi', 800000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V203', N'PV203', N'VIP đôi', 800000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V204', N'PV204', N'VIP đôi', 800000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V301', N'PV301', N'VIP ba', 1000000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V302', N'PV302', N'VIP ba', 1000000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V303', N'PV303', N'VIP ba', 1000000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V304', N'PV304', N'VIP ba', 1000000, N'Trống')
/****** Object:  Table [dbo].[Khach]    Script Date: 11/06/2016 21:31:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach](
	[CMT] [nvarchar](12) NOT NULL,
	[Hoten] [nvarchar](255) NOT NULL,
	[Diachi] [nvarchar](255) NOT NULL,
	[GT] [nvarchar](5) NOT NULL,
	[SDT] [nvarchar](15) NULL,
 CONSTRAINT [PK_Khach] PRIMARY KEY CLUSTERED 
(
	[CMT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'012434832', N'Cao Thị Linh', N'18 Thanh Bình', N'Nữ', N'0984234567')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'123253454', N'Vũ Tuấn Anh', N'Bà Triệu', N'Nam', N'01235243234')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'123383294', N'Nguyễn Thị Mai', N'Lộc Hạ', N'Nữ', N'0987654356')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'145573262', N'Phạm Vân Anh', N'Nguyễn Du', N'Nữ', N'0956243242')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'152015415', N'Hoàng Đức Hưng', N'Lộc Hạ', N'Nam', N'0963243462')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'190023198', N'Phạm Anh Khoa', N'Hạ Long', N'Nam', N'0955734823')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'234453134', N'Đào Đức Đủ', N'Bà Triệu', N'Nam', N'0942963929')
/****** Object:  Table [dbo].[Dichvu]    Script Date: 11/06/2016 21:31:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dichvu](
	[MaDV] [nvarchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NOT NULL,
	[GiaDV] [float] NOT NULL,
	[DVT] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Dichvu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Dichvu] ([MaDV], [TenDV], [GiaDV], [DVT]) VALUES (N'DV001', N'Bia Hà Nội 330ml', 15000, N'lon')
INSERT [dbo].[Dichvu] ([MaDV], [TenDV], [GiaDV], [DVT]) VALUES (N'DV002', N'Bia Heniken 330ml', 20000, N'lon')
INSERT [dbo].[Dichvu] ([MaDV], [TenDV], [GiaDV], [DVT]) VALUES (N'DV003', N'Bia Halida 330ml', 15000, N'lon')
INSERT [dbo].[Dichvu] ([MaDV], [TenDV], [GiaDV], [DVT]) VALUES (N'DV004', N'Rượu Vodka 330ml', 100000, N'chai')
INSERT [dbo].[Dichvu] ([MaDV], [TenDV], [GiaDV], [DVT]) VALUES (N'DV005', N'Hoa quả tươi', 100000, N'đĩa')
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 11/06/2016 21:31:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[Acc] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[TenND] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[Acc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'admin', N'12345', N'Quản trị viên')
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'user1', N'hoanghung', N'Hoàng Hưng')
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'user2', N'caolinh95', N'Cao Thị Linh')
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'user4', N'nganngo95', N'Dương Thị Ngân')
/****** Object:  Table [dbo].[ThueP]    Script Date: 11/06/2016 21:31:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThueP](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[CMT] [nvarchar](12) NOT NULL,
	[MaP] [nvarchar](5) NOT NULL,
	[Ngayden] [date] NOT NULL,
	[Ngaydi] [date] NULL,
	[TenNV] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_ThueP_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ThueP] ON
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (1, N'012434832', N'T101', CAST(0x073C0B00 AS Date), CAST(0x103C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (2, N'012434832', N'T103', CAST(0x083C0B00 AS Date), CAST(0x103C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (3, N'012434832', N'V102', CAST(0x083C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (4, N'123383294', N'V101', CAST(0x083C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (5, N'145573262', N'T102', CAST(0x073C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (6, N'145573262', N'T202', CAST(0x073C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (7, N'012434832', N'V301', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (8, N'012434832', N'T101', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (9, N'012434832', N'T101', CAST(0x093C0B00 AS Date), CAST(0x113C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (10, N'012434832', N'T102', CAST(0x093C0B00 AS Date), NULL, N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (11, N'123383294', N'T103', CAST(0x093C0B00 AS Date), NULL, N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (12, N'123383294', N'T201', CAST(0x093C0B00 AS Date), NULL, N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (13, N'145573262', N'T104', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (14, N'145573262', N'T204', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (15, N'145573262', N'T302', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (16, N'152015415', N'V201', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (17, N'152015415', N'V202', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (18, N'152015415', N'V203', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (19, N'152015415', N'V204', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (20, N'012434832', N'T202', CAST(0x093C0B00 AS Date), CAST(0x113C0B00 AS Date), N'Hưng')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (21, N'012434832', N'T203', CAST(0x093C0B00 AS Date), NULL, N'Hưng')
INSERT [dbo].[ThueP] ([MaHD], [CMT], [MaP], [Ngayden], [Ngaydi], [TenNV]) VALUES (22, N'012434832', N'T204', CAST(0x093C0B00 AS Date), NULL, N'Hưng')
SET IDENTITY_INSERT [dbo].[ThueP] OFF
/****** Object:  Table [dbo].[SDDV]    Script Date: 11/06/2016 21:31:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SDDV](
	[MaHDDV] [int] IDENTITY(1,1) NOT NULL,
	[CMT] [nvarchar](12) NOT NULL,
	[MaDV] [nvarchar](10) NOT NULL,
	[Soluong] [int] NOT NULL,
	[NgaySD] [date] NOT NULL,
	[MaP] [nvarchar](5) NULL,
 CONSTRAINT [PK_SDDV_1] PRIMARY KEY CLUSTERED 
(
	[MaHDDV] ASC,
	[CMT] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SDDV] ON
INSERT [dbo].[SDDV] ([MaHDDV], [CMT], [MaDV], [Soluong], [NgaySD], [MaP]) VALUES (1, N'012434832', N'DV001', 10, CAST(0x0F3C0B00 AS Date), N'T101')
INSERT [dbo].[SDDV] ([MaHDDV], [CMT], [MaDV], [Soluong], [NgaySD], [MaP]) VALUES (2, N'012434832', N'DV002', 10, CAST(0x0F3C0B00 AS Date), N'T102')
INSERT [dbo].[SDDV] ([MaHDDV], [CMT], [MaDV], [Soluong], [NgaySD], [MaP]) VALUES (3, N'012434832', N'DV001', 10, CAST(0x0F3C0B00 AS Date), N'T102')
INSERT [dbo].[SDDV] ([MaHDDV], [CMT], [MaDV], [Soluong], [NgaySD], [MaP]) VALUES (5, N'012434832', N'DV003', 10, CAST(0x0F3C0B00 AS Date), N'T101')
SET IDENTITY_INSERT [dbo].[SDDV] OFF
/****** Object:  StoredProcedure [dbo].[Hoadonthuephong]    Script Date: 11/06/2016 21:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Hoadonthuephong]
	@cmt nvarchar(20)
AS
BEGIN
	SELECT Khach.Hoten,ThueP.CMT,TenP,Ngayden,Ngaydi,Phong.GiaP
    FROM   Khach INNER JOIN ThueP ON Khach.CMT = ThueP.CMT INNER JOIN
           Phong ON ThueP.MaP = Phong.MaP
    GROUP BY Khach.Hoten, Phong.TenP, ThueP.Ngayden, ThueP.Ngaydi, ThueP.TenNV, ThueP.CMT, Phong.GiaP
    HAVING      (Day(ThueP.Ngaydi) = DAY(GETDATE())) AND (ThueP.CMT = @cmt) and (month(ThueP.Ngaydi) = month(GETDATE()))
				and (YEAR(ThueP.Ngaydi) = YEAR(Getdate()))
END
GO
/****** Object:  StoredProcedure [dbo].[Hoadondichvu]    Script Date: 11/06/2016 21:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Hoadondichvu] 
@cmt nvarchar(20),
@ngayden date,
@map nvarchar(20)
AS
BEGIN
	SELECT  Khach.Hoten, Khach.CMT, Dichvu.TenDV, GiaDV,SDDV.Soluong,NgaySD,SDDV.MaP, Soluong * GiaDV as Thanhtien
    FROM    Dichvu INNER JOIN SDDV ON Dichvu.MaDV = SDDV.MaDV inner join Khach on Khach.CMT = SDDV.CMT
    Where      (SDDV.NgaySD <=(GETDATE()) AND (SDDV.CMT = @cmt)) and (SDDV.NgaySD >= @ngayden) and (SDDV.MaP = @map)
END
GO
/****** Object:  ForeignKey [FK_SDDV_Dichvu]    Script Date: 11/06/2016 21:31:21 ******/
ALTER TABLE [dbo].[SDDV]  WITH CHECK ADD  CONSTRAINT [FK_SDDV_Dichvu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[Dichvu] ([MaDV])
GO
ALTER TABLE [dbo].[SDDV] CHECK CONSTRAINT [FK_SDDV_Dichvu]
GO
/****** Object:  ForeignKey [FK_SDDV_Khach]    Script Date: 11/06/2016 21:31:21 ******/
ALTER TABLE [dbo].[SDDV]  WITH CHECK ADD  CONSTRAINT [FK_SDDV_Khach] FOREIGN KEY([CMT])
REFERENCES [dbo].[Khach] ([CMT])
GO
ALTER TABLE [dbo].[SDDV] CHECK CONSTRAINT [FK_SDDV_Khach]
GO
/****** Object:  ForeignKey [FK_SDDV_Phong]    Script Date: 11/06/2016 21:31:21 ******/
ALTER TABLE [dbo].[SDDV]  WITH CHECK ADD  CONSTRAINT [FK_SDDV_Phong] FOREIGN KEY([MaP])
REFERENCES [dbo].[Phong] ([MaP])
GO
ALTER TABLE [dbo].[SDDV] CHECK CONSTRAINT [FK_SDDV_Phong]
GO
/****** Object:  ForeignKey [FK_ThueP_Khach]    Script Date: 11/06/2016 21:31:21 ******/
ALTER TABLE [dbo].[ThueP]  WITH CHECK ADD  CONSTRAINT [FK_ThueP_Khach] FOREIGN KEY([CMT])
REFERENCES [dbo].[Khach] ([CMT])
GO
ALTER TABLE [dbo].[ThueP] CHECK CONSTRAINT [FK_ThueP_Khach]
GO
/****** Object:  ForeignKey [FK_ThueP_Phong1]    Script Date: 11/06/2016 21:31:21 ******/
ALTER TABLE [dbo].[ThueP]  WITH CHECK ADD  CONSTRAINT [FK_ThueP_Phong1] FOREIGN KEY([MaP])
REFERENCES [dbo].[Phong] ([MaP])
GO
ALTER TABLE [dbo].[ThueP] CHECK CONSTRAINT [FK_ThueP_Phong1]
GO
