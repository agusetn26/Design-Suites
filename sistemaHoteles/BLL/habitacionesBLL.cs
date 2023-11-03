using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class habitacionesBLL
    {
        public int id;
        public string nombre;
        public string[] imagenes;
        public string descripcion;
        public int ocupacion;
        public decimal dimensiones;
        public decimal precio;
        public string fAlta;
        public int habitaciones;

        public DataTable bringHeaders(int id)
        {
            habitacionesDAL modelo = new habitacionesDAL();
            DataSet data = modelo.listHeaders(id);
            DataTable cabezeras = data.Tables[0];

            return cabezeras;
        }

        public void fillData()
        {
            habitacionesDAL modelo = new habitacionesDAL();
            DataSet data = modelo.bringRoomData(id);
            DataTable roomData = data.Tables[0];

            if (roomData.Rows.Count == 0)
            {
                throw new Exception("Hubo un error de conexión con la base de datos, verifique su conexión. De persistir contactar con soporte");
            }

            DataRow room = roomData.Rows[0];
            this.nombre = room.Field<string>("nombre");
            this.descripcion = room.Field<string>("descripcion");
            this.imagenes = room.Field<string>("imagenes").Split(';');
            this.precio = room.Field<decimal>("costo");
            this.dimensiones = room.Field<decimal>("dimensiones");
            this.ocupacion = room.Field<int>("ocupacion");
            this.fAlta = room.Field<DateTime>("fecha_alta").ToString();
        }

        public DataTableCollection roomsData(int idHotel, int idRoom)
        {
            habitacionesDAL modelo = new habitacionesDAL();
            DataSet data = modelo.bringRoomsData(idHotel, idRoom);
            return data.Tables;
        }

        public void updateRooms(List<object> arrIds)
        {
            if (!arrIds.Any())
                return;
            habitacionesDAL modelo = new habitacionesDAL();
            modelo.updateRoomsData(string.Join(",", arrIds));
        }

        public void insertRooms(int rowsAmount, int idHotel, int idRoom)
        {
            if (rowsAmount == 0)
                return;

            string[] rowBuilder = new string[rowsAmount];
            for (int i=0; i<rowsAmount; i++)
            {
                rowBuilder[i] = $"({idRoom}, {idHotel}, GETDATE(), NULL)";
            }

            habitacionesDAL modelo = new habitacionesDAL();
            modelo.insertRoomsData(string.Join(",", rowBuilder));
            Console.WriteLine(string.Join(",", rowBuilder));
        }

        public void newRoom(int idH)
        {
            this.moveFiles();
            habitacionesDAL modelo = new habitacionesDAL();
            this.id = idH;
            modelo.createNewRoom(this);
        }

        public void modifyRoom()
        {
            this.moveFiles();
            habitacionesDAL modelo = new habitacionesDAL();
            modelo.updateRoom(this);
        }

        private string mainFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private string tmpF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmp");

        private void moveFiles()
        {
            try
            {
                if (Directory.GetFiles(tmpF).Length == 0)
                    return;

                string roomsFolder = Path.Combine(mainFolder, @"img\habitaciones");
                string roomFolder = Path.Combine(roomsFolder, this.fAlta.Replace('/', '-').Replace(':', '-'));
                Console.WriteLine(roomFolder);

                if (Directory.Exists(roomFolder))
                    Directory.Delete(roomFolder, true);

                Directory.Move(tmpF, roomFolder);
                this.imagenes = Directory.GetFiles(roomFolder);
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
