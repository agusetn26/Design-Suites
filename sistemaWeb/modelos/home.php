<?php 
    $hotelesCarrusel = [];
    $cantidadHoteles = 0;

    foreach ($filas as $hotel){
        $hotelesCarrusel[$cantidadHoteles]['nombre'] = $hotel['nombre'];
        $hotelesCarrusel[$cantidadHoteles]['imagen'] = explode(";", $hotel['imagen'])[0];
        $cantidadHoteles += 1;
    }
?>