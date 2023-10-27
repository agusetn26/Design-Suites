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
        //"Data Source=DESKTOP-QB22C4J\\SQLEXPRESS; Initial Catalog=design_suites; User ID = sa; Password = 123"
        //Data Source=DESKTOP-L8KEE59\\Rodrigo Acosta; Initial Catalog=design_suites; Integrated Security=True;
        private string connStr = "Data Source=DESKTOP-L8KEE59; Initial Catalog=design_suites; Integrated Security=True;";
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
                return data;
            } 
            catch (Exception e) {
                Console.WriteLine(e);
                MessageBox.Show("Hubo un error al tratar de comunicarse con la base de datos, comuniquese con soporte.");
                data.Tables.Add(new DataTable());

                return data;
            }
        }
        
        public bool consultasSinR(SqlCommand sqlCom)
        {
            try
            {
                sqlCom.Connection = conn;
                if (conn.State != ConnectionState.Open) //Parche salvador
                {
                    conn.Open();
                }
                sqlCom.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);

                return false;
            }
        }
    }
}
