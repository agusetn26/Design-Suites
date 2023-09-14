using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sistemaPrincipal.DAL
{
    class transaccionesDAL
    {
        baseDeDatos db;
        public transaccionesDAL()
        {
            db = new baseDeDatos();
        }
    
        public DataSet select()
        {
            return db.consultasConR
                (
                    "SELECT id_transaccion, hoteles.nombre as hotel, proveedores.nombre as proveedor," +
                           "productos.nombre as producto, transacciones.cantidad, productos.costeU * suministros.cantidad as coste," +
                           "transacciones.id_suministro, transacciones.fecha_alta, estado " +
                    "FROM transacciones " +
                    " JOIN suministros ON suministros.id_suministro = transacciones.id_suministro" +
                    " JOIN hoteles ON hoteles.id_hotel = suministros.id_hotel" +
                    " JOIN productos ON productos.id_producto = suministros.id_producto" +
                    " JOIN proveedores ON proveedores.id_proveedor = productos.id_proveedor"
                );
        }

        public bool actualizarListado(string idSuministro, string cantidadPedida, string idTrans)
        {
            string consulta1 = $"UPDATE suministros SET cantidad = {cantidadPedida} WHERE id_suministro = {idSuministro};";
            string consulta2 = $"UPDATE transacciones SET estado = 'atendido' WHERE id_transaccion = {idTrans}";
            SqlCommand com = new SqlCommand();
            com.CommandText = consulta1 + consulta2;

            return db.consultasSinR(com);
        }
    }
}
