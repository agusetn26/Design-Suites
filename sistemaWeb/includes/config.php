<?php
    $connInfo = array("Database" => "design_suites", "UID" => "sa", "PWD" => "123");
    $conn = sqlsrv_connect("DESKTOP-QB22C4J\SQLEXPRESS", $connInfo);
    if(!$conn){
        die("Error al conectarse con la base de datos, contactar con soporte");
    }
?>