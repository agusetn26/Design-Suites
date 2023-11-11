<?php
require_once "modelos/habitaciones.php";
?>
<div class="container py-4">
    <div class="fs-3 fw-bold"><?php echo($filas[$_GET["idH"]]["nombre"])?></div>
    <div class="fs-4">Habitacion <span class="text-primary"><?php echo ($hab["nombre"]); ?></span></div>
    <!-------------------------------casurrel-->
    <div id="myCarousel" class="carousel slide my-4" data-bs-ride="carousel">
        <div class="carousel-indicators">
            <?php foreach ($imgRoom as $i => $img) { ?>
                <button type="button" data-bs-target="#myCarousel" aria-label="Slide <?php echo ($i + 1); ?>" data-bs-slide-to="<?php echo $i; ?>" <?php echo (($i == 0) ? 'class="active" aria-current="true"' : ""); ?>></button>
            <?php } ?>
        </div>
        <div class="carousel-inner">
            <?php foreach ($imgRoom as $i => $img) { ?>
                <div class="carousel-item <?php echo (($i == 0) ? "active" : "") ?>">
                    <img src="../img/habitaciones/<?php echo basename(dirname($img)) . "/" . basename($img) ?>" style="width: 100%; height: auto;">
                </div>
            <?php } ?>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#myCarousel" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#myCarousel" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>
    <!---------------------------------------------------------->
    <div class="container my-3">
        <div class="row row-cols-2">
            <div class="col"><span class="fw-bold">Capacidad: </span><?php echo $hab["ocupacion"]?> personas.</div>
            <div class="col"><span class="fw-bold">Dimension: </span><?php echo $hab["dimensiones"]?> m².</div>
        </div>
    </div>
    <!--------------------------------descripcion vasada sigma-->
    <p class="text-justify fs-5"><?php echo $hab["descripcion"] ?></p>
    <!--------------------------------coso-->
    <div class="container bg-gray p-3 pb-0 rounded">
        <div class="row row-cols-2">
                            <div class="col mb-3">
                    <span class="material-symbols-outlined h6">check_box</span>
                    I-FI sin cargo                </div>
                            <div class="col mb-3">
                    <span class="material-symbols-outlined h6">check_box</span>
                    LCD TV 32"                 </div>
                            <div class="col mb-3">
                    <span class="material-symbols-outlined h6">check_box</span>
                    Caja de seguridad                </div>
                            <div class="col mb-3">
                    <span class="material-symbols-outlined h6">check_box</span>
                    Teléfono                </div>
                            <div class="col mb-3">
                    <span class="material-symbols-outlined h6">check_box</span>
                    Minibar                </div>
                            <div class="col mb-3">
                    <span class="material-symbols-outlined h6">check_box</span>
                    Baño con hidromasaje                </div>
                    </div>
    </div>
    <!---------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Ubicacion</p>
    <div class="video_con">
        <iframe class="video" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1641.8135822167621!2d-58.40583319994833!3d-34.613605375079786!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x95bccb87409a19cb%3A0xca5521b461138618!2sEscuela%20T%C3%A9cnica%20N%C2%BA26%20D.E.6%20%22Confederaci%C3%B3n%20Suiza%22!5e0!3m2!1ses-419!2sar!4v1693585879304!5m2!1ses-419!2sar" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </div>
</div>
