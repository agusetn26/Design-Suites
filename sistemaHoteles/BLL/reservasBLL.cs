using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class reservasBLL
    {
        public DataTable bringHeaders(string option)
        {
            reservasDAL modelo = new reservasDAL();
            return modelo.bringDataHeaders(option).Tables[0];
        }

        public DataTable bringRows(int idH, int from, string option)
        {
            reservasDAL modelo = new reservasDAL();
            return modelo.bringDataRows(idH, from, option).Tables[0];
        }
    }
}
