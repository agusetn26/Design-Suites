using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using sistemaPrincipal.DAL;

namespace sistemaPrincipal.BLL
{
    internal class hotelBLL
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string ubicacion;
        private string direccion;
        private string telefono;
   

        public int attrId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string attrNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"No se actualizó el hotel con el id {this.id}.\nEl nombre del hotel debe contener al menos un caracter");
                nombre = value;
            }
        }
        public string attrDescripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 50)
                {
                    Console.WriteLine(value.Length);
                    throw new ArgumentException($"No se actualizó el hotel con el id {this.id}.\nLa descripcion debe contener al menos 50 caracteres");
                } descripcion = value;
            }
        }
        public string attrUbicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"No se actualizó el hotel con el id {this.id}.\n" +
                                                "La ubicacion del hotel es invalida\n" +
                                                "Ubicación válida ejemplo: Provincia de Buenos Aires, Mar del Plata");
                ubicacion = value;
            }
        }
        public string attrDireccion
        {
            get
            {
                return direccion;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"No se actualizó el hotel con el id {this.id}.\n"+
                                                "La direccion del hotel ingresada no es válida\n"+
                                                "Direccion válida ejemplo: Av.Cochabamba y Muniz");
                direccion = value;
            }
        }
        public string attrTelefono
        {
            get
            {
                return telefono;
            }
            set
            {
                string regexPattern = @"^\+\d{2}\s\d{2}\s\d{8}$"; // Ejemplo: +54 11 23456789

                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, regexPattern))
                    throw new ArgumentException($"No se actualizó el hotel con el id {this.id}.\n"+
                                                "El formato del número de teléfono ingresado no es válido.\n" +
                                                "Numero válido ejemplo: +54 11 43576890");
                telefono = value;
            }
        }

        public string attrHabitaciones { get; set; }
        public string attrEventos { get; set; }
        public string[] attrImg { get; set; }
        public string attrBaja { get; set; }

        public hotelBLL(string nom, string des, string ub, string di, string tel, string cat, string[] img)
        {
            attrNombre = nom;
            attrDescripcion = des;
            attrUbicacion = ub;
            attrDireccion = di;
            attrTelefono = tel;
            attrHabitaciones = hotelHabitaciones(cat);
            attrEventos = hotelEventos(cat);
            attrImg = img;
        }
       
        public hotelBLL(int id, string nom, string des, string ub, string di, string tel, string img, string fBaja)
        {
            attrId = id;
            attrNombre = nom;
            attrDescripcion = des;
            attrUbicacion = ub;
            attrDireccion = di;
            attrTelefono = tel;
            attrImg = img.Split(';');
            attrBaja = fBaja;
        }

        public string currentProyetLoc = Directory.GetCurrentDirectory();
        private string hotelHabitaciones(string cate)
        {
            string fileLocation = currentProyetLoc + "\\recursos\\habitaciones\\" + cate + ".txt";
            return File.ReadAllText(fileLocation);
        }

      
        private string hotelEventos(string cate)
        {
            string fileLocation = currentProyetLoc + "\\recursos\\eventos\\" + cate + ".txt";
            return File.ReadAllText(fileLocation);
        }

        public void crearHotel()
        {
            hotelDAL hotelModelo = new hotelDAL();
            hotelModelo.insertarHotel(this);
        }
        
        public bool modificarHotel()
        {
            hotelDAL hotelModelo = new hotelDAL();
            return hotelModelo.actualizarListado(this);
        }
    }
    
}
