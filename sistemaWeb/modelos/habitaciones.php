<?php 
     if(empty($_GET) || empty($filas[$_GET['idH']])){
        echo "<script>window.location.href='index.php';</script>";
        exit;
    }
    $idHab = $_GET['idHab'];

    require_once "includes/config.php";

    $sqlHabicaciones = "SELECT t.id_tipoHabitacion, t.nombre, t.descripcion, t.ocupacion, t.servicios, t.dimensiones, t.imagenes, COUNT(habitaciones.id_tipoHabitacion) AS cantidad " . 
    "FROM habitaciones JOIN tipoHabitacion AS t ON t.id_tipoHabitacion = habitaciones.id_tipoHabitacion " . 
    "WHERE t.id_tipoHabitacion = '". $idHab ."' AND id_hotel = '". $filas[$_GET['idH']]['id_hotel'] ."' AND habitaciones.fecha_baja IS NULL GROUP BY t.id_tipoHabitacion, t.nombre, t.descripcion, t.ocupacion, t.servicios, t.dimensiones, t.imagenes";
 
    $qryHabicaciones = sqlsrv_query($conn, $sqlHabicaciones);
    
    if(!$qryHabicaciones){
        die("Hubo un error de consulta, contactar con soporte en caso de que perdure el problema");
    }

    if(!sqlsrv_has_rows($qryHabicaciones)){
        echo "<script>window.location.href='index.php';</script>";
        exit;
    }

    $hab = sqlsrv_fetch_array($qryHabicaciones, SQLSRV_FETCH_ASSOC);
    $imgRoom = explode(";", $hab["imagenes"]);
?>