drop database recruitment;
create database recruitment;
use recruitment;

create table `Category` (
    `Id` int primary key auto_increment,
    `Name` nvarchar(255) not null,
    `Description` nvarchar(255)
);

create table `Product` (
    `Id` int primary key auto_increment,
    `Name` nvarchar(255) not null,
    `Description` nvarchar(255),
    `CategoryId` int,
    `Quantity` int,
    foreign key (`CategoryId`) references `Category`(`Id`)
);

create table `Customer`(
    `Id` int primary key auto_increment,
    `Name` nvarchar(255) not null,
    `Address` nvarchar(255)
);

create table `Order` (
    `Id` int primary key auto_increment,
    `CustomerId` int(255) not null,
    `OrderDate` datetime,
    foreign key (`CustomerId`) references `Customer`(`Id`)
);

create table `OrderDetail` (
    `Id` int primary key auto_increment,
    `OrderId` int not null,
    `ProductId` int not null,
    `Amount` int not null,
    foreign key (`ProductId`) references `Product`(`Id`),
    foreign key (`OrderId`) references `Order`(`Id`)
);