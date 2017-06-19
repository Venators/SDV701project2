-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 19, 2017 at 05:27 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `jsondb`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Add_Coffee` (`prType` VARCHAR(50), `prCoffeeName` VARCHAR(15), `prPrice` DECIMAL(3,2), `prDateModified` DATE, `prNumberOfShots` VARCHAR(3), `prHotWater` TINYINT(1), `prSteamedmilk` TINYINT(1), `prFrothedMilk` TINYINT(1), `prChocolate` TINYINT(1), `prChocolateDusting` TINYINT(1), `prFlavourType` VARCHAR(15), `prBeanID` INT(4), OUT `prCoffeeID` INT(3))  BEGIN
 INSERT INTO `coffee`(`$type`, `CoffeeName`, `Price`, `DateModified`, `NumberOfShots`, `HotWater`, `SteamedMilk`, `FrothedMilk`, `Chocolate`, `ChocolateDusting`, `FlavourType`, `BeanID`) VALUES (prType,prCoffeeName,prPrice,prDateModified,prNumberOfShots,prHotWater,prSteamedmilk,prFrothedMilk,prChocolate,prChocolateDusting,prFlavourType,prBeanID);
 SELECT LAST_INSERT_ID() INTO prCoffeeID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Check_Bean_Quantity` (`prBeanID` INT(3))  BEGIN
 SELECT Quantity FROM Beans WHERE BeanID = prBeanID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_Coffee` (`prCoffeeID` INT(3))  BEGIN
 DELETE FROM Coffee WHERE CoffeeID = prCoffeeID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_Order` (`prOrderID` INT(3))  BEGIN
 DELETE FROM Orders WHERE OrderID = prOrderID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Edit_Coffee` (`prType` VARCHAR(50), `prCoffeeName` VARCHAR(15), `prPrice` DECIMAL(3,2), `prDateModified` DATE, `prNumberOfShots` VARCHAR(3), `prHotWater` TINYINT(1), `prSteamedmilk` TINYINT(1), `prFrothedMilk` TINYINT(1), `prChocolate` TINYINT(1), `prChocolateDusting` TINYINT(1), `prFlavourType` VARCHAR(15), `prBeanID` INT(4))  BEGIN
 UPDATE `coffee` SET $type = prType, CoffeeName = prCoffeeName, Price = prPrice, DateModified = prDateModified, NumberOfShots = prNumberOfShots, HotWater = prHotWater, SteamedMilk = prSteamedmilk, FrothedMilk = prFrothedMilk, Chocolate = prChocolate, ChocolateDusting = prChocolateDusting, FlavourType = prFlavourType WHERE  BeanID = prBeanID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Get_InStock_BeanTypes` ()  BEGIN
 SELECT BeanID, BeanType, RoastType FROM Beans WHERE Quantity > 0;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Get_Selected_Bean` (`prBeanID` INT(3))  BEGIN
 SELECT * FROM Beans WHERE BeanID = prBeanID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Get_Selected_Bean_Coffees` (`prBeanID` INT(3))  BEGIN
 SELECT $type, CoffeeID, CoffeeName, Price, DATE_FORMAT(DateModified,'%e/%m/%Y') AS DateModified, NumberOfShots, HotWater, SteamedMilk, FrothedMilk, Chocolate, ChocolateDusting, FlavourType, BeanID FROM Coffee WHERE BeanID = prBeanID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `View_Beverages` ()  BEGIN
 SELECT * FROM Beans;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `View_Coffees` (`lcBeanID` INT(3))  BEGIN
 SELECT * FROM Coffee WHERE BeanID = lcBeanID;
 END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `View_Orders` ()  BEGIN
 SELECT O.OrderID, B.BeanType, B.RoastType, C.CoffeeName, C.Price, O.Quantity, DATE_FORMAT(O.OrderDateTime,'%e/%m/%Y') AS OrderDateTime, O.CupSize, O.NeedsCarryTray, O.NeedsCupSleeve, O.TableNumber, O.CustomerName FROM Orders O
    INNER JOIN Coffee C
    ON C.CoffeeID = O.CoffeeID
    INNER JOIN Beans B
    ON B.BeanID = O.BeanID;
 END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `beans`
--

