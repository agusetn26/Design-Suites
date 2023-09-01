<div class="container my-4">
    <p class="h1"><?php echo $_GET['ubi']; ?></p>
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
    <div class="video_con">
        <iframe width="560" height="315" src="https://www.youtube.com/embed/Si8kDwCGQ24?si=3q5HaBd0jRH8FC1G" frameborder="0" class="video"></iframe>
    </div>
    <!-------------------------------------------------------------------->
    <p class="h3 m-3 border-bottom">Ubicacion</p>
    <div class="video_con">
        <iframe class="video" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1641.8135822167621!2d-58.40583319994833!3d-34.613605375079786!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x95bccb87409a19cb%3A0xca5521b461138618!2sEscuela%20T%C3%A9cnica%20N%C2%BA26%20D.E.6%20%22Confederaci%C3%B3n%20Suiza%22!5e0!3m2!1ses-419!2sar!4v1693585879304!5m2!1ses-419!2sar" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </div>
    <!-------------------------------------------------------------------->

</div>