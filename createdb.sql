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
    `ProductId` int not null,
    `Amount` int not null,
    foreign key (`CustomerId`) references `Customer`(`Id`),
    foreign key (`ProductId`) references `Product`(`Id`)
);

INSERT INTO `recruitment`.`category` (`Name`) VALUES ('Cate1');
INSERT INTO `recruitment`.`category` (`Name`) VALUES ('Cate2');

INSERT INTO `recruitment`.`customer` (`Name`) VALUES ('Cus1');
INSERT INTO `recruitment`.`customer` (`Name`) VALUES ('Cus2');

INSERT INTO `recruitment`.`product` (`Name`, `CategoryId`, `Quantity`) VALUES ('Prod1', '1', '7');
INSERT INTO `recruitment`.`product` (`Name`, `CategoryId`, `Quantity`) VALUES ('Prod2', '2', '6');
INSERT INTO `recruitment`.`product` (`Name`, `CategoryId`, `Quantity`) VALUES ('Prod3', '1', '9');
INSERT INTO `recruitment`.`product` (`Name`, `CategoryId`, `Quantity`) VALUES ('Prod4', '1', '5');
INSERT INTO `recruitment`.`product` (`Name`, `CategoryId`, `Quantity`) VALUES ('Prod5', '2', '8');
INSERT INTO `recruitment`.`product` (`Name`, `CategoryId`, `Quantity`) VALUES ('Prod6', '1', '6');

INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-06', '1', '1');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2022-07-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-08', '2', '1');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '5', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-06', '3', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-04', '1', '1');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '4', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-06', '5', '1');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '4', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('1', '2023-01-06', '6', '1');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
INSERT INTO `recruitment`.`order` (`CustomerId`, `OrderDate`, `ProductId`, `Amount`) VALUES ('2', '2023-01-06', '1', '2');
