using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionMatos
{
    class SqlConn
    {
        public SqlConnection Conn=new SqlConnection("Data Source=DESKTOP-2GU1170;Initial Catalog=GestionMatosDB;Integrated Security=True");
        public void Connect()
        {
            if (Conn.State!=ConnectionState.Open)
            {
                Conn.Open();
            }
        }
        public void disconnect()
        {
            if (Conn.State!=ConnectionState.Closed)
            {
                Conn.Close();
            }
        }
    }
}
