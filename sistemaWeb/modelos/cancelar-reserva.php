<?php
    /* ----------------- NO TOCAR -------------------- */
    require_once "../includes/config.php";

    $codigo = trim($_GET["input-codigo"]);
    $sqlCancelarHab = 
    "
    IF EXISTS (SELECT * FROM reservaHabitaciones WHERE codigo = '".$codigo."')
    BEGIN
        SELECT 'Se ha eliminado la reserva de habitación';
        DELETE FROM reservaHabitaciones WHERE codigo = '".$codigo."';
    END
    ELSE IF EXISTS (SELECT * FROM reservaEventos WHERE codigo = '".$codigo."') 
    BEGIN
        SELECT 'Se ha eliminado la reserva de evento'; 
        DELETE FROM reservaEventos WHERE codigo = '".$codigo."'; 
    END 
    ELSE 
    BEGIN 
        SELECT 'Código invalido'; 
    END 
    ";

    $sqlResH = sqlsrv_query($conn, $sqlCancelarHab);

    if (!$sqlResH) {
        //die(print_r(sqlsrv_errors(), true));
        header("HTTP/1.1 500 Internal Server Error");
        exit;
    }

    $res = sqlsrv_fetch_array($sqlResH, SQLSRV_FETCH_NUMERIC); 
    
    echo $res[0]; 
?>