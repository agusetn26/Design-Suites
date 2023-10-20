<?php
    require_once "../includes/config.php";


    $reservas = json_decode($_POST['reservas']);
    $ids = [];
    $sqlReservas = "";
    $code = "";
    $in = $_POST['checkIn'];
    $out = $_POST['checkOut'];
    $inDate = $_POST['inDate'];

    foreach($reservas as $reserva){
        $ids[] = $reserva->id;
        $code = uniqid($_POST['numero_documento']);

        $sqlReservas .=  "
                        INSERT INTO reservaEventos (codigo, comentarios, checkIn, checkOut, fecha_alta, id_evento, id_cliente) 
                        VALUES ('".$code."', '".$_POST['comentarios']."', '".$in."', '".$out."', '".$inDate."', '".$reserva->id."', @id);
                        
                        ";
    }
    $sqlReservas .= "END";

    $ids = implode(",", $ids);
    
    $sql = "
    IF NOT EXISTS(SELECT 1 FROM reservaEventos WHERE checkIn >= ? AND checkout <= ? AND fecha_alta = ? AND id_evento IN (".$ids."))
    BEGIN
        DECLARE @id int;
        
        SELECT @id = id_cliente FROM clientes WHERE dni = ?;
        
        IF @id IS NULL
        BEGIN
            INSERT INTO clientes (apellido, dni, correo, edad, telefono) VALUES (?, ?, ?, ?, ?);
            SET @id = SCOPE_IDENTITY();
        END
        " . $sqlReservas .
    "
    ELSE
    BEGIN
        SELECT 'Reserva no disponible' AS msg;
    END
    ";

    $params = array($in, $out, $inDate, $_POST['numero_documento'], 
                    $_POST['apellido'], $_POST['numero_documento'], $_POST['email'], $_POST['edad'], $_POST['telefono']
                );

    $qry = sqlsrv_query($conn, $sql, $params);

    if (!$qry) {
        die(print_r(sqlsrv_errors(), true));
      
    }

    if(sqlsrv_fetch($qry)){
        echo sqlsrv_get_field($qry, 0);
        exit;
    }

    echo $code;
?>