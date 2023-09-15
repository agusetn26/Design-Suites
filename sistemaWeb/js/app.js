var reservasNav = document.getElementById("nav-res");
var reservasContentDefault = reservasNav.innerHTML;
console.log(reservasNav);

function selectedRooms(){
    var roomsHTML = "";

    roomsHTML += '<li class="nav-item px-5 my-1">';
        roomsHTML += '<div class="d-flex gap-2 align-items-center">';
            roomsHTML += '<span class="material-symbols-outlined" onclick="back()" style="color: white; cursor: pointer;">reply</span>';
            roomsHTML += '<a class="nav-link active text-center" style="font-weight: 700;" aria-current="page">HABITACIONES</a>';
        roomsHTML += '</div>';
    roomsHTML += '</li>';
    roomsHTML += '<li class="nav-item px-2 my-1">';
        roomsHTML += '<select class="form-select" style="width: 260px; height: 30px; line-height: 14px;">';
            roomsHTML += '<option selected>Seleccione el hotel</option>';
            roomsHTML += '<option value="1">Buenos Aires</option>';
            roomsHTML += '<option value="2">Bariloche</option>';
            roomsHTML += '<option value="3">Calafate</option>';
            roomsHTML += '<option value="4">Salta</option>';
        roomsHTML += '</select>';
    roomsHTML += '</li>';
    roomsHTML += '<li class="nav-item px-2 my-1">';
        roomsHTML += '<input type="date" name="data" class="border-0 px-2"';
            roomsHTML += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    roomsHTML += '</li>';
    roomsHTML += '<li class="nav-item px-2 my-1">';
        roomsHTML += '<input type="date" name="data" class="border-0 px-2"';
            roomsHTML += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    roomsHTML += '</li>';
    roomsHTML += '<li class="nav-item px-2 my-1">';
        roomsHTML += '<a class="nav-link active bg-light text-dark rounded text-center"';
            roomsHTML += 'style="width: 130px; line-height: 14px; font-weight: 700;" href="#" aria-current="page">RESERVAR</a>';
    roomsHTML += '</li>';

    reservasNav.innerHTML = roomsHTML;
}

function selectedEvents(){
    var eventsHTML = '';

    eventsHTML += '<li class="nav-item px-5 my-1">';
        eventsHTML += '<div class="d-flex gap-2 align-items-center">';
            eventsHTML += '<span class="material-symbols-outlined" onclick="back()" style="color: white; cursor: pointer;">reply</span>';
            eventsHTML += '<a class="nav-link active text-center" style="font-weight: 700;" aria-current="page">SALA DE EVENTOS</a>';
        eventsHTML += '</div>';
    eventsHTML += '</li>';
    eventsHTML += '<li class="nav-item px-2 my-1">';
        eventsHTML += '<select class="form-select" style="width: 260px; height: 30px; line-height: 14px;">';
            eventsHTML += '<option selected>Seleccione el hotel</option>';
            eventsHTML += '<option value="1">Buenos Aires</option>';
            eventsHTML += '<option value="2">Bariloche</option>';
            eventsHTML += '<option value="3">Calafate</option>';
            eventsHTML += '<option value="4">Salta</option>';
        eventsHTML += '</select>';
    eventsHTML += '</li>';
    eventsHTML += '<li class="nav-item px-2 my-1">';
        eventsHTML += '<input type="date" name="data" class="border-0 px-2"';
            eventsHTML += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    eventsHTML += '</li>';
    eventsHTML += '<li class="nav-item px-2 my-1">';
        eventsHTML += '<input type="time" name="data" class="border-0 px-2"';
            eventsHTML += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    eventsHTML += '</li>';
    eventsHTML += '<li class="nav-item px-2 my-1">';
        eventsHTML += '<input type="time" name="data" class="border-0 px-2"';
            eventsHTML += 'style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">';
    eventsHTML += '</li>';
    eventsHTML += '<li class="nav-item px-2 my-1">';
        eventsHTML += '<a class="nav-link active bg-light text-dark rounded text-center"';
            eventsHTML += 'style="width: 130px; line-height: 14px; font-weight: 700;" href="#" aria-current="page">RESERVAR</a>';
    eventsHTML += '</li>';

    reservasNav.innerHTML = eventsHTML;
}

function back(){
    reservasNav.innerHTML = reservasContentDefault;
}