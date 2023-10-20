using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
            hotelDAL hotelModelo = new hotelDAL();
            hotelModelo.modifyHotel(this);
        }
    }
}
