<?php
$dbhost = 'Localhost';
$dbuser = 'root';
$dbpass = '';

$conn = mysqli_connect($dbhost, $dbuser, $dbpass);

if(! $conn ){
    die('Could not connect: ' . mysqli_connect_error() . '<br>');
} else {
    echo 'Connected successfully <br>';
}

$sql = "DROP DATABASE jsondb";
$retval = mysqli_query($conn, $sql);
if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Database destroyed successfully<br>";
}

$sql = "CREATE DATABASE jsondb";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Database created successfully<br>";
}

mysqli_select_db($conn, "jsondb");

$sql = "CREATE TABLE Beans(\n"
    . "BeanID INT(4) AUTO_INCREMENT PRIMARY KEY,\n"
    . "BeanType VARCHAR(30) NOT NULL,\n"
    . "RoastType VARCHAR(15) NOT NULL,\n"
    . "Quantity INT(4),\n"
    . "CountryOfOrigin VARCHAR(50) NOT NULL\n"
    . ")";
    
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Beans Table created successfully<br>";
}

$sql = "CREATE TABLE Coffee(\n"
    . "\$type VARCHAR(50),"
    . "CoffeeID INT(4) AUTO_INCREMENT PRIMARY KEY,\n"
    . "CoffeeName VARCHAR(15) NOT NULL,\n"
    . "Price DECIMAL(3,2) NOT NULL,\n"
    . "DateModified DATE,\n"
    . "NumberOfShots VARCHAR(3) NOT NULL,\n"
    . "HotWater BOOLEAN,\n"
    . "SteamedMilk BOOLEAN,\n"
    . "FrothedMilk BOOLEAN,\n"
    . "Chocolate BOOLEAN,\n"
    . "ChocolateDusting BOOLEAN,\n"
    . "FlavourType VARCHAR(15),\n"
    . "BeanID INT(4) NOT NULL,\n"
    . "LockStatus BOOLEAN,\n"
    . "FOREIGN KEY (BeanID) REFERENCES Beans (BeanID)\n"
    . ")";
    
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Coffee Table created successfully<br>";
}

$sql = "CREATE TABLE Orders(\n"
    . "OrderID INT(4) AUTO_INCREMENT PRIMARY KEY,\n"
    . "BeanID INT NOT NULL,\n"
    . "CoffeeID INT NOT NULL,\n"
    . "Quantity INT(4) NOT NULL,\n"
    . "OrderDateTime DATETIME,\n"
    . "CupSize VARCHAR(15) NOT NULL,\n"
    . "NeedsCarryTray BOOLEAN,\n"
    . "NeedsCupSleeve BOOLEAN,\n"
    . "TableNumber INT(2) NOT NULL,\n"
    . "CustomerName VARCHAR(50) NOT NULL,\n"
    . "CustomerEmail VARCHAR(50) NOT NULL,\n"
    . "FOREIGN KEY (`BeanID`) REFERENCES `beans` (`BeanID`) ON DELETE CASCADE ON UPDATE CASCADE,\n"
    . "FOREIGN KEY (CoffeeID) REFERENCES Coffee (CoffeeID) ON DELETE CASCADE ON UPDATE CASCADE\n"
    . ")";
    
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Orders Table created successfully<br>";
}

$sql  = "INSERT INTO `beans`(`BeanType`, `RoastType`, `Quantity`, `CountryOfOrigin`) \n"
    . "VALUES ('Arabica','Light','500','Brazil'),\n"
    . "('Arabica','Medium','500','Honduras'),\n"
    . "('Arabica','Medium-Dark','500','Peru')";

$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Beans Data Inserted successfully<br>";
}

$sql  = "INSERT INTO `coffee`(`\$type`, `CoffeeName`, `Price`, `DateModified`, `NumberOfShots`, `HotWater`, `SteamedMilk`, `FrothedMilk`, `Chocolate`, `ChocolateDusting`, `FlavourType`,`BeanID`, `LockStatus`) \n"
    . "VALUES ('SDV701Project2.clsWithoutMilk\, SDV701Project2','Espresso','2.50','2017-05-24','1','0','0','0','0','0','None','1','0'),\n"
    . "('SDV701Project2.clsWithMilk\, SDV701Project2','Latte','3.50','2017-05-24','1','0','1','1','0','0','None','3','0'),\n"
    . "('SDV701Project2.clsWithFlavours\, SDV701Project2','Mochaccino','5.50','2017-05-24','1','0','1','1','1','1','None','2','0')";

$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Coffee Data Inserted successfully<br>";
}

$sql  = "INSERT INTO `orders`(`BeanID`, `CoffeeID`, `Quantity`, `OrderDateTime`, `CupSize`, `NeedsCarryTray`, `NeedsCupSleeve`, `TableNumber`, `CustomerName`, `CustomerEmail`) \n"
    . "VALUES ('1','2','1','2017-05-24','Medium','0','0','7','David','Sivhardar@Gmail.com'),\n"
    . "('3','3','1','2017-05-24','Large','0','1','0','Jonathan','JPG207@Gmail.com')";

$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Orders Data Inserted successfully<br>";
}

