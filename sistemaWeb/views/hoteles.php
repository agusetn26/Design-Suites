<?php
require_once "modelos/hoteles.php";
?>

<div class="container my-4">

    <p class="h1"><?php echo $filas[$index]['nombre']; ?></p>
    <p class="text-secondary text-break fs-5"><?php echo nl2br($filas[$index]['descripcion']) ?></p>
    <p class="fw-bold lead"><?php echo $cantidadHabitaciones; ?>&nbsp;habitaciones</p>

    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Galeria de fotos</p>

    <div id="hotelesCarrusel" class="carousel slide mb-6" data-bs-ride="carousel">

        <div class="carousel-indicators">
            <?php foreach ($rutas as $i => $ruta) { ?>
                <button type="button" data-bs-target="#hotelesCarrusel" aria-label="Slide <?php echo ($i + 1); ?>" data-bs-slide-to="<?php echo $i; ?>" <?php echo (($i == 0) ? 'class="active" aria-current="true"' : ""); ?>></button>
            <?php } ?>
        </div>

        <div class="carousel-inner">
            <?php foreach ($rutas as $i => $ruta) { ?>
                <div class="carousel-item <?php echo (($i == 0) ? "active" : "") ?>">
                    <img src="../img/hoteles/<?php echo basename(dirname($ruta)) . "/" . basename($ruta) ?>" style="width: 100%; height: auto;">
                </div>
            <?php } ?>
        </div>

        <button class="carousel-control-prev" type="button" data-bs-target="#hotelesCarrusel" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        </button>

        <button class="carousel-control-next" type="button" data-bs-target="#hotelesCarrusel" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
        </button>

    </div>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Habitaciones</p>
    <div class="row row-cols-1 row-cols-md-3 g-4 mb-3">
        <?php foreach ($habitacionesCategoria as $tipo) { ?>
            <a href="?sec=habitaciones&idHab=<?php echo ($tipo['id_tipoHabitacion'] . "&idH=" . $index) ?>">
                <div class="col imgCard">
                    <div class="card h-100">
                        <img src="../img/habitaciones/<?php echo basename(dirname(explode(";", $tipo['imagenes'])[0])) . "/" . basename(explode(";", $tipo['imagenes'])[0]); ?>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title text-dark h4"><?php echo $tipo['nombre'] ?></h5>
                            <p class="card-text text-dark h5"><?php echo $tipo['ocupacion'] ?>&nbsp;huespedes | <?php echo $tipo['dimensiones'] ?>&nbsp;m²</p>
                        </div>
                    </div>
                </div>
            </a>
        <?php } ?>
    </div><?php if (!empty($eventos)) { ?>
        <!-------------------------------------------------------------------->
        <p class="h3 m-3 border-bottom">Eventos</p>
        <div class="row row-cols-1 row-cols-md-3 g-4 mb-3">
            <?php foreach ($eventos as $evento) { ?>
                <a href="?sec=eventos&idEvento=<?php echo ($evento['idEvento'] . "&idH=" . $index) ?>">
                    <div class="col imgCard">
                        <div class="card h-100">
                            <img src="../img/eventos/<?php echo basename(dirname(explode(";", $evento['img'])[0])) . "/" . basename(explode(";", $evento['img'])[0]); ?>" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title text-dark h4"><?php echo($evento['nombre'])?></h5>
                                <p class="card-text text-dark h5">$<?php echo(number_format($evento['precio'], 2)) // floatval() recordar?></p>
                            </div>
                        </div>
                    </div>
                </a>
            <?php } ?>
        </div>
    <?php } ?>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Amenities & Servicios</p>
    <div class="container">
        <div class="row row-cols-2">
            <?php foreach ($serviciosHotel as $tipo) { ?>
                <div class="col h4 my-2 text-secondary"><span class="material-symbols-outlined h5">check_box</span><?php echo $tipo ?></div>
            <?php } ?>
        </div>
    </div>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Video</p>
    <div class="video_con">
        <iframe width="560" height="315" src="https://www.youtube.com/embed/Si8kDwCGQ24?si=3q5HaBd0jRH8FC1G" frameborder="0" class="video"></iframe>
    </div>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Ubicacion</p>
    <p class="text-break"><?php echo $filas[$index]['ubicacion'] . "&nbsp;(" . $filas[$index]['direccion'] . ")" ?></p>

    <div class="video_con">
        <iframe class="video" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1641.8135822167621!2d-58.40583319994833!3d-34.613605375079786!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x95bccb87409a19cb%3A0xca5521b461138618!2sEscuela%20T%C3%A9cnica%20N%C2%BA26%20D.E.6%20%22Confederaci%C3%B3n%20Suiza%22!5e0!3m2!1ses-419!2sar!4v1693585879304!5m2!1ses-419!2sar" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </div>
    <!-------------------------------------------------------------------->

</div>