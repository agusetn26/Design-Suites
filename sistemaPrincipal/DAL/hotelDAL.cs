using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using sistemaPrincipal.BLL;

namespace sistemaPrincipal.DAL
{
    class hotelDAL
    {
        baseDeDatos db;
        public hotelDAL() 
        {
            db = new baseDeDatos();
        }
        
        public DataSet select() {
            return db.consultasConR("SELECT * FROM hoteles;");
        }

        public void insert(hotelBLL hotelData)
        {
            //moveFile();
            string sqlStr = "INSERT INTO hoteles VALUES('', @nom, @ubi, @desc, @tel, @dir, @img, GETDATE(), '');";
            SqlCommand sql = new SqlCommand(sqlStr);
            sql.Parameters.AddWithValue("@nom", hotelData.attrNombre);
            sql.Parameters.AddWithValue("@ubi", hotelData.attrUbicacion);
            sql.Parameters.AddWithValue("@desc", hotelData.attrDescripcion);
            sql.Parameters.AddWithValue("@tel", hotelData.attrTelefono);
            sql.Parameters.AddWithValue("@dir", hotelData.attrDireccion);
            sql.Parameters.AddWithValue("@img", hotelData.attrImg);
            //db.consultasSinR();
        }

    }
}
