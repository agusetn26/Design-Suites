<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/customStyles.css">
    <title> <?php echo(ucfirst($_GET['sec'])); ?> - Design Suites</title>
</head>

<body>
    <!-- Top -->

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" aria-label="Twelfth navbar example">
        <div class="container-fluid navbar-collapse justify-content-center collapse">
            <ul class="navbar-nav align-items-center">
                <li class="nav-item d-flex align-items-center text-white mx-5">
                    <span class="material-symbols-outlined">
                        call
                    </span>
                    <a class="nav-link active" href="#" aria-current="page">(+54)11 4896-6340</a>
                </li>
                <br>
                <li class="nav-item d-flex align-items-center text-white mx-5">
                    <span class="material-symbols-outlined">
                        verified_user
                    </span>
                    <a class="nav-link active" href="https://www.designsuites.com/protocolo.php" aria-current="page">PROTOCOLO DE SEGURIDAD</a>
                </li>
                <br>
                <li class="nav-item d-flex align-items-center mx-5">
                    <a class="nav-link active border border-light mx-2 text-center" style="height: 42px; width: 42px" href="https://www.facebook.com/designsuites" aria-current="page">
                        <img src="../img/f.png" alt="facebooklogo" width="20">
                    </a>
                    <a class="nav-link active border border-light mx-2 text-center" style="height: 42px; width: 42px" href="https://www.instagram.com/designsuites/" aria-current="page">
                        <img src="../img/i.png" alt="instagramlogo" width="20">
                    </a>
                </li>
            </ul>
        </div>
    </nav>

    <!-- Nav bar -->

    <nav>
        <div class="container">
            <header class="d-flex flex-wrap justify-content-center py-3" style="align-items: center;">
                <a href="?sec=home">
                    <img src="../img/logo.png" alt="logo" width="150" height="75">
                </a>

                <ul class="nav col-lg-auto my-2 justify-content-center my-md-0 text-small">
                    <a class="nav-link text-dark" href="?sec=hoteles&ubi=0" id="navbarDropdown" role="button">
                        BUENOS AIRES
                    </a>
                    <a class="nav-link text-dark" href="?sec=hoteles&ubi=1" id="navbarDropdown" role="button">
                        BARILOCHE
                    </a>
                    <a class="nav-link text-dark" href="?sec=hoteles&ubi=2" id="navbarDropdown" role="button">
                        CALAFATE
                    </a>
                    <a class="nav-link text-dark" href="?sec=hoteles&ubi=3" id="navbarDropdown" role="button">
                        SALTA
                    </a>
                    <li class="nav-item"><a href="#" class="nav-link text-dark">CONTACTO</a></li>
                </ul>
            </header>
        </div>
    </nav>


    <!-- Reservas -->

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <ul class="navbar-nav flex-wrap justify-content-center align-items-center mx-auto">
            <li class="nav-item px-3">
                <a class="nav-link active text-center" style="font-weight: 700;" aria-current="page">RESERVAS ONLINE</a>
            </li>
            <li class="nav-item px-3 py-md-2 py-sm-2 py-2 py-xl-0">
                <select class="form-select" style="width: 260px; height: 30px; line-height: 14px;">
                    <option selected>Seleccione el hotel</option>
                    <option value="1">Buenos Aires</option>
                    <option value="2">Bariloche</option>
                    <option value="3">Calafate</option>
                    <option value="4">Salta</option>
                </select>
            </li>
            <li class="nav-item d-flex flex-wrap justify-content-center px-3 py-md-2 py-sm-2 py-2 py-xl-0">
                <input type="date" name="data" class="border-0 m-2 px-2" style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">
                <input type="date" name="data" class="border-0 m-2 px-2" style="width: 260px; height: 35px; line-height: 14px; border-radius: 8px;">
            </li>
            <li class="nav-item px-3 py-md-2 py-sm-2 py-2 py-xl-0">
                <a class="nav-link active bg-light text-dark rounded text-center" style="width: 130px; line-height: 14px; font-weight: 700;" href="#" aria-current="page">RESERVAR</a>
            </li>
        </ul>
    </nav>



    <!-- Apartados -->

    <div id="contenedorPrincipal">
        <?php
        require_once 'views/' . $_GET['sec'] . ".php";
        ?>
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

</html>