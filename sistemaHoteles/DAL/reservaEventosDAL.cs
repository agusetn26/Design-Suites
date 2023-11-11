using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sistemaHoteles.DAL
{
    class reservaEventosDAL
    {
        private config conn;
        public reservaEventosDAL()
        {
            conn = new config();
        }
        public DataSet bringDataHeaders(string filters)
        {
            string sql = "SELECT clientes.dni as Cliente, codigo as Codigo, eventos.nombre as Evento, eventos.fecha_alta as 'Dia', " +
                            "checkIn, checkOut, estado as Estado FROM reservaEventos " +
                            "JOIN clientes ON clientes.id_cliente = reservaEventos.id_cliente " +
                            "JOIN eventos ON eventos.id_evento = reservaEventos.id_evento " +
                            filters;

            return conn.returnData(sql);
        }
        public DataSet bringRecordsAmount(string filters)
        {
            string sql = "SELECT CASE WHEN COUNT(*) = 0 THEN 1 ELSE COUNT(*) END as total FROM reservaEventos " +
                            "JOIN eventos ON eventos.id_evento = reservaEventos.id_evento " +
                            filters;

            return conn.returnData(sql);
        }

        public void acceptReservas(string codes)
        {
            string sql = $"UPDATE reservaEventos SET estado = 'aceptado' WHERE codigo IN ({codes})";
            SqlCommand comm = new SqlCommand(sql);
            conn.nonReturnData(comm);
        }

        public void rejectReservas(string codes)
        {
            string sql = $"UPDATE reservaEventos SET estado = 'rechazado' WHERE codigo IN ({codes})";
            SqlCommand comm = new SqlCommand(sql);
            conn.nonReturnData(comm);
        }
    }
}
