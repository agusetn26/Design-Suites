using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using sistemaPrincipal.DAL;

namespace sistemaPrincipal.BLL
{
    internal class hotelBLL
    {
        public string attrNombre;
        public string attrDescripcion;
        public string attrUbicacion;
        public string attrDireccion;
        public string attrTelefono;
        public string attrHabitaciones;
        public string attrSuministros;
        public string attrEventos;
        public string[] attrImg;

       public hotelBLL(string nom, string des, string ub, string di, string tel, string cat, string[] img)
       {
            attrNombre = nom;
            attrDescripcion = des;
            attrUbicacion = ub;
            attrDireccion = di;
            attrTelefono = tel;
            attrHabitaciones = hotelHabitaciones(cat);
            attrSuministros = hotelSuministros(cat);
            attrEventos = hotelEventos(cat);
            attrImg = img;
       }

       public string currentProyetLoc = Directory.GetCurrentDirectory();
       private string hotelHabitaciones(string cate)
       {
          
            string fileLocation = currentProyetLoc + "\\recursos\\habitaciones\\" + cate + ".txt";
            return File.ReadAllText(fileLocation);
       }

        private string hotelSuministros(string cate)
        {
            string fileLocation = currentProyetLoc + "\\recursos\\suministros\\" + cate + ".txt";
            return File.ReadAllText(fileLocation);
        }
        private string hotelEventos(string cate)
        {
            string fileLocation = currentProyetLoc + "\\recursos\\eventos\\" + cate + ".txt";
            return File.ReadAllText(fileLocation);
        }

        public void createNewHotel()
        {
            hotelDAL hotelModelo = new hotelDAL();
            hotelModelo.insert(this);
        }
    }
    
}
