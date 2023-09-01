using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistemaPrincipal.DAL
{
    class baseDeDatos 
    {
        private string connStr = "Data Source=DESKTOP-L8KEE59; Initial Catalog=design_suites; Integrated Security=True";
        SqlConnection conn;

        public baseDeDatos()
        {
            conn = new SqlConnection(connStr);

        }
        public DataSet consultasConR(string sqlStr)
        {
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try {

                SqlCommand sqlCom = new SqlCommand(sqlStr, conn);
                adapter.SelectCommand = sqlCom;
                conn.Open();
                adapter.Fill(data);
                conn.Close();
                Console.WriteLine("success");

                return data;
            } 
            catch {

                MessageBox.Show("Hubo un error al tratar de comunicarse con la base de datos, comuniquese con soporte.");
                data.Tables.Add(new DataTable());

                return data;
            }
        }

        public void consultasSinR(SqlCommand sqlCom)
        {
            try
            {
                sqlCom.Connection = conn;
                conn.Open();
                sqlCom.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("success");

            }
            catch
            {
                MessageBox.Show("Hubo un error con la confirmación del formulario, comuniquese con soporte para más i");
            }
        }
    }
}
