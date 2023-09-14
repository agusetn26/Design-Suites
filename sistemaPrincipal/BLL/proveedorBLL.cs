using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using sistemaPrincipal.DAL;

namespace sistemaPrincipal.BLL
{
    class proveedorBLL
    {
        public string attrId,
                      attrNombre,
                      attrDir,
                      attrContacto,
                      attrProductos,
                      attrEnvio,
                      attrBaja;

        
        public proveedorBLL(string id, string nom, string dir, string cont, string pro, string env, string baja)
        {
            attrId = id;
            attrNombre = nom;
            attrDir = dir;
            attrContacto = cont;
            attrProductos = pro;
            attrEnvio = env;
            attrBaja = baja;
        }

        public proveedorBLL(string nom, string dir, string cont, string pro, string env)
        {
            attrNombre = nom;
            attrDir = dir;
            attrContacto = cont;
            attrProductos = pro;
            attrEnvio = env;
        }

        public bool crearProveedor()
        {
            proveedoresDAL modelo = new proveedoresDAL();
            return modelo.crearProveedor(this);
        }

        public bool modificarProveedor()
        {
            proveedoresDAL modelo = new proveedoresDAL();
            return modelo.actualizarListado(this);
        }
    }
}
