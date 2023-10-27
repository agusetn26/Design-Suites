using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sistemaHoteles.DAL
{
    class habitacionesDAL
    {
        config conn;
        public habitacionesDAL()
        {
            conn = new config();
        }

        public DataSet bringTypes(int idHotel)
        {
            string sql = "SELECT DISTINCT tipoHabitacion.id_tipoHabitacion, nombre FROM tipoHabitacion " +
                         "INNER JOIN habitaciones as h ON h.id_tipoHabitacion = tipoHabitacion.id_tipoHabitacion " +
                         $"WHERE id_hotel = {idHotel}";

            DataSet rows = conn.returnData(sql);

            if (rows.Tables[0].Rows.Count == 0)
            {
                throw new Exception("Hubo un error de conexión con la base de datos, verifique su conexión. De persistir contactar con soporte");
            }

            return rows;
        }

        public DataSet bringTypeData(int idRoom)
        {
            string sql = "SELECT tipoHabitacion.*, habitaciones.habitaciones FROM tipoHabitacion " +
                            "INNER JOIN(" +
                                "SELECT habitaciones.id_tipoHabitacion as id, COUNT(habitaciones.id_tipoHabitacion) as habitaciones " +
                                "FROM tipoHabitacion INNER JOIN habitaciones ON habitaciones.id_tipoHabitacion = tipoHabitacion.id_tipoHabitacion " +
                                "GROUP BY habitaciones.id_tipoHabitacion" +
                            ") AS habitaciones ON habitaciones.id = tipoHabitacion.id_tipoHabitacion " +
                           $"WHERE tipoHabitacion.id_tipoHabitacion = {idRoom}";

            return conn.returnData(sql);
        }
    }
}
