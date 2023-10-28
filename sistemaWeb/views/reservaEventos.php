<div class="row">
        <!-- izq -->
        <div class="col-md-3 my-1">
            <div class="h4 col-sm bg-dark p-3 text-light rounded">
                Buscar
            </div>
            <div class="col bg-gris text-light px-4 py-3 rounded    ">
                <form action="?sec=reservas" method="POST" class="d-flex flex-wrap justify-content-center align-items-center" onsubmit="return verifData(this);">
                    <div class="row w-100 mb-3">
                        Día
                        <input type="date" name="inDate" class="border-0 p-1" value="<?php echo $inDate?>" id="inDate">
                    </div>
                    <div class="row w-100 mb-3">
                        Desde
                        <input class="w-100 p-1" type="time" name="inHour" value="<?php echo $checkIn?>" id="checkIn">
                    </div>
                    <div class="row w-100 text-center">
                        Hasta
                        <input class="w-100 p-1" type="time" name="outHour" value="<?php echo $checkOut?>" id="checkOut">

                        <input type="hidden" name="type" value="eventos">
                        <input type="hidden" name="hotel" value="<?php echo $hotel?>">

                        <input type="submit" class="btn btn-outline-light my-3" value="Buscar">
                        <a class="text-light" href="#">» Modificar / Cancelar una reserva</a>
                    </div>
                </form>
            </div>
        </div>

        <!-- cen -->

        <div class="col-md-6 my-1">
            <div class="col-sm bg-dark h4 p-3 text-light rounded">
                Eventos
            </div>
                <?php
                    if(sqlsrv_has_rows($qryEvents) == 0){
                        echo '<div class="fs-1 fw-bold text-center my-5">No se encontraron eventos disponibles para el horario ingresado</div>';
                    } else {  
                    while($event = sqlsrv_fetch_array($qryEvents, SQLSRV_FETCH_ASSOC)) {
                ?>
                    <div class="eventRow row bg-gris text-light p-3 mb-2 rounded" id="event-<?php echo $event['id_evento']?>">
                            <div class="col-lg-5">
                                <img src="../<?php echo $event['imagen']?>" class="img-fluid w-100 rounded imgReserva" alt="Responsive image">
                            </div>
                            <div class="col-lg-7 contenedor">
                                <div class="d-flex justify-content-between mt-1">
                                    <a href="#" class="text-white" id="eventType"><?php echo $event['nombre'] ?></a>
                                    <abbr title="Para seleccionar el evento presione la tarjeta"><span class="material-symbols-outlined cant-per">info</span></abbr>
                                    <!--<div><span class="material-symbols-outlined cant-per">person</span><span class="material-symbols-outlined cant-per2">person</span></div>-->
                                </div>
                                <div class="linea-in my-1"></div>
                                <div class="row d-flex align-items-center">
                                    <div class="col-lg-6 my-2">
                                        <span class="material-symbols-outlined icono-personalizado">contact_phone</span>
                                        <span class="material-symbols-outlined icono-personalizado">tv</span>
                                        <span class="material-symbols-outlined icono-personalizado">wifi</span>
                                        <span class="material-symbols-outlined icono-personalizado">ac_unit</span>
                                        <span class="material-symbols-outlined icono-personalizado my-2">lock</span>
                                        <span class="material-symbols-outlined icono-personalizado my-2">hot_tub</span>
                                        <span class="material-symbols-outlined icono-personalizado my-2">local_bar</span>
                                        <span class="material-symbols-outlined icono-personalizado my-2">dry</span>
                                    </div>
                                    <div class="col-lg-6 flex-grow" id="contPrecio">
                                        <div class="border text-center fs-5 my-2 px-2">
                                            Precio:
                                            <span class="fs-3" id="costoEvento">$<?php echo number_format($event['precio'], 2); //money_format, floatval(no recomendado)?></span>
                                        </div>
                                        
                                        <button class="d-flex justify-content-center align-items-center text-center btn btn-light w-100 py-1" onclick="selectEvent(<?php echo $event['id_evento']?>, this);" title="Seleccione u omita la seleccion de un evento haciendo clic">
                                            <span class="material-symbols-outlined">check_circle</span>
                                        </button>         
                                    </div>
                                </div>
                            </div>
                    </div>
                <?php } } ?>
        </div>

        <!-- der -->

        <div class="col-md-3 my-1">
            <div class="col-sm bg-dark h4 p-3 text-light rounded">
                <H4>PRECIO TOTAL</H4>
                <div class="linea-in my-1"></div>
                <div>
                    <H4 id="resultado_final" class="my-4">0</H4>
                </div>
            </div>
            <button class="btn btn-dark " type="button" aria-expanded="false" onclick="submitEventos(this);">
                RESERVA AHORA
            </button>
        </div>
</div>