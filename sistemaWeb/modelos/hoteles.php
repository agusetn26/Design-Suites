<?php 
    if(empty($_POST)){
        echo "<script>window.location.href='index.php';</script>";
        exit;
    }

    /* HABITACIONES */

    $index = $_POST['hotel'];
    $rutas = explode(";", $filas[$index]['imagen']);

    require_once "includes/config.php";

    $sqlHabicaciones = "SELECT t.id_tipoHabitacion, t.nombre, t.descripcion, t.ocupacion, t.servicios, t.dimensiones, t.imagenes, COUNT(habitaciones.id_tipoHabitacion) AS cantidad " . 
                    "FROM habitaciones JOIN tipoHabitacion AS t ON t.id_tipoHabitacion = habitaciones.id_tipoHabitacion " . 
                    "WHERE id_hotel = '". $filas[$index]['id_hotel'] ."' AND habitaciones.fecha_baja IS NULL GROUP BY t.id_tipoHabitacion, t.nombre, t.descripcion, t.ocupacion, t.servicios, t.dimensiones, t.imagenes";
 
    $qryHabicaciones = sqlsrv_query($conn, $sqlHabicaciones);
    
    if(!$qryHabicaciones){
        die("Hubo un error de consulta, contactar con soporte en caso de que perdure el problema");
    }

    $habitacionesCategoria = [];
    $cantidadHabitaciones = 0;

    while($room = sqlsrv_fetch_array($qryHabicaciones, SQLSRV_FETCH_ASSOC)){
        $habitacionesCategoria[] = $room;
        $cantidadHabitaciones += $room['cantidad'];
    }

    //Añadir columna servicios en tabla hoteles, solucion provicional
    $serviciosHotel = explode(";", $habitacionesCategoria[0]['servicios']);

    /* EVENTOS */

    $sqlEventos = 'SELECT id_evento AS "idEvento", eventos.id_hotel AS "idHotel", precio, eventos.imagen AS img, eventos.nombre  FROM eventos JOIN hoteles ON eventos.id_hotel = hoteles.id_hotel WHERE eventos.fecha_baja IS NULL AND hoteles.id_hotel = ' . $filas[$index]['id_hotel'];
    $qryEventos = sqlsrv_query($conn, $sqlEventos);
    $eventos = [];

    while($evento = sqlsrv_fetch_array($qryEventos, SQLSRV_FETCH_ASSOC)){
        $eventos[] = $evento;
    }
    
    if(!$qryEventos){
        die("Hubo un error de consulta, contactar con soporte en caso de que perdure el problema");
    }
?>