<div class="container my-5">
    <div class="row">

        <!-- izq -->
        <div class="col-sm my-1">
            <div class="h4 col-sm bg-dark p-3 text-light rounded">
                Buscar
            </div>
            <div class="col bg-gris text-light px-4 py-3 rounded    ">
                <div class="row mb-3">
                    Desde
                    <input class="w-100 p-1" type="date">
                </div>
                <div class="row">

                    Hasta
                    <input class="w-100 p-1" type="date">

                    <button type="button" class="btn btn-outline-light my-3">Buscar</button>
                    <a class="text-light" href="#">» Modificar / Cancelar una reserva</a>
                </div>
            </div>
        </div>

        <!-- cen -->

        <div class="col-sm-7 my-1">
            <div class="col-sm bg-dark h4 p-3 text-light rounded">
                Habitaciones
            </div>
            <div class="col bg-gris text-light p-3 mb-2 rounded">
                <div class="row">
                    <div class="col-5">
                        <img src="../img/goku-ssj-3.jpg" class="img-fluid w-100 rounded imgReserva" alt="Responsive image">
                    </div>
                    <div class="col contenedor">
                        <div>
                            <a href="#" style="color: white;">Classic Room</a>
                            <!--<div><span class="material-symbols-outlined cant-per">person</span><span class="material-symbols-outlined cant-per2">person</span></div>-->
                        </div>
                        <div class="linea-in my-1"></div>
                        <div class="my-2 ">
                            <span class="material-symbols-outlined icono-personalizado">contact_phone</span>
                            <span class="material-symbols-outlined icono-personalizado">tv</span>
                            <span class="material-symbols-outlined icono-personalizado">wifi</span>
                            <span class="material-symbols-outlined icono-personalizado">ac_unit</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">lock</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">hot_tub</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">local_bar</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">dry</span>

                        </div>
                    </div>
                    <div class="col-4">
                        <div class="d-flex justify-content-between">
                            <h6>Cantidad de personas</h6>
                            <div>
                                <select name="cantHabitaciones" id="opciones">
                                    <option value="0">0</option>
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                </select>
                            </div>
                        </div>
                        <p class="my-2 d-flex justify-content-between">Precio por la habitacion<abbr title="Este precio va cambiando segun la cantidad de personas que esten en la habitacion"><span class="material-symbols-outlined cant-per">info</span></abbr></p>
                        <br>
                        <div>
                            <h2 id="resultado">$0</h2>
                        </div>
                    </div>
                </div>
            </div>



            <div class="col bg-gris text-light p-3 mb-2 rounded">
                <div class="row">
                    <div class="col-5">
                        <img src="../img/goku-ssj-3.jpg" class="img-fluid w-100 rounded imgReserva" alt="Responsive image">
                    </div>
                    <div class="col contenedor">
                        <div>
                            <a href="#" style="color: white;">Classic Room</a>
                        </div>
                        <div class="linea-in my-1"></div>
                        <div class="my-2 ">
                            <span class="material-symbols-outlined icono-personalizado">contact_phone</span>
                            <span class="material-symbols-outlined icono-personalizado">tv</span>
                            <span class="material-symbols-outlined icono-personalizado">wifi</span>
                            <span class="material-symbols-outlined icono-personalizado">ac_unit</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">lock</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">hot_tub</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">local_bar</span>
                            <span class="material-symbols-outlined icono-personalizado my-2">dry</span>

                        </div>
                    </div>
                    <div class="col-4">
                        <div class="d-flex justify-content-between">
                            <h6>Cantidad de personas</h6>
                            <div>
                                <select name="cantHabitaciones" id="opciones2">
                                    <option value="0">0</option>
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                </select>
                            </div>
                        </div>
                        <p class="my-2 d-flex justify-content-between">Precio por la habitacion<abbr title="Este precio va cambiando segun la cantidad de personas que esten en la habitacion"><span class="material-symbols-outlined cant-per">info</span></abbr></p>
                        <br>
                        <div>
                            <h2 id="resultado2">$0</h2>
                        </div>
                    </div>
                </div>
            </div>


        </div>

        <!-- der -->

        <div class="col-sm my-1">
            <div class="col-sm bg-dark h4 p-3 text-light rounded">
                <H4>PRECIO TOTAL</H4>
                <div class="linea-in my-1"></div>
                <div>
                    <H4 id="resultado_final" class="my-4">$0</H4>
                </div>
            </div>
            <button class="btn btn-dark " type="button" aria-expanded="false">
                RESERVA AHORA
            </button>
        </div>



    </div>
</div>

<script>
    var select = document.getElementById('opciones');
    var divResultado = document.getElementById('resultado');
    var select2 = document.getElementById('opciones2');
    var divResultado2 = document.getElementById('resultado2');
    var divResultado_final = document.getElementById('resultado_final');

    select.addEventListener('click', function() {

        var selectValue = select.value;
        divResultado.textContent = '$' + (selectValue * 10000);
        suma();
    });

    select2.addEventListener('click', function() {
        var select2Value = select2.value;
        divResultado2.textContent = '$' + (select2Value * 10000);
        suma();
    });



    function suma() {
        var suma = parseInt((divResultado.textContent).replace("$", "")) + parseInt((divResultado2.textContent).replace("$", ""));

        resultado_final.textContent = "$" + suma;
    }





    /*
        function calcularSuma() {
                
                const select1 = document.getElementById('opciones');
                const select2 = document.getElementById('opciones2');
                const valor1 = parseInt(opciones.value);
                const valor2 = parseInt(opciones2.value);
                const suma = valor1 + valor2;
                const Resultado_finalElement = document.getElementById('resultado_final');
                resuldato_final.textContent = suma;
            }
            */
</script>