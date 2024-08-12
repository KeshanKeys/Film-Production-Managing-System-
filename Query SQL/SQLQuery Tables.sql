create table ProductionProperty(

Production_Id int,
Property_Id int,
foreign key(Production_Id) references Production(Production_Id),
foreign key(Property_Id) references Property(Property_Id),
)
create table ProductionLocation(

Location_Id int,
Production_Id int,
foreign key(Location_Id) references Location(Location_Id),
foreign key(Production_Id) references Production(Production_Id),
)

create table LocationProperty(

Property_Id int,
Location_Id int,
foreign key(Property_Id) references Property(Property_Id),
foreign key(Location_Id) references Location(Location_Id),

)

create table productionStaff(

Production_Id int,
Staff_Id int,
foreign key(Staff_Id) references Staff(Staff_Id),
foreign key(Production_Id) references Production(Production_Id),

)
