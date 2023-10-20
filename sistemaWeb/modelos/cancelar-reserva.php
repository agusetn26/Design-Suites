<?php
    /* ----------------- NO TOCAR -------------------- */
    require_once "../includes/config.php";

    $codigo = $_GET["input-codigo"];
    $encontrado = false;
    $donde = "";

    $sqlCancelarHab = "SELECT codigo FROM reservaHabitaciones WHERE codigo = '" .$codigo ."'";
    $sqlCancelarEven = "SELECT codigo FROM reservaEventos WHERE codigo = '" .$codigo ."'";

    $sqlResH = sqlsrv_query($conn, $sqlCancelarHab);

    if(!$sqlResH){
        die("Hubo un error de consulta");
    }

    
    $resultH = sqlsrv_fetch_array($sqlResH, SQLSRV_FETCH_ASSOC);
    
    if($resultH == null){
        $sqlResE = sqlsrv_query($conn, $sqlCancelarEven);
        
        if(!$sqlResE){
            die("Hubo un error de consulta");
        }
        
        $resultE = sqlsrv_fetch_array($sqlResE, SQLSRV_FETCH_ASSOC);
        
        if($resultE != null){
            $encontrado = true;
            $donde = 'eventos';
        }
    }else{
        $encontrado = true;
        $donde = 'habitacion';
    }

    //echo $result['codigo'];

    echo $pepe;

?>