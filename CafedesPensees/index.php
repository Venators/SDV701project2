<?php
require_once('DBConn.php');
require_once('CafeAPI.php');
class APIRouter{

    public function URLParsing(){
        $endofurl = NULL;
        $urlparam = NULL;
        $urlparam2 = NULL;
        $urlparam3 = NULL;
        $url = $_SERVER['REQUEST_URI'];
        $url = explode('/', $url); //Splits URL into array
        $url = array_filter($url, 'strlen'); //Removes empty or equivalent values from array
        $url = array_merge($url, array()); //Reindexes the array
        if(array_key_exists(2, $url)){
            $endofurl = $url[2];
            if(array_key_exists(3, $url)){
                $urlparam = $url[3];
            }
            if(array_key_exists(4, $url)){
                $urlparam2 = $url[4];
            }
            if(array_key_exists(5, $url)){
                $urlparam3 = $url[5];
            }
            $this->APIRouting($endofurl, $urlparam, $urlparam2, $urlparam3);
        }else{
            echo "You have tried to access an unauthorised url. Please try a valid url.";
        }
        //echo $endofurl;
    }
    
    private function APIRouting($endofurl, $urlparam, $urlparam2, $urlparam3){
      $API = new CafeAPI();
      if(method_exists($API, $endofurl) ){
        $API->$endofurl(@$urlparam, @$urlparam2, @$urlparam3);
      }
      else{
        echo "url not recognised. Please try a valid API call";
      }
    }
}
$APIRouter = new APIRouter(); //This instanciates new object
$APIRouter->URLParsing(); //This call the query
?>