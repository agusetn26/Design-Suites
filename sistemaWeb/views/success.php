<?php
    if(empty($_POST)){
        echo "<script>window.location.href='index.php';</script>";
        exit;
    }
?>

<div class="container my-5" style="max-width: 500px;">
    <div class="alert alert-success text-center p-4">
        <h4 class="alert-heading">¡Se ha realizado la reserva con éxito!</h4>
        <p class="mb-4">Puedes modificar o cancelar tu reserva utilizando el siguiente código:</p>
        <div class="input-group mb-3">
            <input type="text" class="form-control" value="<?php echo $_POST['code']?>" id="clipboardText" readonly>
            <div class="input-group-append">
                <button class="btn btn-outline-success" onclick="copyToClipboard()">Copiar</button>
            </div>
        </div>
        <p class="text-secondary">La reserva quedará invalidada si no te presentas en la fecha de entrada, no se aceptan devoluciones.</p>
    </div>
</div>
<script>
    function copyToClipboard() {
        var clipboardText = document.getElementById("clipboardText");
        clipboardText.select();
        document.execCommand("copy");
        alert("¡Copiado!");
    }
</script>