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
        public int attrId { get; set; }

        private string nombre;
        public string attrNombre { 
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new FormatException("Nombre de producto invalido");
                nombre = value;
            }
        }

        private string categoria;
        public string attrCategoria
        {
            get
            {
                return categoria;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new FormatException("Categoria de producto invalido");
                categoria = value;
            }
        }
        public float attrCoste { get; set; }
        public string attrImg { get; set; }
        public int idProveedor { get; set; }
        public string attrAlta { get; set; }
        public string attrBaja { get; set; }


        public productoBLL(int id, string nom, string cate, string cos, string img, int prov, string fAlta, string fBaja)
        {
            attrId = id;
            attrNombre = nom;
            attrCategoria = cate;
            SetAttrCoste(cos);
            attrImg = img;
            idProveedor = prov;
            attrAlta = fAlta;
            attrBaja = fBaja;
        }

        public productoBLL(string nom, string cate, int prov, string cos, string img)
        {
            attrNombre = nom;
            attrCategoria = cate;Console.WriteLine(prov);
            idProveedor = prov;
            SetAttrCoste(cos);
            attrImg = img;
        }

        private void SetAttrCoste(string cos)
        {
            if (float.TryParse(cos, out float costo))
            {
                attrCoste = costo;
            }
            else
            {
                throw new Exception($"El valor \"{cos}\" no es válido para el coste unitario");
            }
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
