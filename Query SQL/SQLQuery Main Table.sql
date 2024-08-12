Create table Client(
Client_Id int,
Name varchar(50),
Contact_No int,
primary key(Client_Id)
)
Create table Production(
Production_Id int,
Name varchar(100),
Type varchar(50),
Client_Id int,
primary key(Production_Id),
foreign key(Client_Id) references Client(Client_Id),
)
Create table Location(
Location_Id int,
Name varchar(100),
Address varchar(50),
primary key(Location_Id)
)
Create table Property(
Property_Id int,
Name varchar(100),
Type varchar(50),
QTY int,
Primary key(Property_Id)
)
Create table Staff(
Staff_Id int,
Name varchar(100),
Type varchar(50),
QTY int,
Primary key(Staff_Id)
)
