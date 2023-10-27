using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class hotelBLL
    {
        public int id;
        public string nombre;
        public string descripcion;
        public string ubicacion;
        public string direccion;
        public string telefono;
        public string[] imagenes;

        public void getFields(int hotelId)
        {
            hotelDAL hotelModelo = new hotelDAL();
            DataTable hotelData = hotelModelo.returnHotelData(hotelId.ToString()).Tables[0];
            this.nombre = hotelData.Rows[0].Field<string>("nombre");
            this.descripcion = hotelData.Rows[0].Field<string>("descripcion");
            this.ubicacion = hotelData.Rows[0].Field<string>("ubicacion");
            this.direccion = hotelData.Rows[0].Field<string>("direccion");
            this.telefono = hotelData.Rows[0].Field<string>("telefono");
            this.imagenes = hotelData.Rows[0].Field<string>("imagen").Split(';');
        }

        public void modifyFields()
        {
            changeImgPath();
            hotelDAL hotelModelo = new hotelDAL();
            hotelModelo.modifyHotel(this);
        }

        private void changeImgPath()
        {
            if(this.imagenes.Length > 5)
            {
                throw new Exception("Deben ser no más de 5 imágenes");
            }

            string tmpFile = AppDomain.CurrentDomain.BaseDirectory + "\\tmp";

            try
            {
                List<string> rutasTemporales = new List<string>();

                foreach (string img in this.imagenes)
                {
                    string imgName = Path.GetFileName(img);
                    string fullPath = Path.Combine(tmpFile, imgName);
                    rutasTemporales.Add(fullPath);
                    File.Copy(img, fullPath);
                }

                string carpetaHoteles = "C:\\xampp\\htdocs\\Design-Suites\\img\\hoteles";   //Almacena imagenes del hotel
                string archivoHotel = $"\\hotelId_{this.id}";   //Carpeta en la cual se almacenan las imagenes de un hotel en especifico
                string rutaHotel = carpetaHoteles + archivoHotel;

                Directory.Delete(rutaHotel, true);
                Directory.CreateDirectory(rutaHotel);

                for (int i = 0; i < rutasTemporales.Count; i++)
                {
                    string ruta = rutasTemporales[i];
                    string ext = Path.GetExtension(ruta);     //Extension de la imagen seleccionada
                    string nombreImg = $"{i}";      //Nuevo nombre de imagen
                    string nuevoNombre = nombreImg + ext;
                    string rutaFinal = Path.Combine(rutaHotel, nuevoNombre);
                    this.imagenes[i] = rutaFinal;
                    File.Copy(ruta, rutaFinal);
                }

                Directory.Delete(tmpFile, true);
                Directory.CreateDirectory(tmpFile);
            }
            catch (Exception e)
            {
                Directory.Delete(tmpFile, true);
                Directory.CreateDirectory(tmpFile);

                Console.WriteLine(e.Message);
                throw new Exception("Hubo un error en la subida de imagenes, cambie las imágenes seleccionadas. De persistir el error contactar con soporte");
            }
            
        }
    }
}
