<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <style>
        body {
            margin: 0;
            padding: 0;
            display: flex;
            flex-direction: column;
            min-height: 100vh;
            position: relative;
        }

        .footer {
            background-color: #000;
            color: #fff;
            padding: 30px 0;
            position: absolute;
            bottom: 0;
            width: 100%;
        }

        .footer-logo {
            max-width: 200px;
            margin-bottom: 40px;
        }

        .mr-3 {
            max-width: 20px;
            margin-bottom: 20px;
            margin: 0 10px;
        }

        h4 {
            font-size: 40px;
        }
    </style>
</head>

<body>
    <!-- Nav bar -->
    <!-- Reservas -->
    <footer class="footer">
        <div class="container text-center">
            <div class="row mb-4">
                <div class="col-md-12 text-center">
                    <a href="#"><img src="facebook-logo.png" alt="Facebook" class="mr-3"></a>
                    <a href="#"><img src="instagram-logo.png" alt="Instagram" class="mr-3"></a>
                </div>
            </div>
            <div class="row">

                <div class="col-md-4">
                    <img src="logo.png" alt="Logo" class="footer-logo">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce tempus arcu vel justo lacinia, eu vehicula metus cursus.</p>
                </div>
                <div class="col-md-4">
                    <h4>Design Suites</h4>
                    <ul class="list-unstyled">
                        <p></p>
                        <li>Home</li>
                        <p></p>
                        <li>Buenos Aires</li>
                        <p></p>
                        <li>Bariloche</li>
                        <p></p>
                        <li>Calatafè</li>
                        <p></p>
                        <li>Salta</li>
                        <p></p>
                        <li>Contacto</li>
                    </ul>
                </div>
                <div class="col-md-4">
                    <h4>Contactenos</h4>
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
    <div id="contenedorPrincipal">
        <?php //require_once 'views/' . $_GET['sec']
        ?>
    </div>
</body>

</html>