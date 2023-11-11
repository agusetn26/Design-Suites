<?php
    require_once "modelos/home.php";    
?>
<div class="row m-5">
            <div id="myCarousel" class="carousel slide mb-6 col-xl-6 " data-bs-ride="carousel">
                <div class="carousel-indicators">
                    <?php for ($i = 0; $i < $cantidadHoteles; $i++) { ?>
                        <button type="button" data-bs-target="#myCarousl" data-bs-slide-to="<?php echo $i ?>" <?php if ($i == 0) { ?>class="active" aria-current="true" <?php } ?>aria-label="Slide <?php echo $i + 1 ?>"></button>
                    <?php } ?>
                </div>
                <div class=" carousel-inner">
                    <?php foreach ($hotelesCarrusel as $i => $hotel) { ?>
                        <div class="carousel-item <?php if ($i == 0) { ?>active<?php } ?>">
                            <div class="content">
                                <div class="content-overlay"></div> <img class="content-image img-carrusel" src="../img/hoteles/<?php echo basename(dirname($hotel['imagen'])) . "/" . basename($hotel['imagen'])?>" style="width: 1903; height: auto;" alt="">
                                <div class="content-details fadeIn-bottom">
                                    <h3 class="content-title" style="font-size: 50px;"><?php echo $hotel["nombre"]?></h3>
                                    <p class="content-text" style="font-size: 35px;"><i class="fa fa-map-marker"></i> Design Suites Hoteles</p>
                                </div>
                    
                            </div>
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
            <div class="col-xl-6 ">
                <div class="d-none d-md-block contact-form-area fix mtb-30">
                    <h3 class="uppercase mb-25 text-center">CONTACTO</h3>
                    <p></p>
                    <form action="#" class="contact-form" id="contact-form" method="post" onsubmit="return validar(this)">
                        <div class="form-group">
                            <input type="text" name="nombre" class="form-control" value="" placeholder="Nombre" required="">
                        </div>
                        <div class="form-group">
                            <input type="text" name="tel" class="form-control" value="" placeholder="Teléfono">
                        </div>
                        <div class="form-group">
                            <input type="email" name="email" class="form-control" value="" placeholder="Mail" required="">
                        </div>
                        <div class="form-group1">
                            <ul>
                                <li class="nav-item list-unstyled mx-1">
                                    <select class="form-select">
                                        <?php   
                                            echo $hotelesOp;
                                        ?>
                                    </select>
                                </li>
                            </ul>
                        </div>
                        <div class="form-group">
                            <textarea name="consulta" class="form-control" rows="5" placeholder="Mensaje"></textarea>
                        </div>
                        <div class="send-area">
                            <input type="submit" class="send-btn" value="ENVIAR">
                        </div>
                    </form>
                </div>

                <!-- para iafon -->
                <br>
                <div class="d-block d-md-none contact-form-area fix mtb-30">
                    <h3 class="uppercase mb-25 text-center">CONTACTO</h3>
                    <p></p>
                    <form action="#" class="contact-form" id="contact-form" method="post" onsubmit="return validar(this)">
                        <div class="form-group">
                            <input type="text" name="nombre" class="form-control" value="" placeholder="Nombre" required="">
                        </div>
                        <div class="form-group">
                            <input type="text" name="tel" class="form-control" value="" placeholder="Teléfono">
                        </div>
                        <div class="form-group">
                            <input type="email" name="email" class="form-control" value="" placeholder="Mail" required="">
                        </div>
                        <div class="form-group1">
                            <ul>
                                <li class="nav-item list-unstyled mx-1">
                                    <select class="form-select">
                                        <option selected>Seleccione el hotel</option>
                                        <option value="1">Buenos Aires</option>
                                        <option value="2">Bariloche</option>
                                        <option value="3">Calafate</option>
                                        <option value="4">Salta</option>
                                    </select>
                                </li>
                            </ul>
                        </div>
                        <div class="form-group">
                            <textarea name="consulta" class="form-control" rows="5" placeholder="Mensaje"></textarea>
                        </div>
                        <div class="send-area">
                            <input type="submit" class="send-btn" value="ENVIAR">
                        </div>
                    </form>
                </div>

            </div>
        </div>
    </div>
</div></div>