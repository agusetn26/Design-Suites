<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/customStyles.css">
</head>

<body>
    <!-- Nav bar -->

    <div class="row py-2 mx-5">
        <div class="col-lg-2 text-center">
            <img src="../img/logo.png" alt="DESING SUITES LOGO">
        </div>
        <div class="navmenu col-lg-10 d-lg-flex justify-content-end align-items-center text-center fs-4 pt-2">
            <a href="#" class="fw-light text-dark text-uppercase ms-3">Buenos Aires</a>
            <a href="#" class="fw-light text-dark text-uppercase ms-3">Bariloche</a>
            <a href="#" class="fw-light text-dark text-uppercase ms-3">Calafate</a>
            <a href="#" class="fw-light text-dark text-uppercase ms-3">Salta</a>
            <a href="#" class="fw-light text-dark text-uppercase ms-3">Contacto</a>
        </div>
    </div>


    <!-- Reservas -->

    <div class="row text-uppercase text-white fw-bold py-2" style="background-color: #5555FF;">
        <p class="col-md-2 text-center m-0">Reservas Online</p>
        <select name="" id="" class="col-md-3 ms-2">
            <option selected="selected">Seleccione el hotel</option>
        </select>
        <input type="date" placeholder="ENTRADA" class="col-md-2 ms-2">
        <input type="date" placeholder="SALIDA" class="col-md-2 ms-2">
        <input type="submit" value="RESERVAR" class="col-md-2 ms-2 p-0">
    </div>

    <!-- Apartados -->

    <div id="contenedorPrincipal">
        <?php //require_once 'views/' . $_GET['sec']?>
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
                        <li><a href="">Home</a></li>
                        <br>
                        <li><a href="">Buenos Aires</a></li>
                        <br>
                        <li><a href="">Bariloche</a></li>
                        <br>
                        <li><a href="">Calatafè</a></li>
                        <br>
                        <li><a href="">Salta</a></li>
                        <br>
                        <li><a href="">Contacto</a></li>
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
</html>