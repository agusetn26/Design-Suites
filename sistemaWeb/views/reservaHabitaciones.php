<div class="row">
    <!-- izq -->
    <div class="col-md-3 my-1">
        <div class="h4 col-sm bg-dark p-3 text-light rounded">
            Buscar
        </div>
        <div class="col bg-gris text-light px-4 py-3 rounded    ">
            <form action="?sec=reservas" method="POST" class="d-flex flex-wrap justify-content-center align-items-center" onsubmit="return verifData(this);">
                <div class="row w-100 mb-3">
                    Desde
                    <input class="w-100 p-1" type="date" name="in" value="<?php echo $checkIn ?>" id="checkIn">
                </div>
                <div class="row w-100 text-center">
                    Hasta
                    <input class="w-100 p-1" type="date" name="out" value="<?php echo $checkOut ?>" id="checkOut">

                    <input type="hidden" name="type" value="habitaciones">
                    <input type="hidden" name="hotel" value="<?php echo $hotel ?>">

                    <input type="submit" class="btn btn-outline-light my-3" value="Buscar">
                    <a class="text-light" href="?sec=cancelar-reserva">» Cancelar una reserva »</a>
                </div>
            </form>
        </div>
    </div>

    <!-- cen -->

    <div class="col-md-6 my-1">
        <div class="col-sm bg-dark h4 p-3 text-light rounded">
            Habitaciones
        </div>
        <?php
        if (sqlsrv_has_rows($qryRooms) == 0) {
            echo '<div class="fs-1 fw-bold text-center my-5">No se encontraron habitaciones disponibles para las fechas ingresadas</div>';
        } 
        else {
            //while ($room = sqlsrv_fetch_array($qryRooms, SQLSRV_FETCH_ASSOC)) {
        ?>
        <div id="roomsPaginator">

        </div>
                <div class="col bg-gris text-light p-3 mb-2 rounded rectangulo border border-2" id="room-<?php echo $room['id_habitacion'] ?>">
                    <div class="row">
                        <div class="col-lg-6">
                            <a href="?sec=habitaciones&idHab=1&idH=1">
                                <img src="../img/habitaciones/<?php echo basename(dirname($room['imagenes'])) . "/" . basename($room['imagenes']) ?>" class="img-fluid w-100 rounded imgReserva" alt="Responsive image">
                            </a>
                        </div>
                        <div class="col-lg-6 contenedor">
                            <div class="d-flex justify-content-between mt-1">
                                <a href="#" class="text-white" id="roomType"><?php echo $room['nombre']?></a>
                                <!--<abbr title="Para seleccionar el hotel cambie la cantidad de personas"><span class="material-symbols-outlined cant-per">info</span></abbr>
                                <div><span class="material-symbols-outlined cant-per">person</span><span class="material-symbols-outlined cant-per2">person</span></div>-->
                            </div>
                            <div class="linea-in my-1"></div>
                            <div class="my-2 ">
                                <!-- Modal -->
                                <button type="button" class="btn btn-dark" data-bs-toggle="modal" data-bs-target="#staticBackdrop-<?php echo $room['id_habitacion'] ?>">
                                    Informacion de la Habitacion
                                </button>
                                <div class="modal fade" id="staticBackdrop-<?php echo $room['id_habitacion'] ?>" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                                    <div class="modal-dialog modal-xl">
                                        <div class="modal-content bg-dark">
                                            <div class="modal-header bg-success">
                                                <h5 class="modal-title" id="staticBackdropLabel">Servicios de la Habitacion</h5>
                                                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                            </div>
                                            <div class="modal-body">
                                                <div class="row">
                                                    <div class="col-lg-6">
                                                        <a href="?sec=habitaciones&idHab=1&idH=1">
                                                            <img src="../img/habitaciones/<?php echo basename(dirname($room['imagenes'])) . "/" . basename($room['imagenes']) ?>" class="img-fluid w-100 rounded imgReserva" alt="Responsive image">
                                                        </a>
                                                    </div>
                                                    <div class="col-lg-6">
                                                        <?php
                                                            echo $room['descripcion'] . '<br>Precio por la Habitacion:&nbsp;' . $room['costo'] . 
                                                            '<br>Ocupación máxima:&nbsp;' . $room['ocupacion'] . '<br>Dimensiones:&nbsp;' . $room['dimensiones'];
                                                        ?>                                                        
                                                        <div class="linea-in my-2"></div>
                                                        Esto incluye:
                                                        <div class="d-flex"> 
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2">tv</span></p>
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2">contact_phone</span></p>
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2">wifi</span></p>
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2">ac_unit</span></p>
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2 ">lock</span></p>
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2 ">hot_tub</span></p>
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2 ">local_bar</span></p>
                                                            <p class="my-2 align-items-center"><span class="material-symbols-outlined icono-personalizado2 ">dry</span></p>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="my-3"></div>

                            <div>
                                <div class="d-flex align-items-center justify-content-between">
                                    <h6>Cant. de personas</h6><abbr class="derecha" title="Para seleccionar el hotel cambie la cantidad de personas">
                                        <span class="material-symbols-outlined cant-per">info</span></abbr>
                                </div>
                                <div class="linea-in2"></div>
                                <div class="d-flex my-2 align-items-center justify-content-between">
                                    <select id="opciones" oninput="roomPersons('<?php echo $room['id_habitacion'] ?>');">
                                        <?php
                                        for ($i = 0; $i < ($room['ocupacion'] + 1); $i++) {
                                            echo '<option value=' . $i . '>' . $i . '</option>';
                                        }
                                        ?>
                                    </select>

                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="d-flex align-items-center">
                                <p class="my-2 justify-content-between">Precio por la habitacion</p>
                                <div class="precio-chamba">
                                    <h2 id="costoRoom">$<?php echo number_format($room['costo'], 2)?></h2>
                                    <p id="AcostoRoom" class="d-none"><?php echo $room['costo']?></p>
                                    <p id="currentValue" class="d-none">0</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
        <?php //}
        } ?>
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
        <button class="btn btn-dark " type="button" aria-expanded="false" onclick="submitRooms(this);">
            RESERVA AHORA
        </button>
    </div>
</div>