Create Database Ass01
Use Ass01
Drop table Users
Create table Users (
MemberID int Primary key,
MemberName varchar(50) ,
Email varchar(50),
Passwords varchar(50),
City varchar(50),
Country varchar(50)
)

insert into Users(MemberID,MemberName,Email,Passwords,City,Country) values (1,'user1','user1@gmail.com','12345678','City1','Country1')
insert into Users(MemberID,MemberName,Email,Passwords,City,Country) values (2,'user2','user2@gmail.com','12345678','City2','Country2')
insert into Users(MemberID,MemberName,Email,Passwords,City,Country) values (3,'user3','user3@gmail.com','12345678','City3','Country3')