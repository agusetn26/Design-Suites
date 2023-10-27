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
    class eventosDAL
    {
        private config conn;
        public eventosDAL()
        {
            conn = new config();
        }

        public DataSet listHeaders(int id)
        {
            return conn.returnData($"SELECT id_evento, nombre FROM eventos WHERE id_hotel = {id}");
        }

        public DataSet bringEventData(int id)
        {
            return conn.returnData($"SELECT * FROM eventos WHERE id_evento = {id}");
        }
        
        public void createNew(eventosBLL evento)
        {
            string sql = "INSERT INTO eventos (nombre,descripcion,imagen,precio,fecha_alta,fecha_baja,id_hotel,servicios) " +
                            "VALUES (@nom, @desc, @imgs, @precio, GETDATE(), null, @idh, 'ser vicio');";
            SqlCommand comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@nom", evento.nombre);
            comm.Parameters.AddWithValue("@desc", evento.descripcion);
            comm.Parameters.AddWithValue("@imgs", string.Join(";", evento.imagenes));
            comm.Parameters.AddWithValue("@precio", evento.precio);
            comm.Parameters.AddWithValue("@idh", evento.id);

            conn.nonReturnData(comm);
        }

        public void updateEvent(eventosBLL evento)
        {
            string sql = "UPDATE eventos SET nombre = @nom, descripcion = @desc, imagen = @imgs, precio = @precio, " +
                            "fecha_baja = @baja WHERE id_evento = @idE";
            SqlCommand comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@nom", evento.nombre);
            comm.Parameters.AddWithValue("@desc", evento.descripcion);
            comm.Parameters.AddWithValue("@imgs", string.Join(";", evento.imagenes));
            comm.Parameters.AddWithValue("@precio", evento.precio);
            object fechaBaja = evento.fBaja == "" ? (object) DBNull.Value : DateTime.Now;
            comm.Parameters.AddWithValue("@baja", fechaBaja);
            comm.Parameters.AddWithValue("@idE", evento.id);

            conn.nonReturnData(comm);
        }
    }
}
