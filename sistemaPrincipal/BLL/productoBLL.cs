using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using sistemaPrincipal.DAL;

namespace sistemaPrincipal.BLL
{
    class productoBLL
    {
        public int attrId;
        public string attrNombre;
        public string attrCategoria;
        public float attrCoste;
        public string attrImg;
        public string idProveedor;
        public string attrAlta;
        public string attrBaja;

        public productoBLL(int id, string nom, string cate, string cos, string img, string prov, string fAlta, string fBaja)
        {
            attrId = id;
            attrNombre = nom;
            attrCategoria = cate;
            float.TryParse(cos, NumberStyles.Float, new CultureInfo("es-ES"), out attrCoste);
            attrImg = img;
            idProveedor = prov;
            attrAlta = fAlta;
            attrBaja = fBaja;
        }

        public productoBLL(string nom, string cate, string prov, string cos, string img)
        {
            attrNombre = nom;
            attrCategoria = cate;
            idProveedor = prov;
            float.TryParse(cos, NumberStyles.Float, new CultureInfo("es-ES"), out attrCoste);
            attrImg = img;
        }

        public bool crearProducto()
        {
            productosDAL modelo = new productosDAL();
            return modelo.nuevoProducto(this);
        }

        public bool modificarProducto()
        {
            productosDAL modelo = new productosDAL();
            return modelo.actualizarProducto(this);
        }
    }
}
