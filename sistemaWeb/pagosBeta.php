<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/customStyles.css">
    <link rel="shortcut icon" type="image/x-icon" style="font-size: 130px;" href="../img/logo-dark.png">
    <title>
    </title>
</head>

<body>

    <!-- Top -->

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" aria-label="Twelfth navbar example">
        <div class="container-fluid navbar-collapse justify-content-center collapse">
            <ul class="navbar-nav align-items-center">
                <li class="nav-item d-flex align-items-center text-white mx-5" style="font-size: 13px;">
                    <span class="material-symbols-outlined">
                        call
                    </span>
                    <a class="nav-link active" style="font-size: 13px;" href="#" aria-current="page">(+54) 11 4896-6340</a>
                </li>
                <br>
                <li class="nav-item d-flex align-items-center text-white mx-5" style="font-size: 13px;">
                    <span class="material-symbols-outlined">
                        verified_user
                    </span>
                    <a class="nav-link active" style="font-size: 13px;" href="https://www.designsuites.com/protocolo.php" aria-current="page">PROTOCOLO DE SEGURIDAD</a>
                </li>
                <br>
                <li class="nav-item d-flex align-items-center mx-5">
                    <a class="nav-link active border border-light mx-2 text-center" target="_blank" style="height: 42px; width: 42px" href="https://www.facebook.com/designsuites" aria-current="page">
                        <img src="../img/f.png" alt="facebooklogo" width="13">
                    </a>
                    <a class="nav-link active border border-light mx-2 text-center" target="_blank" style="height: 42px; width: 42px" href="https://www.instagram.com/designsuites/" aria-current="page">
                        <img src="../img/i.png" alt="instagramlogo" width="17">
                    </a>
                </li>
            </ul>
        </div>
    </nav>



    <!-- Nav bar -->

    <nav class="navbar navbar-expand d-flex flex-wrap flex-column justify-content-center my-3">
        <a href="?sec=home" class="mb-3">
            <img src="../img/logo.png" alt="logo" width="150" height="75">
        </a>

        <ul class="navbar-nav flex-wrap justify-content-center align-items-center mx-auto">
            <li class="nav-item mx-2 my-1">
                <div class="dropdown">
                    <button class="btn btn-dark dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                        HOTELES
                    </button>

                    <form action="?sec=hoteles" method="POST">
                        <ul class="dropdown-menu">

                        </ul>
                    </form>

                </div>
            </li>
            <li class="nav-item mx-2 my-1">
                <a href="?sec=membresias" class="btn btn-dark" role="button">MEMBRESIAS</a>
            </li>
            <li class="nav-item mx-2 my-1">
                <a href="?sec=contacto" class="btn btn-dark" role="button">CONTACTO</a>
            </li>
        </ul>
    </nav>



    <!-- Reservas -->

    <nav class="navbar navbar-expand-md navbar-dark bg-dark" style="min-height: 64px;">
        <ul id="nav-res" class="navbar-nav flex-wrap justify-content-center align-items-center mx-auto">
            <li class="nav-item mx-3">
                <a class="nav-link active text-center" style="font-weight: 700;" aria-current="page">RESERVAS ONLINE</a>
            </li>
            <li class="nav-item px-3 py-md-2 py-sm-2 py-2 py-xl-0">
                <button type="button" onclick="selectedRooms()" class="btn px-3 py-0 bg-light" style="font-weight: 700; line-height: 29px">HABITACIONES</button>
            </li>
            <li class="nav-item px-3 py-md-2 py-sm-2 py-2 py-xl-0">
                <button type="button" onclick="selectedEvents()" class="btn px-3 py-0 bg-light" style="font-weight: 700; line-height: 29px">SALA DE
                    EVENTOS</button>
            </li>
        </ul>
    </nav>
    <!--
    <br>

    <nav class="navbar navbar-expand-md navbar-dark bg-dark" style="min-height: 64px;">
        <ul class="navbar-nav flex-wrap justify-content-center align-items-center mx-auto">
            <li class="nav-item px-5 my-1">
                <div class="d-flex gap-2 align-items-center">
                    <span class="material-symbols-outlined" onclick="" style="color: white; cursor: pointer;">reply</span>
                    <a class="nav-link active text-center" style="font-weight: 700;" aria-current="page">HABITACIONES</a>
                </div>
            </li>
            <li class="nav-item px-2 my-1">
                <select class="form-select" style="width: 260px; height: 30px; line-height: 14px;">
                    <option selected>Seleccione el hotel</option>
                    <option value="1">Buenos Aires</option>
                    <option value="2">Bariloche</option>
                    <option value="3">Calafate</option>
                    <option value="4">Salta</option>
                </select>
            </li>
            <li class="nav-item px-2 my-1">
                <input type="date" name="data" class="border-0 px-2"
                    style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">
            </li>
            <li class="nav-item px-2 my-1">
                <input type="date" name="data" class="border-0 px-2"
                    style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">
            </li>
            <li class="nav-item px-2 my-1">
                <a class="nav-link active bg-light text-dark rounded text-center"
                    style="width: 130px; line-height: 14px; font-weight: 700;" href="#" aria-current="page">RESERVAR</a>
            </li>
        </ul>
    </nav>

    <br>

    <nav class="navbar navbar-expand-md navbar-dark bg-dark" style="min-height: 64px;">
        <ul class="navbar-nav flex-wrap justify-content-center align-items-center mx-auto">
            <li class="nav-item px-5 my-1">
                <div class="d-flex gap-2 align-items-center">
                    <span class="material-symbols-outlined" onclick="" style="color: white; cursor: pointer;">reply</span>
                    <a class="nav-link active text-center" style="font-weight: 700;" aria-current="page">SALA DE EVENTOS</a>
                </div>
            </li>
            <li class="nav-item px-2 my-1">
                <select class="form-select" style="width: 260px; height: 30px; line-height: 14px;">
                    <option selected>Seleccione el hotel</option>
                    <option value="1">Buenos Aires</option>
                    <option value="2">Bariloche</option>
                    <option value="3">Calafate</option>
                    <option value="4">Salta</option>
                </select>
            </li>
            <li class="nav-item px-2 my-1">
                <input type="date" name="data" class="border-0 px-2"
                    style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">
            </li>
            <li class="nav-item px-2 my-1">
                <input type="time" name="data" class="border-0 px-2"
                    style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">
            </li>
            <li class="nav-item px-2 my-1">
                <input type="time" name="data" class="border-0 px-2"
                    style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">
            </li>
            <li class="nav-item px-2 my-1">
                <a class="nav-link active bg-light text-dark rounded text-center"
                    style="width: 130px; line-height: 14px; font-weight: 700;" href="#" aria-current="page">RESERVAR</a>
            </li>
        </ul>
    </nav>

     -->

    <!-- Apartados -->

    <div id="contenedorPrincipal">
        <div class="container my-3">
            <div class="row">
                <div class="col-sm-6 my-1">
                    <div class="h4 bg-dark p-3 text-light rounded">
                        Información Personal
                    </div>
                    <form action="#" method="post">

                        <div class="row mb-3">
                            <div class="col-md-6">
                                <label for="email" class="form-label">Correo Electrónico:</label>
                                <input type="email" id="email" name="email" class="form-control" required>
                            </div>
                            <div class="col-md-6">
                                <label for="apellido" class="form-label">Apellido:</label>
                                <input type="text" id="apellido" name="apellido" class="form-control" required>
                            </div>
                        </div>

                        <div class="row mb-3">

                            <div class="col-md-6">
                                <label for="telefono" class="form-label">Teléfono:</label>
                                <input type="tel" id="telefono" name="telefono" class="form-control">
                            </div>
                            <div class="col-md-6">
                                <label for="numero_documento" class="form-label">Número de Documento:</label>
                                <input type="text" id="numero_documento" name="numero_documento" class="form-control">
                            </div>
                        </div>

                        <div class=" mb-3">
                            <div class="col-md-2">
                                <label for="edad" class="form-label">Edad:</label>
                                <input type="number" min="18" max="121" id="edad" name="edad" class="form-control">
                            </div>
                        </div>

                        <div class="row mb-3">
                            <div class="col-md-12">
                                <label for="comentarios" class="form-label">Comentarios:</label>
                                <textarea id="comentarios" name="comentarios" class="form-control" rows="4" cols="50"></textarea>
                            </div>
                        </div>

                        <!-- Otros campos del formulario aquí -->
                        <div class="row mb-3">
                            <div class="col-md-8">
                                <label for="cupon_membresia" class="form-label text-muted">Ingrese cupón de Membresía (opcional):</label>
                                <input type="text" id="cupon_membresia" name="cupon_membresia" class="form-control bg-light border">
                            </div>
                        </div>




                    </form>

                    <!--termino y condiciones -->
                    <div class="container mt-5">
                        <div class="row">
                            <div class="col-md-6">
                                <p class="text-left">Por favor, lee y acepta nuestros <a href="#">términos y condiciones</a> antes de continuar.</p>
                                <div class="form-check">
                                    <input type="checkbox" class="form-check-input" id="aceptarTerminos">
                                    <label class="form-check-label" for="aceptarTerminos">Acepto los términos y condiciones</label>
                                </div>
                                <button type="button" class="btn btn-primary mt-3" id="btnAceptar">Aceptar</button>
                            </div>
                        </div>
                    </div>

                    </form>
                </div>

                <div class="col-sm-6 my-1">
                    <div class="h4 bg-dark p-3 text-light rounded">
                        Información de Reserva
                    </div>
                    <!--contenido-->

                    <div class="col-sm-12">
                        <div class="bg-dark h6 text-light rounded p-2">
                            Detalla de Reserva
                        </div>
                        <div class=" text-center">
                            <!-- Contenido del nuevo div 1 -->
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde veniam sit
                            dignissimos ipsum reiciendis atque exercitationem quibusdam inventore et at recusandae s
                            aepe rem maxime commodi aperiam, consectetur, soluta tenetur!
                            <p></p>
                            <button type="button" class="btn btn-primary mb-3">Modificar</button>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12">
                            <div class="bg-dark h6 text-light rounded p-2">
                                (aca va el tipo de habitacion)
                            </div>
                            <div class="text-center ">
                                <!-- Contenido del nuevo div 2 -->

                                <div class="card" style="width: 18rem;">
                                    <img class="card-img-top" src="../img/home_salta.jpg" alt="Card image cap">
                                    <div class="card-body text-left"> <!-- Agrega la clase text-left aquí -->
                                        <h5 class="card-title"> <b>Junior Suite</b> </h5>
                                        <!-- Información adicional -->
                                        <ul class="list-unstyled">
                                            <li><strong>Camas:</strong> Queen o camas Twin.</li>
                                            <li><strong>Ocupación:</strong> Single, Doble o Triple.</li>
                                            <li><strong>Cama Extra:</strong> Si (con cargo).</li>
                                            <li><strong>Vista:</strong> Vista al lago.</li>
                                            <li><strong>Dimensión:</strong> 35 m².</li>
                                            <li><strong>Aire Acondicionado.</strong></li>
                                            <li><strong>Escritorio.</strong></li>
                                            <li><strong>Amenidades especiales.</strong></li>
                                        </ul>
                                        <!-- Fin de información adicional -->
                                        <a href="#" class="btn btn-primary">matias monzon</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="my-4">
                        <div style="background-color: #cccccc;" class=" p-4 rounded">
                            <!-- Subtítulo a la izquierda en negritas -->
                            <h6 class="text-left" style="font-weight: 600;">Términos de pago</h6>
                            <!-- Contenido de tu div aquí -->
                            <p>
                                Es necesaria una tarjeta de crédito válida y se le cobrará el monto completo de la reserva con impuestos incluidos en cualquier momento luego de confirmar la reserva. A los huéspedes extranjeros que cumplan los requisitos, se les reintegrará el IVA (21%) al momento del check-in a la misma tarjeta de la cual se ha cobrado la reserva. Pasajeros argentinos abonarán en pesos a la cotización del día.
                            </p>
                        </div>
                    </div>




                </div>


            </div>
        </div>
    </div>

    <!-- Footer -->

    <footer class="footer">
        <div class="container text-start">
            <div class="row mb-4">
                <div class="col-md-12 text-center">
                    <a href="#"><img src="../img/facebook-logo.png" alt="Facebook" class="mx-3" width="20"></a>
                    <a href="#"><img src="../img/instagram-logo.png" alt="Instagram" class="mx-3" width="20"></a>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <img src="../img/logo.png" alt="Logo" class="footer-logo" style="filter: invert(100%);">
                    <p class="text-start">
                        Design Suites son modernos hoteles ubicados en distintas ciudades de Argentina.
                        <br>
                        <br>
                        Design Suites<br>
                        Hotel 4 estrellas<br>
                        Disposición Turística 181-A-2017
                    </p>
                </div>
                <div class="col-md-4">
                    <p class="fs-2 fw-light text-uppercase">Design Suites</p>
                    <ul class="footer-list list-unstyled">
                        <li><a class="text-light" href="">Home</a></li>
                        <br>
                        <li><a class="text-light" href="">Buenos Aires</a></li>
                        <br>
                        <li><a class="text-light" href="">Bariloche</a></li>
                        <br>
                        <li><a class="text-light" href="">Calatafè</a></li>
                        <br>
                        <li><a class="text-light" href="">Salta</a></li>
                        <br>
                        <li><a class="text-light" href="">Contacto</a></li>
                    </ul>
                </div>
                <div class="col-md-4">
                    <p class="fs-2 fw-light text-uppercase">Contactenos</p>
                    <p></p>
                    <p>123 Calle Principal, Ciudad</p>
                    <p></p>
                    <p>Teléfono: 123-456-7890</p>
                    <p></p>
                    <p>Email: info@example.com</p>
                </div>
            </div>

        </div>
    </footer>
</body>
<script src="js/bootstrap.bundle.js"></script>
<script src="js/app.js"></script>

</html>