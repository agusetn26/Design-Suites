<?php
$ubicaciones = ["Buenos Aires", "Bariloche", "Calafate", "Salta",];
?>
<div class="container my-5">
    <p class="h1"><?php echo ($ubicaciones[$_GET['ubi']]); ?></p>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat illo quae pariatur nemo fugit voluptates ipsa est iure nulla sapiente magnam consequatur reiciendis ipsam iste eaque harum, distinctio saepe? Dolore!
        Sint laborum minima quod eligendi culpa nemo sunt facere dolore optio dolorem excepturi cupiditate saepe quia beatae, praesentium reprehenderit ab autem delectus illum cumque, impedit fuga officiis. Non, laborum deleniti!
        Accusamus praesentium incidunt voluptatum enim expedita natus maiores? Ipsum illo ea, magnam tempora, porro dolorem iure temporibus enim est reiciendis expedita itaque mollitia accusamus? Repellendus, quis culpa. Amet, neque laborum!
        Deserunt cum sunt quo qui dicta laboriosam officia consequatur, natus sint harum! Facere consequuntur magnam libero similique vel, repudiandae aspernatur tempore id odit dolorum obcaecati. Amet modi eos doloremque magni.
    </p>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Galeria</p>
    <div id="hotelesCarrusel" class="carousel slide mb-6" data-bs-ride="carousel">
        <div class="carousel-indicators">
            <?php for ($i = 0; $i < 4; $i++) { ?>
                <button type="button" data-bs-target="#hotelesCarrusel" aria-label="Slide <?php echo ($i + 1); ?>" data-bs-slide-to="<?php echo $i; ?>" <?php echo (($i == 0) ? 'class="active" aria-current="true"' : ""); ?>></button>
            <?php } ?>
        </div>
        <div class="carousel-inner">
            <?php for ($i = 0; $i < 4; $i++) { ?>
                <div class="carousel-item <?php echo (($i == 0) ? "active" : "") ?>">
                    <img src="../img/hoteles/<?php echo $i ?>.jpg" style="width: 100%; height: auto;">
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
        <?php for ($i = 0; $i < 3; $i++) { ?>
            <div class="col imgCard">
                <div class="card h-100">
                    <img src="../img/hoteles/1.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Classic Room</h5>
                        <p class="card-text">1-2 huéspedes | 28 m²</p>
                    </div>
                </div>
            </div>
        <?php } ?>
    </div>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Amenities & Servicios</p>
    <div class="container">
        <div class="row row-cols-2">
            <?php for ($i = 0; $i < 5; $i++) { ?>
                <div class="col h4 my-2 text-secondary"><span class="material-symbols-outlined h5">check_box</span>Dato</div>
            <?php } ?>
        </div>
    </div>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Video</p>
        <iframe width="560" height="315" src="https://www.youtube.com/embed/Si8kDwCGQ24?si=3q5HaBd0jRH8FC1G" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
</div>