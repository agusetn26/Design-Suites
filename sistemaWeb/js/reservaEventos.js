    let loadingScreen = document.getElementById("loadingScreen");
    let seleccionadas = [];
    let pagoTotal = 0;

    let inDate = document.getElementById("inDate").value;
    let currentCheckIn = document.getElementById("checkIn").value;
    let currentCheckOut = document.getElementById("checkOut").value;

    function selectEvent(id, button){
        let evento = document.querySelector("#event-"+id);
        let precioEvento = parseInt(evento.querySelector("#costoEvento").innerHTML.split("$")[1]);
        let rFinal = document.querySelector("#resultado_final");

        let index = seleccionadas.indexOf(id);
        if(index != -1){
            //  Se borra el id de habitacion del arreglo si existe
            seleccionadas.splice(index, 1);
            pagoTotal = pagoTotal - precioEvento;
            evento.classList.toggle("bg-warning");
            button.classList.toggle("btn-light");
            button.classList.toggle("btn-danger");
            button.innerHTML = '<span class="material-symbols-outlined">check_circle</span>';

        } else{
            seleccionadas.push(id);
            pagoTotal = pagoTotal + precioEvento;
            evento.classList.toggle("bg-warning");
            button.classList.toggle("btn-light");
            button.classList.toggle("btn-danger");
            button.innerHTML = '<span class="material-symbols-outlined">cancel</span>';
        }

        rFinal.innerHTML = "$"+pagoTotal;
    }

    let eventos = [];

    function submitEventos(){
        if(seleccionadas.length == 0){
            alert("Seleccione al menos un evento");
            return;
        }
        showLoadingScreen();
        
        for(let i=0; i<seleccionadas.length; i++){
            let nombre = document.querySelector("#event-"+seleccionadas[i]+" #eventType").innerHTML;
            let id = seleccionadas[i];
            let coste = parseInt(document.querySelector("#event-"+seleccionadas[i]+" #costoEvento").innerHTML.split("$")[1]);
            let img = document.querySelector("#event-"+seleccionadas[i]+" img").src;
            let arrData = {'tipo': nombre, 'id': id, 'costo': coste, 'img': img};
            eventos.push(arrData);
        }

        if(eventos.length > 0){
            let xhr = new XMLHttpRequest();

            xhr.open("GET", "views/pagos.php", true);

            // xhr.responseType = 'text'; Default text

            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 ){

                    if (xhr.status === 200) {
                        let pagos = xhr.response;
                        document.getElementById("reservasBuilder").innerHTML = pagos;
                        addReservas();
                        
                    } else{
                        alert("Error de conexión, intentelo más tarde. Estado: " + xhr.status);
                    }
                }
            };

            xhr.send();

        }
        
    }

    function addReservas(){
        let reserva = "";
        for(let i=0; i<eventos.length; i++){
            
            reserva += '<div class="row bg-dark text-center w-100 m-auto my-2" id="reservaH">';
                //reserva +=  '<img class="col-sm-6 p-0" src="'+eventos[i].img+'" alt="Card image cap">';
                reserva +=  '<img class="col-sm-6 p-0" src="../img/salon2.jpg" alt="Card image cap">';
                reserva +=  '<div class="col-sm-6 d-flex flex-column text-white text-center p-5">';
                    reserva +=      '<h5 class="fs-4"> <b>'+eventos[i].tipo+'</b> <div class="linea-in my-1"></div> </h5> ';
                    reserva +=      '<div class="fs-3 text-center p-3">$';
                        reserva +=      eventos[i].costo;
                    reserva +=      '</div>'
                reserva += '</div>';
            reserva += '</div>';
        }
        document.getElementById("pagosCheckIn").innerHTML = inDate + " " + currentCheckIn;
        document.getElementById("pagosCheckOut").innerHTML = inDate + " " + currentCheckOut;
        document.getElementById("pagosContenedor").innerHTML = reserva;
        document.getElementById("pagosTotalesReserva").innerHTML = "$"+pagoTotal;
        hideLoadingScreen();
    }

    function submitPago(form){
        showLoadingScreen();

        document.getElementById("inDateValue").value = inDate;
        document.getElementById("checkInValue").value = currentCheckIn;
        document.getElementById("checkOutValue").value = currentCheckOut;
        document.querySelector("#reservasStr").value = JSON.stringify(eventos);

        let formData = new FormData(form);

        let xhr = new XMLHttpRequest();

        xhr.open("POST", "modelos/pagosEventos.php", true);

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