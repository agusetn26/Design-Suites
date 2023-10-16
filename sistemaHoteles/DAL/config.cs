using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace sistemaHoteles.DAL
{
    class config
    {
        //"Data Source=DESKTOP-QB22C4J\\SQLEXPRESS; Initial Catalog=design_suites; User ID = sa; Password = 123"
        //Data Source=DESKTOP-L8KEE59\\Rodrigo Acosta; Initial Catalog=design_suites; Integrated Security=True;
        private string connStr;
        SqlConnection conn;

        public config()
        {
            connStr = "Data Source=DESKTOP-L8KEE59; Initial Catalog=design_suites; Integrated Security=True;";
            conn = new SqlConnection(connStr);
        }

        private void closeConn()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataSet returnData(string sqlStr)
        {
            DataSet data = new DataSet();
            SqlCommand sqlCom = new SqlCommand(sqlStr, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCom);

            try
            {

                conn.Open();
                adapter.Fill(data);
                this.closeConn();

                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public ConnectionState GetState()
        {
            return conn.State;
        }
    }
}
