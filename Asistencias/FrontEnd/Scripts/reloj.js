
function currentTime(){
    let date = new Date();
    let ndd= date.getDate();
    let mdd= date.getMonth();
    let anio =date.getFullYear();
    let dd= date.getDay();
    let nombre = new String();
    let Mes = new String();
    let hh = date.getHours();
    let mm = date.getMinutes();
    let ss = date.getSeconds();
//    let session = "AM";

//    if(hh==0){
//        hh = 24;
//    }
    if(hh > 12){
        //hh = hh - 24;
        //session = "PM";
    }
    switch(dd){
        case 1: nombre="Lunes"
        break;
        case 2: nombre="Martes"
        break;
        case 3: nombre="Miercoles"
        break;
        case 4: nombre="Jueves"
        break;
        case 5: nombre="Viernes"
        break;
        case 6: nombre="Sabado"
        break;
        case 0: nombre="Domingo"
        break;
        default: nombre="Error"
        break;
    }
    switch(mdd){
        case 0: Mes="Enero"
        break;
        case 1: Mes="Febrero"
        break;
        case 2: Mes="Marzo"
        break;
        case 3: Mes="Abril"
        break;
        case 4: Mes="Mayo"
        break;
        case 5: Mes="Junio"
        break;
        case 6: Mes="Julio"
        break;
        case 7: Mes="Agosto"
        break;
        case 8: Mes="Septiembre"
        break;
        case 9: Mes="Octubre"
        break;
        case 10: Mes="Nomviembre"
        break;
        case 11: Mes="Diciembre"
        break;
        default: Mes="Error"
        break;
    }
        
   hh = (hh<10) ? "0" + hh : hh;
   mm = (mm<10) ? "0" + mm : mm;
   ss = (ss<10) ? "0" + ss : ss;

   let time = nombre + ", "+ ndd+ " "+ " de "+Mes+ " de "+ anio + " \n "+hh + ":" + mm + ":" + ss + " "  ;//+ session

   document.getElementById("clock").innerText = time;
   let t = setTimeout(function(){
    currentTime() }, 1000)
}
currentTime();
/*var timeDisplay = document.getElementById("time");


function refreshTime() {
  var dateString = new Date().toLocaleString("en-US", {timeZone: "America/Sao_Paulo"});
  var formattedString = dateString.replace(", ", " - ");
  timeDisplay.innerHTML = formattedString;
}

setInterval(refreshTime, 1000);
/*const $tiempo=document.querySelector('.tiempo'),
$fecha=document-querySelector('.fecha');

function Relojdigital(){
    let f = new Date(),
    dia = f.getDate(),
    mes = f.getMonth(),
    anio = f.getFullYear(),
    diaSemana = f.getDay();

    dia = ('0'+dia).slice(-2);
    mes = ('0'+mes).slice(-2) 

    let timeString= f.toLocaleTimeString();
    $tiempo.innerHTML=timeString;

    let semana=['DOMINGO','LUNES','MARTES','MIERCOLES','JUEVES','VIERNES','SABADO'];
    let showSemana= (semana[diaSemana])
    $fecha.innerHTML = `${showSemana} ${dia}-${mes}-${anio}`
    
}
setInterval(() =>{
    Relojdigital()
},1000);






<div class="reloj">
<p class="fecha"></p>
<p class="tiempo"></p>
</div>
<script >function Relojdigital(){
let f = new Date(),
dia = f.getDate(),
mes = f.getMonth(),
anio = f.getFullYear(),
diaSemana = f.getDay();
var $tiempo=0;
var $fecha=0;
dia = ('0'+dia).slice(-2);
mes = ('0'+mes).slice(-2); 

let timeString= f.toLocaleTimeString();
$tiempo.innerHTML=timeString;

let semana=['DOMINGO','LUNES','MARTES','MIERCOLES','JUEVES','VIERNES','SABADO'];
let showSemana= (semana[diaSemana])
$fecha.innerHTML = `${showSemana} ${dia}-${mes}-${anio}`

}
setInterval(() =>{
Relojdigital()
},1000);</script>*/