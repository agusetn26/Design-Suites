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

   /*
    $qryRooms = sqlsrv_query($conn, $sqlRooms);

    if(!$qryRooms){
        die("Error de consulta, comunicarse con soporte");
    }
    
    while ($room = sqlsrv_fetch_array($qryRooms, SQLSRV_FETCH_ASSOC));
    */
?>