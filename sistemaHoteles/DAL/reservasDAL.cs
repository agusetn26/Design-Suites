using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sistemaHoteles.DAL
{
    class reservasDAL
    {
        config conn;
        public reservasDAL()
        {
            conn = new config();
        }

        public DataSet bringDataHeaders(string table)
        {
                        Console.WriteLine(table);

            string sql = table == "Habitaciones" ?
                            "SELECT TOP 0 clientes.dni as Cliente, codigo as Codigo, tipoHabitacion.nombre as Habitacion, checkIn, checkOut, " +
                            "(cantidadPersonas * tipoHabitacion.costo) AS Total, estado as Estado FROM reservaHabitaciones " +
                            "JOIN habitaciones ON habitaciones.id_habitacion = reservaHabitaciones.id_habitacion " +
                            "JOIN tipoHabitacion ON tipoHabitacion.id_tipoHabitacion = habitaciones.id_tipoHabitacion " +
                            "JOIN clientes ON clientes.id_cliente = reservaHabitaciones.id_cliente"
                            :
                            "SELECT TOP 0 clientes.dni as Cliente, codigo as Codigo, eventos.nombre as Evento, eventos.fecha_alta as 'Dia', " +
                            "checkIn, checkOut, estado as Estado FROM reservaEventos " +
                            "JOIN clientes ON clientes.id_cliente = reservaEventos.id_cliente " +
                            "JOIN eventos ON eventos.id_evento = reservaEventos.id_evento";


            return conn.returnData(sql);
        }

        public DataSet bringDataRows(int idH, int start, string table)
        {
            Console.WriteLine(table);
            string sql = table == "Habitaciones" ?
                            "SELECT clientes.dni as cliente, codigo, tipoHabitacion.nombre, checkIn, checkOut, " +
                            "(cantidadPersonas * tipoHabitacion.costo) AS total, estado FROM reservaHabitaciones " +
                            "JOIN habitaciones ON habitaciones.id_habitacion = reservaHabitaciones.id_habitacion " +
                            "JOIN tipoHabitacion ON tipoHabitacion.id_tipoHabitacion = habitaciones.id_tipoHabitacion " +
                            "JOIN clientes ON clientes.id_cliente = reservaHabitaciones.id_cliente " +
                            $"WHERE habitaciones.id_hotel = {idH} ORDER BY id_hotel OFFSET {start} ROWS FETCH NEXT 2 ROWS ONLY"
                            :
                            "SELECT clientes.dni as Cliente, codigo as Codigo, eventos.nombre as Evento, eventos.fecha_alta as 'Dia', " +
                            "checkIn, checkOut, estado as Estado FROM reservaEventos " +
                            "JOIN clientes ON clientes.id_cliente = reservaEventos.id_cliente " +
                            "JOIN eventos ON eventos.id_evento = reservaEventos.id_evento " +
                            $"WHERE eventos.id_hotel = {idH} ORDER BY id_hotel OFFSET {start} ROWS FETCH NEXT 2 ROWS ONLY";

            return conn.returnData(sql);
        }
    }
}
