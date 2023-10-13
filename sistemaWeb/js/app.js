var reservasNav = document.getElementById("nav-res");
var reservasDefaultOp = reservasNav.innerHTML;

function selectedRooms(){
    document.getElementById("reservaType").innerHTML = "HABITACIONES";
    
    let roomsHtml = '';
    roomsHtml += '<input type="hidden" name="type" value="habitaciones">'
    roomsHtml += '<li class="nav-item px-2 my-1">';
    roomsHtml += '<input type="date" name="in" class="border-0 px-2" ';
    roomsHtml += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    roomsHtml += '</li>';
    roomsHtml += '<li class="nav-item px-2 my-1">';
    roomsHtml += '<input type="date" name="out" class="border-0 px-2" ';
    roomsHtml += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    roomsHtml += '</li>';
        
    document.getElementById("dateInputs").innerHTML = roomsHtml;
    reservasNav.innerHTML = document.getElementById("reservasOp").innerHTML;
}

function selectedEvents(){
    document.getElementById("reservaType").innerHTML = "SALON DE EVENTOS";

    let eventosHtml = '';
    eventosHtml += '<input type="hidden" name="type" value="eventos">'
    eventosHtml += '<li class="nav-item px-2 my-1">';
    eventosHtml += '<input type="date" name="inDate" class="border-0 px-2"';
    eventosHtml += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    eventosHtml += '</li>';
    eventosHtml += '<li class="nav-item px-2 my-1">'
    eventosHtml += '<input type="time" name="inHour" class="border-0 px-2"'
    eventosHtml += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">'
    eventosHtml += '</li>'
    eventosHtml += '<li class="nav-item px-2 my-1">';   
    eventosHtml += '<input type="time" name="outHour" class="border-0 px-2"'; 
    eventosHtml += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">'; 
    eventosHtml += '</li>'; 

    document.getElementById("dateInputs").innerHTML = eventosHtml;
    reservasNav.innerHTML = document.getElementById("reservasOp").innerHTML;
}

function back(){
    reservasNav.innerHTML = reservasDefaultOp;
}

function verifData(form){
console.log(form);
    if(form.elements.type.value == "habitaciones"){
        let checkIn = new Date(form.elements.in.value.replace("-", "/"));
        let checkOut = new Date(form.elements.out.value.replace("-", "/"));
        let currentDate = new Date().setHours(0,0,0,0);

        if(checkIn == "Invalid Date" || checkOut == "Invalid Date"){
            alert("Ingese las fechas");
            return false;
        }

        if(checkIn < currentDate){
            alert("La fecha de entrada debe ser mayor o igual a la fecha actual");
            return false;
        }

        if(checkIn >= checkOut){
            alert("La fecha de entrada no puede ser mayor o igual a la fecha de salida");
            return false;
        }
        console.log(checkIn, checkOut, form.elements.in.value, form.elements.out.value);

        form.submit();
    }
}

