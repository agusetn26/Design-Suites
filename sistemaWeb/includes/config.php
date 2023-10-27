<?php
    $connInfo = array("Database" => "design_suites", "UID" => "", "PWD" => "", "CharacterSet" => "UTF-8");
    $conn = sqlsrv_connect("DESKTOP-L8KEE59", $connInfo);

    if(!$conn){
        die("Error al conectarse con la base de datos, contactar con soporte");
    }
?>  

