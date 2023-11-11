<?php
    require_once "../includes/config.php";

    //print_r($_POST);

    $reservas = json_decode($_POST['reservas']);
    $ids = [];
    $sqlReservas = "";
    $code = uniqid($_POST['numero_documento']);

    foreach($reservas as $reserva){
        $ids[] = $reserva->id;

        $sqlReservas .=  "
                        INSERT INTO reservaHabitaciones (codigo, comentarios, checkIn, checkout, cantidadPersonas, id_habitacion, id_cliente) 
                        VALUES ('".$code."', '".$_POST['comentarios']."', '".$_POST['checkIn']."', '".$_POST['checkOut']."', '".$reserva->personas."', '".$reserva->id."', @id);
                        
                        ";
    }
    $sqlReservas .= "END";

    $ids = implode(",", $ids);
    $in = $_POST['checkIn'];
    $out = $_POST['checkOut'];

    $sql = "
    IF NOT EXISTS(SELECT 1 FROM reservaHabitaciones WHERE checkIn >= ? AND checkout <= ? AND id_habitacion IN (".$ids."))
    BEGIN
        DECLARE @id int;
        
        SELECT @id = id_cliente FROM clientes WHERE dni = ?;
        
        IF @id IS NULL
        BEGIN
            INSERT INTO clientes (apellido, dni, correo, edad, telefono) VALUES (?, ?, ?, ?, ?);
            SET @id = SCOPE_IDENTITY();
        END
        " . $sqlReservas . "
    ELSE
    BEGIN
        SELECT 'Reserva no disponible' AS msg;
    END
    ";

    $params = array($_POST['checkIn'], $_POST['checkOut'], $_POST['numero_documento'], 
                    $_POST['apellido'], $_POST['numero_documento'], $_POST['email'], $_POST['edad'], $_POST['telefono']
                );

    $qry = sqlsrv_query($conn, $sql, $params);

    if (!$qry) {
        //die(print_r(sqlsrv_errors(), true));
        header("HTTP/1.1 500 Internal Server Error");
        exit;
    }

    if(sqlsrv_fetch($qry)){
        echo sqlsrv_get_field($qry, 0);
        exit;
    }

    echo $code;

    /*  Sistema de pagos anterior (beta)
    if(!sqlsrv_has_rows($qry)){
        $sqlCli = "INSERT INTO clientes (apellido, dni, correo, edad, telefono) VALUES (?, ?, ?, ?, ?); SELECT SCOPE_IDENTITY();";
        $qryCli = sqlsrv_query($conn, $sqlCli, $params);

        if (!$qryCli) {
            die(print_r(sqlsrv_errors(), true));
            //header("HTTP/1.1 500 Internal Server Error");
        }

        sqlsrv_next_result($qryCli); 
        sqlsrv_fetch($qryCli); 
        $idCli = sqlsrv_get_field($qryCli, 0); 
        echo $idCli;
    }*/
?>