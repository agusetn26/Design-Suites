<?php
    require_once "../includes/config.php";

    $amount = $_POST["rooms"];
    $sql = "SELECT * FROM habitaciones INNER JOIN tipoHabitacion ON tipoHabitacion.id_tipoHabitacion = habitaciones.id_tipoHabitacion 
    WHERE habitaciones.id_hotel = '".$filas[$hotel]['id_hotel']."' AND habitaciones.fecha_baja IS NULL AND habitaciones.id_habitacion NOT IN 
    (SELECT DISTINCT id_habitacion FROM reservaHabitaciones WHERE checkIn <= '".$checkOut."' AND checkout >= '".$checkIn."') FETCH NEXT '".$amount."' ROWS ONLY";
?>