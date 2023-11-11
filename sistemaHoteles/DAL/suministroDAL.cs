using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using sistemaHoteles.BLL;

namespace sistemaHoteles.DAL
{
    class suministroDAL
    {
        config conn;
        public suministroDAL()
        {
            conn = new config();
        }
        public DataSet bringHeaders(int idH)
        {
            string sql = "SELECT suministros.id_suministro, productos.nombre, productos.imagen,'x'+CAST(suministros.cantidad AS varchar) AS stock FROM productos " +
                            "LEFT JOIN suministros ON suministros.id_producto = productos.id_producto " +
                            $"WHERE id_hotel = {idH} AND productos.fecha_baja IS NULL";

            return conn.returnData(sql);
        }

        public void setNewQry(suministroBLL suministro)
        {
            string sql = "INSERT INTO transacciones (id_suministro, cantidad, fecha_alta, estado) " +
                            "VALUES (@idS, @amount, GETDATE(), 'pendiente')";

            SqlCommand comm = new SqlCommand(sql);
            comm.Parameters.AddWithValue("@idS", suministro.id);
            comm.Parameters.AddWithValue("@amount", suministro.cantidad);

            conn.nonReturnData(comm);
        }
    }
}
