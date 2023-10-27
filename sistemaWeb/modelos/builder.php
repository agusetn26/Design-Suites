<?php
    $stmt = sqlsrv_query($conn, "SELECT * FROM hoteles WHERE fecha_baja IS NULL");
    
    if(!$stmt){
        die("Error de consulta, de persistir contactar con soporte");
    }
    
    $filas = [];

    while($fila = sqlsrv_fetch_array( $stmt, SQLSRV_FETCH_ASSOC) ){
        $filas[] = $fila;
    }
?>