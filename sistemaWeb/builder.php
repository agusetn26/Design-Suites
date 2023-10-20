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
                    <a class="nav-link active" style="font-size: 13px;" href="https://www.designsuites.com/protocolo.php"
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
        <form action="?sec=reservas" method="POST" class="d-flex flex-wrap justify-content-center align-items-center" onsubmit="return verifData(this);">
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