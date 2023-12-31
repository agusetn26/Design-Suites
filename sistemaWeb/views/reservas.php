<?php
    date_default_timezone_set("America/Argentina/Buenos_Aires");
    //echo  date_default_timezone_get();

    $hotel = $_POST['hotel'];
    	
    $currentDate = date("Y-m-d");
    $checkIn = $_POST['in'];
    $checkOut = $_POST['out'];

    if (!preg_match("/^\d{4}-\d{2}-\d{2}$/", $checkIn) || !preg_match("/^\d{4}-\d{2}-\d{2}$/", $checkOut)) {
        echo "Ingrese las fechas en formato yyyy-mm-dd";
        exit;
    }

    $checkInDate = new DateTime($checkIn);
    $checkOutDate = new DateTime($checkOut);

    if (!$checkInDate || !$checkOutDate) {
        echo "Ingrese fechas válidas";
        exit;
    }

    if ($checkInDate < new DateTime($currentDate)) {
        echo "La fecha de entrada debe ser mayor o igual a la fecha actual";
        exit;
    }

    if ($checkInDate >= $checkOutDate) {
        echo "La fecha de entrada no puede ser mayor o igual a la fecha de salida";
        exit;
    }

    $sqlRooms = "SELECT * FROM habitaciones INNER JOIN tipoHabitacion ON tipoHabitacion.id_tipoHabitacion = habitaciones.id_tipoHabitacion 
    WHERE habitaciones.id_hotel = '".$filas[$hotel]['id_hotel']."' AND habitaciones.id_habitacion NOT IN 
    (SELECT DISTINCT id_habitacion FROM reservaHabitaciones WHERE checkIn <= '".$checkOut."' AND checkout >= '".$checkIn."')
    ";

    $qryRooms = sqlsrv_query($conn, $sqlRooms);

    if(!$qryRooms){
        die("Error de consulta, comunicarse con soporte");
    } 
?>

<div class="container my-5" id="reservasBuilder">
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
                        <input class="w-100 p-1" type="date" name="in" value="<?php echo $checkIn?>" id="checkIn">
                    </div>
                    <div class="row w-100 text-center">
                        Hasta
                        <input class="w-100 p-1" type="date" name="out" value="<?php echo $checkOut?>" id="checkOut">

                        <input type="hidden" name="type" value="habitaciones">
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
                Habitaciones
            </div>
                <?php while($room = sqlsrv_fetch_array( $qryRooms, SQLSRV_FETCH_ASSOC)) {?>
                    <div class="col bg-gris text-light p-3 mb-2 rounded" id="room-<?php echo $room['id_habitacion']?>">
                        <div class="row">
                            <div class="col-lg-6">
                                <img src="../img/habitaciones/<?php echo basename(dirname($room['imagenes'])) . "/" . basename($room['imagenes'])?>" class="img-fluid w-100 rounded imgReserva" alt="Responsive image">
                            </div>
                            <div class="col-lg-3 contenedor">
                                <div class="d-flex justify-content-between mt-1">
                                    <a href="#" class="text-white" id="roomType"><?php echo $room['nombre'] ?></a>
                                    <abbr title="Para seleccionar el hotel cambie la cantidad de personas"><span class="material-symbols-outlined cant-per">info</span></abbr>
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
                            <div class="col-lg-3">
                                <div class="d-flex justify-content-between">
                                    <h6>Cantidad de personas</h6>
                                    <div>
                                        <select id="opciones" oninput="roomPersons('<?php echo $room['id_habitacion']?>');">
                                            <?php 
                                            for($i=0; $i<($room['ocupacion']+1); $i++){
                                                echo '<option value='.$i.'>'.$i.'</option>';
                                            }    
                                            ?>
                                        </select>
                                    </div>
                                </div>
                                <p class="my-2 d-flex justify-content-between">Precio por la habitacion</p>
                                <br>
                                <div>
                                    <h2 id="costoRoom">$<?php echo $room['costo']?></h2>
                                    <p id="currentValue" class="d-none">0</p>
                                </div>
                            </div>
                        </div>
                    </div>
                <?php } ?>
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
</div>

<script src="js/reservas.js">