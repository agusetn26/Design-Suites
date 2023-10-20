<?php 
     if(empty($_GET)){
        echo "<script>window.location.href='index.php';</script>";
        exit;
    }
    $idHab = $_GET['idHab'];

    require_once "includes/config.php";

    $sqlHabicaciones = "SELECT * FROM tipoHabitacion WHERE id_tipoHabitacion =" . $idHab;
 
    $qryHabicaciones = sqlsrv_query($conn, $sqlHabicaciones);
    
    if(!$qryHabicaciones){
        die("Hubo un error de consulta, contactar con soporte en caso de que perdure el problema");
    }

    $hab = sqlsrv_fetch_array($qryHabicaciones, SQLSRV_FETCH_ASSOC);
    $nombreHotel = $filas[$_GET["idH"]]["nombre"];
?>