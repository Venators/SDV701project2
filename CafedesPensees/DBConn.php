<?php
class DBConnection {
    private $rs; //Procedural "handle" or "resource" to database
    private $connectRs; //ConnectionResource
    
    private function connectDB() //Internal Connection Function
    {
        $this->connectRs = mysqli_connect("Localhost","root","");
        if(!$this->connectRs)
            {
                echo "Error connecting to the server".mysqli_error($this->connectRs);
                //$this->connectRs = -1;
            } else {
                //echo "Connected to Server</br>";
            }
        
        $dbRs = mysqli_select_db($this->connectRs,'jsondb');
        if(! $dbRs)
            {
                echo "Error selecting the database ".mysqli_error($this->connectRs) . "<br>"; 
            } else {
                //echo "Connected to Database" . $pStrDatabase . "<br>";
            }
    }

    private function closeDB()
    {
        mysqli_close($this->connectRs);
    }
    
    /*public function StringEscape($pString){
        $Output = mysqli_real_escape_string($this->connectRs, $pString);
        return $Output;
    }*/
    
    public function DBConnection() //External Connection Function
    { 
        $this->connectDB();            
    }
    
    public function DBClose() //External Connection Function
    { 
        $this->closeDB();            
    }
    

    public function DBQuery($pStrSQL) //External Query Function
    {
        //$this->rs = -1;       
        $this->rs = mysqli_query($this->connectRs,$pStrSQL);
        //$LastID = mysqli_insert_id($this->connectRs);
        //echo $LastID . '@DBQuery <br>';
        //$_SESSION['LastID'] = $LastID;
        if( !$this->rs)
        {
            echo "Error running query [$pStrSQL] ".mysqli_error($this->connectRs)."<br>";
            //$this->rs = -1;            
        }
        return $this->rs;
    }
    
    /*public function LastID()
    {
        $LastID = mysqli_insert_id($this->connectRs);
        return $LastID;
    }*/
}
?>