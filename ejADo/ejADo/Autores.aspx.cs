using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejADo
{
    public partial class Autores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true";
            string queryTabla = "Select * from Autor where nombre like '" + txtNyA.Text + "%' or apellido like '" + txtNyA.Text + "%'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryTabla, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    gvAutores.DataSource = reader;
                    gvAutores.DataBind();
                    conn.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}