using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using sistemaHoteles.BLL;
using System.Data.SqlClient;

namespace sistemaHoteles.DAL
{
    class hotelDAL
    {
        private config configIns;

        public hotelDAL()
        {
            configIns = new config();
        }

        public DataSet returnHotelData(string id)
        {
            DataSet rows = configIns.returnData($"SELECT * FROM hoteles WHERE id_hotel = {id}");

            if (rows.Tables[0].Rows.Count == 0)
            {
                throw new Exception("Hubo un error de conexión con la base de datos, verifique su conexión. De persistir contactar con soporte");
            }

            return rows;
        }

        public void modifyHotel(hotelBLL hotel)
        {
            string sql = "UPDATE hoteles SET nombre = @nom, ubicacion = @ubi, descripcion = @desc, telefono = @tel, direccion = @dir, imagen = @img WHERE id_hotel = @idH";
            SqlCommand sqlCom = new SqlCommand(sql);
            sqlCom.Parameters.AddWithValue("@nom", hotel.nombre);
            sqlCom.Parameters.AddWithValue("@ubi", hotel.ubicacion);
            sqlCom.Parameters.AddWithValue("@desc", hotel.descripcion);
            sqlCom.Parameters.AddWithValue("@tel", hotel.telefono);
            sqlCom.Parameters.AddWithValue("@dir", hotel.direccion);
            sqlCom.Parameters.AddWithValue("@img", string.Join(";", hotel.imagenes));
            sqlCom.Parameters.AddWithValue("@idH", hotel.id);

            configIns.nonReturnData(sqlCom);
        }
    }
}
