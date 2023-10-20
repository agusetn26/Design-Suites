<?php
    $hotel = $_POST['hotel'];
    $inDate = $_POST["inDate"];
    $checkIn = $_POST["inHour"];
    $checkOut = $_POST["outHour"];
    $currentDate = new DateTime();

    //Validación de entradas
    if (empty($inDate) || empty($checkIn) || empty($checkOut)) {
        echo "Ingrese las fechas y horas.";
        exit;
    } else {
        $inDateTime = new DateTime($inDate . " " . $checkIn);

        if ($inDateTime == false || $inDateTime == new DateTime('0000-00-00 00:00:00')) {
            echo "La fecha u hora de entrada no son válidas.";
            exit;

        } else if ($inDateTime < $currentDate) {
            echo "La fecha y hora de entrada deben ser mayores o iguales a la fecha y hora actuales.";
            exit;

        } else {
            $outDateTime = new DateTime($inDate . " " . $checkOut);

            if ($inDateTime >= $outDateTime) {
                echo "La hora de entrada no puede ser mayor o igual a la hora de salida.";
                exit;
            } 
        }
    }

    // Querys
    $idHotel = $filas[$_POST['hotel']]['id_hotel'];
    $sql = "SELECT * FROM eventos WHERE id_hotel = '".$idHotel."' AND id_evento NOT IN " .
            "(SELECT id_evento FROM reservaEventos WHERE checkIn <= '".$checkIn."' AND checkOut >= '".$checkOut."' AND fecha_alta = '".$inDate."')";

    $qryEvents = sqlsrv_query($conn, $sql);

    // while($evento[] = sqlsrv_fetch_array($qry, SQLSRV_FETCH_ASSOC)); hacks
?>