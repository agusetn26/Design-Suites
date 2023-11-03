using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using sistemaHoteles.BLL;

namespace sistemaHoteles.DAL
{
    class habitacionesDAL
    {
        config conn;
        public habitacionesDAL()
        {
            conn = new config();
        }

        public DataSet listHeaders(int id)
        {
            return conn.returnData($"SELECT DISTINCT tipoHabitacion.id_tipoHabitacion, tipoHabitacion.nombre FROM tipoHabitacion JOIN habitaciones ON habitaciones.id_tipoHabitacion = tipoHabitacion.id_tipoHabitacion WHERE id_hotel = {id}");
        }

        public DataSet bringRoomData(int id)
        {
            return conn.returnData($"SELECT * FROM tipoHabitacion WHERE id_tipoHabitacion = {id}");
        }

        public void createNewRoom(habitacionesBLL room)
        {
            string sql =
                "INSERT INTO tipoHabitacion(nombre, descripcion, ocupacion, dimensiones, imagenes, costo) " +
                "VALUES(@nom, @desc, @ocu, @dim, @imgs, @costo); " +
                "INSERT INTO habitaciones(id_tipoHabitacion, id_hotel) " +
                "SELECT SCOPE_IDENTITY(), @idH";
            SqlCommand comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@nom", room.nombre);
            comm.Parameters.AddWithValue("@desc", room.descripcion);
            comm.Parameters.AddWithValue("@imgs", string.Join(";", room.imagenes));
            comm.Parameters.AddWithValue("@costo", room.precio);
            comm.Parameters.AddWithValue("@ocu", room.ocupacion);
            comm.Parameters.AddWithValue("@dim", room.dimensiones);
            comm.Parameters.AddWithValue("@idH", room.id);

            conn.nonReturnData(comm);
        }

        public void updateRoom(habitacionesBLL room)
        {
            string sql = "UPDATE tipoHabitacion SET nombre = @nom, descripcion = @desc, imagenes = @imgs, costo = @costo, " +
                            " dimensiones = @dim, ocupacion = @ocu WHERE id_tipoHabitacion = @idT";
            SqlCommand comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@nom", room.nombre);
            comm.Parameters.AddWithValue("@desc", room.descripcion);
            comm.Parameters.AddWithValue("@imgs", string.Join(";", room.imagenes));
            comm.Parameters.AddWithValue("@costo", room.precio);
            comm.Parameters.AddWithValue("@dim", room.dimensiones);
            comm.Parameters.AddWithValue("@ocu", room.ocupacion);
            //object fechaBaja = room.fBaja == "" ? (object)DBNull.Value : DateTime.Now;
            //comm.Parameters.AddWithValue("@baja", fechaBaja);
            comm.Parameters.AddWithValue("@idT", room.id);

            conn.nonReturnData(comm);
        }

        public DataSet bringRoomsData(int idH, int idR)
        {
            return conn.returnData($"SELECT id_habitacion, fecha_alta, fecha_baja FROM habitaciones WHERE id_hotel = {idH} AND id_tipoHabitacion = {idR};" +
                                    $"SELECT COUNT(*) as cant, COUNT(fecha_baja) as baja from habitaciones WHERE id_hotel = {idH} AND id_tipoHabitacion = {idR};");
        }

        public void updateRoomsData(string roomIds)
        {
            string sql = $"UPDATE habitaciones SET fecha_baja = CASE WHEN fecha_baja IS NULL THEN GETDATE() ELSE NULL END " +
                         $"WHERE id_habitacion IN (" + roomIds + ")";
            SqlCommand comm = new SqlCommand(sql);
            conn.nonReturnData(comm);
        }

        public void insertRoomsData(string rooms)
        {
            string sql = "INSERT INTO habitaciones VALUES " + rooms;
            Console.WriteLine(sql);
            SqlCommand comm = new SqlCommand(sql);
            conn.nonReturnData(comm);
        }
    }
}
