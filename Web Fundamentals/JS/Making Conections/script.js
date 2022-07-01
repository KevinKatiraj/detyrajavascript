console.log("page loaded...");

function changename(){
    document.getElementById("jane").innerHTML = "Kevin Katiraj";
}
var requestSpan = document.querySelector("#request")
var connectionSpan = document.querySelector("#connections")


function accept(id){
    var element = document.querySelector(id)
   element.remove();
    requestSpan.innerText--;
    connectionSpan.innerText++;
}

function abcd(id){
    var element = document.querySelector(id)
   element.remove();
   requestSpan.innerText--;
}