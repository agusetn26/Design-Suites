using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using sistemaPrincipal.BLL;
using System.Windows.Forms;

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
            string src = moveFile(hotelData.attrImg, hotelData.attrNombre);
            if (src != null) {
                string sqlStrHotel = "INSERT INTO hoteles VALUES(@nom, @ubi, @desc, @tel, @dir, @img, GETDATE(), NULL)";
                SqlCommand sqlCom1 = new SqlCommand(sqlStrHotel);
                sqlCom1.Parameters.AddWithValue("@nom", hotelData.attrNombre);
                sqlCom1.Parameters.AddWithValue("@ubi", hotelData.attrUbicacion);
                sqlCom1.Parameters.AddWithValue("@desc", hotelData.attrDescripcion);
                sqlCom1.Parameters.AddWithValue("@tel", hotelData.attrTelefono);
                sqlCom1.Parameters.AddWithValue("@dir", hotelData.attrDireccion);
                sqlCom1.Parameters.AddWithValue("@img", src);

                string sqlStrHabitaciones = hotelData.attrHabitaciones;
                SqlCommand sqlCom2 = new SqlCommand(sqlStrHabitaciones);
                int idHotel = (int) db.consultasConR("SELECT MAX(id_hotel) as last FROM habitaciones").Tables[0].Rows[0]["last"];
                sqlCom2.Parameters.AddWithValue("@idH", idHotel);

                db.consultasSinR(sqlCom1);
                db.consultasSinR(sqlCom2);
            }
        }

        private string moveFile(string[] rutas, string nombre)
        {
            string rutaDestino = "C:\\xampp\\htdocs\\Design-Suites\\img\\hoteles";
            string[] nuevasRutas = new string[rutas.Length];
            int i = 0;

            try
            {
                foreach (string ruta in rutas)
                {
                    string nombreArchivo = Path.GetFileName(ruta);

                    string nuevoNombre = $"{nombre} - {i}";

                    string nuevaRutaDestino = Path.Combine(rutaDestino, nuevoNombre + Path.GetExtension(nombreArchivo));

                    File.Copy(ruta, nuevaRutaDestino);
                   
                    nuevasRutas[i] = nuevaRutaDestino;
                    i++;
                }
                return string.Join(";", nuevasRutas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mover o renombrar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
