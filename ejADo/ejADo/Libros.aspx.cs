using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejADo
{
    public partial class Libros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarDdl();
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true";
            string queryTabla;

            switch (slcOpciones.Value)
            {
                case "autor":
                    queryTabla = "Select * from Libro join Autor on Libro.idAutor = Autor.ID where Autor.nombre like " + "'" + txtOpcion.Text + "%'";
                    break;
                case "anio":
                    queryTabla = "Select * from Libro where Libro." + slcOpciones.Value + "=" + txtOpcion.Text;
                    break;
                case "titulo":
                    queryTabla = "Select * from Libro where Libro." + slcOpciones.Value + " like '" + txtOpcion.Text + "%'";
                    break;
                default:
                    queryTabla = "";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryTabla, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();


                    gvLibros.DataSource = reader;
                    gvLibros.DataBind();
                    conn.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true";
            // hacer una query q me traiga el id del autor a partir del q selecciona en la ddl
            string query = "INSERT INTO Libro (titulo, descripcion, anio ) VALUES ('" + txtTitulo.Text + "','" + txtDescripcion.Text + "','" + opcAnio.Text + "')";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("Libro agregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Response.Write("Error al agregar el libro: " + ex.Message);
                }
            }
            //insert into la tabla () y en los values de la consulta, le paso el txtTitulo txtAnio etc
        }

        protected void llenarDdl()
        {
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(nombre, ' ', apellido) AS nombreCompleto, nombre, apellido FROM Autor", Conexion.Open());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            ddlAutores.DataSource = dataSet.Tables[0]; // selecciona la primera tabla del DataSet
            ddlAutores.DataTextField = "nombreCompleto"; // establece la columna concatenada como el texto a mostrar
            ddlAutores.DataValueField = "nombre"; // establece la columna nombre como el valor del DropDownList
            ddlAutores.DataBind();


        }

    }
}