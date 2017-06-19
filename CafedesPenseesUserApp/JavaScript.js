/*var xmlhttp = new XMLHttpRequest(); //This makes a new HTTP Request
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
           // var names = document.getElementById("demo");
            var text = this.responseText;
            var myObj = JSON.parse(text);
            console.log(this.responseText);
            document.getElementById("demo").innerHTML =
myObj.orders[1].CustomerName + " " + myObj.orders[1].CustomerEmail;
            //var arrayLength = myObj.length;
            //for (var i = 0; i < arrayLength; i++) {
                //alert(myObj.CustomerName);
                //alert(myObj[i]);

                //var output = document.createElement("li");
                //output.innerHTML = myObj[i];
                //names.appendChild(output);
           // }

        }
    }; //This handles the returned HTTP Responce


xmlhttp.open("GET", "http://localhost:8080/CafedesPensees/API/ViewOrders", true); //This opens a new HTTP Request
//xmlhttp.responseType = 'json';
xmlhttp.send(); //This sends the request

/*xmlhttp.onreadystatechange = function() {
var myObj = this.response;
console.log(this.response);
var names = document.getElementById("demo");
var arrayLength = myObj.length;
    for (var i = 0; i < arrayLength; i++) {
        var output = document.createElement("li");
        output.innerHTML = myObj[i];
        names.appendChild(output);
    }
}*/

/*var xmlhttp = new XMLHttpRequest();
xmlhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        var myObj = JSON.parse(this.responseText);
        document.getElementById("demo").innerHTML = myObj[2];
    }
};
xmlhttp.open("GET", "http://localhost:8080/CafedesPensees/API/ViewOrders", true);
xmlhttp.send();*/
var request = new XMLHttpRequest();
request.open('GET', 'http://localhost:8080/CafedesPensees/API/ViewOrders');
request.responseType = 'json'; // now we're getting a string!
request.send();

request.onload = function() {
  var Obj = request.response; // get the string from the response
    console.log(request.response);
    alert(Obj.Order.CustomerName);
//var superHeros = JSON.parse(superHeroesText);
  //var superHeroes = JSON.parse(superHeroesText); // convert it to an object
    console.log(Obj.Order.CustomerName);
    // var names = document.getElementById("demo");
            document.getElementById("demo").innerHTML =
Obj.Order.CustomerName + " " + Obj.Order.CustomerEmail;
            //var arrayLength = myObj.length;
            //for (var i = 0; i < arrayLength; i++) {
                //alert(myObj.CustomerName);
                //alert(myObj[i]);

                //var output = document.createElement("li");
                //output.innerHTML = myObj[i];
                //names.appendChild(output);
  //populateHeader(superHeroes);
  //showHeroes(superHeroes);
}