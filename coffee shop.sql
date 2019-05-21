use master
drop database coffeeshop
go

create database coffeeshop
go

use coffeeshop
go

create table cftable
(
	id int identity primary key,
	name nvarchar(100) not null,
	status nvarchar(100) not null default N'Empty'
)
go

create table category
(
	id int identity primary key,
	name nvarchar(100) not null,
)
go

create table drink
(
	id int identity primary key,
	name nvarchar(100) not null,
	idcategory int not null foreign key references dbo.category(id),
	price float not null default 0	
)
go

create table account
(
	id int identity primary key,
	username varchar(100) unique,
	displayname nvarchar(100) not null,
	password varchar(100) not null,
	type int not null default 0 check (type = 1 or type = 0), -- 1: admin, 0: staff
	typename nvarchar(100) not null default N'staff'
)
go

create table bill
(
	id int identity primary key,
	checkin date not null default getdate(),
	checkout date,
	idtable int not null foreign key references dbo.cftable(id),
	discount int default 0,
	totalprice float default 0,
	status int not null default 0
)
go

create table billinfo
(
	id int identity primary key,
	idbill int not null foreign key references dbo.bill(id),
	iddrink int not null foreign key references dbo.drink(id),
	count int not null default 0
)
go

insert into dbo.account values ('admin', N'Admin', '$2a$12$WVFbFGFUFC7yGGVSV7LmXOafig1X9w6og3zhCNVGMc/VOzN9HGQzW', 1, 'admin')
insert into dbo.account values ('staff', N'Staff', '$2a$12$WVFbFGFUFC7yGGVSV7LmXOafig1X9w6og3zhCNVGMc/VOzN9HGQzW', 0, 'staff')
go

begin
	declare @i int = 1
	while @i  < 13
	begin
		insert dbo.cftable (name) values (N'Table ' + cast (@i as nvarchar(100)))
		set @i = @i + 1
	end
end
go

create proc usp_getaccount
@username nvarchar(100)
as
begin
	select * from dbo.account where username = @username
end
go

create proc usp_login
@username nvarchar(100), @password nvarchar(1000)
as
begin
	select * from dbo.account where username = @username and password = @password
end
go

create proc usp_gettablelist
as select * from dbo.cftable
go

--Test Data
insert dbo.category (name) values (N'Coffee')
insert dbo.category (name) values (N'Fruit Juice')
insert dbo.category (name) values (N'Soft Drink')

insert dbo.Drink (name, idcategory, price) values (N'Black Coffee', 1, 13000)
insert dbo.Drink (name, idcategory, price) values (N'Milk Coffee', 1, 15000)
insert dbo.Drink (name, idcategory, price) values (N'Cappuccino', 1, 25000)
insert dbo.Drink (name, idcategory, price) values (N'Latte', 1, 25000)

insert dbo.Drink (name, idcategory, price) values (N'Lemon', 2, 15000)
insert dbo.Drink (name, idcategory, price) values (N'Orange', 2, 20000)
insert dbo.Drink (name, idcategory, price) values (N'Strawberry', 2, 20000)
insert dbo.Drink (name, idcategory, price) values (N'Coconut', 2, 20000)

insert dbo.Drink (name, idcategory, price) values (N'Aquafina', 3, 10000)
insert dbo.Drink (name, idcategory, price) values (N'Coca Cola', 3, 15000)
insert dbo.Drink (name, idcategory, price) values (N'Pepsi', 3, 15000)
go

create proc usp_insertbill
@idtable int
as
begin
	insert dbo.bill (checkin, checkout, idtable, status, discount) values (getdate(), null, @idtable, 0, 0)
end
go

create proc usp_insertbillinfo
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
go

create trigger utg_updatebillinfo
on dbo.billinfo for insert, update
as
begin
	declare @idbill int
	select @idbill = idbill from inserted
	declare @idtable int
	select @idtable = idtable from dbo.bill where id = @idbill and status = 0
	update dbo.cftable set status = N'Guest' where id = @idtable
end
go

create trigger utg_updatebill
on dbo.bill for update
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
go

create proc usp_switchtable
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
go

create proc usp_getbilllistbydate
@checkin date, @checkout date
as
begin
	select t.name as [Table Name], checkin as [Checkin], checkout [Checkout], discount as [Discount], totalprice as [Total Price]
	from dbo.bill as b, dbo.cftable as t
	where checkin >= @checkin and checkout <= @checkout and b.status = 1 and t.id = b.idtable
end
go

create proc usp_updateaccount
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
go

create trigger utg_deletebillinfo
on dbo.billinfo for delete
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
go