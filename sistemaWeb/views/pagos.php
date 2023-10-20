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
                        <input type="email" id="email" name="email" class="form-control" required>
                    </div>
                    <div class="col-md-6">
                        <label for="apellido" class="form-label">Apellido:</label>
                        <input type="text" id="apellido" name="apellido" class="form-control" maxlength="50" required>
                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-md-6">
                        <label for="telefono" class="form-label">Teléfono:</label>
                        <input type="tel" id="telefono" name="telefono" class="form-control" maxlength="50" required>
                    </div>
                    <div class="col-md-6">
                        <label for="numero_documento" class="form-label">Número de Documento:</label>
                        <input type="text" id="numero_documento" name="numero_documento" class="form-control" maxlength="50" required>
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
                <input type="hidden" id="checkInValue" name="checkIn">
                <input type="hidden" id="checkOutValue" name="checkOut">
                <input type="hidden" id="reservasStr" name="reservas">
                <!--termino y condiciones -->
                <div class="container mt-5">
                    <div class="row">
                        <div class="col-md-6">

                            <p class="text-left">Por favor, lee y acepta nuestros <a href="#" id="openModal" data-bs-toggle="modal" data-bs-target="#myModal">términos y condiciones</a> antes de continuar.</p>
                            <!--modal-->
                            <div class="modal fade" id="myModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                <div class="modal-dialog modal-xl"> <!-- Utilizamos modal-xl para hacerlo más ancho -->
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h5 class="modal-title" id="exampleModalLabel">Términos y Condiciones</h5>
                                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Cerrar"></button>
                                        </div>
                                        <div class="modal-body" style="max-height: 70vh; overflow-y: auto;"> <!-- Agregamos una altura máxima y la barra de desplazamiento -->
                                            <!-- Contenido de tus términos y condiciones aquí -->
                                            Términos y Condiciones para la Reserva de Habitación en Design Suites
                                            <p></p>
                                            Este sitio web es operado por Design Suites y brindamos nuestros productos y servicios bajo los siguientes Términos y Condiciones. Los mismos, podrán ser periódicamente modificados y actualizados por Design Suites sin notificación previa al Usuario ni a ninguna otra persona física o jurídica. Por esta razón, Design Suites sugiere la revisión periódica de estos Términos y Condiciones cada vez que se acceda a la página Web.

                                            El acceso a la página Web implica la aceptación y conocimiento por parte del Usuario de los siguientes Términos y Condiciones:
                                            <p></p>
                                            POLÍTICA DE PAGO
                                            <p></p>
                                            Una vez que complete su reserva y efectúe el pago, usted recibirá nuestro correo de confirmación. El precio será cobrado en pesos argentinos y en su factura aparecerá Design Suites.
                                            <p></p>
                                            RECLAMOS
                                            <p></p>
                                            Si usted considera que los servicios ofrecidos no cumplen lo acordado entre usted y Design Suites, o en el caso de objeciones o situaciones que eviten el desenvolvimiento normal de los servicios, debe notificar de inmediato a nuestro establecimiento. Los datos de contacto están disponibles en los documentos y mensajes de confirmación de su reserva. La ausencia de esta notificación inmediata limitará a Design Suites en la búsqueda de una solución adecuada. No obstante, si después de contactarnos, no se logra una solución adecuada, usted podrá cursar un reclamo escrito, en el término de siete (7) días siguientes a la fecha de la finalización del servicio en cuestión.
                                            <p></p>
                                            REEMBOLSOS
                                            <p></p>
                                            En el caso de existir algún tipo de reembolso, el mismo se realizará mediante transferencia bancaria. Nuestro propósito es tramitar el reembolso dentro de las 72 horas siguientes de haberle ofrecido una respuesta concluyente a su solicitud. Aunque nos esforzamos para garantizar la disponibilidad de los servicios reservados, en ocasiones pueden ocurrir errores. Una vez que nos percatemos de estos, haremos todo lo razonablemente posible para informarle durante las 48 horas posteriores a su reserva. Nos reservamos el derecho de cancelar su reservación y reembolsarle el monto total pagado, sin ningún cargo para usted.
                                            <p></p>
                                            HOSPEDAJE Y PRECIOS
                                            <p></p>
                                            Design Suites brindará hospedaje a la persona a cuyo nombre se realizó la reserva (el "pasajero principal") y al número exacto de personas acompañantes incluidas en la reserva de cada habitación. El pasajero principal debe estar presente durante el check-in, y todos los huéspedes deben presentar un pasaporte o documento válido. Las habitaciones están generalmente disponibles a partir de las 14:00 horas, el día de arribo, y el check-out debe realizarse no más tarde de las 11:00 horas, el día de partida. Normalmente las habitaciones cuentan con 1 o 2 camas. Camas adicionales o cunas no se garantizan, por tanto, la ocupación máxima se entiende compartiendo camas existentes, salvo que el hotel en cuestión tenga disponibilidad de otorgar alguna.
                                            <p></p>
                                            POLÍTICA SOBRE NIÑOS
                                            <p></p>
                                            Niños de hasta 1 año y 11 meses de edad no tienen costo. Las cunas deberán ser directamente solicitadas en el hotel, sin costo extra. En caso de no existir cunas disponibles, los infantes deberán compartir la cama con los padres. Normalmente, son considerados niños, los pasajeros comprendidos entre 2 y 11 años, y abonan y deben incluirse en la reserva, como un pasajero adulto. La mayoría de las habitaciones no tienen espacio para una cama adicional para los niños, y por lo tanto, la capacidad máxima es la misma tanto para adultos como niños. Los niños, de 12 o más años de edad, deberán incluirse en la reserva como adultos.
                                            <p></p>
                                            POLÍTICA DE PAGO Y CANCELACIONES
                                            <p></p>
                                            La siguiente política de cancelación se aplica una vez que se haya confirmado su reserva:
                                            Términos especiales de cancelación se aplican para estadías en Temporada Alta, siendo esta la comprendida en la Temporada de Verano, Semana Santa, Fines de semana largo, Rally Mundial y otras épocas en las cuales el Design Suites así lo establezca. Si usted cancela su reserva antes de los 15 días de cumplirse su fecha de arribo planificada, le reembolsaremos la totalidad de la suma abonada. Si usted cancela su reserva en un plazo menor a los 15 días anteriores a su fecha de arribo planificada, tendrá una penalidad equivalente al 50% de la estadía. Si Usted no se presenta (No Show) el día de su fecha planificada de arribo, no se hará devolución alguna: la penalidad será del 100%. Durante el resto del año, si usted cancela con 5 días o más de antelación a la fecha de arribo planificada, le reembolsaremos la totalidad de la suma abonada. Si usted cancela su reserva con menos de 5 días anteriores a su fecha de arribo planificada, tendrá una penalidad equivalente al 50% de la estadía. Si Usted no se presenta (No Show) el día de su fecha planificada de arribo, no se hará devolución alguna: la penalidad será del 100%. En todos los casos que se produzcan devoluciones, el importe tendrá un descuento equivalente a los impuestos abonados por el Design Suites y los recargos y gastos correspondientes ya deducidos por las entidades crediticias (Bancos, Entidades Financieras o Tarjetas de Crédito). En el caso de salidas imprevistas que no han sido fehacientemente comunicadas al hotel, con anterioridad al Check-In, se penalizará al cliente facturándole el total de la estadía reservada oportunamente. En el caso que el cliente haya abonado con anterioridad al Check-In el total de la estadía, no podrá reclamar la devolución del importe facturado.
                                            <p></p>
                                            CONDICIONES GENERALES
                                            <p></p>
                                            Usted acepta estar sujeto a las siguientes obligaciones, incluyendo y sin limitación:

                                            Usted asume responsabilidad financiera por todas las transacciones realizadas bajo su nombre o cuenta.
                                            Para realizar cualquier compra, debe tener más de 18 años de edad, hacer la compra para uso personal y tener capacidad legal para efectuar la transacción.
                                            Usted
                                            <!-- ... Tu contenido ... -->
                                        </div>
                                        <div class="modal-footer">
                                            <button type="button" class="btn btn-primary mt-3" data-bs-dismiss="modal" id="botonAcepto">Acepto términos</button>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            
                            <div class="form-check">
                                <input type="checkbox" class="form-check-input" id="aceptarTerminos" required>
                                <label class="form-check-label" for="aceptarTerminos">Acepto los términos y condiciones</label>
                                <script>
                                    document.getElementById("botonAcepto").addEventListener("click", function() {
                                        document.getElementById("aceptarTerminos").checked = true;
                                        $('#myModal').modal('hide'); // Cierra la ventana modal
                                    });
                                </script>

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
            <div class="d-flex flex-wrap w-100 my-2">
                <div class="d-flex flex-column flex-fill text-center">
                    <span class="bg-dark text-white fs-4">Fecha de Entrada</span>
                    <span class="bg-secondary text-dark fs-4" id="pagosCheckIn">11/10/2023</span>
                </div>
                <hr class="vr">
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
                        <div class="row bg-dark text-center m-auto">
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