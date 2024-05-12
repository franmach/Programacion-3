using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ejADo
{
    public static class Conexion
    {
        public static SqlConnection Open()
        {
            SqlConnection conn = new SqlConnection("Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true");
            conn.Open();
            return conn;
        }

        public static SqlConnection Close()
        {
            SqlConnection conn = new SqlConnection("Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true");
            conn.Close();
            return conn;

        }

    }
}