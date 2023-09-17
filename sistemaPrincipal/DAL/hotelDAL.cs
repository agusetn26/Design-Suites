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
            return db.consultasConR("SELECT id_hotel, nombre, ubicacion, " +
                                    "descripcion, telefono,  direccion, " +
                                    "imagen, fecha_alta as apertura, " +
                                    "CASE WHEN fecha_baja IS NULL THEN 'Establecer fecha de cierre' ELSE CONVERT(varchar, fecha_baja, 120)" +
                                    "END as cerrar FROM hoteles;");
        }

        public void insertarHotel(hotelBLL hotelData)
        {
            int idHotel = (int)db.consultasConR("SELECT MAX(id_hotel) as last FROM hoteles").Tables[0].Rows[0]["last"];
            idHotel++;
            string src = moveFile(hotelData.attrImg, idHotel);

           if (src != null) {
                string sqlStrHotel = "INSERT INTO hoteles VALUES(@nom, @ubi, @desc, @tel, @dir, @img, GETDATE(), NULL)";
                SqlCommand sqlCom1 = new SqlCommand(sqlStrHotel);
                sqlCom1.Parameters.AddWithValue("@nom", hotelData.attrNombre);
                sqlCom1.Parameters.AddWithValue("@ubi", hotelData.attrUbicacion);
                sqlCom1.Parameters.AddWithValue("@desc", hotelData.attrDescripcion);
                sqlCom1.Parameters.AddWithValue("@tel", hotelData.attrTelefono);
                sqlCom1.Parameters.AddWithValue("@dir", hotelData.attrDireccion);
                sqlCom1.Parameters.AddWithValue("@img", src);

                db.consultasSinR(sqlCom1);

                string sqlStrHabitaciones = hotelData.attrHabitaciones;
                SqlCommand sqlCom2 = new SqlCommand(sqlStrHabitaciones);
                sqlCom2.Parameters.AddWithValue("@idH", idHotel);

                db.consultasSinR(sqlCom2);

                string sqlStrEventos = hotelData.attrEventos;
                SqlCommand sqlCom3 = new SqlCommand(sqlStrEventos);
                sqlCom3.Parameters.AddWithValue("@idH", idHotel);

                if (db.consultasSinR(sqlCom3))
                {
                    MessageBox.Show("Hotel añadido con éxito, vaya al apartado anterior para visualizar", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Hubo un error con la confirmación del formulario, comuniquese con soporte para más información");
                }
            }
        }

        public bool actualizarListado(hotelBLL hotelData)
        {
            string src = moveFile(hotelData.attrImg, hotelData.attrId);
            if (src != null)
            {
                string sqlStrHotel = "UPDATE hoteles SET nombre = @nom, ubicacion = @ubi, descripcion = @desc, telefono = @tel, direccion = @dir, imagen = @img, fecha_baja = @f WHERE id_hotel = @id;";


                SqlCommand sqlCom1 = new SqlCommand(sqlStrHotel);
                sqlCom1.Parameters.AddWithValue("@nom", hotelData.attrNombre);
                sqlCom1.Parameters.AddWithValue("@ubi", hotelData.attrUbicacion);
                sqlCom1.Parameters.AddWithValue("@desc", hotelData.attrDescripcion);
                sqlCom1.Parameters.AddWithValue("@tel", hotelData.attrTelefono);
                sqlCom1.Parameters.AddWithValue("@dir", hotelData.attrDireccion);
                sqlCom1.Parameters.AddWithValue("@img", src);

                if (hotelData.attrBaja != "Establecer fecha de cierre")
                {
                    sqlCom1.Parameters.AddWithValue("@f", DateTime.Now); 
                }
                else
                {
                    sqlCom1.Parameters.AddWithValue("@f", DBNull.Value); 
                }

                sqlCom1.Parameters.AddWithValue("@id", hotelData.attrId);

                if (!db.consultasSinR(sqlCom1))
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private string moveFile(string[] rutas, int id)
        {
            string rutaDestino = "C:\\xampp\\htdocs\\Design-Suites\\img\\hoteles";
            string[] nuevasRutas = new string[rutas.Length];
            int i = 0;

            try
            {
                string carpeta = rutaDestino + $"\\hotelId_{id}";

                if (Directory.Exists(carpeta))
                {
                    string fileString = string.Join(";", Directory.GetFileSystemEntries(carpeta));

                    if (fileString == string.Join(";", rutas))
                    {
                        Console.WriteLine(fileString);
                        return fileString;
                    }
                    Directory.Delete(carpeta, true);
                }
            
                Directory.CreateDirectory(carpeta);

                foreach (string ruta in rutas)
                {
                    string nombreArchivo = Path.GetFileName(ruta);

                    string nuevoNombre = $"{i}";
                    
                    string nuevaRutaDestino = Path.Combine(carpeta, nuevoNombre + Path.GetExtension(nombreArchivo));

                    File.Copy(ruta, nuevaRutaDestino);
                    
                    nuevasRutas[i] = nuevaRutaDestino;
                    i++;
                }
                return string.Join(";", nuevasRutas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
