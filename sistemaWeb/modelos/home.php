<?php 
require_once "includes/config.php";

    $sqlHabicaciones = "SELECT id_hotel, nombre, imagen AS img FROM hoteles";
 
    $qryHabicaciones = sqlsrv_query($conn, $sqlHabicaciones);
    
    if(!$qryHabicaciones){
        die("Hubo un error de consulta, contactar con soporte en caso de que perdure el problema");
    }

    $hotelesCarrusel = [];
    $cantidadHoteles = 0;

    while($hoteles = sqlsrv_fetch_array($qryHabicaciones, SQLSRV_FETCH_ASSOC)){
        $hotelesCarrusel[] = $hoteles;
        $cantidadHoteles += 1;
    }
?>