using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class habitacionesBLL
    {
        public int id;
        public string nombre;
        public string[] imagenes;
        public string descripcion;
        public int ocupacion;
        public double dimensiones;
        public decimal precio;
        public int habitaciones;

        public DataSet fillList(int idHotel)
        {
            habitacionesDAL modelo = new habitacionesDAL();
            return modelo.bringTypes(idHotel);
        }

        public void setData()
        {
            habitacionesDAL modelo = new habitacionesDAL();
            DataSet data = modelo.bringTypeData(id);
            DataTable tipoInfo = data.Tables[0];

            descripcion = tipoInfo.Rows[0].Field<string>("descripcion");
            ocupacion = tipoInfo.Rows[0].Field<int>("ocupacion");
            dimensiones = tipoInfo.Rows[0].Field<double>("dimensiones");
            precio = tipoInfo.Rows[0].Field<decimal>("costo");
            habitaciones = tipoInfo.Rows[0].Field<int>("habitaciones");
            imagenes = tipoInfo.Rows[0].Field<string>("imagenes").Split(';');
        }
    }
}
