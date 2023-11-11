<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet"
        href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/customStyles.css">
    <link rel="shortcut icon" type="image/x-icon" style="font-size: 130px;" href="../img/logo-dark.png">
    <title>
        <?php echo (ucfirst($_GET['sec'])); ?> - Design Suites
    </title>
</head>

<body>
    <?php
        require_once "includes/config.php";
        require_once "modelos/builder.php";

        $hotelesButtons = "";
        $hotelesOp = "";
        foreach($filas as $index => $fila){
            $hotelesButtons .= '<button class="dropdown-item" type="submit" name="hotel" value="'.$index.'">'.$fila['nombre'].'</button>';
            $hotelesOp .= '<option value="'.$index.'">'.$fila['nombre'].'</option>';
        }
    ?>
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
                    <a class="nav-link active" style="font-size: 13px;" href="?sec=protocolo"
                        aria-current="page">PROTOCOLO DE SEGURIDAD</a>
                </li>
                <br>
                <li class="nav-item d-flex align-items-center mx-5">
                    <a class="nav-link active border border-light mx-2 text-center" target="_blank"
                        style="height: 42px; width: 42px" href="https://www.facebook.com/designsuites"
                        aria-current="page">
                        <img src="../img/f.png" alt="facebooklogo" width="13">
                    </a>
                    <a class="nav-link active border border-light mx-2 text-center" target="_blank"
                        style="height: 42px; width: 42px" href="https://www.instagram.com/designsuites/"
                        aria-current="page">
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
                    <button class="btn btn-dark dropdown-toggle" type="button" data-bs-toggle="dropdown"
                        aria-expanded="false">
                        HOTELES
                    </button>

                    <form action="?sec=hoteles" method="POST">
                        <ul class="dropdown-menu">
                            <?php   
                                echo $hotelesButtons;
                            ?>
                        </ul>
                    </form>
                </div>
            </li>
        <!-- shh
            <li class="nav-item mx-2 my-1">
                <a href="?sec=membresias" class="btn btn-dark" role="button">MEMBRESIAS</a>
            </li>
        -->
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
                <button type="button" onclick="selectedRooms()" class="btn px-3 py-0 bg-light"
                    style="font-weight: 700; line-height: 29px">HABITACIONES</button>
            </li>
            <li class="nav-item px-3 py-md-2 py-sm-2 py-2 py-xl-0">
                <button type="button" onclick="selectedEvents()" class="btn px-3 py-0 bg-light" style="font-weight: 700; line-height: 29px">SALA DE
                    EVENTOS</button>
            </li>
        </ul>
    </nav>
    
    <div id="reservasOp" style="display: none;">
        <form action="?sec=reservas" method="POST" class="d-flex flex-wrap justify-content-center align-items-center" onsubmit="alert('Se ha enviado queja'); return false;">
            <li class="nav-item px-5 my-1">
                <div class="d-flex gap-2 align-items-center">
                    <span class="material-symbols-outlined" onclick="back()" style="color: white; cursor: pointer;">reply</span>
                    <a class="nav-link active text-center" style="font-weight: 700;" aria-current="page" id="reservaType">SALA DE EVENTOS</a>
                </div>
            </li>

            <li class="nav-item px-2 my-1">
                <select class="form-select" style="width: 260px; height: 30px; line-height: 14px;" name="hotel">
                    <?php   
                        echo $hotelesOp;
                    ?>
                </select>
            </li>

            <div id="dateInputs" class="d-flex flex-wrap justify-content-center"></div>

            <li class="nav-item px-2 my-1">
                <input type="submit" value="RESERVAR" class="form-control btn btn-light"
                    style="width: 130px; line-height: 14px; font-weight: 700;"  aria-current="page">
            </li>
        </form>
    </div>

    <!-- Apartados -->

    <div id="contenedorPrincipal" class="position-relative">
        <div class="customLoading position-absolute align-items-center w-100 h-100 bg-dark" style="display: none;" id="loadingScreen">
            <div class="spinner-border m-auto text-secondary" role="status">
                <span class="sr-only"></span>
            </div>
        </div>

        <?php
            require_once 'views/' . $_GET['sec'] . ".php";
        ?>
        <br>
    </div>

    <!-- Footer -->
    <div class="footer bg-dark">
        <div class="container">
            <footer class="row row-cols-1 row-cols-sm-2 row-cols-md-5 py-3">
                <div class="col d-flex flex-column align-items-center">
                    <a href="?sec=home" class="d-flex align-items-center mb-3 link-dark text-decoration-none">
                        <img src="../img/logo.png" alt="Logo" class="" style="filter: invert(100%);">
                    </a>
                    <p class="text-muted">© 2023 Design Suites, Inc.</p>
                </div>

                <div class="col mb-3 d-none d-md-block"></div>
                <div class="col mb-3 d-none d-md-block"></div>
                <div class="col mb-3 d-none d-md-block"></div>

                <div class="col d-flex flex-column align-items-center align-items-md-start mt-5 mt-md-0">
                    <h5>Design Suites</h5>
                    <ul class="nav flex-column align-items-center align-items-md-start">
                        <li class="nav-item mb-2"><a href="?sec=home" class="nav-link p-0 text-muted">Home</a></li>
                        <li class="nav-item mb-2"><a href="?sec=contacto" class="nav-link p-0 text-muted">Contacto</a></li>
                        <li class="nav-item mb-2"><a href="?sec=protocolo" class="nav-link p-0 text-muted">Protocolo</a></li>
                        <li class="nav-item mb-2"><a href="?sec=cancelar-reserva" class="nav-link p-2 bg-danger rounded text-white">Boton de Arrepentimiento</a></li>
                    </ul>
                </div>

                <!--
                <div class="col mb-3">
                    <h5>Section</h5>
                    <ul class="nav flex-column">
                        <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">Home</a></li>
                        <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">Features</a></li>
                        <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">Pricing</a></li>
                        <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">FAQs</a></li>
                        <li class="nav-item mb-2"><a href="#" class="nav-link p-0 text-muted">About</a></li>
                    </ul>
                </div> -->
            </footer>
        </div>
    </div>
</body>
<script src="js/bootstrap.bundle.js"></script>
<script src="js/app.js"></script>

</html>