USE [uxebfmif_coffeeshop]
GO
/****** Object:  Table [dbo].[account]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](100) NULL,
	[displayname] [nvarchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[type] [int] NOT NULL,
	[typename] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bill]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[checkin] [date] NOT NULL,
	[checkout] [date] NULL,
	[idtable] [int] NOT NULL,
	[discount] [int] NULL,
	[totalprice] [float] NULL,
	[status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[billinfo]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[billinfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idbill] [int] NOT NULL,
	[iddrink] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cftable]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cftable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[drink]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[drink](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idcategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 

INSERT [dbo].[account] ([id], [username], [displayname], [password], [type], [typename]) VALUES (1, N'admin', N'Admin', N'$2a$12$WVFbFGFUFC7yGGVSV7LmXOafig1X9w6og3zhCNVGMc/VOzN9HGQzW', 1, N'admin')
INSERT [dbo].[account] ([id], [username], [displayname], [password], [type], [typename]) VALUES (2, N'staff', N'Staff', N'$2a$12$SbrjIokYyNezAinLLpqmeOaPanJpHVmNuq6lh8hcq098w4j8KB/G2', 0, N'staff')
SET IDENTITY_INSERT [dbo].[account] OFF
SET IDENTITY_INSERT [dbo].[bill] ON 

INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (1, CAST(N'2019-05-16' AS Date), CAST(N'2019-05-16' AS Date), 1, 10, 25200, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (2, CAST(N'2019-05-16' AS Date), CAST(N'2019-05-16' AS Date), 5, 20, 79000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (3, CAST(N'2019-05-16' AS Date), CAST(N'2019-05-16' AS Date), 4, 20, 31200, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (4, CAST(N'2019-05-16' AS Date), CAST(N'2019-05-27' AS Date), 4, 0, 28000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (5, CAST(N'2019-05-16' AS Date), CAST(N'2019-05-17' AS Date), 1, 0, 28000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (6, CAST(N'2019-05-16' AS Date), CAST(N'2019-05-16' AS Date), 7, 15, 23800, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (7, CAST(N'2019-05-17' AS Date), CAST(N'2019-05-17' AS Date), 1, 0, 40000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (8, CAST(N'2019-05-17' AS Date), CAST(N'2019-05-17' AS Date), 9, 10, 43200, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (9, CAST(N'2019-05-17' AS Date), CAST(N'2019-05-17' AS Date), 7, 0, 13000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (10, CAST(N'2019-05-18' AS Date), CAST(N'2019-05-18' AS Date), 1, 10, 25200, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (11, CAST(N'2019-05-18' AS Date), CAST(N'2019-05-20' AS Date), 1, 5, 12350, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (12, CAST(N'2019-05-18' AS Date), CAST(N'2019-05-18' AS Date), 5, 0, 13000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (15, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 2, 5, 43000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (16, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 1, 0, 15000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (17, CAST(N'2019-05-20' AS Date), NULL, 2, 0, 0, 0)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (18, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 5, 0, 15000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (19, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 6, 100, 0, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (20, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 9, 0, 25000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (21, CAST(N'2019-05-20' AS Date), NULL, 5, 0, 0, 0)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (22, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 6, 0, 15000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (23, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 8, 0, 0, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (24, CAST(N'2019-05-20' AS Date), NULL, 6, 0, 0, 0)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (25, CAST(N'2019-05-20' AS Date), NULL, 8, 0, 0, 0)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (26, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-28' AS Date), 1, 50, 14000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (27, CAST(N'2019-05-20' AS Date), CAST(N'2019-05-20' AS Date), 9, 0, 52000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (28, CAST(N'2019-05-28' AS Date), CAST(N'2019-05-28' AS Date), 1, 50, 26000, 1)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (29, CAST(N'2019-05-28' AS Date), NULL, 3, 0, 0, 0)
INSERT [dbo].[bill] ([id], [checkin], [checkout], [idtable], [discount], [totalprice], [status]) VALUES (30, CAST(N'2019-05-28' AS Date), CAST(N'2019-05-28' AS Date), 1, 50, 13000, 1)
SET IDENTITY_INSERT [dbo].[bill] OFF
SET IDENTITY_INSERT [dbo].[billinfo] ON 

INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (1, 1, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (2, 1, 2, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (3, 2, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (4, 2, 4, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (5, 2, 5, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (8, 3, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (10, 6, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (11, 6, 2, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (12, 5, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (13, 5, 2, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (14, 7, 2, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (15, 7, 4, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (16, 8, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (17, 8, 3, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (18, 8, 9, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (19, 9, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (20, 10, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (21, 10, 2, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (22, 11, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (23, 12, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (30, 15, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (31, 15, 2, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (33, 4, 2, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (35, 20, 9, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (36, 19, 9, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (37, 20, 11, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (38, 27, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (39, 4, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (40, 26, 15, 1)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (42, 26, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (43, 28, 1, 2)
INSERT [dbo].[billinfo] ([id], [idbill], [iddrink], [count]) VALUES (44, 30, 1, 1)
SET IDENTITY_INSERT [dbo].[billinfo] OFF
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [name]) VALUES (1, N'Coffee')
INSERT [dbo].[category] ([id], [name]) VALUES (2, N'Fruit Juice')
INSERT [dbo].[category] ([id], [name]) VALUES (3, N'Soft Drink')
INSERT [dbo].[category] ([id], [name]) VALUES (4, N'Dessert')
SET IDENTITY_INSERT [dbo].[category] OFF
SET IDENTITY_INSERT [dbo].[cftable] ON 

INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (1, N'Table 1', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (2, N'Table 2', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (3, N'Table 3', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (4, N'Table 4', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (5, N'Table 5', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (6, N'Table 6', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (7, N'Table 7', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (8, N'Table 8', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (9, N'Table 9', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (10, N'Table 10', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (11, N'Table 11', N'Empty')
INSERT [dbo].[cftable] ([id], [name], [status]) VALUES (12, N'Table 12', N'Empty')
SET IDENTITY_INSERT [dbo].[cftable] OFF
SET IDENTITY_INSERT [dbo].[drink] ON 

INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (1, N'Black Coffee', 1, 13000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (2, N'Milk Coffee', 1, 15000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (3, N'Cappuccino', 1, 25000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (4, N'Latte', 1, 25000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (5, N'Lemon', 2, 15000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (6, N'Orange', 2, 20000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (7, N'Strawberry', 2, 20000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (8, N'Coconut', 2, 20000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (9, N'Aquafina', 3, 10000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (10, N'Coca Cola', 3, 15000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (11, N'Pepsi', 3, 15000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (12, N'Americano', 1, 15000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (15, N'Twister', 3, 15000)
INSERT [dbo].[drink] ([id], [name], [idcategory], [price]) VALUES (16, N'Red Bull', 3, 20000)
SET IDENTITY_INSERT [dbo].[drink] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__account__F3DBC572C671A792]    Script Date: 6/10/2019 8:08:47 PM ******/
ALTER TABLE [dbo].[account] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT ((0)) FOR [type]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (N'staff') FOR [typename]
GO
ALTER TABLE [dbo].[bill] ADD  DEFAULT (getdate()) FOR [checkin]
GO
ALTER TABLE [dbo].[bill] ADD  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[bill] ADD  DEFAULT ((0)) FOR [totalprice]
GO
ALTER TABLE [dbo].[bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[billinfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[cftable] ADD  DEFAULT (N'Empty') FOR [status]
GO
ALTER TABLE [dbo].[drink] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[bill]  WITH CHECK ADD FOREIGN KEY([idtable])
REFERENCES [dbo].[cftable] ([id])
GO
ALTER TABLE [dbo].[billinfo]  WITH CHECK ADD FOREIGN KEY([idbill])
REFERENCES [dbo].[bill] ([id])
GO
ALTER TABLE [dbo].[billinfo]  WITH CHECK ADD FOREIGN KEY([iddrink])
REFERENCES [dbo].[drink] ([id])
GO
ALTER TABLE [dbo].[drink]  WITH CHECK ADD FOREIGN KEY([idcategory])
REFERENCES [dbo].[category] ([id])
GO
ALTER TABLE [dbo].[account]  WITH CHECK ADD CHECK  (([type]=(1) OR [type]=(0)))
GO
/****** Object:  StoredProcedure [dbo].[usp_getaccount]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_getaccount]
@username nvarchar(100)
as
begin
	select * from dbo.account where username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[usp_getbilllistbydate]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_getbilllistbydate]
@checkin date, @checkout date
as
begin
	select t.name as [Table Name], checkin as [Checkin], checkout [Checkout], discount as [Discount], totalprice as [Total Price]
	from dbo.bill as b, dbo.cftable as t
	where checkin >= @checkin and checkout <= @checkout and b.status = 1 and t.id = b.idtable
end
GO
/****** Object:  StoredProcedure [dbo].[usp_gettablelist]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_gettablelist]
as select * from dbo.cftable
GO
/****** Object:  StoredProcedure [dbo].[usp_insertbill]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_insertbill]
@idtable int
as
begin
	insert dbo.bill (checkin, checkout, idtable, status, discount) values (getdate(), null, @idtable, 0, 0)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_insertbillinfo]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_insertbillinfo]
@idbill int, @iddrink int, @count int
as
begin
	declare @isexitedbillinfo int
	declare @drinkcount int = 1
	select @isexitedbillinfo = id, @drinkcount = b.count from dbo.billinfo as b
	where idbill = @idbill and iddrink = @iddrink
	if (@isexitedbillinfo > 0) 
		begin
			declare @newcount int = @drinkcount + @count
			if (@newcount > 0) update dbo.billinfo set count = @drinkcount + @count where iddrink = @iddrink
			else delete dbo.billinfo where idbill = @idbill and iddrink = @iddrink
		end
	else
		begin
			if (@count > 0) insert dbo.billinfo (idbill, iddrink, count) values (@idbill, @iddrink, @count)
		end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_login]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_login]
@username nvarchar(100), @password nvarchar(1000)
as
begin
	select * from dbo.account where username = @username and password = @password
end
GO
/****** Object:  StoredProcedure [dbo].[usp_switchtable]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_switchtable]
@idtable1 int, @idtable2 int
as
begin
	declare @idfirstbill int
	declare @idsecondbill int
	select @idsecondbill = id from dbo.bill where idtable = @idtable2 and status = 0
	select @idfirstbill = id from dbo.bill where idtable = @idtable1 and status = 0
	declare @isfirsttableempty int = 1
	declare @issecondtableempty int = 1
	if (@idfirstbill is null) 
	begin
		insert dbo.bill (checkin, checkout, idtable, status) values (getdate(), null, @idtable1, 0)
		select @idfirstbill = max(id) from dbo.bill where idtable = @idtable1 and status = 0
	end
	select @isfirsttableempty = count(*) from dbo.billinfo where idbill = @idfirstbill
	if (@idsecondbill is null) 
	begin
		insert dbo.bill (checkin, checkout, idtable, status) values (getdate(), null, @idtable2, 0)
		select @idsecondbill = max(id) from dbo.bill where idtable = @idtable2 and status = 0
	end
	select @issecondtableempty = count(*) from dbo.billinfo where idbill = @idsecondbill
	select id into idbillinfotable from dbo.billinfo where idbill = @idsecondbill
	update dbo.billinfo set idbill = @idsecondbill where idbill = @idfirstbill
	update dbo.billinfo set idbill = @idfirstbill where id in (select * from idbillinfotable)
	drop table idbillinfotable
	if (@isfirsttableempty = 0) update dbo.cftable set status = N'Empty' where id = @idtable2
	if (@issecondtableempty = 0) update dbo.cftable set status = N'Empty' where id = @idtable1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_updateaccount]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_updateaccount]
@username nvarchar(100), @password nvarchar(100), @newpassword nvarchar(100)
as
begin
	declare @isrightpassword int
	select @isrightpassword = count(*) from dbo.account where username = @username and password = @password
	if (@isrightpassword >= 1)
	begin
		if (@newpassword <> null or @newpassword <> '')
		begin
			update dbo.account set password = @newpassword where username = @username
			select * from dbo.account where username = @username and password = @password
		end
	end
end
GO
/****** Object:  Trigger [dbo].[utg_updatebill]    Script Date: 6/10/2019 8:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[utg_updatebill]
on [dbo].[bill] for update
as
begin
	declare @idbill int
	select @idbill = id from inserted
	declare @idtable int
	select @idtable = idtable from dbo.bill where id = @idbill
	declare @count int = 0
	select @count = count(*) from dbo.bill where idtable = @idtable and status = 0
	if (@count = 0) update dbo.cftable set status = N'Empty' where id = @idtable
end
GO
ALTER TABLE [dbo].[bill] ENABLE TRIGGER [utg_updatebill]
GO
/****** Object:  Trigger [dbo].[utg_deletebillinfo]    Script Date: 6/10/2019 8:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[utg_deletebillinfo]
on [dbo].[billinfo] for delete
as
begin
	declare @idbillinfo int
	declare @idbill int
	select @idbillinfo = id, @idbill = deleted.idbill from deleted
	declare @idtable int
	select @idtable = idtable from dbo.bill where id = @idbill
	declare @count int = 0
	select @count = count(*) from dbo.billinfo as bi, dbo.bill as b
	where b.id = bi.idbill and b.id = @idbill and status = 0
	if (@count = 0) update dbo.cftable set status = N'Empty' where id = @idtable
end
GO
ALTER TABLE [dbo].[billinfo] ENABLE TRIGGER [utg_deletebillinfo]
GO
/****** Object:  Trigger [dbo].[utg_updatebillinfo]    Script Date: 6/10/2019 8:08:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[utg_updatebillinfo]
on [dbo].[billinfo] for insert, update
as
begin
	declare @idbill int
	select @idbill = idbill from inserted
	declare @idtable int
	select @idtable = idtable from dbo.bill where id = @idbill and status = 0
	update dbo.cftable set status = N'Guest' where id = @idtable
end
GO
ALTER TABLE [dbo].[billinfo] ENABLE TRIGGER [utg_updatebillinfo]
GO
