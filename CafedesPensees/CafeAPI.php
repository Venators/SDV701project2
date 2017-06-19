<?php
class CafeAPI {
//    /public $ReturnJSON;

    public function ViewOrders(){
        $dbconn = new DBConnection();
        if($dbconn){
            $results = array();
            $result = $dbconn->DBQuery("Call View_Orders()");
            
            while($row = $result->fetch_assoc()){
                $results[] = $row;
            }
            header('Content-type: application/json');
            echo json_encode($results);
        }
        $dbconn->DBClose();
    }
    
    public function ViewBeverages(){
        $dbconn = new DBConnection();
        if($dbconn){
            $results = array();
            $result = $dbconn->DBQuery("Call View_Beverages()");
            
            while($row = $result->fetch_assoc()){
                $results[] = $row;
            }
            header('Content-type: application/json');
            echo json_encode($results);
        }
        $dbconn->DBClose();
    }
    
    public function ViewCoffees(){
        $dbconn = new DBConnection();
        if($dbconn){
            $BeanID = 1;
            $results = array();
            $result = $dbconn->DBQuery("Call View_Coffees('$BeanID')");
            
            while($row = $result->fetch_assoc()){
                $results[] = $row;
            }
            header('Content-type: application/json');
            echo json_encode($results);
        }
        $dbconn->DBClose();
    }
    
    public function GetInStockBeanTypes(){
        $dbconn = new DBConnection();
        if($dbconn){
            $BeanID = 1;
            $results = array();
            $result = $dbconn->DBQuery("Call Get_InStock_BeanTypes()");
            
            while($row = $result->fetch_assoc()){
                $results[] = $row;
            }
            header('Content-type: application/json');
            echo json_encode($results);
        }
        $dbconn->DBClose();
    }
        
    public function GetSelectedBean($prBeanID){  
        $dbconn = new DBConnection();
        if($dbconn){
            $results = $this->GetSelectedBeanCoffees($prBeanID, 'GetSelectedBean'); 
            //$results = array();
            $results2 = array();
            //$result = $dbconn->DBQuery("Call Get_Selected_Bean('$prBeanID')");
            $result = $dbconn->DBQuery("SELECT * FROM Beans WHERE BeanID = '$prBeanID';");
            //var_dump($result);
            //$dbRs = mysqli_select_db($this->connectRs,'jsondb');
            while($row = $result->fetch_assoc()){
                $results2 = array(
                'BeanID' => $row['BeanID'],
                'BeanType' => $row['BeanType'],
                'RoastType' => $row['RoastType'],
                'Quantity' => $row['Quantity'],
                'CountryOfOrigin' => $row['CountryOfOrigin'],
                'BeanCoffees' => $results
                );
            }
            header('Content-type: application/json');
            echo json_encode($results2);
        } 
        $dbconn->DBClose();
    }
    
    public function GetSelectedBeanCoffees($prBeanID, $prCaller){
        $dbconn = new DBConnection();
        if($dbconn){
            $results = array();
            $result = $dbconn->DBQuery("Call Get_Selected_Bean_Coffees('$prBeanID')");
            
            while($row = $result->fetch_assoc()){
                $results[] = $row;
            }
            $dbconn->DBClose();
        }
        if($prCaller == 'GetSelectedBean'){
            return($results);
        }elseif($prCaller == 'JS'){
            header('Content-type: application/json');
            echo json_encode($results);
        }
    }
    
    public function DeleteOrder($prOrderID){
        $dbconn = new DBConnection();
        if($dbconn){
            $result = $dbconn->DBQuery("Call Delete_Order('$prOrderID')");
            header('Content-type: application/json');
            echo json_encode($result);
        }
        $dbconn->DBClose();
    }
    
    public function DeleteCoffee($prCoffeeID){
        $dbconn = new DBConnection();
        if($dbconn){
            $result = $dbconn->DBQuery("Call Delete_Coffee('$prCoffeeID')");
            header('Content-type: application/json');
            echo json_encode($result);
        }
        $dbconn->DBClose();
    }
    
