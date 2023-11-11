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
    }
    else{
        let inDate = new Date(form.elements.inDate.value.replace("-", "/"));
        let checkIn = form.elements.inHour.value;
        let checkOut = form.elements.outHour.value;
        let currentDate = new Date();
            
        if (inDate == "Invalid Date" || !checkIn || !checkOut) {
            alert("Ingrese las fechas y horas");
            return false;
        }
        
        inDate.setHours(checkIn.split(":")[0]);
        inDate.setMinutes(checkIn.split(":")[1]);

        if (inDate < currentDate) {
            alert("La fecha y hora de entrada deben ser mayores o iguales a la fecha y hora actuales");
            return false;
        }
        
        let outDate = new Date(inDate);
        outDate.setHours(checkOut.split(":")[0]);
        outDate.setMinutes(checkOut.split(":")[1]);

        if (inDate >= outDate) {
            alert("La hora de entrada no puede ser mayor o igual a la hora de salida");
            return false;
        }
    }

    form.submit();
}

function cancelar_reserva(){
    let xhr = new XMLHttpRequest();
    let codigo = document.getElementById('input-codigo').value;

    if(codigo == ""){
        alert("Rellene el campo correctamente");
        return;
    }

    xhr.open("GET", "modelos/cancelar-reserva.php?input-codigo=" + codigo, true);
console.log(codigo);
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4){
            console.log(xhr.status);

            if(xhr.status === 200) {
                let respuesta = xhr.response;
                
                console.log(respuesta);

                alert(respuesta);
            } else{
                alert("Error de conexión, intentelo más tarde. Estado: " + xhr.status);
            }
        } 
    }

    xhr.send();
}