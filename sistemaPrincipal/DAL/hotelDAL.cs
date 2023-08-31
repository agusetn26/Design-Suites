using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sistemaPrincipal.DAL
{
    class hotelDAL
    {
        baseDeDatos db;
        public hotelDAL() 
        {
            db = new baseDeDatos();
        }
        
        public DataSet select(string sql) {
            return db.consultasConR(sql);
        }
    }
}
