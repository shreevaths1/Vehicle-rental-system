SELECT        [user].User_Id, [user].Username, booking.Booking_Id, vehicle.Vehicle_Id, vehicle.Vehicle_Type, vehicle.Vehicle_Brand, vehicle.Vehicle_Model, vehicle.Color, vehicle.License_number, vehicle.rate_per_day, 
                                             booking.Rental_Date, booking.Return_Date, booking.Rent_Duration, booking.Rent_Amount, payment.Payment_Id, payment.Payment_Date, payment.Card_Type
                    FROM            [user] INNER JOIN
                                             booking ON [user].User_Id = booking.User_Id 
                                           INNER JOIN
                                             payment ON [user].User_Id = payment.User_Id and [booking].Booking_Id = payment.Booking_Id
                                           INNER JOIN
                                             vehicle ON vehicle.Vehicle_Id = booking.Vehicle_Id

select * from payment;
select * from report;

select 
        [user].User_Id,[user].Username,
        feedback.Subject, feedback.Feedback
from [user] 
inner join feedback on [user].User_Id = feedback.User_Id;

SELECT        [user].User_Id, [user].Username, booking.Booking_Id, vehicle.Vehicle_Id, vehicle.Vehicle_Type, vehicle.Vehicle_Brand, vehicle.Vehicle_Model, vehicle.Color, vehicle.License_number, vehicle.rate_per_day, 
                         booking.Rental_Date, booking.Return_Date, booking.Rent_Duration, booking.Rent_Amount, payment.Payment_Id, payment.Payment_Date, payment.Card_Type
FROM            [user] INNER JOIN
                         booking ON [user].User_Id = booking.User_Id INNER JOIN
                         payment ON [user].User_Id = payment.User_Id INNER JOIN
                         vehicle ON vehicle.Vehicle_Id = booking.Vehicle_Id

SELECT        [user].User_Id, [user].Username, booking.Booking_Id,payment.Payment_Id, payment.Payment_Date,booking.Rent_Amount As Payment_Amount
FROM            [user] INNER JOIN
                         booking ON [user].User_Id = booking.User_Id INNER JOIN
                         payment ON [user].User_Id = payment.User_Id;

SELECT        [user].User_Id, [user].Username, booking.Booking_Id,payment.Payment_Id, payment.Payment_Date,booking.Rent_Amount As Payment_Amount
                    FROM            [user] INNER JOIN
                                             booking ON [user].User_Id = booking.User_Id INNER JOIN
                                             payment ON [user].User_Id = payment.User_Id;
                         



drop table login;
delete from booking where user_id = 102;
select * from booking;
select * from vehicle;
select * from payment;
select * from feedback;
delete from feedback;
delete from payment where user_id = 102;
drop table [dbo].[user]

CREATE TABLE [dbo].[user] (
    [User_Id]   int  identity(101,1) NOT NULL,
    [Username] VARCHAR (15) NULL,
    [Password] VARCHAR (15) NOT NULL,
    [Email]    VARCHAR (30) NOT NULL,
    [Contact]  BIGINT          NOT NULL,
    [City]     VARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([User_Id] ASC),
);

select * from [dbo].[user];

drop table [dbo].[admin];
CREATE TABLE [dbo].[admin] (
    [Admin_Id]   int  identity(1,1) NOT NULL,
    [Ad_Username] VARCHAR (15) not NULL,
    [Ad_Password] VARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([Admin_Id] ASC),
);

insert into [dbo].[admin](Ad_Username,Ad_Password) values('admin','admin');
insert into [dbo].[user](Username,Password,Email,Contact,City) values('shree','sri123','srivathsa.kalyan@gmail.com',6363537674,'Bangalore');

delete from [dbo].[user];

create table [dbo].[vehicle] 
(
	[Vehicle_Id] int identity(301,1) primary key,
	[Vehicle_Type] varchar(5) not null,
	[Model_Year] int not null,
	[Vehicle_Brand] varchar(20) not null,
	[Vehicle_Model] varchar(30) not null,
    [Color] varchar(20) not null,
    [Capacity] int not null,
    [License_number] int not null,
    [Engine] varchar(15) not null,
    [Status] varchar(15) not null,
    [Rate] varchar(20) not null
);

select * from [dbo].[vehicle];
drop table [dbo].[vehicle];
alter table [dbo].[vehicle] alter column "License_number" varchar(15);

update [dbo].[vehicle] 
set  Status = 'Available' 
where Vehicle_Id = 308;

alter table [dbo].[vehicle] drop column "License_number";
delete from [dbo].[vehicle] ;
insert into [dbo].[vehicle](Vehicle_Type,Model_Year,Vehicle_Brand,Vehicle_Model,Color,Capacity,Engine,Status,Rate) values ('Car',2019,'Tata','Nexon','Blue',5,'Petrol','Availbale','Rs 5000 per day');

select * from [dbo].[vehicle] where License_number = ' KA-03-HA-1985 ' ;
select * from [dbo].[vehicle] where Model_Year = 2005 ;

drop table [dbo].[booking];
select * from [dbo].[booking];
CREATE TABLE [dbo].[booking] (
    [Booking_Id]   int  identity(401,1) primary key,
    [User_Id] int not null foreign key references [dbo].[user](User_Id),
    [Vehicle_Id] int not null foreign key references [dbo].[vehicle](Vehicle_Id),
    [Rental_Date]  date NOT NULL,
    [Return_Date]  date  NOT NULL,
    [Rent_Duration] int NOT NULL,
    [Rent_Amount] int NOT NULL
    
);

select * from [dbo].[payment];
CREATE TABLE [dbo].[payment] (
    [Payment_Id]   int  identity(501,1) primary key,
    [Booking_Id] int not null foreign key references [dbo].[booking](Booking_Id),
    [User_Id] int not null foreign key references [dbo].[user](User_Id),
    [Payment_Date]  date NOT NULL,
    [Card_Type] varchar(15) not null,
    [Card_No] varchar(16) not null,
    [Card_Holder] varchar(20) not null,
    [Expiring_Date] date not null,
    [CVV] varchar(4) not null,    
);

alter table [dbo].[payment] alter column Payment_Date datetime not null;

CREATE TABLE [dbo].[feedback] (
    [Feedback_Id]   int  identity(601,1) primary key,
    [User_Id] int not null foreign key references [dbo].[user](User_Id),
    [Subject]  varchar(20) NOT NULL,
    [Feedback] varchar(100) not null,    
);

CREATE TABLE [dbo].[report] (
    [Report_Id]   int  identity(701,1) primary key,
    [User_Id] int not null foreign key references [dbo].[user](User_Id),
    [Booking_Id] int not null foreign key references [dbo].[booking](Booking_Id),
    [Vehicle_Id] int not null foreign key references [dbo].[vehicle](Vehicle_Id),
    [Payment_Id] int not null foreign key references [dbo].[payment](Payment_Id),    
);

select * from booking;


select * from vehicle where vehicle_type=vehicle_type

select * from vehicle where vehicle_type=vehicle_type AND vehicle_brand=vehicle_brand AND vehicle_model=vehicle_model AND status = 'available'