CREATE TABLE `beans` (
  `BeanID` int(4) NOT NULL,
  `BeanType` varchar(30) NOT NULL,
  `RoastType` varchar(15) NOT NULL,
  `Quantity` int(4) DEFAULT NULL,
  `CountryOfOrigin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `beans`
--

INSERT INTO `beans` (`BeanID`, `BeanType`, `RoastType`, `Quantity`, `CountryOfOrigin`) VALUES
(1, 'Arabica', 'Light', 500, 'Brazil'),
(2, 'Arabica', 'Medium', 10, 'Honduras'),
(3, 'Arabica', 'Medium-Dark', 500, 'Peru');

-- --------------------------------------------------------

--
-- Table structure for table `coffee`
--

CREATE TABLE `coffee` (
  `$type` varchar(50) DEFAULT NULL,
  `CoffeeID` int(4) NOT NULL,
  `CoffeeName` varchar(15) NOT NULL,
  `Price` decimal(3,2) NOT NULL,
  `DateModified` date DEFAULT NULL,
  `NumberOfShots` varchar(3) NOT NULL,
  `HotWater` tinyint(1) DEFAULT NULL,
  `SteamedMilk` tinyint(1) DEFAULT NULL,
  `FrothedMilk` tinyint(1) DEFAULT NULL,
  `Chocolate` tinyint(1) DEFAULT NULL,
  `ChocolateDusting` tinyint(1) DEFAULT NULL,
  `FlavourType` varchar(15) DEFAULT NULL,
  `BeanID` int(4) NOT NULL,
  `LockStatus` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `coffee`
--

INSERT INTO `coffee` (`$type`, `CoffeeID`, `CoffeeName`, `Price`, `DateModified`, `NumberOfShots`, `HotWater`, `SteamedMilk`, `FrothedMilk`, `Chocolate`, `ChocolateDusting`, `FlavourType`, `BeanID`, `LockStatus`) VALUES
('SDV701Project2.clsWithoutMilk, SDV701Project2', 1, 'Espresso', '2.50', '2017-05-24', '1', 0, 0, 0, 0, 0, 'None', 1, 0),
('SDV701Project2.clsWithMilk, SDV701Project2', 2, 'Latte', '3.50', '2017-05-24', '1', 0, 1, 1, 0, 0, 'None', 3, 0),
('SDV701Project2.clsWithFlavours, SDV701Project2', 3, 'Mochaccino', '5.50', '2017-05-24', '1', 0, 1, 1, 1, 1, 'None', 2, 0);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderID` int(4) NOT NULL,
  `BeanID` int(11) NOT NULL,
  `CoffeeID` int(11) NOT NULL,
  `Quantity` int(4) NOT NULL,
  `OrderDateTime` datetime DEFAULT NULL,
  `CupSize` varchar(15) NOT NULL,
  `NeedsCarryTray` tinyint(1) DEFAULT NULL,
  `NeedsCupSleeve` tinyint(1) DEFAULT NULL,
  `TableNumber` int(2) NOT NULL,
  `CustomerName` varchar(50) NOT NULL,
  `CustomerEmail` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderID`, `BeanID`, `CoffeeID`, `Quantity`, `OrderDateTime`, `CupSize`, `NeedsCarryTray`, `NeedsCupSleeve`, `TableNumber`, `CustomerName`, `CustomerEmail`) VALUES
(1, 1, 2, 1, '2017-05-24 00:00:00', 'Medium', 0, 0, 7, 'David', 'Sivhardar@Gmail.com'),
(2, 3, 3, 1, '2017-05-24 00:00:00', 'Large', 0, 1, 0, 'Jonathan', 'JPG207@Gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `beans`
--
ALTER TABLE `beans`
  ADD PRIMARY KEY (`BeanID`);

--
-- Indexes for table `coffee`
--
ALTER TABLE `coffee`
  ADD PRIMARY KEY (`CoffeeID`),
  ADD KEY `BeanID` (`BeanID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `BeanID` (`BeanID`),
  ADD KEY `CoffeeID` (`CoffeeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `beans`
--
ALTER TABLE `beans`
  MODIFY `BeanID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `coffee`
--
ALTER TABLE `coffee`
  MODIFY `CoffeeID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `coffee`
--
ALTER TABLE `coffee`
  ADD CONSTRAINT `coffee_ibfk_1` FOREIGN KEY (`BeanID`) REFERENCES `beans` (`BeanID`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`BeanID`) REFERENCES `beans` (`BeanID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`CoffeeID`) REFERENCES `coffee` (`CoffeeID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
