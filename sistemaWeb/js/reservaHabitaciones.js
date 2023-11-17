    let loadingScreen = document.getElementById("loadingScreen");
    let seleccionadas = [];
    let pagoTotal = 0;
    let roomsAmount = 2;
    loadRooms(roomsAmount);

    function roomPersons(id){

        let index = seleccionadas.indexOf(id);
        let room = document.querySelector("#room-"+id);
        let cantPersonas = room.querySelector("#opciones").value;

        if(index != -1){
            //  Se borra el id de habitacion del arreglo si ya existe
            seleccionadas.splice(index, 1);    
            roomUnFocus(id);  
        }

        if(cantPersonas != 0 ) {   
            seleccionadas.push(id);
            roomFocus(id);
        } 
        console.log(room.querySelector("#costoRoom").innerHTML.split("$"));

        let costo = parseFloat(room.querySelector("#AcostoRoom").innerHTML);
        let valorActual = costo * cantPersonas;

        room.querySelector("#currentValue").innerHTML = valorActual;
        costeTotal();    
    }

    function roomFocus(id) {
        updateRoomBorder(id, true);
    }
      
    function roomUnFocus(id) {
      updateRoomBorder(id, false);
    }
    
    function updateRoomBorder(id, isFocused) {
      const rectangulo = document.querySelector('#room-' + id);
      rectangulo.classList.toggle("border-warning", isFocused);
    }
    //const select = document.getElementById('opciones');
    //const rectangulo = document.querySelector('.rectangulo')

    


    function costeTotal(){
        let finalR = document.getElementById("resultado_final");
        let total = 0;
        let rooms = document.querySelectorAll("#currentValue");
        Array.from(rooms).forEach(function(room){
            total = total + parseFloat(room.innerHTML);
        })

        finalR.innerHTML = "$"+total;
        pagoTotal = total;
    }

    let roomsData = [];

    function submitRooms(submit){
        submit.disabled = true;
        
        if(seleccionadas.length == 0){                    
            alert("Seleccione al menos una habitación para reservar");
            submit.disabled = false;

            return;
        }

        showLoadingScreen();

        for(let i=0; i<seleccionadas.length; i++){
            let nombre = document.querySelector("#room-"+seleccionadas[i]+" #roomType").innerHTML;
            let personas = document.querySelector("#room-"+seleccionadas[i]+" #opciones").value;
            let coste = document.querySelector("#room-"+seleccionadas[i]+" #costoRoom").innerHTML;
            let img = document.querySelector("#room-"+seleccionadas[i]+" img").src;
            let arrData = {'tipo': nombre, 'personas': personas, 'costo': coste, 'id': seleccionadas[i], 'img': img};
            roomsData.push(arrData);
        }

        if(roomsData.length > 0){
            let xhr = new XMLHttpRequest();

            xhr.open("GET", "views/pagos.php", true);

            // xhr.responseType = 'text'; Default text

            xhr.onreadystatechange = function () {
              
                if (xhr.readyState === 4 ){

                    hideLoadingScreen();

                    if (xhr.status === 200) {
                        let pagos = xhr.response;
                        document.getElementById("reservasBuilder").innerHTML = pagos;
                        submit.disabled = false;

                        addReservas();
                    } else{
                        alert("Error de conexión, intentelo más tarde. Estado: " + xhr.status);
                    }
                }
            };

            xhr.send();

        }
    }

    let currentCheckIn = document.getElementById("checkIn").value;
    let currentCheckOut = document.getElementById("checkOut").value;
    

    //$(document.createElement("div")).addClass("row bg-dark").append($(document.createElement("img")))
    function addReservas(){
        let reserva = "";
        for(let i=0; i<roomsData.length; i++){
            reserva += '<div class="row bg-dark text-center w-100 m-auto my-2" id="reservaH">';
                reserva +=  '<img class="col-sm-6 p-0" src="'+ roomsData[i]['img'] +'" alt="Card image cap">';
                reserva +=  '<div class="col-sm-6 d-flex flex-column text-white text-center p-1">';
                    reserva +=      '<h5 class="card-title fs-2"> <b>'+roomsData[i]['tipo']+'</b> </h5>';
                    reserva +=      '<hr class="m-0">';
                    reserva +=     '<div class="row d-flex align-items-center fs-3 w-100 h-100 p-0 m-auto">';
                        reserva +=     '<div class="col-lg-6 p-0" title="Cantidad de personas">';
                        reserva +=       roomsData[i]['personas'];
                        reserva +=     '<span class="material-symbols-outlined cant-per2">person</span><span class="material-symbols-outlined cant-per2">person</span>';
                    reserva +=      '</div>';
                    reserva +=      '<div class="col-lg-6 fs-2 p-0">';
                        reserva +=      roomsData[i]['costo'];
                    reserva +=      '</div>';
                    reserva +=    '</div>';
                reserva += '</div>';
            reserva += '</div>';
        }
        document.getElementById("pagosCheckIn").innerHTML = currentCheckIn;
        document.getElementById("pagosCheckOut").innerHTML = currentCheckOut;
        document.getElementById("pagosContenedor").innerHTML = reserva;
        document.getElementById("pagosTotalesReserva").innerHTML = "$"+pagoTotal;
    }

    function submitPago(form){
        showLoadingScreen();

        let checkInValue = document.getElementById("pagosCheckIn").textContent;
        let checkOutValue = document.getElementById("pagosCheckOut").textContent;

        document.getElementById("checkInValue").value = checkInValue;
        document.getElementById("checkOutValue").value = checkOutValue;
        document.querySelector("#reservasStr").value = JSON.stringify(roomsData);

        let formData = new FormData(form);

        let xhr = new XMLHttpRequest();

        xhr.open("POST", "modelos/pagos.php", true);

        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4){

                hideLoadingScreen();  
                console.log(xhr.response);

                if(xhr.status === 200) {
                    document.getElementById("hashCode").value = xhr.response;
                    form.submit();

                } else{
                    alert("Error de conexión, intentelo más tarde. Estado: " + xhr.status);
                }
                
            }
        };

        xhr.send(formData);

        return false;
    }

    function loadRooms(amount){
        let xhr = new XMLHttpRequest();
        xhr.open("POST", "modelos/paginadorRooms.php", true);
        
        xhr.onreadystatechange = function (){
            if (xhr.readyState == 4){
                if (xhr.status == 200){
                    document.getElementById("roomsPaginator").innerHTML = xhr.response;
                    roomsAmount += 2;
                } else {
                    alert("Error de conexión, intentelo más tarde. Estado: " + xhr.status);
                }
            }
        }

        xhr.send("rooms="+amount);
    }

    function showLoadingScreen() {
        loadingScreen.style.display = "flex";
        setTimeout(function () {
          loadingScreen.style.opacity = 0.7;
        }, 1); 
      }
      
      
    function hideLoadingScreen() {
      loadingScreen.style.opacity = 0;
      setTimeout(function () {
        loadingScreen.style.display = "none";
      }, 300);
    }