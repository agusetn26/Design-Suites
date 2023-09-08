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
                        <div class="d-flex">
                            <h6>Cantidad de personas</h6>
                            <select name="cantHabitaciones">
                                <option value="0">0</option>
                                <option value="1">1</option>
                                <option value="2">2</option>
                                <option value="3">3</option>
                            </select>
                        </div>
                        <p class="my-2 d-flex">Precio por la habitacion<abbr title="Este precio va cambiando segun la cantidad de personas que esten en la habitacion"><span class="material-symbols-outlined cant-per">info</span></abbr></p>
                        <br>
                        <h2>$50000</h2>
                    </div>
                </div>
            </div>



            <div class="col bg-gris text-light p-3 mb-2 rounded">
                <img src="../img/goku-ssj-3.jpg" class="img-fluid w-40 rounded imgReserva" alt="Responsive image">
            </div>

        </div>

        <!-- der -->

        <div class="col-sm my-1">
            <div class="col-sm bg-dark h4 p-3 text-light rounded">
                <H4>PRECIO TOTAL</H4>
                <div class="linea-in my-1"></div>
                <H4 class="my-4">$50000</H4>
            </div>
        </div>
    </div>
</div>