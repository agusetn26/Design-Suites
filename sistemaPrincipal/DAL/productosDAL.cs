using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

using sistemaPrincipal.BLL;

namespace sistemaPrincipal.DAL
{
    class productosDAL
    {
        baseDeDatos db;
        public productosDAL()
        {
            db = new baseDeDatos();
        }

        public DataSet select()
        {
            return db.consultasConR( 
                "SELECT id_producto, productos.nombre, categoria, " +
                "costeU, imagen, id_proveedor, productos.fecha_alta, " +
                "CASE WHEN productos.fecha_baja IS NULL THEN 'Dar de baja' " +
                "ELSE CONVERT(varchar, productos.fecha_baja, 120) END as eliminar " +
                "FROM productos"
            );
        }

        public DataSet selectProveedores()
        {
            return db.consultasConR("SELECT * FROM proveedores");
        }

        public bool nuevoProducto(productoBLL producto)
        {
            int idProducto = (int)db.consultasConR("SELECT MAX(id_producto) as last FROM productos").Tables[0].Rows[0]["last"];
            idProducto++;
            string src = moveFile(producto.attrImg, idProducto);
            
            if (src != null)
            {
                string sql = "INSERT INTO productos VALUES(@nom, @cate, @cos, @src, @pr, GETDATE(), NULL)";
                SqlCommand sqlCom1 = new SqlCommand(sql);
                sqlCom1.Parameters.AddWithValue("@nom", producto.attrNombre);
                sqlCom1.Parameters.AddWithValue("@cate", producto.attrCategoria);
                sqlCom1.Parameters.AddWithValue("@cos", producto.attrCoste);
                sqlCom1.Parameters.AddWithValue("@src", src);
                sqlCom1.Parameters.AddWithValue("@pr", producto.idProveedor);

                if (db.consultasSinR(sqlCom1))
                {
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        public bool actualizarProducto(productoBLL producto)
        {

            string src = moveFile(producto.attrImg, producto.attrId);
            if(src != null)
            {
                string sql = $"UPDATE productos SET nombre = @nom, categoria = @cate, costeU = @cos, imagen = @src, id_proveedor = @pr, fecha_alta = @fa, fecha_baja = @fb WHERE id_producto = @idP";

                SqlCommand sqlCom = new SqlCommand(sql);
                sqlCom.Parameters.AddWithValue("@nom", producto.attrNombre);
                sqlCom.Parameters.AddWithValue("@cate",producto.attrCategoria);
                sqlCom.Parameters.AddWithValue("@cos", producto.attrCoste);
                sqlCom.Parameters.AddWithValue("@src", src);
                sqlCom.Parameters.AddWithValue("@pr", producto.idProveedor);
                sqlCom.Parameters.AddWithValue("@fa", DateTime.Parse(producto.attrAlta));

                if (producto.attrBaja != "Dar de baja")
                {
                    sqlCom.Parameters.AddWithValue("@fb", DateTime.Now);
                }
                else
                {
                    sqlCom.Parameters.AddWithValue("@fb", DBNull.Value);
                }
                
                sqlCom.Parameters.AddWithValue("@idP", producto.attrId);

                if (db.consultasSinR(sqlCom))
                {
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }
        
        private string moveFile(string ruta, int id)
        {
            string destinoFinal = "C:\\xampp\\htdocs\\Design-Suites\\img\\productos";
            string nombreArchivo = $"{id}";

            string nuevoDestino = Path.Combine(destinoFinal, nombreArchivo);

            try
            {
                if (File.Exists(nuevoDestino + ".jpg"))
                    File.Delete(nuevoDestino + ".jpg");

                if (File.Exists(nuevoDestino + ".png"))
                    File.Delete(nuevoDestino + ".png");

                File.Copy(ruta, nuevoDestino + Path.GetExtension(ruta), true);
                return nuevoDestino + Path.GetExtension(ruta);

            } catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
           
        }
    }
}
