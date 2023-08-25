using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sistemaPrincipal.DAL
{
    class baseDeDatos 
    {
        private string connStr = "Data Source=DESKTOP-L8KEE59; Initial Catalog=design_suites; Integrated Security=True";
        SqlConnection conn;
        public SqlConnection conexion()
        {
            conn = new SqlConnection(connStr);
            return conn;
        }

        public DataSet consultas()
        {
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();


            try { 
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM hoteles");
                sqlCom.Connection = conexion();
                adapter.SelectCommand = sqlCom;
                conn.Open();
                adapter.Fill(data);
                conn.Close();
                Console.WriteLine("success");

                return data;
            } 
            catch (Exception ex) {
                Console.WriteLine(ex);
                return data;
            }
        }
    }
}