    public function AddCoffee(){
        $lcCoffee = json_decode(file_get_contents('php://input'), true);
        $lcFlavourType = isset($lcCoffee[@FlavourType]) ? $lcCoffee[@FlavourType] : 'None';
        $preFormatDate = str_replace("/", "-", " $lcCoffee[DateModified] ");
        $postFormatDate = date ("Y-m-d", strtotime($preFormatDate));
        $dbconn = new DBConnection();
        if($dbconn){
            $result = $dbconn->DBQuery("Call Add_Coffee('$lcCoffee[type]', '$lcCoffee[CoffeeName]', $lcCoffee[Price], '$postFormatDate', $lcCoffee[NumberOfShots], ".((@$lcCoffee[HotWater]=='')? 0 : 1).", ".((@$lcCoffee[SteamedMilk]=='')? 0 : 1).", ".((@$lcCoffee[FrothedMilk]=='')? 0 : 1).", ".((@$lcCoffee[Chocolate]=='')? 0 : 1).", ".((@$lcCoffee[ChocolateDusting]=='')? 0 : 1).",'$lcFlavourType', '$lcCoffee[BeanID]', @CoffeeID)");
            $lcCoffeeID = array();
            $result = $dbconn->DBQuery("SELECT @CoffeeID");
                while($row = $result->fetch_assoc()){
                    $lcCoffeeID = $row;
                }
            header('Content-type: application/json');
            echo json_encode($lcCoffeeID);
        }
        $dbconn->DBClose();
    }
    
        public function EditCoffee(){
        $lcCoffee = json_decode(file_get_contents('php://input'), true);
        $lcFlavourType = isset($lcCoffee[@FlavourType]) ? $lcCoffee[@FlavourType] : 'None';
        $preFormatDate = str_replace("/", "-", " $lcCoffee[DateModified] ");
        $postFormatDate = date ("Y-m-d", strtotime($preFormatDate));
        $dbconn = new DBConnection();
        if($dbconn){
            $result = $dbconn->DBQuery("Call Edit_Coffee('$lcCoffee[type]', '$lcCoffee[CoffeeName]', $lcCoffee[Price], '$postFormatDate', $lcCoffee[NumberOfShots], ".((@$lcCoffee[HotWater]=='')? 0 : 1).", ".((@$lcCoffee[SteamedMilk]=='')? 0 : 1).", ".((@$lcCoffee[FrothedMilk]=='')? 0 : 1).", ".((@$lcCoffee[Chocolate]=='')? 0 : 1).", ".((@$lcCoffee[ChocolateDusting]=='')? 0 : 1).",'$lcFlavourType', '$lcCoffee[BeanID]')");
            header('Content-type: application/json');
            echo json_encode($result);
        }

        $dbconn->DBClose();
    }
    
    public function LockRecord($prTableName, $prRecordID, $prLockStatus){
        $dbconn = new DBConnection();
        if($dbconn){
            $RowName = $prTableName . "ID";
            $result = $dbconn->DBQuery("UPDATE $prTableName SET LockStatus = $prLockStatus WHERE $RowName = $prRecordID");
            header('Content-type: application/json');
            echo json_encode($result);
        }
        $dbconn->DBClose();
    }
    
    public function CheckLockStatus($prTableName, $prRecordID){
        $dbconn = new DBConnection();
        if($dbconn){
            $RowName = $prTableName . "ID";
            $lcLockStatus = null;
            $result = $dbconn->DBQuery("SELECT LockStatus FROM $prTableName WHERE $RowName = '$prRecordID';");
            while($row = $result->fetch_assoc()){
                $lcLockStatus = $row['LockStatus'];
            }
            header('Content-type: application/json');
            echo json_encode($lcLockStatus);
        }
        $dbconn->DBClose();
    }
    
    public function CheckBeanQuantity($prBeanID, $prQuantity){
        $dbconn = new DBConnection();
        if($dbconn){
            $result = $dbconn->DBQuery("Call Check_Bean_Quantity('$prBeanID')");
            while($row = $result->fetch_assoc()){
                $lcQuantity = $row['Quantity'];
            }
            if ($lcQuantity - ($prQuantity * 20) > 0){
                header('Content-type: application/json');
                echo json_encode('true');
            } else {
                header('Content-type: application/json');
                echo json_encode('false');
            }
        }
        $dbconn->DBClose();
    }
    
        public function NewOrder(){
        $lcOrder = json_decode(file_get_contents('php://input'), true);
        print_r($lcOrder);
        $dbconn = new DBConnection();
        if($dbconn){
            /*$result = $dbconn->DBQuery("Call Check_Bean_Quantity('$prBeanID')");
            while($row = $result->fetch_assoc()){
                $lcQuantity = $row['Quantity'];
            }
            if ($lcQuantity - ($prQuantity * 20) > 0){
                header('Content-type: application/json');
                echo json_encode('true');
            } else {
                header('Content-type: application/json');
                echo json_encode('false');
            }*/
        }
        $dbconn->DBClose();
    }
}
?>