using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class suministroBLL
    {
        public int id;
        public string nombre;
        public int cantidad;

        public DataTable bringProducts(int idHotel)
        {
            suministroDAL modelo = new suministroDAL();
            return modelo.bringHeaders(idHotel).Tables[0];
        }

        public void newQuery()
        {
            suministroDAL modelo = new suministroDAL();
            modelo.setNewQry(this);
        }
    }
}
