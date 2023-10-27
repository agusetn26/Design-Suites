using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class eventosBLL
    {
        public int id;
        public string nombre;
        public string descripcion;
        public string[] imagenes;
        public decimal precio;
        public string fAlta;
        public string fBaja;

        public DataTable bringHeaders(int id)
        {
            eventosDAL modelo = new eventosDAL();
            DataSet data = modelo.listHeaders(id);
            DataTable cabezeras = data.Tables[0];

            return cabezeras;
        }

        public void fillData()
        {
            eventosDAL modelo = new eventosDAL();
            DataSet data = modelo.bringEventData(id);
            DataTable eventData = data.Tables[0];

            if (eventData.Rows.Count == 0)
            {
                throw new Exception("Hubo un error de conexión con la base de datos, verifique su conexión. De persistir contactar con soporte");
            }

            DataRow evento = eventData.Rows[0];
            this.nombre = evento.Field<string>("nombre");
            this.descripcion = evento.Field<string>("descripcion");
            this.imagenes = evento.Field<string>("imagen").Split(';');
            this.precio = evento.Field<decimal>("precio");
            this.fAlta = evento.Field<DateTime>("fecha_alta").ToString();
            if (evento["fecha_baja"] == DBNull.Value)
            {
                fBaja = "";
                return;
            }
            this.fBaja = evento.Field<DateTime>("fecha_baja").ToString();
        }

        public void newEvent(int idH)
        {
          
            this.moveFiles();
            eventosDAL modelo = new eventosDAL();
            this.id = idH;
            modelo.createNew(this);
            
        }

        public void modifyEvent()
        {
            this.moveFiles();
            eventosDAL modelo = new eventosDAL();
            modelo.updateEvent(this);
        }

        private string mainFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private string tmpF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmp");

        private void moveFiles()
        {
            try
            {
                if (Directory.GetFiles(tmpF).Length == 0)
                    return;

                string eventsFolder = Path.Combine(mainFolder, @"img\eventos");
                string eventFolder = Path.Combine(eventsFolder, this.fAlta.Replace('/', '-').Replace(':', '-'));
                Console.WriteLine(eventFolder);

                if (Directory.Exists(eventFolder))
                    Directory.Delete(eventFolder, true);

                Directory.Move(tmpF, eventFolder);
                this.imagenes = Directory.GetFiles(eventFolder);
                Directory.CreateDirectory(tmpF);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Directory.Delete(tmpF, true);
                Directory.CreateDirectory(tmpF);
                throw new Exception("Hubo un error en la subida de los archivos de imagen, de persistir el error contactar con soporte");
            }
        }
    }
}
