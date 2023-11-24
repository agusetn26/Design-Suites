<div class="container my-3">
    <div class="row">
            <div class="col-md-6 my-1">
                <div class="h4 bg-dark p-3 text-light rounded">
                    Información Personal
                </div>
                <form action="?sec=success" onsubmit="return submitPago(this);" method="POST">
                    <div class="row mb-3">
                        <div class="col-md-6">
                            <label for="email" class="form-label">Correo Electrónico:</label>
                            <input type="email" id="email" name="email" class="form-control" required maxlength="40">
                        </div>
                        <div class="col-md-6">
                            <label for="apellido" class="form-label">Apellido:</label>
                            <input type="text" id="apellido" name="apellido" class="form-control" maxlength="40" required>
                        </div>
                    </div>
                    <div class="row mb-3">
                        <div class="col-md-6">
                            <label for="telefono" class="form-label">Teléfono:</label>
                            <input type="tel" id="telefono" name="telefono" class="form-control" maxlength="40" required>
                        </div>
                        <div class="col-md-6">
                            <label for="numero_documento" class="form-label">Número de Documento:</label>
                            <input type="text" id="numero_documento" name="numero_documento" class="form-control"  maxlength="40" required>
                        </div>
                    </div>
                    <div class=" mb-3">
                        <div class="col-md-2">
                            <label for="edad" class="form-label">Edad:</label>
                            <input type="number" min="18" max="150" id="edad" name="edad" class="form-control" required>
                        </div>
                    </div>
                    <div class="row mb-3">
                        <div class="col-md-12">
                            <label for="comentarios" class="form-label">Comentarios: (opcional)</label>
                            <textarea id="comentarios" name="comentarios" class="form-control" rows="4" cols="40" maxlength="499"></textarea>
                        </div>
                    </div>
                    <!-- Otros campos del formulario aquí -->
                  
                    <input type="hidden" id="inDateValue" name="inDate">
                    <input type="hidden" id="checkInValue" name="checkIn">
                    <input type="hidden" id="checkOutValue" name="checkOut">
                    <input type="hidden" id="reservasStr" name="reservas">
                <!--termino y condiciones -->
                    <div class="container mt-5">
                        <div class="row">
                            <div class="col-md-6">
                                <p class="text-left">Por favor, lee y acepta nuestros <a href="#">términos y condiciones</a> antes de continuar.</p>
                                <div class="form-check">
                                    <input type="checkbox" class="form-check-input" id="aceptarTerminos" required>
                                    <label class="form-check-label" for="aceptarTerminos">Acepto los términos y condiciones</label>
                                </div>
                                <input type="submit" class="btn btn-primary mt-3" value="Aceptar" id="btnAceptar">
                            </div>
                        </div>
                    </div>
                    <input type="hidden" id="hashCode" name="code">
                </form>
            </div>

            <div class="col-md-6 my-1">
                <div class="h4 bg-dark p-3 text-light rounded">
                    Información de Reserva
                </div>
                <div class="d-flex flex-column w-100 my-2">
                    <div class="d-flex flex-column flex-fill text-center">
                        <span class="bg-dark text-white fs-4">Hotel seleccionado</span>
                        <span class="bg-secondary text-dark fs-4" id="hotelIn">Buenos Aires</span>
                    </div>
                    <div class="d-flex flex-column flex-fill text-center">
                        <span class="bg-dark text-white fs-4">Fecha de Entrada</span>
                        <span class="bg-secondary text-dark fs-4" id="pagosCheckIn">11/10/2023</span>
                    </div>
                    <div class="d-flex flex-column flex-fill text-center">
                        <span class="bg-dark text-white fs-4">Fecha de Salida</span>
                        <span class="bg-secondary text-dark fs-4" id="pagosCheckOut">11/10/2023</span>
                    </div>
                </div>
                
                <div class="col-sm-12 ">
                    <div class="bg-dark h6 text-light rounded p-2">
                        Detalles de Reserva
                    </div>
                    <div style="overflow: hidden; height: 370px;">
                        <div id="pagosContenedor" class="overflow-auto h-100">
                            <div class="row bg-dark text-center m-auto" >
                                <img class="col-6 p-0" src="../img/home_salta.jpg" alt="Card image cap">
                                <div class="col-6 d-flex flex-column text-white text-center p-1">
                                    <h5 class="card-title fs-2"> <b>Junior Suite</b> </h5>
                                    <hr class="m-0">
                                    <div class="row d-flex align-items-center p-0 fs-3 h-100">
                                        <div class="col-lg-6" title="Cantidad de personas">
                                            2
                                            <span class="material-symbols-outlined cant-per2">person</span><span class="material-symbols-outlined cant-per2">person</span>
                                        </div>
                                        <div class="col-lg-6 fs-2">
                                            $500
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="fs-3 text-white p-4 my-2 bg-dark">
                        <div class="row">
                            <div class="col-6">
                                TOTAL
                            </div>
                            <div class="col-6 text-end">
                                <span id="pagosTotalesReserva">$500</span>
                            </div>
                        </div>
                        <hr class="m-0">
                    </div>
                    <button onclick='showLoadingScreen(); location.reload();' type="button" class="form-control btn btn-dark mb-3">Modificar reserva</button>
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