<?php 
    if(empty($_POST)){
        echo "<script>window.location.href='index.php';</script>";
        exit;
    }

    $index = $_POST['hotel'];
    $rutas = explode(";", $filas[$index]['imagen']);

    require_once "includes/config.php";

    $sqlHabicaciones = "SELECT t.id_tipoHabitacion, t.nombre, t.descripcion, t.ocupacion, t.servicios, t.dimensiones, t.imagenes, COUNT(habitaciones.id_tipoHabitacion) AS cantidad " . 
                    "FROM habitaciones JOIN tipoHabitacion AS t ON t.id_tipoHabitacion = habitaciones.id_tipoHabitacion " . 
                    "WHERE id_hotel = '". $filas[$index]['id_hotel'] ."' GROUP BY t.id_tipoHabitacion, t.nombre, t.descripcion, t.ocupacion, t.servicios, t.dimensiones, t.imagenes;";
 
    $qryHabicaciones = sqlsrv_query($conn, $sqlHabicaciones);
    
    if(!$qryHabicaciones){
        die("Hubo un error de consulta, contactar con soporte en caso de que perdure el problema");
    }

    $habitacionesCategoria = [];

    while($room = sqlsrv_fetch_array( $qryHabicaciones, SQLSRV_FETCH_ASSOC)){
        $habitacionesCategoria[] = $room; 
    }

    //Añadir columna servicios en tabla hoteles, solucion provicional
    $serviciosHotel = explode(";", $habitacionesCategoria[0]['servicios']);
?>