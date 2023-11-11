using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    public abstract class Reservas
    {
        //  PAGINACION  //

        public int idH; //Contiene el id del hotel actual
        public int from;  //Contiene el registro de inicio
        public int amount; //Contiene la cantidad de registros por página
        public int page; //Contiene página actual
        public int totalPages;  //Contiene el total de páginas
        public string filterStr;  //Contiene el filtro actual

        public DataTable bringHeaders() //Trae filas y cabezeras de la página
        {
            this.defineFilterStr();

            DataTable result = this.dataHeaders();

            this.defaultFilterStr("");

            return result;
        }
        public void pagesAmount()  //Trae cantidad de páginas
        {
            DataTable results = this.recordsAmount();
            int totalRecords = (int)results.Rows[0]["total"];
            totalPages = (int)Math.Ceiling(((decimal)totalRecords / (decimal)this.amount));
        }

        public DataTable jumpTo(int to)  //Trae la página seleccionada
        {
            this.page = to;
            this.from = (to - 1) * this.amount;
            return this.bringHeaders();
        }
        public DataTable lookFor(string code)  //Trae la fila con el valor dado
        {
            string others = $"AND codigo = '{code}' ";
            this.page = 1;
            this.from = 0;
            this.defaultFilterStr(others);
            this.pagesAmount();
            return this.bringHeaders();
        }

            //  Funciones de conexion a datos   //  
        public abstract DataTable dataHeaders();
        public abstract DataTable recordsAmount();
        public abstract void acceptState(string codes);
        public abstract void rejectState(string codes);

            //  Funciones de filtros    //
        public abstract void defaultFilterStr(string conditions);
        public abstract void defineFilterStr();
    }
}
