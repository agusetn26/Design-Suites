<?php
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
    WHERE habitaciones.id_hotel = '".$filas[$hotel]['id_hotel']."' AND habitaciones.fecha_baja IS NULL AND habitaciones.id_habitacion NOT IN 
    (SELECT DISTINCT id_habitacion FROM reservaHabitaciones WHERE checkIn <= '".$checkOut."' AND checkout >= '".$checkIn."')
    ";

    $qryRooms = sqlsrv_query($conn, $sqlRooms);

    if(!$qryRooms){
        die("Error de consulta, comunicarse con soporte");
    } 
?>