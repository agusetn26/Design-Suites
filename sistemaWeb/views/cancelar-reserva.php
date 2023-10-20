<div class="modal modal-sheet position-static d-block bg-body-secondary p-4 py-md-5">
    <div class="modal-dialog pe-auto" role="document">
            <div class="modal-header border-bottom-0 bg-dark justify-content-center">
                <h1 class="modal-title fs-5 fw-bolder text-white">Cancelar Reserva</h1>
            </div>
            <div class="modal-body py-2">
                <p class="m-0 text-center">Ingrese el codigo de reserva para poder cancelarla</p>
                <input type="text" id="input-codigo" class="form-control mt-4" placeholder="Ej.: 123235436532c8e04e144">
            </div>
            <div class="d-flex justify-content-center align-items-stretch w-100 gap-2 mt-4 border-top-0">
                <button type="submit" onclick="cancelar_reserva();" class="btn btn-lg btn-danger">Save changes</button>
            </div>
    </div>
</div>