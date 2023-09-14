using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using sistemaPrincipal.BLL;

namespace sistemaPrincipal.DAL
{
    class proveedoresDAL
    {
        baseDeDatos db;
        public proveedoresDAL()
        {
            db = new baseDeDatos();
        }

        public DataSet select()
        {
            return db.consultasConR(
                                    "SELECT id_proveedor, nombre, direccion, " +
                                    "contacto, productos, formaEnvio as envio, fecha_alta, " +
                                    "CASE WHEN fecha_baja IS NULL THEN 'Rescindir contrato' " +
                                    "ELSE CONVERT(varchar, fecha_baja, 120) END as rescindir " +
                                    "FROM proveedores"
                                   );
        }

        public bool crearProveedor(proveedorBLL proveedor)
        {
            int id = (int)db.consultasConR("SELECT MAX(id_proveedor) as last FROM proveedores").Tables[0].Rows[0]["last"];
            id++;

                string sql = "INSERT INTO proveedores VALUES(@nom, @dir, @cont, @pro, @env, GETDATE(), NULL)";
                SqlCommand sqlCom1 = new SqlCommand(sql);
                sqlCom1.Parameters.AddWithValue("@nom", proveedor.attrNombre);
                sqlCom1.Parameters.AddWithValue("@dir", proveedor.attrDir);
                sqlCom1.Parameters.AddWithValue("@cont", proveedor.attrContacto);
                sqlCom1.Parameters.AddWithValue("@pro", proveedor.attrProductos);
                sqlCom1.Parameters.AddWithValue("@env", proveedor.attrEnvio);

                if (db.consultasSinR(sqlCom1))
                {
                    return true;
                }

                return false;
            
        }
        public bool actualizarListado(proveedorBLL proveedor)
        {
            string sqlStr = "UPDATE proveedores SET nombre = @nom, direccion = @dir, contacto = @cont, productos = @pro, formaEnvio = @env, fecha_baja = @f WHERE id_proveedor = @id";


            SqlCommand sqlCom1 = new SqlCommand(sqlStr);
            sqlCom1.Parameters.AddWithValue("@nom", proveedor.attrNombre);
            sqlCom1.Parameters.AddWithValue("@dir", proveedor.attrDir);
            sqlCom1.Parameters.AddWithValue("@cont", proveedor.attrContacto);
            sqlCom1.Parameters.AddWithValue("@pro", proveedor.attrProductos);
            sqlCom1.Parameters.AddWithValue("@env", proveedor.attrEnvio);


            if (proveedor.attrBaja != "Rescindir contrato")
            {
                sqlCom1.Parameters.AddWithValue("@f", DateTime.Now);
            }
            else
            {
                sqlCom1.Parameters.AddWithValue("@f", DBNull.Value);
            }

            sqlCom1.Parameters.AddWithValue("@id", proveedor.attrId);

            if (!db.consultasSinR(sqlCom1))
            {
                return false;
            }

            return true;
        }
    }
}

