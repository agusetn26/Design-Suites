using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sistemaHoteles.DAL
{
    class reservaHabitacionesDAL
    {
        config conn;
        public reservaHabitacionesDAL()
        {
            conn = new config();
        }

        public DataSet bringDataHeaders(string filters)
        {
            string sql = "SELECT clientes.dni as Cliente, codigo as Codigo, tipoHabitacion.nombre as Habitacion, checkIn as 'In', checkOut as 'Out', " +
                            "(cantidadPersonas * tipoHabitacion.costo) AS Total, estado as Estado FROM reservaHabitaciones " +
                            "JOIN habitaciones ON habitaciones.id_habitacion = reservaHabitaciones.id_habitacion " +
                            "JOIN tipoHabitacion ON tipoHabitacion.id_tipoHabitacion = habitaciones.id_tipoHabitacion " +
                            "JOIN clientes ON clientes.id_cliente = reservaHabitaciones.id_cliente " +
                            filters;

            return conn.returnData(sql);
        }

        public DataSet bringRecordsAmount(string filters)
        {
            string sql = "SELECT CASE WHEN COUNT(*) = 0 THEN 1 ELSE COUNT(*) END as total FROM reservaHabitaciones " +
                            "JOIN habitaciones ON habitaciones.id_habitacion = reservaHabitaciones.id_habitacion " +
                            filters;

            return conn.returnData(sql);
        }
        public void acceptReservas(string codes)
        {
            string sql = $"UPDATE reservaHabitaciones SET estado = 'aceptado' WHERE codigo IN ({codes})";
            Console.WriteLine(sql);
            SqlCommand comm = new SqlCommand(sql);
            conn.nonReturnData(comm);
        }

        public void rejectReservas(string codes)
        {
            string sql = $"UPDATE reservaHabitaciones SET estado = 'rechazado' WHERE codigo IN ({codes})";
            SqlCommand comm = new SqlCommand(sql);
            conn.nonReturnData(comm);
        }
    }
}
