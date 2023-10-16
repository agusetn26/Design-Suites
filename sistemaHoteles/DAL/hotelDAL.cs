using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sistemaHoteles.DAL
{
    class hotelDAL
    {
        private config configIns;

        public hotelDAL()
        {
            configIns = new config();
        }

        public DataSet returnHotelData(string id)
        {
            return configIns.returnData($"SELECT * FROM hoteles WHERE id_hotel = {id}");
        }
    }
}