$sql = "CREATE PROCEDURE View_Orders()\n"
    . " BEGIN\n"
    . " SELECT O.OrderID, B.BeanType, B.RoastType, C.CoffeeName, C.Price, O.Quantity, DATE_FORMAT(O.OrderDateTime,'%e/%m/%Y') AS OrderDateTime, O.CupSize, O.NeedsCarryTray, O.NeedsCupSleeve, O.TableNumber, O.CustomerName FROM Orders O
    INNER JOIN Coffee C
    ON C.CoffeeID = O.CoffeeID
    INNER JOIN Beans B
    ON B.BeanID = O.BeanID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure View Orders created successfully<br>";
}

//Delete Order to go here

$sql = "CREATE PROCEDURE View_Beverages()\n"
    . " BEGIN\n"
    . " SELECT * FROM Beans;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure View Beverages created successfully<br>";
}

$sql = "CREATE PROCEDURE View_Coffees(lcBeanID INT(3))\n"
    . " BEGIN\n"
    . " SELECT * FROM Coffee WHERE BeanID = lcBeanID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure View Coffees created successfully<br>";
}
    
$sql = "CREATE PROCEDURE Get_InStock_BeanTypes()\n"
    . " BEGIN\n"
    . " SELECT BeanID, BeanType, RoastType FROM Beans WHERE Quantity > 0;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Get InStock BeanTypes created successfully<br>";
}
    
$sql = "CREATE PROCEDURE Get_Selected_Bean(prBeanID INT(3))\n"
    . " BEGIN\n"
    . " SELECT * FROM Beans WHERE BeanID = prBeanID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Get Selected Bean created successfully<br>";
}

$sql = "CREATE PROCEDURE Get_Selected_Bean_Coffees(prBeanID INT(3))\n"
    . " BEGIN\n"
    . " SELECT \$type, CoffeeID, CoffeeName, Price, DATE_FORMAT(DateModified,'%e/%m/%Y') AS DateModified, NumberOfShots, HotWater, SteamedMilk, FrothedMilk, Chocolate, ChocolateDusting, FlavourType, BeanID FROM Coffee WHERE BeanID = prBeanID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Get Selected Bean Coffees created successfully<br>";
}

$sql = "CREATE PROCEDURE Delete_Order(prOrderID INT(3))\n"
    . " BEGIN\n"
    . " DELETE FROM Orders WHERE OrderID = prOrderID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Delete Order created successfully<br>";
}

$sql = "CREATE PROCEDURE Delete_Coffee(prCoffeeID INT(3))\n"
    . " BEGIN\n"
    . " DELETE FROM Coffee WHERE CoffeeID = prCoffeeID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Delete Coffee created successfully<br>";
}

$sql = "CREATE PROCEDURE Add_Coffee(prType VARCHAR(50), prCoffeeName VARCHAR(15), prPrice DECIMAL(3,2), prDateModified DATE, prNumberOfShots VARCHAR(3), prHotWater TINYINT(1), prSteamedmilk TINYINT(1), prFrothedMilk TINYINT(1), prChocolate TINYINT(1), prChocolateDusting TINYINT(1), prFlavourType VARCHAR(15),prBeanID INT(4), OUT prCoffeeID INT(3))\n"
    . " BEGIN\n"
    . " INSERT INTO `coffee`(`\$type`, `CoffeeName`, `Price`, `DateModified`, `NumberOfShots`, `HotWater`, `SteamedMilk`, `FrothedMilk`, `Chocolate`, `ChocolateDusting`, `FlavourType`, `BeanID`) VALUES (prType,prCoffeeName,prPrice,prDateModified,prNumberOfShots,prHotWater,prSteamedmilk,prFrothedMilk,prChocolate,prChocolateDusting,prFlavourType,prBeanID);\n"
    . " SELECT LAST_INSERT_ID() INTO prCoffeeID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Add Coffee created successfully<br>";
}

$sql = "CREATE PROCEDURE Edit_Coffee(prType VARCHAR(50), prCoffeeName VARCHAR(15), prPrice DECIMAL(3,2), prDateModified DATE, prNumberOfShots VARCHAR(3), prHotWater TINYINT(1), prSteamedmilk TINYINT(1), prFrothedMilk TINYINT(1), prChocolate TINYINT(1), prChocolateDusting TINYINT(1), prFlavourType VARCHAR(15),prBeanID INT(4))\n"
    . " BEGIN\n"
    . " UPDATE `coffee` SET \$type = prType, CoffeeName = prCoffeeName, Price = prPrice, DateModified = prDateModified, NumberOfShots = prNumberOfShots, HotWater = prHotWater, SteamedMilk = prSteamedmilk, FrothedMilk = prFrothedMilk, Chocolate = prChocolate, ChocolateDusting = prChocolateDusting, FlavourType = prFlavourType WHERE  BeanID = prBeanID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Edit Coffee created successfully<br>";
}

$sql = "CREATE PROCEDURE Check_Bean_Quantity(prBeanID INT(3))\n"
    . " BEGIN\n"
    . " SELECT Quantity FROM Beans WHERE BeanID = prBeanID;\n"
    . " END;";
$retval = mysqli_query($conn, $sql);

if(! $retval ){
    echo "Error: " . mysqli_error($conn) . "<br>";
} else {
    echo "Procedure Check Bean Quantity created successfully<br>";
}

mysqli_close($conn);
?>