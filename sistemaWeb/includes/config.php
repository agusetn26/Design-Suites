<?php
    $connInfo = array("Database" => "design_suites", "UID" => "", "PWD" => "");
    $conn = sqlsrv_connect("PC-F-026\SQLEXPRESS", $connInfo);

    if(!$conn){
        die("Error al conectarse con la base de datos, contactar con soporte");
    }
?>  

