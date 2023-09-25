<!-- carrusel prestado -->

<div id="myCarousel" class="carousel slide mb-6" data-bs-ride="carousel">
    <div class="carousel-indicators">
        <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="0" class="" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="1" aria-label="Slide 2" class="active" aria-current="true"></button>
        <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="2" aria-label="Slide 3"></button>
        <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="3" aria-label="Slide 4"></button>
    </div>
    <div class="carousel-inner">
        <div class="carousel-item active">
            <div class="content"> <a href="#">
                    <div class="content-overlay"></div> <img class="content-image img-carrusel" src="../img/salta.jpg" style="width: 1903; height: auto;" alt="">
                    <div class="content-details fadeIn-bottom">
                        <h3 class="content-title" style="font-size: 50px;">Salta</h3>
                        <p class="content-text" style="font-size: 35px;"><i class="fa fa-map-marker"></i> Design Suites Hoteles</p>
                    </div>
                </a>
            </div>
        </div>
        <div class="carousel-item">
            <div class="content"> <a href="#">
                    <div class="content-overlay"></div> <img class="content-image img-carrusel" src="../img/bariloche.jpg" style="width: 1903; height: auto;" alt="">
                    <div class="content-details fadeIn-bottom">
                        <h3 class="content-title" style="font-size: 50px;">Bariloche</h3>
                        <p class="content-text" style="font-size: 35px;"><i class="fa fa-map-marker"></i> Design Suites Hoteles</p>
                    </div>
                </a>
            </div>
        </div>
        <div class="carousel-item">
            <div class="content"> <a href="#">
                    <div class="content-overlay"></div> <img class="content-image img-carrusel" src="../img/calafate.jpg" style="width: 1903; height: auto;" alt="">
                    <div class="content-details fadeIn-bottom">
                        <h3 class="content-title" style="font-size: 50px;">Calafate</h3>
                        <p class="content-text" style="font-size: 35px;"><i class="fa fa-map-marker"></i> Design Suites Hoteles</p>
                    </div>
                </a>
            </div>
        </div>
        <div class="carousel-item">
            <div class="content"> <a href="#">
                    <div class="content-overlay"></div> <img class="content-image img-carrusel" src="../img/BsAs.png" style="width: 1903; height: auto;" alt="">
                    <div class="content-details fadeIn-bottom">
                        <h3 class="content-title" style="font-size: 50px;">Buenos Aires</h3>
                        <p class="content-text" style="font-size: 35px;"><i class="fa fa-map-marker"></i>Design Suites Hoteles </p>
                    </div>
                </a>
            </div>
        </div>
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

<!--------Hoteles------------>


<div class="text-center">
    <p class="my-2" style="font-size: 45px;"> Nuestos Hoteles </p>
</div>
<!--
<div>

    <div class="hoteles">

        <div class="hotel">
            <div class="carousel-none">
                <a href="#">
                    <img src="../img/home_bariloche.jpg" alt="Design Suites Bariloche">
                </a>
                <div class="single-blog-text">
                    <div class="blog-post-info bg-violet pl-20 pr-20 pt-17 pb-17">
                        <span><i class="fa fa-location-arrow mr-12"></i>BARILOCHE</span>
                    </div>
                </div>

            </div>
        </div>
    </div>

</div>-->

<div class="album py-5 bg-body-tertiary">
    <div class="container">

        <div class="row row-cols-1 row-cols-sm-2 row-cols-md-2 g-5">
            <?php foreach($filas as $index => $fila){

                $hotel = $fila['nombre'];   //nombre del hotel
                $idTag = "hotelCard - " . $index;   //id del formulario

                $archivo = "/" . basename(explode(";", $fila['imagen'])[0]);    //obtengo nombre del archivo de imagen
                $carpeta = basename(dirname(explode(";", $fila['imagen'])[0])); //obtengo la carpeta que contiene la imagen

                $ruta =  "../img/hoteles/" . $carpeta . $archivo;   //establezco ruta definitiva
            ?>
                <div class="col hentai">
                    <form action="?sec=hoteles" method="POST" id="<?php echo $idTag?>">
                        <div class="card shadow-sm" onclick="document.getElementById('<?php echo $idTag?>').submit();">
                            <img class="bd-placeholder-img card-img-top" width="100%" height="225" src="<?php echo $ruta?>" alt="Design Suites Bariloche"> 
                            <div class="card-body py-3 px-5" style="background-color: #20233f; ">
                                <p class="card-text" style="color: white; font-size:20px; font-weight:bold;"><?php echo $hotel?></p>
                            </div>
                        </div>
                        <input type="hidden" name="hotel" value="<?php echo $index?>">
                    </form>
                </div>
            <?php }?>
        </div>
    </div>
</div>

<br>