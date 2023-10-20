<?php
    date_default_timezone_set("America/Argentina/Buenos_Aires");
    //echo  date_default_timezone_get();
    $archivo = "reserva" . ucfirst($_POST["type"]) . ".php";

    if(!file_exists("modelos/" . $archivo)){
        echo '<div class="w-100 fs-1 fw-bold text-center my-5">La página consultada no existe</div>';
        exit;
    }

    require_once "modelos/" . $archivo;
?>

<div class="container my-5" id="reservasBuilder">
    <?php require_once "views/" . $archivo ?>
</div>

<script src="js/<?php echo "reserva" . ucfirst($_POST["type"]) . ".js" ?>"></script>
<script>
    function showLoadingScreen() {
        loadingScreen.style.display = "flex";
        setTimeout(function () {
          loadingScreen.style.opacity = 0.7;
        }, 1); 
      }
      
      
    function hideLoadingScreen() {
      loadingScreen.style.opacity = 0;
      setTimeout(function () {
        loadingScreen.style.display = "none";
      }, 300);
    }
</script>