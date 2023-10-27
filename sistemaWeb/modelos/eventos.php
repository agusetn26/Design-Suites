<?php 
     if(empty($_GET)){
        echo "<script>window.location.href='index.php';</script>";
        exit;
    }
    $idEvento = $_GET['idEvento'];

    require_once "includes/config.php";

    $sqlEventos = "SELECT * FROM eventos WHERE id_evento = " . $idEvento;
 
    $qryEventos = sqlsrv_query($conn, $sqlEventos);
    
    if(!$qryEventos){
        die("Hubo un error de consulta, contactar con soporte en caso de que perdure el problema");
    }

    $evento = sqlsrv_fetch_array($qryEventos, SQLSRV_FETCH_ASSOC);
    $imgEventos = explode(";", $evento["imagen"]);
?>